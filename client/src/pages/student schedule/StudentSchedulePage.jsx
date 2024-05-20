import React, { useState, useEffect } from 'react'
import Menu from '../components/menu/Menu'
import TimeBlock from '../components/timeBlock/timeBlock'
import DaySchedule from '../components/daySchedule/dayScheduleW'
import "./studentschedulePage.css"

function StudentSchedulePage() {
    const [currentTimeBlock, setCurrentTimeBlock] = useState(null);
    const [currentDay, setCurrentDay] = useState(new Date().getDay());

    const timeBlocks = [
        { timeUp: '08:30', timeDown: '10:05' },
        { timeUp: '10:25', timeDown: '12:00' },
        { timeUp: '12:30', timeDown: '14:05' },
        { timeUp: '14:20', timeDown: '15:55' },
        { timeUp: '16:05', timeDown: '17:40' },
        { timeUp: '17:50', timeDown: '19:25' }
    ];
    const dayNames = ['Понедельник', 'Вторник', 'Среда', 'Четверг', 'Пятница', 'Суббота'];

    useEffect(() => {
        const checkCurrentTimeBlock = () => {
            const currentTime = new Date();
            const currentHours = currentTime.getHours();
            const currentMinutes = currentTime.getMinutes();

            const currentMinutesTotal = currentHours * 60 + currentMinutes;

            timeBlocks.forEach((block, index) => {
                const [startHours, startMinutes] = block.timeUp.split(':').map(Number);
                const [endHours, endMinutes] = block.timeDown.split(':').map(Number);

                const startMinutesTotal = startHours * 60 + startMinutes;
                const endMinutesTotal = endHours * 60 + endMinutes;

                if (currentMinutesTotal >= startMinutesTotal && currentMinutesTotal <= endMinutesTotal) {
                    setCurrentTimeBlock(index);
                }
            });
        };

        checkCurrentTimeBlock();
        const intervalId = setInterval(checkCurrentTimeBlock, 60000); // Check every minute

        return () => clearInterval(intervalId);
    }, [timeBlocks]);
    const schedules = {

    Понедельник: [
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "practice" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "", professorName: "", classroom: "", type: "" },
       
    ],
    Вторник: [
        { className: "", professorName: "", classroom: "", type: "" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "practice" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "", professorName: "", classroom: "", type: "" },
    ], 
    Среда: [
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "", professorName: "", classroom: "", type: "" },
        { className: "", professorName: "", classroom: "", type: "" },
        { className: "", professorName: "", classroom: "", type: "" },
       
    ],
    Четверг: [
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "", professorName: "", classroom: "", type: "" },
        { className: "", professorName: "", classroom: "", type: "" },
       
    ],
    Пятница: [
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "", professorName: "", classroom: "", type: "" },
        { className: "", professorName: "", classroom: "", type: "" },
        { className: "", professorName: "", classroom: "", type: "" },
        { className: "", professorName: "", classroom: "", type: "" },
       
    ],
    Суббота: [
        { className: "", professorName: "", classroom: "", type: "" },
        { className: "", professorName: "", classroom: "", type: "" },
        { className: "", professorName: "", classroom: "", type: "" },
        { className: "", professorName: "", classroom: "", type: "" },
        { className: "", professorName: "", classroom: "", type: "" },
        { className: "", professorName: "", classroom: "", type: "" },
       
    ],
};
    return (
        <div className="studentschedulepage">
            <Menu></Menu>
            <div className="students-content">
                <div className="student-schedule-time">
                    <p>Время</p>
                    <div className="line-under">
                        <svg width="87" height="2" viewBox="0 0 87 2" fill="none" xmlns="http://www.w3.org/2000/svg">
                            <path d="M1 1L85.5 1" stroke="#ABABAB" stroke-opacity="0.3" stroke-width="2" stroke-linecap="round" />
                        </svg>
                    </div>
                    {timeBlocks.map((block, index) => (
                    <TimeBlock
                        key={index}
                        timeUp={block.timeUp}
                        timeDown={block.timeDown}
                        isCurrent={index === currentTimeBlock}
                    />
                ))}
                </div>
                <div className="student-schedule-days">
                {dayNames.map((dayName, index) => (
                    <DaySchedule
                        key={dayName}
                        dayName={dayName}
                        schedule={schedules[dayName] || []}
                        isCurrentDay={index === currentDay-1}/* текущий день -1 (нумерация с 0) */
                    />
                ))}
                </div>
            </div>
        </div>
    )
}

export default StudentSchedulePage