import React, { memo, useState } from 'react';
import { Bar, Pie } from 'react-chartjs-2';
import { Chart as ChartJS } from 'chart.js/auto';
import styles from '../StatsPage.module.css';

const MAX_HOURS = 900; // Максимальная нагрузка в часах на преподавателя

const DepartmentLoadChart = memo(({ professors, dateRange, calculateHours }) => {
  const [isCircular, setIsCircular] = useState(false);

  if (!professors?.length) return null;

  const chartData = {
    labels: professors.map(p => p.name),
    datasets: [
      {
        label: 'Текущая нагрузка',
        data: professors.map(p => calculateHours(p.load, dateRange)),
        backgroundColor: isCircular ? 
          professors.map((_, i) => `rgba(131, 163, 107, ${0.5 + (i * 0.1)})`) :
          'rgba(131, 163, 107, 0.5)',
        borderColor: 'rgba(131, 163, 107, 1)',
        borderWidth: 1
      },
      {
        label: 'Незанятые часы',
        data: professors.map(p => calculateHours(MAX_HOURS - p.load, dateRange)),
        backgroundColor: isCircular ? 
          professors.map(() => 'rgba(220, 220, 220, 0.5)') :
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
      }
    },
    scales: {
      y: {
        beginAtZero: true,
        stacked: false, // Отключаем стекирование для сравнения
        title: { 
          display: true, 
          text: 'Часы' 
        },
        max: MAX_HOURS // Устанавливаем максимальное значение шкалы
      },
      x: {
        ticks: {
          autoSkip: false,
          maxRotation: 45,
          minRotation: 45
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
      }
    },
    cutout: 0, // Устанавливаем в 0 для создания полного круга
    radius: '90%' // Устанавливаем радиус
  };

  const totalHours = professors.reduce((sum, p) => 
    sum + calculateHours(p.load, dateRange), 0
  );
  const totalMaxHours = professors.reduce((sum, p) => 
    sum + calculateHours(MAX_HOURS, dateRange), 0
  );

  return (
    <div className={styles['stats-chart-block']}>
      <h3 className={styles['stats-chart-title']}>Нагрузка по кафедре</h3>
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
        <div>Всего часов: {totalHours}</div>
        <div>Доступно часов: {totalMaxHours - totalHours}</div>
        <div>Загруженность: {((totalHours / totalMaxHours) * 100).toFixed(1)}%</div>
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

DepartmentLoadChart.displayName = 'DepartmentLoadChart';
export default DepartmentLoadChart;
