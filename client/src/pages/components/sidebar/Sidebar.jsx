import React from 'react';
import './sidebar.css';
import { useAuth0 } from '@auth0/auth0-react';

const Sidebar = ({ isOpen, onClose }) => {
  const { isAuthenticated, user, logout, loginWithRedirect } = useAuth0();
  const isAdmin = isAuthenticated && user?.email === 'getrent.v1@gmail.com';
  return (
    <>
      <div className={`sidebar ${isOpen ? 'open' : ''}`}>
        <div className="close-btn" onClick={onClose}>
          <svg width="24" height="24" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
            <path d="M6 18L18 6M6 6L18 18" stroke="#ABABAB" strokeWidth="2" strokeLinecap="round" strokeLinejoin="round"/>
          </svg>
        </div>
        {isAuthenticated && user?.email && (
          <div style={{margin: '16px 0 8px 16px', color: '#676B57', fontSize: '15px', fontWeight: 500, wordBreak: 'break-all'}}>
            {user.email}
          </div>
        )}
        <ul className="sidebar-menu">
            <li><a className='active' href="/">Главная</a></li>
            <li><a className='active' href="/profschedule">Расписание преп</a></li>
            <li><a className='active' href="/stschedule">Расписание занятий</a></li>
            <li><a className='active' href="/stprofile">Личный кабинет (тест)</a></li>
            {isAdmin && (
              <li><a className='active' href="/admin/roles">Управление ролями</a></li>
            )}
        </ul>
        {isAuthenticated && (
          <div style={{margin: '24px 0 0 16px'}}>
            <button
              style={{background: '#83A36B', color: 'white', border: 'none', borderRadius: '8px', padding: '8px 18px', fontFamily: 'Montserrat', fontWeight: 'bold', cursor: 'pointer'}}
              onClick={() => logout({ returnTo: window.location.origin })}
            >
              Выйти
            </button>
          </div>
        )}
        {!isAuthenticated && (
          <div style={{margin: '24px 0 0 16px'}}>
            <button
              style={{background: '#83A36B', color: 'white', border: 'none', borderRadius: '8px', padding: '8px 18px', fontFamily: 'Montserrat', fontWeight: 'bold', cursor: 'pointer'}}
              onClick={() => loginWithRedirect()}
            >
              Вход
            </button>
          </div>
        )}
      </div>
      <div className={`overlay ${isOpen ? 'open' : ''}`} onClick={onClose}></div>
    </>
  );
};

export default Sidebar;

