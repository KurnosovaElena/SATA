import React from 'react'
import Menu from '../components/menu/Menu'
import StudentSchedule from '../components/studentSchedule/studentSchedule'
import "./studentschedulePage.css"

function StudentSchedulePage() {
    return (
        <div className="studentschedulepage">
            <Menu />
            <StudentSchedule />
        </div>
    );
}
export default StudentSchedulePage