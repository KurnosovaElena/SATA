import React from 'react'
import Menu from '../components/menu/Menu'
import TimeBlock from '../components/timeBlock/timeBlock'
import DaySchedule from '../components/daySchedule/dayScheduleW'
import "./studentschedulePage.css"


function StudentSchedulePage() {
    const mondaySchedule = [
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "practice" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "", professorName: "", classroom: "", type: "" },
       
    ];
    const tuesdaySchedule = [
        { className: "", professorName: "", classroom: "", type: "" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "practice" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "", professorName: "", classroom: "", type: "" },
    ];
    const wednesdaySchedule = [
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "", professorName: "", classroom: "", type: "" },
        { className: "", professorName: "", classroom: "", type: "" },
        { className: "", professorName: "", classroom: "", type: "" },
       
    ];
    const thursdaySchedule = [
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "", professorName: "", classroom: "", type: "" },
        { className: "", professorName: "", classroom: "", type: "" },
       
    ];
    const fridaySchedule = [
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "СТК", professorName: "Скрылёв Н.П.", classroom: "416/2", type: "lecture" },
        { className: "", professorName: "", classroom: "", type: "" },
        { className: "", professorName: "", classroom: "", type: "" },
        { className: "", professorName: "", classroom: "", type: "" },
        { className: "", professorName: "", classroom: "", type: "" },
       
    ];
    const saturdaySchedule = [
        { className: "", professorName: "", classroom: "", type: "" },
        { className: "", professorName: "", classroom: "", type: "" },
        { className: "", professorName: "", classroom: "", type: "" },
        { className: "", professorName: "", classroom: "", type: "" },
        { className: "", professorName: "", classroom: "", type: "" },
        { className: "", professorName: "", classroom: "", type: "" },
       
    ];
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
                    <TimeBlock timeUp="08:30" timeDown="10:05" />{/* timeBlock component area*/}
                    <TimeBlock timeUp="10:25" timeDown="12:00" />
                    <TimeBlock timeUp="12:30" timeDown="14:05" />
                    <TimeBlock timeUp="14:20" timeDown="15:55" />
                    <TimeBlock timeUp="16:05" timeDown="17:40" />
                    <TimeBlock timeUp="17:50" timeDown="19:25" />
                </div>
                <div className="student-schedule-days">
                    <DaySchedule dayName="Понедельник" schedule={mondaySchedule} />
                    <DaySchedule dayName="Вторник" schedule={tuesdaySchedule} />
                    <DaySchedule dayName="Среда" schedule={wednesdaySchedule} />
                    <DaySchedule dayName="Четверг" schedule={thursdaySchedule} />
                    <DaySchedule dayName="Пятница" schedule={fridaySchedule} />
                    <DaySchedule dayName="Суббота" schedule={saturdaySchedule} />
                </div>
            </div>
        </div>
    )
}

export default StudentSchedulePage