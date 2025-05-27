import React, { useState } from 'react';
import schedulesData from '../../data/schedules.json';
import professorsData from '../../data/professors.json';
import "./professorschedulePage.css";
import Menu from '../components/menu/Menu';
import TimeBlock from '../components/timeBlock/timeBlock';
import DaySchedule from '../components/daySchedule/dayScheduleW';

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

    // Формируем расписание преподавателя по дням и парам
    const getProfessorSchedule = (professorName) => {
        const schedule = {};
        dayNames.forEach(day => {
            schedule[day] = timeBlocks.map((_, blockIdx) => {
                // Ищем среди всех групп, у кого в этот день/пару стоит этот преподаватель
                for (const group in schedulesData) {
                    const groupDay = schedulesData[group][day];
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
                // Если ни у кого нет пары с этим преподавателем
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
                        <div key={idx} className={`time-block${block.className ? ' ' + typeClass : ' empty-block'}`}> 
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
        </div>
    );
}

export default ProfessorSchedulePage;