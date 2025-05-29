import React, { useState, useEffect } from 'react';
import Menu from '../components/menu/Menu'
import StudentSchedule from '../components/studentSchedule/studentSchedule'
import "./studentschedulePage.css"
import Sidebar from '../components/sidebar/Sidebar';

// Helper function to format dates
const formatDate = (date) => {
    const options = { day: '2-digit', month: '2-digit', year: 'numeric' };
    return date.toLocaleDateString('ru-RU', options);
  };
  
// Helper function to get the week range
const getWeekRange = (date) => {
    const firstDay = date.getDate() - date.getDay() + 1; // Get the first day (Monday) of the week
    const startDate = new Date(date.setDate(firstDay));
    const endDate = new Date(date.setDate(firstDay + 5)); // Saturday of the same week
  
    const start = formatDate(startDate);
    const end = formatDate(endDate);
  
    return `${start} / ${end}`;
  };
  
  // Determine if a given date is within the academic year
  const isWithinAcademicYear = (date) => {
    const year = date.getFullYear();
    const startOfYear = new Date(year, 8, 1); // September 1st
    const endOfYear = new Date(year + 1, 5, 1); // June 1st
    return date >= startOfYear && date <= endOfYear;
  };
  
  // Get the initial week type (upper or lower) for a given date
  const getInitialWeekType = (date) => {
    const startOfYear = new Date(date.getFullYear(), 8, 1); // September 1st
    const weekNumber = Math.floor((date - startOfYear) / (7 * 24 * 60 * 60 * 1000));
    return weekNumber % 2 === 0 ? 'upper' : 'lower';
  };
  
  function StudentSchedulePage() {
    const [isSidebarOpen, setSidebarOpen] = useState(false);
    const [currentDate, setCurrentDate] = useState(new Date());
    const [activeWeek, setActiveWeek] = useState(() => getInitialWeekType(new Date()));
  
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
  
    const weekRange = getWeekRange(new Date(currentDate)); // Fix the week range calculation
    
    const toggleSidebar = () => {
      setSidebarOpen(!isSidebarOpen);
    };
  
    const closeSidebar = () => {
      setSidebarOpen(false);
    };

    return (
      <div className="studentschedulepage">
        <Sidebar isOpen={isSidebarOpen} onClose={closeSidebar} />
        {isSidebarOpen && <div className="overlay active" onClick={toggleSidebar}></div>}
        <Menu activeWeek={activeWeek} setActiveWeek={setActiveWeek} weekRange={weekRange} switchWeek={switchWeek} />
        <StudentSchedule activeWeek={activeWeek} />
      </div>
    );
  }
  
  export default StudentSchedulePage;