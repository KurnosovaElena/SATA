import React, { useState, useEffect } from 'react';
import schedulesData from '../../data/schedules.json';
import professorsData from '../../data/professors.json';
import "./professorschedulePage.css";
import Menu from '../components/menu/Menu';
import TimeBlock from '../components/timeBlock/timeBlock';
import MoveLessonPopup from './MoveLessonPopup';
import { isBefore, isSameDay } from 'date-fns';

const timeBlocks = [
    { timeUp: '08:30', timeDown: '10:05' },
    { timeUp: '10:25', timeDown: '12:00' },
    { timeUp: '12:30', timeDown: '14:05' },
    { timeUp: '14:20', timeDown: '15:55' },
    { timeUp: '16:05', timeDown: '17:40' },
    { timeUp: '17:50', timeDown: '19:25' }
];
const dayNames = ['Понедельник', 'Вторник', 'Среда', 'Четверг', 'Пятница', 'Суббота'];
const allProfessors = professorsData.map(p => p.name);

// --- week helpers (как на странице студента) ---
const formatDate = (date) => {
    const options = { day: '2-digit', month: '2-digit', year: 'numeric' };
    return date.toLocaleDateString('ru-RU', options);
};
const getWeekRange = (date) => {
    const firstDay = date.getDate() - date.getDay() + 1;
    const startDate = new Date(date.setDate(firstDay));
    const endDate = new Date(date.setDate(firstDay + 5));
    const start = formatDate(startDate);
    const end = formatDate(endDate);
    return `${start} / ${end}`;
};
const getInitialWeekType = (date) => {
    const startOfYear = new Date(date.getFullYear(), 8, 1); // 1 сентября
    const weekNumber = Math.floor((date - startOfYear) / (7 * 24 * 60 * 60 * 1000));
    return weekNumber % 2 === 0 ? 'upper' : 'lower';
};

