import React from 'react';
import './sidebar.css';

const Sidebar = ({ isOpen, onClose }) => {
  return (
    <>
      <div className={`sidebar ${isOpen ? 'open' : ''}`}>
        <div className="close-btn" onClick={onClose}>
          <svg width="24" height="24" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
            <path d="M6 18L18 6M6 6L18 18" stroke="#ABABAB" strokeWidth="2" strokeLinecap="round" strokeLinejoin="round"/>
          </svg>
        </div>
        <ul className="sidebar-menu">
            <li><a className='active' href="/week-schedule">Расписание преп (тест)</a></li>
            <li><a className='active' href="/stschedule">Расписание (тест)</a></li>
            <li><a className='active' href="/stprofile">Личный кабинет (тест)</a></li>
        </ul>
      </div>
      <div className={`overlay ${isOpen ? 'open' : ''}`} onClick={onClose}></div>
    </>
  );
};

export default Sidebar;

