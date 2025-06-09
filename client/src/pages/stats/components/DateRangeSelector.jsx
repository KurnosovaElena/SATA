import React, { useState, useCallback } from 'react';
import DatePicker from 'react-datepicker';
import { registerLocale } from 'react-datepicker';
import ru from 'date-fns/locale/ru';
import "react-datepicker/dist/react-datepicker.css";
import styles from '../StatsPage.module.css';

registerLocale('ru', ru);

const DateRangeSelector = ({ onRangeChange }) => {
  const [dateRange, setDateRange] = useState([new Date(), new Date()]);
  const [startDate, endDate] = dateRange;
  const [startInput, setStartInput] = useState('');
  const [endInput, setEndInput] = useState('');
  const [isStartValid, setIsStartValid] = useState(true);
  const [isEndValid, setIsEndValid] = useState(true);

  const validateDate = (dateStr) => {
    const regex = /^(0[1-9]|[12][0-9]|3[01])\.(0[1-9]|1[0-2])\.\d{4}$/;
    if (!regex.test(dateStr)) return false;
    
    const [day, month, year] = dateStr.split('.').map(Number);
    const date = new Date(year, month - 1, day);
    return date.getDate() === day && 
           date.getMonth() === month - 1 && 
           date.getFullYear() === year;
  };

  const parseDate = (dateStr) => {
    const [day, month, year] = dateStr.split('.').map(Number);
    return new Date(year, month - 1, day);
  };

  const handleInputChange = useCallback((value, isStart) => {
    // Удаляем все нецифровые символы из ввода
    const digits = value.replace(/\D/g, '');
    
    // Форматируем строку с точками
    let formattedValue = '';
    if (digits.length > 0) {
      // Добавляем дни
      formattedValue = digits.substring(0, 2);
      if (digits.length > 2) {
        // Добавляем месяц
        formattedValue += '.' + digits.substring(2, 4);
        if (digits.length > 4) {
          // Добавляем год
          formattedValue += '.' + digits.substring(4, 8);
        }
      }
    }

    // Обновляем значение в соответствующем поле
    if (isStart) {
      setStartInput(formattedValue);
      if (formattedValue.length === 10) {
        const isValid = validateDate(formattedValue);
        setIsStartValid(isValid);
        if (isValid) {
          const newStartDate = parseDate(formattedValue);
          setDateRange([newStartDate, dateRange[1]]);
          onRangeChange([newStartDate, dateRange[1]]);
        }
      }
    } else {
      setEndInput(formattedValue);
      if (formattedValue.length === 10) {
        const isValid = validateDate(formattedValue);
        setIsEndValid(isValid);
        if (isValid) {
          const newEndDate = parseDate(formattedValue);
          setDateRange([dateRange[0], newEndDate]);
          onRangeChange([dateRange[0], newEndDate]);
        }
      }
    }
  }, [dateRange, onRangeChange]);

  const formatInputDate = (date) => {
    if (!date) return '';
    const day = date.getDate().toString().padStart(2, '0');
    const month = (date.getMonth() + 1).toString().padStart(2, '0');
    const year = date.getFullYear();
    return `${day}.${month}.${year}`;
  };

  const handleDatePickerChange = (update) => {
    setDateRange(update);
    if (update[0]) setStartInput(formatInputDate(update[0]));
    if (update[1]) setEndInput(formatInputDate(update[1]));
    onRangeChange && onRangeChange(update);
  };

  return (
    <div className={styles['date-range-container']}>
      <label className={styles['date-range-label']}>Период</label>
      <div className={styles['calendar-wrapper']}>
        <DatePicker
          selectsRange={true}
          startDate={startDate}
          endDate={endDate}
          onChange={handleDatePickerChange}
          inline
          locale="ru"
          calendarClassName={styles['react-datepicker']}
        />
      </div>
      <div className={styles['date-input-container']}>
        <input
          type="text"
          className={`${styles['date-input']} ${!isStartValid ? styles['invalid'] : ''}`}
          placeholder="ДДММГГГГ"
          value={startInput}
          onChange={(e) => handleInputChange(e.target.value, true)}
          maxLength={10}
        />
        <div className={styles['date-separator']}>по</div>
        <input
          type="text"
          className={`${styles['date-input']} ${!isEndValid ? styles['invalid'] : ''}`}
          placeholder="ДДММГГГГ"
          value={endInput}
          onChange={(e) => handleInputChange(e.target.value, false)}
          maxLength={10}
        />
      </div>
    </div>
  );
};

export default DateRangeSelector;