import React, { memo } from 'react';
import { Bar } from 'react-chartjs-2';
import { Chart as ChartJS } from 'chart.js/auto';
import '../chartConfig';
import styles from '../StatsPage.module.css';
import chartStyles from './ChartStyles.module.css';

const ProfessorLoadChart = memo(({ professor }) => {
  if (!professor) return null;

  const data = {
    labels: ['Нагрузка'],
    datasets: [{
      label: 'Академические часы',
      data: [professor.load],
      backgroundColor: 'rgba(131, 163, 107, 0.5)',
      borderColor: 'rgba(131, 163, 107, 1)',
      borderWidth: 1
    }]
  };

  const options = {
    responsive: true,
    maintainAspectRatio: false,
    animation: {
      duration: 1000, // Длительность анимации в мс
      easing: 'easeInOutQuart', // Тип анимации
    },
    plugins: {
      title: {
        display: true,
        text: `Нагрузка преподавателя ${professor.name}`
      }
    },
    scales: {
      y: {
        beginAtZero: true,
        title: {
          display: true,
          text: 'Часы'
        }
      }
    }
  };

  return (
    <div className={styles['stats-chart-block']}>
      <h3 className={styles['stats-chart-title']}>
        Нагрузка преподавателя
      </h3>
      <div className={chartStyles['chart-container']}>
        <Bar data={data} options={options} />
      </div>
      <div className={styles['stats-total-hours']}>
        Всего часов: {professor.load}
      </div>
    </div>
  );
});

ProfessorLoadChart.displayName = 'ProfessorLoadChart';
export default ProfessorLoadChart;
