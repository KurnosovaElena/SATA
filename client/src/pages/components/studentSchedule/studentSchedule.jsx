import React, { useState, useEffect } from 'react';
import TimeBlock from '../timeBlock/timeBlock';
import DaySchedule from '../daySchedule/dayScheduleW';
import "./studentSchedule.css";

const StudentSchedule = ({ activeWeek, initialGroup = 'АСОИР-211' }) => {
    const currentDay = new Date().getDay();
    const [isGenerating, setIsGenerating] = useState(false);
    const [animationProgress, setAnimationProgress] = useState(0);
    const [allGroupsSchedule, setAllGroupsSchedule] = useState({});
    const [currentGroup, setCurrentGroup] = useState(initialGroup);
    const [currentSchedule, setCurrentSchedule] = useState(null);

    //import subjectsData from ../../subjects.json
    //import professorsData from ../../professors.json
    //import classroomsData from ../../classrooms.json

    // Все группы университета
    const allGroups = [
        'АСОИР-211',
        'ПИР-211',
        'МИР-211', 
        'ЗАР-211',
        'СПР-211'
    ];

    // Полный список предметов с указанием необходимых аудиторий
    const subjectsData = [
        {
            name: "Математика",
            code: "MATH",
            departments: ["АСОИР", "ПИР", "МИР", "ЗАР", "СПР"],
            forAll: false,
            onlyLecture: false,
            onlyPractice: false,
            department: "Математика",
            requiredClassroom: "lecture_hall"
        },
        {
            name: "Физика",
            code: "PHYS",
            departments: ["АСОИР", "ПИР", "МИР"],
            forAll: false,
            onlyLecture: true,
            onlyPractice: false,
            department: "Физика",
            requiredClassroom: "lecture_hall"
        },
        {
            name: "Программирование",
            code: "PROG",
            departments: ["АСОИР", "ПИР"],
            forAll: false,
            onlyLecture: false,
            onlyPractice: false,
            department: "ИТ",
            requiredClassroom: "computer_class"
        },
        {
            name: "Базы данных",
            code: "DB",
            departments: ["АСОИР", "ПИР"],
            forAll: false,
            onlyLecture: false,
            onlyPractice: false,
            department: "ИТ",
            requiredClassroom: "computer_class"
        },
        {
            name: "Физкультура",
            code: "PE",
            departments: ["АСОИР", "ПИР", "МИР", "ЗАР", "СПР"],
            forAll: true,
            onlyLecture: false,
            onlyPractice: true,
            department: "Физкультура",
            requiredClassroom: "gym"
        },
        {
            name: "Лингвистика",
            code: "LING",
            departments: ["АСОИР", "ПИР", "МИР", "ЗАР", "СПР"],
            forAll: false,
            onlyLecture: false,
            onlyPractice: false,
            department: "Лингвистика",
            requiredClassroom: "lecture_hall"
        },
        {
            name: "Философия",
            code: "PHIL",
            departments: ["АСОИР", "ПИР", "МИР", "ЗАР", "СПР"],
            forAll: false,
            onlyLecture: false,
            onlyPractice: false,
            department: "Философия",
            requiredClassroom: "lecture_hall"
        },
        {
            name: "Английский язык",
            code: "ENG",
            departments: ["АСОИР", "ПИР", "МИР", "ЗАР", "СПР"],
            forAll: false,
            onlyLecture: false,
            onlyPractice: false,
            department: "Лингвистика",
            requiredClassroom: "lecture_hall"
        },
        {
            name: "Русский язык",
            code: "RUS",
            departments: ["АСОИР", "ПИР", "МИР", "ЗАР", "СПР"],
            forAll: false,
            onlyLecture: false,
            onlyPractice: false,
            department: "Лингвистика",
            requiredClassroom: "lecture_hall"
        },
        {
            name: "География",
            code: "GEO",
            departments: ["АСОИР", "ПИР", "МИР", "ЗАР", "СПР"],
            forAll: false,
            onlyLecture: false,
            onlyPractice: false,
            department: "Лингвистика",
            requiredClassroom: "lecture_hall"
        },
        {
            name: "История",
            code: "HIST",
            departments: ["АСОИР", "ПИР", "МИР", "ЗАР", "СПР"],
            forAll: false,
            onlyLecture: false,
            onlyPractice: false,
            department: "Лингвистика",
            requiredClassroom: "lecture_hall"
        },
        {
            name: "Экономика",
            code: "ECON",
            departments: ["АСОИР", "ПИР", "МИР", "ЗАР", "СПР"],
            forAll: false,
            onlyLecture: false,
            onlyPractice: false,
            department: "Философия",
            requiredClassroom: "lecture_hall"
        },
        {
            name: "Право",
            code: "LAW",
            departments: ["АСОИР", "ПИР", "МИР", "ЗАР", "СПР"],
            forAll: false,
            onlyLecture: false,
            onlyPractice: false,
            department: "Философия",
            requiredClassroom: "lecture_hall"
        },
        {
            name: "Социология",
            code: "SOC",
            departments: ["АСОИР", "ПИР", "МИР", "ЗАР", "СПР"],
            forAll: false,
            onlyLecture: false,
            onlyPractice: false,
            department: "Философия",
            requiredClassroom: "lecture_hall"
        },
        {
            name: "Психология",
            code: "PSY",
            departments: ["АСОИР", "ПИР", "МИР", "ЗАР", "СПР"],
            forAll: false,
            onlyLecture: false,
            onlyPractice: false,
            department: "Философия",
            requiredClassroom: "lecture_hall"
        }
    ];

    // Преподаватели
    const professorsData = [
        { name: "Иванов И.И.", department: "ИТ", maxHours: 12 },
        { name: "Петров П.П.", department: "Математика", maxHours: 10 },
        { name: "Сидоров С.С.", department: "Физика", maxHours: 8 },
        { name: "Кузнецова Е.В.", department: "Программирование", maxHours: 12 },
        { name: "Смирнов А.А.", department: "Базы данных", maxHours: 10 },
        
        // Лингвистика
        { name: "Васильева О.Н.", department: "Лингвистика", maxHours: 14 },
        { name: "Ковалева М.С.", department: "Лингвистика", maxHours: 12 },
        { name: "Жукова Л.Д.", department: "Лингвистика", maxHours: 10 },
        
        // Философия и гуманитарные науки
        { name: "Николаев Д.К.", department: "Философия", maxHours: 8 },
        { name: "Соколов А.В.", department: "Философия", maxHours: 10 },
        { name: "Белова Т.М.", department: "Философия", maxHours: 12 },
        { name: "Громова В.П.", department: "Философия", maxHours: 8 },
        
        // Физкультура
        { name: "Громов В.П.", department: "Физкультура", maxHours: 16 },
        { name: "Тихонов С.А.", department: "Физкультура", maxHours: 12 },
        
        // История и социология
        { name: "Орлов Н.Ф.", department: "Философия", maxHours: 10 },
        { name: "Зайцева Е.В.", department: "Философия", maxHours: 8 },
        
        // Экономика и право
        { name: "Крылов М.П.", department: "Философия", maxHours: 12 },
        { name: "Морозова А.С.", department: "Философия", maxHours: 10 }
    ];
    
    // Аудитории (20 штук)
    const classroomsData = [
        // Лекционные аудитории (10)
        { number: "101", building: "1", type: "lecture_hall", capacity: 30 },
        { number: "102", building: "1", type: "lecture_hall", capacity: 25 },
        { number: "103", building: "1", type: "lecture_hall", capacity: 40 },
        { number: "201", building: "1", type: "lecture_hall", capacity: 35 },
        { number: "202", building: "1", type: "lecture_hall", capacity: 30 },
        { number: "301", building: "1", type: "lecture_hall", capacity: 50 },
        { number: "302", building: "1", type: "lecture_hall", capacity: 45 },
        { number: "401", building: "1", type: "lecture_hall", capacity: 60 },
        { number: "402", building: "1", type: "lecture_hall", capacity: 55 },
        { number: "Актовый зал", building: "1", type: "large_lecture_hall", capacity: 100 },
        
        // Компьютерные классы (8)
        { number: "105", building: "2", type: "computer_class", capacity: 20 },
        { number: "106", building: "2", type: "computer_class", capacity: 18 },
        { number: "205", building: "2", type: "computer_class", capacity: 22 },
        { number: "206", building: "2", type: "computer_class", capacity: 20 },
        { number: "305", building: "2", type: "computer_class", capacity: 25 },
        { number: "306", building: "2", type: "computer_class", capacity: 20 },
        { number: "405", building: "2", type: "computer_class", capacity: 30 },
        { number: "406", building: "2", type: "computer_class", capacity: 25 },
        
        // Специальные аудитории (2)
        { number: "Спортзал", building: "3", type: "gym", capacity: 50 },
        { number: "Лингафонный кабинет", building: "3", type: "language_lab", capacity: 15 }
    ];

    // Временные блоки (пары)
    const timeBlocks = [
        { timeUp: '08:30', timeDown: '10:05' }, // 1 пара
        { timeUp: '10:25', timeDown: '12:00' }, // 2 пара
        { timeUp: '12:30', timeDown: '14:05' }, // 3 пара
        { timeUp: '14:20', timeDown: '15:55' }, // 4 пара
        { timeUp: '16:05', timeDown: '17:40' }, // 5 пара
        { timeUp: '17:50', timeDown: '19:25' }  // 6 пара 
    ];

    const dayNames = ['Понедельник', 'Вторник', 'Среда', 'Четверг', 'Пятница', 'Суббота'];

    // Создание пустого расписания
    const createEmptySchedule = () => {
        return dayNames.reduce((acc, day) => {
            acc[day] = timeBlocks.map(() => ({
                className: "",
                professorName: "",
                classroom: "",
                type: ""
            }));
            return acc;
        }, {});
    };

    // Получение предмета для группы
    const getSubjectForGroup = (groupName) => {
        const specialty = groupName.split('-')[0] || 'АСОИР';
        
        const availableSubjects = subjectsData.filter(subject => {
            if (subject.forAll) return true;
            return subject.departments?.includes(specialty);
        });

        return availableSubjects.length > 0 
            ? availableSubjects[Math.floor(Math.random() * availableSubjects.length)]
            : subjectsData[0];
    };

    // Генерация расписания с улучшенной анимацией и новыми ограничениями
    const generateAllSchedules = () => {
        setIsGenerating(true);
        setAnimationProgress(0);
        
        const newAllGroupsSchedule = {};
        const professorLoad = professorsData.reduce((acc, prof) => {
            acc[prof.name] = 0;
            return acc;
        }, {});

        const totalSteps = allGroups.length * dayNames.length * 5 * 10;
        let currentStep = 0;

        const generateForGroup = (groupName) => {
            const schedule = createEmptySchedule();
            const specialty = groupName.split('-')[0];
            let peCount = 0; // Счетчик пар физкультуры

            dayNames.forEach(day => {
                if (day === 'Суббота') return;

                // 1. Сначала ставим физкультуру (не более 2 раз в неделю)
                if (peCount < 2 && Math.random() > 0.7) {
                    const peSubject = subjectsData.find(s => s.code === 'PE');
                    const peProfessor = professorsData.find(p => p.department === 'Физкультура');
                    const peClassroom = classroomsData.find(c => c.type === 'gym');

                    // Ставим физкультуру на первую или вторую пару
                    const peBlock = Math.random() > 0.5 ? 0 : 1;
                    
                    schedule[day][peBlock] = {
                        className: peSubject.name,
                        professorName: peProfessor.name,
                        classroom: `${peClassroom.number}/${peClassroom.building}`,
                        type: 'practice'
                    };
                    professorLoad[peProfessor.name] += 1;
                    peCount++; // Увеличиваем счетчик физкультуры

                    currentStep += 2;
                    setAnimationProgress(Math.min((currentStep / totalSteps) * 100, 100));
                }

                // 2. Заполняем остальные пары
                for (let block = 0; block < 5; block++) {
                    if (schedule[day][block].className) continue;

                    for (let i = 0; i < 10; i++) {
                        currentStep++;
                        if (i === 9) {
                            setAnimationProgress(Math.min((currentStep / totalSteps) * 100, 100));
                        }
                    }

                    for (let attempt = 0; attempt < 5; attempt++) {
                        const subject = getSubjectForGroup(groupName);
                        if (!subject || subject.code === 'PE') continue; // Пропускаем физкультуру

                        const availableProfessors = professorsData.filter(prof => 
                            prof.department === subject.department && 
                            professorLoad[prof.name] < prof.maxHours
                        );

                        if (availableProfessors.length === 0) continue;

                        const professor = availableProfessors[
                            Math.floor(Math.random() * availableProfessors.length)
                        ];

                        const suitableClassrooms = classroomsData.filter(
                            room => room.type === subject.requiredClassroom
                        );
                        if (suitableClassrooms.length === 0) continue;

                        const classroom = suitableClassrooms[
                            Math.floor(Math.random() * suitableClassrooms.length)
                        ];

                        const type = subject.onlyLecture ? 'lecture' : 
                                    subject.onlyPractice ? 'practice' : 
                                    Math.random() > 0.6 ? 'lecture' : 'practice';

                        schedule[day][block] = {
                            className: subject.name,
                            professorName: professor.name,
                            classroom: `${classroom.number}/${classroom.building}`,
                            type: type
                        };
                        professorLoad[professor.name] += 1;
                        break;
                    }
                }

                // 3. Минимизация окон
                for (let block = 0; block < 4; block++) {
                    if (!schedule[day][block].className && schedule[day][block + 1].className) {
                        schedule[day][block] = schedule[day][block + 1];
                        schedule[day][block + 1] = { className: "", professorName: "", classroom: "", type: "" };
                    }
                }
            });

            return schedule;
        };

        const generateWithDelay = async () => {
            for (const groupName of allGroups) {
                newAllGroupsSchedule[groupName] = generateForGroup(groupName);
                await new Promise(resolve => setTimeout(resolve, 10000)); // УУУУУУУУУУУУУУУУУУУУУУУУ
                setAllGroupsSchedule({...newAllGroupsSchedule});
                setCurrentSchedule(newAllGroupsSchedule[currentGroup]);
            }
            
            localStorage.setItem('generatedSchedules', JSON.stringify(newAllGroupsSchedule));
            setIsGenerating(false);
        };

        generateWithDelay();
    };

    // Загрузка сохраненного расписания
    useEffect(() => {
        const savedSchedules = localStorage.getItem('generatedSchedules');
        if (savedSchedules) {
            const parsed = JSON.parse(savedSchedules);
            setAllGroupsSchedule(parsed);
            setCurrentSchedule(parsed[currentGroup] || createEmptySchedule());
        } else {
            setCurrentSchedule(createEmptySchedule());
        }
    }, [currentGroup]);

    // Обработчик изменения группы
    const handleGroupChange = (e) => {
        const selectedGroup = e.target.value;
        setCurrentGroup(selectedGroup);
        if (allGroupsSchedule[selectedGroup]) {
            setCurrentSchedule(allGroupsSchedule[selectedGroup]);
        }
    };

    // Экспорт в JSON файл
    const exportToJson = () => {
        if (!allGroupsSchedule || Object.keys(allGroupsSchedule).length === 0) return;
        
        const dataStr = JSON.stringify(allGroupsSchedule, null, 2);
        const dataUri = 'data:application/json;charset=utf-8,'+ encodeURIComponent(dataStr);
        
        const exportFileDefaultName = `schedules_${new Date().toISOString().slice(0,10)}.json`;
        
        const linkElement = document.createElement('a');
        linkElement.setAttribute('href', dataUri);
        linkElement.setAttribute('download', exportFileDefaultName);
        linkElement.click();
    };

    return (
        <div className="students-content">
            <div className="controls-container">
                <div className="group-selector-container">
                    <div className="group-selector">
                        <label className="group-selector-label">Выберите группу:</label>
                        <select 
                            value={currentGroup} 
                            onChange={handleGroupChange}
                            disabled={isGenerating}
                            className="group-select"
                        >
                            {allGroups.map(g => (
                                <option key={g} value={g}>{g}</option>
                            ))}
                        </select>
                    </div>
                </div>

                <div className="buttons-container">
                    <button 
                        onClick={generateAllSchedules}
                        disabled={isGenerating}
                        className={`generate-button ${isGenerating ? 'generating' : ''}`}
                    >
                        <span className="button-icon">🔄</span>
                        <span className="button-text">
                            {isGenerating ? `Генерация ${Math.round(animationProgress)}%` : 'Сгенерировать расписание'}
                        </span>
                    </button>
                    
                    {Object.keys(allGroupsSchedule).length > 0 && (
                        <button 
                            onClick={exportToJson}
                            className="export-button"
                        >
                            <span className="button-icon">💾</span>
                            <span className="button-text">Экспорт в JSON</span>
                        </button>
                    )}
                </div>
            </div>
            
            {isGenerating && (
                <div className="generation-animation">
                    <div className="animation-container">
                        <div className="book-animation"></div>
                        <div className="clock-animation"></div>
                        <div className="progress-text">Генерация расписания... {Math.round(animationProgress)}%</div>
                        <div className="progress-bar">
                            <div className="progress-fill" style={{ width: `${animationProgress}%` }}></div>
                        </div>
                    </div>
                </div>
            )}
            
            <div className="student-schedule-time">
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
                        isDisabled={index === 5}
                    />
                ))}
            </div>
            <div className="student-schedule-days">
                {dayNames.map((dayName, index) => (
                    <DaySchedule
                        key={dayName}
                        dayName={dayName}
                        schedule={currentSchedule?.[dayName] || []}
                        isCurrentDay={index === currentDay - 1}
                        disabledBlocks={[5]}
                    />
                ))}
            </div>
        </div>
    );
};

export default StudentSchedule;