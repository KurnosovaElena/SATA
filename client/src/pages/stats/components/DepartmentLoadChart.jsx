import React, { memo } from 'react';
import { Bar } from 'react-chartjs-2';
import { Chart as ChartJS } from 'chart.js/auto';
import '../chartConfig';
import styles from '../StatsPage.module.css';
import chartStyles from './ChartStyles.module.css';

const DepartmentLoadChart = memo(({ professors }) => {
  if (!professors?.length) return null;

  const data = {
    labels: professors.map(p => p.name),
    datasets: [{
      label: 'Нагрузка по кафедре',
      data: professors.map(p => p.load), // Изменено с hours на load
      backgroundColor: 'rgba(131, 163, 107, 0.5)',
      borderColor: 'rgba(131, 163, 107, 1)',
      borderWidth: 1
    }],
  };

  const options = {
    responsive: true,
    maintainAspectRatio: false,
    animation: {
      duration: 1000,
      easing: 'easeInOutQuart'
    },
    plugins: {
      title: {
        display: true,
        text: 'Распределение нагрузки по преподавателям'
      },
      legend: {
        display: false
      }
    },
    scales: {
      y: {
        beginAtZero: true,
        title: {
          display: true,
          text: 'Часы'
        }
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

  const totalHours = professors.reduce((sum, p) => 
    sum + (typeof p.load === 'number' ? p.load : 0), 0 // Изменено с hours на load
  );

  return (
    <div className={styles['stats-chart-block']}>
      <h3 className={styles['stats-chart-title']}>Нагрузка по кафедре</h3>
      <div className={chartStyles['chart-container-large']}>
        <Bar 
          data={data} 
          options={options} 
        />
      </div>
      <div className={styles['stats-chart-info']}>
        Всего часов: {totalHours}
      </div>
    </div>
  );
});

DepartmentLoadChart.displayName = 'DepartmentLoadChart';
export default DepartmentLoadChart;
