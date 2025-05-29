import {
  Chart as ChartJS,
  ArcElement,
  Tooltip,
  Legend,
  Title,
  SubTitle
} from 'chart.js';

ChartJS.register(
  ArcElement,
  Tooltip,
  Legend,
  Title,
  SubTitle
);

// Отключаем анимацию по умолчанию для всех диаграмм
ChartJS.defaults.animation = false;
ChartJS.defaults.responsive = true;
ChartJS.defaults.maintainAspectRatio = false;

// Настраиваем глобальные стили для всех диаграмм
ChartJS.defaults.color = '#333';
ChartJS.defaults.font.family = 'Montserrat';
