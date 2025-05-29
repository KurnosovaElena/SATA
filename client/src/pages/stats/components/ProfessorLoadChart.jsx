import React, { memo } from 'react';
import { Pie } from 'react-chartjs-2';
import '../chartConfig';
import styles from '../StatsPage.module.css';
import chartStyles from './ChartStyles.module.css';

const ProfessorLoadChart = memo(({ professor }) => {
  if (!professor) return null;

  const data = {
    labels: ['Загружено часов', 'Свободно'],
    datasets: [{
      data: [professor.hours, Math.max(200 - professor.hours, 0)],
      backgroundColor: ['#83A36B', '#E5E9E2'],
      borderWidth: 0,
    }],
  };

  const options = {
    animation: {
      animateScale: true,
      animateRotate: true,
      duration: 800,
      easing: 'easeInOutQuart'
    },
    plugins: {
      legend: {
        display: false,
      },
      tooltip: {
        enabled: true,
        animation: {
          duration: 150
        },
        callbacks: {
          label: (context) => {
            const value = context.raw;
            return `${value} часов`;
          }
        }
      }
    }
  };

  return (
    <div className={styles['stats-chart-block']}>      <h3 className={styles['stats-chart-title']}>Нагрузка преподавателя</h3>
      <div className={chartStyles['chart-container']}>
        <Pie 
          data={data} 
          options={{
            ...options,
            aspectRatio: 1, // Делаем диаграмму круглой
          }} 
        />
      </div>
      <span className={styles['stats-chart-info']}>
        {typeof professor.hours === 'number' ? `${professor.hours} ч. / 200 ч.` : '—'}
      </span>
    </div>
  );
});

ProfessorLoadChart.displayName = 'ProfessorLoadChart';
export default ProfessorLoadChart;
