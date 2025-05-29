import React, { memo } from 'react';
import { Pie } from 'react-chartjs-2';
import '../chartConfig';
import styles from '../StatsPage.module.css';
import chartStyles from './ChartStyles.module.css';

const DepartmentLoadChart = memo(({ professors }) => {
  if (!professors?.length) return null;

  const data = {
    labels: professors.map(p => p.name),
    datasets: [{
      data: professors.map(p => p.hours),
      backgroundColor: ['#83A36B', '#B6C9A6', '#D1E2C4', '#E5E9E2', '#A3B18A', '#B7B7A4'],
      borderWidth: 0,
    }],
  };

  const options = {
    animation: {
      animateScale: true,
      animateRotate: true,
      duration: 1000,
      easing: 'easeOutCirc'
    },
    plugins: {
      legend: {
        position: 'bottom',
        labels: {
          font: {
            family: 'Montserrat',
            size: 14
          },
          padding: 20,
          animation: {
            duration: 500,
            easing: 'easeInOutQuad'
          }
        },
        onClick: null // Отключаем клики по легенде
      },
      tooltip: {
        animation: {
          duration: 150
        },
        callbacks: {
          label: (context) => {
            const value = context.raw;
            const percentage = ((value / context.dataset.data.reduce((a, b) => a + b, 0)) * 100).toFixed(1);
            return `${context.label}: ${value} часов (${percentage}%)`;
          }
        }
      }
    },
    hover: {
      animationDuration: 200
    }
  };

  const totalHours = professors.reduce((sum, p) => 
    sum + (typeof p.hours === 'number' ? p.hours : 0), 0
  );

  return (
    <div className={styles['stats-chart-block']}>      <h3 className={styles['stats-chart-title']}>Нагрузка по кафедре</h3>
      <div className={chartStyles['chart-container-large']}>
        <Pie 
          data={data} 
          options={{
            ...options,            plugins: {
              ...options.plugins,
              legend: {
                ...options.plugins.legend,
                position: 'right',
                align: 'center',
                labels: {
                  ...options.plugins.legend.labels,
                  boxWidth: 15,
                  font: {
                    family: 'Montserrat',
                    size: 13
                  },
                  padding: 15
                }
              }
            },
            layout: {
              padding: {
                right: 100 // Место для легенды справа
              }
            }
          }} 
        />
      </div>
      <span className={styles['stats-chart-info']}>
        {`Всего часов: ${totalHours}`}
      </span>
    </div>
  );
});

DepartmentLoadChart.displayName = 'DepartmentLoadChart';
export default DepartmentLoadChart;
