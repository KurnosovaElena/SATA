import React, { memo, useState } from 'react';
import { Bar, Pie } from 'react-chartjs-2';
import { Chart as ChartJS } from 'chart.js/auto';
import styles from '../StatsPage.module.css';

const MAX_HOURS = 900; // Максимальная нагрузка в часах

const ProfessorLoadChart = memo(({ professor, dateRange, calculateHours }) => {
  const [isCircular, setIsCircular] = useState(false);

  if (!professor) return null;

  const actualLoad = calculateHours(professor.load, dateRange);
  const maxPeriodLoad = calculateHours(MAX_HOURS, dateRange);

  const chartData = {
    labels: ['Нагрузка преподавателя'],
    datasets: [
      {
        label: 'Текущая нагрузка',
        data: [actualLoad],
        backgroundColor: isCircular ? 
          ['rgba(131, 163, 107, 0.7)'] : 
          'rgba(131, 163, 107, 0.5)',
        borderColor: 'rgba(131, 163, 107, 1)',
        borderWidth: 1
      },
      {
        label: 'Незанятые часы',
        data: [maxPeriodLoad - actualLoad],
        backgroundColor: isCircular ? 
          ['rgba(220, 220, 220, 0.5)'] :
          'rgba(220, 220, 220, 0.5)',
        borderColor: 'rgba(200, 200, 200, 1)',
        borderWidth: 1
      }
    ]
  };

  const commonOptions = {
    responsive: true,
    maintainAspectRatio: false,
    animation: {
      duration: 800,
      easing: 'cubic-bezier(0.68, -0.55, 0.265, 1.55)'
    }
  };

  const barOptions = {
    ...commonOptions,
    plugins: {
      legend: {
        display: true,
        position: 'top'
      },
      title: {
        display: true,
        text: `Нагрузка преподавателя ${professor.name}`
      }
    },
    scales: {
      y: {
        beginAtZero: true,
        stacked: false,
        max: MAX_HOURS,
        title: {
          display: true,
          text: 'Часы'
        }
      }
    }
  };

  const pieOptions = {
    ...commonOptions,
    plugins: {
      legend: {
        display: true,
        position: 'bottom'
      },
      title: {
        display: true,
        text: `Нагрузка преподавателя ${professor.name}`
      }
    },
    cutout: 0, // Устанавливаем в 0 для создания полного круга
    radius: '90%' // Устанавливаем радиус
  };

  const loadPercentage = ((actualLoad / maxPeriodLoad) * 100).toFixed(1);

  return (
    <div className={styles['stats-chart-block']}>
      <h3 className={styles['stats-chart-title']}>
        Нагрузка преподавателя
      </h3>
      <div className={`${styles['chart-container']} ${isCircular ? styles['show-pie'] : ''}`}>
        <div className={styles['chart-wrapper']}>
          <div className={styles['bar-chart']}>
            <Bar data={chartData} options={barOptions} />
          </div>
          <div className={styles['pie-chart']}>
            <Pie data={chartData} options={pieOptions} />
          </div>
        </div>
      </div>
      <div className={styles['stats-chart-info']}>
        <div>Текущая нагрузка: {actualLoad} ч.</div>
        <div>Доступно часов: {maxPeriodLoad - actualLoad} ч.</div>
        <div>Загруженность: {loadPercentage}%</div>
      </div>
      <div className={styles['chart-type-switch']}>
        <span className={styles['chart-type-label']}>График</span>
        <label className={styles['switch']}>
          <input
            type="checkbox"
            checked={isCircular}
            onChange={() => setIsCircular(!isCircular)}
          />
          <span className={styles['slider']}></span>
        </label>
        <span className={styles['chart-type-label']}>Диаграмма</span>
      </div>
    </div>
  );
});

ProfessorLoadChart.displayName = 'ProfessorLoadChart';
export default ProfessorLoadChart;
