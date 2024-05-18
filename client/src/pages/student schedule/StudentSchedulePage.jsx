import React from 'react'
import Menu from '../components/menu/Menu'
import "./studentschedulePage.css"

function StudentSchedulePage() {
    return (
        <div className="studentschedulepage">
            <Menu></Menu>
            <div className="students-content">
                <div className="student-schedule-time">
                    Время
                    <div className="par-1-time">1</div>
                    <div className="par-2-time">2</div>
                    <div className="par-3-time">3</div>
                    <div className="par-4-time">4</div>
                    <div className="par-5-time">5</div>
                    <div className="par-6-time">6</div>
                </div>
                <div className="student-schedule-days">
                    <div className="schedule-day-monday">monday
                    <div className="par-1">1</div>
                    <div className="par-2">2</div>
                    <div className="par-3">3</div>
                    <div className="par-4">4</div>
                    <div className="par-5">5</div>
                    <div className="par-6">6</div>
                    </div>
                    <div className="schedule-day-tuesday">tuesday
                    <div className="par-1">1</div>
                    <div className="par-2">2</div>
                    <div className="par-3">3</div>
                    <div className="par-4">4</div>
                    <div className="par-5">5</div>
                    <div className="par-6">6</div>
                    </div>
                    <div className="schedule-day-wednesday">wednesday
                    <div className="par-1">1</div>
                    <div className="par-2">2</div>
                    <div className="par-3">3</div>
                    <div className="par-4">4</div>
                    <div className="par-5">5</div>
                    <div className="par-6">6</div>
                    </div>
                    <div className="schedule-day-thursday">thursday
                    <div className="par-1">1</div>
                    <div className="par-2">2</div>
                    <div className="par-3">3</div>
                    <div className="par-4">4</div>
                    <div className="par-5">5</div>
                    <div className="par-6">6</div>
                    </div>
                    <div className="schedule-day-friday">friday
                    <div className="par-1">1</div>
                    <div className="par-2">2</div>
                    <div className="par-3">3</div>
                    <div className="par-4">4</div>
                    <div className="par-5">5</div>
                    <div className="par-6">6</div>
                    </div>
                    <div className="schedule-day-saturday">saturday
                    <div className="par-1">1</div>
                    <div className="par-2">2</div>
                    <div className="par-3">3</div>
                    <div className="par-4">4</div>
                    <div className="par-5">5</div>
                    <div className="par-6">6</div>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default StudentSchedulePage