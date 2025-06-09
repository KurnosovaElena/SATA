import React from 'react';
import styles from '../StatsPage.module.css';

const DAYS_OF_WEEK = [
  'Понедельник',
  'Вторник',
  'Среда',
  'Четверг',
  'Пятница',
  'Суббота'
];

const WeeklyLoadStats = ({ professor }) => {
  // В реальном приложении эти данные должны приходить из API
  const weeklyLoad = {
    'Понедельник': 6,
    'Вторник': 4,
    'Среда': 8,
    'Четверг': 2,
    'Пятница': 7,
    'Суббота': 3
  };

  const maxHours = 8; // Максимальное количество часов в день
  return (
    <div className={styles['weekly-stats']}>
      <h3 className={styles['weekly-stats-title']}>Распределение нагрузки по дням недели</h3>
      <div className={styles['weekly-bars-container']}>
        {DAYS_OF_WEEK.map(day => (
          <div key={day} className={styles['weekly-bar-container']}>
            <div className={styles['weekly-day-label']}>{day}</div>
            <div className={styles['weekly-bar-wrapper']}>
              <div 
                className={styles['weekly-bar']} 
                style={{ width: `${(weeklyLoad[day] / maxHours) * 100}%` }}
              />
              <span className={styles['weekly-bar-label']}>
                {weeklyLoad[day]} ч
              </span>
            </div>          </div>
        ))}
      </div>
    </div>
  );
};

export default WeeklyLoadStats;
