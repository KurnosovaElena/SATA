import React from 'react'
import "./professorschedulePage.css"
import Menu from '../components/menu/Menu'
import TimeBlock from '../components/timeBlock/timeBlock'
import DaySchedule from '../components/daySchedule/dayScheduleW'

function ProfessorSchedulePage() {
  const currentDay = new Date().getDay();

  const timeBlocks = [
      { timeUp: '08:30', timeDown: '10:05' },
      { timeUp: '10:25', timeDown: '12:00' },
      { timeUp: '12:30', timeDown: '14:05' },
      { timeUp: '14:20', timeDown: '15:55' },
      { timeUp: '16:05', timeDown: '17:40' },
      { timeUp: '17:50', timeDown: '19:25' }
  ];
  const dayNames = ['Понедельник', 'Вторник', 'Среда', 'Четверг', 'Пятница', 'Суббота'];

  const schedules = {

    Понедельник: [
      { className: "СТК", professorName: "ПИР-211", classroom: "317/2", type: "lecture" },
      { professorName: "", classroom: "", type: "" },
      { className: "ЗИ", professorName: "ПИР-211", classroom: "317/2", type: "practice" },
      { className: "БД", professorName: "ПИР-211", classroom: "317/2", type: "practice" },
      { professorName: "", classroom: "", type: "" },
      { professorName: "", classroom: "", type: "" },
  ],
    Вторник: [
      { professorName: "", classroom: "", type: "" },
      { className: "БД", professorName: "АСОИР-211", classroom: "215/2", type: "practice" },
      { professorName: "", classroom: "", type: "" },
      { className: "ФИЗРА", professorName: "АСОИР-211", classroom: "215/2", type: "lecture" },
      { className: "СТК", professorName: "АСОИР-211", classroom: "215/2", type: "lecture" },
      { professorName: "", classroom: "", type: "" },
  ],
    Среда: [
      { className: "ТРПО", professorName: "ЭР-211", classroom: "216/2", type: "practice" },
      { className: "СТК", professorName: "ЭР-211", classroom: "216/2", type: "practice" },
      { className: "ЗИ", professorName: "ЭР-211", classroom: "216/2", type: "practice" },
      { professorName: "", classroom: "", type: "" },
      { professorName: "", classroom: "", type: "" },
      { professorName: "", classroom: "", type: "" },
  ], 
    Четверг: [
      { className: "ТРПО", professorName: "МИР-211", classroom: "214/2", type: "practice" },
      { className: "ФИЗРА", professorName: "МИР-211", classroom: "214/2", type: "practice" },
      { className: "СЫК", professorName: "МИР-211", classroom: "214/2", type: "practice" },
      { className: "ЖЖДМ", professorName: "МИР-211", classroom: "214/2", type: "practice" },
      { professorName: "", classroom: "", type: "" },
      { professorName: "", classroom: "", type: "" },
  ],
    Пятница: [
      { className: "СКС", professorName: "ПИР-211", classroom: "317/2", type: "practice" },
      { className: "ППХ", professorName: "ПИР-211", classroom: "317/2", type: "practice" },
      { professorName: "", classroom: "", type: "" },
      { professorName: "", classroom: "", type: "" },
      { professorName: "", classroom: "", type: "" },
      { professorName: "", classroom: "", type: "" },
  ],
    Суббота: [
      { professorName: "", classroom: "", type: "" },
      { professorName: "", classroom: "", type: "" },
      { professorName: "", classroom: "", type: "" },
      { professorName: "", classroom: "", type: "" },
      { professorName: "", classroom: "", type: "" },
      { professorName: "", classroom: "", type: "" },
  ],
  };
  return (
    <div className="professorschedulepage">
        <Menu></Menu>
        <div className="professors-content">
        <div className="professor-schedule-time">
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
                    />
                    ))}
                </div>
                <div className="professor-schedule-days">
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

export default ProfessorSchedulePage