function ProfessorSchedulePage() {
    const currentDay = new Date().getDay();
    const [currentProfessor, setCurrentProfessor] = useState(allProfessors[0]);
    const [popupVisible, setPopupVisible] = useState(false);
    const [selectedPair, setSelectedPair] = useState(null); // {day, blockIdx, block}
    // --- week state ---
    const [currentDate, setCurrentDate] = useState(new Date());
    const [activeWeek, setActiveWeek] = useState(() => getInitialWeekType(new Date()));
    const weekRange = getWeekRange(new Date(currentDate));
    const switchWeek = (direction) => {
        const newDate = new Date(currentDate);
        if (direction === 'next') {
            newDate.setDate(currentDate.getDate() + 7);
        } else if (direction === 'previous') {
            newDate.setDate(currentDate.getDate() - 7);
        }
        setCurrentDate(newDate);
        setActiveWeek(getInitialWeekType(newDate));
    };

    // --- состояние для расписания ---
    const [allGroupsSchedule, setAllGroupsSchedule] = useState(() => {
        const local = localStorage.getItem('schedulesData');
        return local ? JSON.parse(local) : schedulesData;
    });

    useEffect(() => {
        localStorage.setItem('schedulesData', JSON.stringify(allGroupsSchedule));
    }, [allGroupsSchedule]);

    // Миграция структуры расписания для поддержки недель (upper/lower)
    useEffect(() => {
        // Проверяем, есть ли weekType (upper/lower) в расписании
        let migrated = false;
        const newSchedule = { ...allGroupsSchedule };
        for (const group in newSchedule) {
            // Если уже есть weekType — пропускаем
            if (newSchedule[group].upper && newSchedule[group].lower) continue;
            // Мигрируем: копируем текущее расписание в обе недели
            const old = newSchedule[group];
            newSchedule[group] = {
                upper: JSON.parse(JSON.stringify(old)),
                lower: JSON.parse(JSON.stringify(old))
            };
            migrated = true;
        }
        if (migrated) {
            setAllGroupsSchedule(newSchedule);
        }
        // eslint-disable-next-line
    }, []);

    // Формируем расписание преподавателя по дням и парам с учётом недели
    const getProfessorSchedule = (professorName) => {
        const schedule = {};
        dayNames.forEach(day => {
            schedule[day] = timeBlocks.map((_, blockIdx) => {
                for (const group in allGroupsSchedule) {
                    // --- поддержка недель ---
                    const weekData = allGroupsSchedule[group][activeWeek];
                    if (!weekData) continue;
                    const groupDay = weekData[day];
                    if (!groupDay) continue;
                    const pair = groupDay[blockIdx];
                    if (pair && pair.professorName === professorName && pair.className) {
                        return {
                            groupName: group,
                            classroom: pair.classroom,
                            className: pair.className,
                            type: pair.type
                        };
                    }
                }
                return { groupName: '', classroom: '', className: '', type: '' };
            });
        });
        return schedule;
    };

    const professorSchedule = getProfessorSchedule(currentProfessor);

    // Кастомный DaySchedule для преподавателя
    const ProfessorDaySchedule = ({ dayName, schedule, isCurrentDay }) => (
        <div className={`day-schedule${isCurrentDay ? ' current-day' : ''}`}>
            <div className="day-name">{dayName}</div>
            <div className="day-blocks">
                {schedule.map((block, idx) => {
                    let typeClass = '';
                    if (block.type === 'lecture') typeClass = 'lecture';
                    else if (block.type === 'practice') typeClass = 'practice';
                    else if (block.type === 'lab') typeClass = 'lab';
                    return (
                        <div
                            key={idx}
                            className={`time-block${block.className ? ' ' + typeClass : ' empty-block'}`}
                            onClick={() => {
                                if (block.className) {
                                    setSelectedPair({ day: dayName, blockIdx: idx, block });
                                    setPopupVisible(true);
                                }
                            }}
                            style={{ cursor: block.className ? 'pointer' : 'default' }}
                        >
                            {block.className ? (
                                <>
                                    <div className="block-class">{block.className}</div>
                                    <div className="block-group">{block.groupName}</div>
                                    <div className="block-classroom">{block.classroom}</div>
                                </>
                            ) : null}
                        </div>
                    );
                })}
            </div>
        </div>
    );

    // --- динамический расчёт доступных слотов для переноса ---
    function getAvailableSlotsForMove(selectedPair, weekOverride, dayOverride) {
        if (!selectedPair || !selectedPair.block || !selectedPair.block.groupName) return { upper: {}, lower: {} };
        const groupName = selectedPair.block.groupName;
        const professorName = selectedPair.block.professorName;
        const result = { upper: {}, lower: {} };
        ["upper", "lower"].forEach(weekType => {
            dayNames.forEach(day => {
                if (day === 'Суббота') {
                    result[weekType][day] = [];
                    return;
                }
                result[weekType][day] = [];
                for (let blockIdx = 0; blockIdx < timeBlocks.length; blockIdx++) {
                    // Разрешаем перенос только на будущие даты
                    const today = new Date();
                    const weekStart = new Date(today);
                    weekStart.setDate(weekStart.getDate() - weekStart.getDay() + 1 + (weekType === 'upper' ? 0 : 7));
                    const dayIdx = dayNames.indexOf(day);
                    const slotDate = new Date(weekStart);
                    slotDate.setDate(weekStart.getDate() + dayIdx);
                    if (isBefore(slotDate, today) && !isSameDay(slotDate, today)) continue;
                    if (day === selectedPair.day && blockIdx === selectedPair.blockIdx && weekType === (weekOverride || activeWeek)) {
                        result[weekType][day].push(blockIdx);
                        continue;
                    }
                    const weekData = allGroupsSchedule[groupName][weekType];
                    const isSlotFree = !weekData[day][blockIdx].className;
                    if (!isSlotFree) continue;
                    let busy = false;
                    for (const otherGroup in allGroupsSchedule) {
                        if (otherGroup === groupName) continue;
                        const otherWeekData = allGroupsSchedule[otherGroup][weekType];
                        if (!otherWeekData) continue;
                        const pair = otherWeekData[day][blockIdx];
                        if (pair && pair.professorName === professorName && pair.className) {
                            busy = true;
                            break;
                        }
                    }
                    if (!busy) result[weekType][day].push(blockIdx);
                }
            });
        });
        return result;
    }

    return (
        <div className="professorschedulepage">
            <Menu activeWeek={activeWeek} setActiveWeek={setActiveWeek} weekRange={weekRange} switchWeek={switchWeek} />
            <div className="controls-container">
                <div className="group-selector-container">
                    <div className="group-selector">
                        <label className="group-selector-label">Выберите преподавателя:</label>
                        <select 
                            value={currentProfessor}
                            onChange={e => setCurrentProfessor(e.target.value)}
                            className="group-select"
                        >
                            {allProfessors.map(p => (
                                <option key={p} value={p}>{p}</option>
                            ))}
                        </select>
                    </div>
                </div>
            </div>
            <div className="professors-content">
                <div className="professor-schedule-time">
                    <p>Время</p>
                    <div className="line-under">
                        <svg width="87" height="2" viewBox="0 0 87 2" fill="none" xmlns="http://www.w3.org/2000/svg">
                            <path d="M1 1L85.5 1" stroke="#ABABAB" strokeOpacity="0.3" strokeWidth="2" strokeLinecap="round" />
                        </svg>
                    </div>
                    {timeBlocks.map((block, index) => (
                        <TimeBlock
                            key={index}
                            timeUp={block.timeUp}
                            timeDown={block.timeDown}
                        />
                    ))}
                </div>
                <div className="professor-schedule-days">
                    {dayNames.map((dayName, index) => (
                        <ProfessorDaySchedule
                            key={dayName}
                            dayName={dayName}
                            schedule={professorSchedule[dayName]}
                            isCurrentDay={index === currentDay - 1}
                        />
                    ))}
                </div>
            </div>
            <MoveLessonPopup
                isVisible={popupVisible}
                onClose={() => setPopupVisible(false)}
                selectedPair={selectedPair}
                availableSlots={getAvailableSlotsForMove(selectedPair)}
                currentSlot={selectedPair ? { week: activeWeek, day: selectedPair.day, slot: selectedPair.blockIdx } : null}
                onMoveConfirm={async (weekType, day, slot, weekIdx) => {
                    if (!selectedPair || !selectedPair.block || !selectedPair.block.groupName) return;
                    // Вычисляем дату и проверяем границы семестра
                    const SEMESTER_START = new Date(new Date().getFullYear(), 8, 1);
                    const SEMESTER_END = new Date(new Date().getFullYear() + (new Date().getMonth() >= 8 ? 1 : 0), 5, 1);
                    const baseMonday = (date => { let d = new Date(date); d.setDate(d.getDate() - d.getDay() + 1); return d; })(SEMESTER_START);
                    const weekMonday = new Date(baseMonday); weekMonday.setDate(baseMonday.getDate() + weekIdx * 7);
                    if (weekMonday < SEMESTER_START || weekMonday > SEMESTER_END) return;
                    const groupName = selectedPair.block.groupName;
                    const oldDay = selectedPair.day;
                    const oldSlot = selectedPair.blockIdx;
                    const oldWeek = activeWeek;
                    // --- поддержка переноса между неделями ---
                    const movedLesson = { ...allGroupsSchedule[groupName][oldWeek][oldDay][oldSlot] };
                    // Если выбран тот же слот и неделя, просто закрыть popup
                    if (oldDay === day && oldSlot === slot && oldWeek === weekType) {
                        setPopupVisible(false);
                        return;
                    }
                    // Копия расписания для иммутабельности
                    const updatedSchedule = JSON.parse(JSON.stringify(allGroupsSchedule));
                    updatedSchedule[groupName][oldWeek][oldDay][oldSlot] = {
                        className: '', professorName: '', classroom: '', type: ''
                    };
                    updatedSchedule[groupName][weekType][day][slot] = movedLesson;
                    // Пересчёт availableForMove (опционально)
                    const availableForMove = {};
                    dayNames.forEach(dayName => {
                        availableForMove[dayName] = [];
                        for (let blockIdx = 0; blockIdx < timeBlocks.length; blockIdx++) {
                            const isSlotFree = !updatedSchedule[groupName][weekType][dayName][blockIdx].className;
                            if (isSlotFree) {
                                availableForMove[dayName].push(blockIdx);
                            }
                        }
                    });
                    updatedSchedule[groupName][weekType].availableForMove = availableForMove;
                    setAllGroupsSchedule(updatedSchedule);
                    setPopupVisible(false);
                }}
            />
        </div>
    );
}

export default ProfessorSchedulePage;