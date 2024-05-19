import React from 'react'
import "./professorschedulePage.css"
import Menu from '../components/menu/Menu'
import TimeBlock from '../components/timeBlock/timeBlock'
import DaySchedule from '../components/daySchedule/dayScheduleW'

function ProfessorSchedulePage() {
    const mondaySchedule = [
      { className: "СТК", professorName: "ПИР-211", classroom: "317/2", type: "lecture" },
      { professorName: "", classroom: "", type: "" },
      { className: "ЗИ", professorName: "ПИР-211", classroom: "317/2", type: "practice" },
      { className: "БД", professorName: "ПИР-211", classroom: "317/2", type: "practice" },
      { professorName: "", classroom: "", type: "" },
      { professorName: "", classroom: "", type: "" },
  ];
    const tuesdaySchedule = [
      { professorName: "", classroom: "", type: "" },
      { className: "БД", professorName: "АСОИР-211", classroom: "215/2", type: "practice" },
      { professorName: "", classroom: "", type: "" },
      { className: "ФИЗРА", professorName: "АСОИР-211", classroom: "215/2", type: "lecture" },
      { className: "СТК", professorName: "АСОИР-211", classroom: "215/2", type: "lecture" },
      { professorName: "", classroom: "", type: "" },
  ];
    const wednesdaySchedule = [
      { className: "ТРПО", professorName: "ЭР-211", classroom: "216/2", type: "practice" },
      { className: "СТК", professorName: "ЭР-211", classroom: "216/2", type: "practice" },
      { className: "ЗИ", professorName: "ЭР-211", classroom: "216/2", type: "practice" },
      { professorName: "", classroom: "", type: "" },
      { professorName: "", classroom: "", type: "" },
      { professorName: "", classroom: "", type: "" },
  ];
    const thursdaySchedule = [
      { className: "ТРПО", professorName: "МИР-211", classroom: "214/2", type: "practice" },
      { className: "ФИЗРА", professorName: "МИР-211", classroom: "214/2", type: "practice" },
      { className: "СЫК", professorName: "МИР-211", classroom: "214/2", type: "practice" },
      { className: "ЖЖДМ", professorName: "МИР-211", classroom: "214/2", type: "practice" },
      { professorName: "", classroom: "", type: "" },
      { professorName: "", classroom: "", type: "" },
  ];
    const fridaySchedule = [
      { className: "СКС", professorName: "ПИР-211", classroom: "317/2", type: "practice" },
      { className: "ППХ", professorName: "ПИР-211", classroom: "317/2", type: "practice" },
      { professorName: "", classroom: "", type: "" },
      { professorName: "", classroom: "", type: "" },
      { professorName: "", classroom: "", type: "" },
      { professorName: "", classroom: "", type: "" },
  ];
    const saturdaySchedule = [
      { professorName: "", classroom: "", type: "" },
      { professorName: "", classroom: "", type: "" },
      { professorName: "", classroom: "", type: "" },
      { professorName: "", classroom: "", type: "" },
      { professorName: "", classroom: "", type: "" },
      { professorName: "", classroom: "", type: "" },
  ];
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
                    <TimeBlock timeUp="08:30" timeDown="10:05" />{/* timeBlock component area*/}
                    <TimeBlock timeUp="10:25" timeDown="12:00" />
                    <TimeBlock timeUp="12:30" timeDown="14:05" />
                    <TimeBlock timeUp="14:20" timeDown="15:55" />
                    <TimeBlock timeUp="16:05" timeDown="17:40" />
                    <TimeBlock timeUp="17:50" timeDown="19:25" />
                </div>
                <div className="professor-schedule-days">
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

export default ProfessorSchedulePage