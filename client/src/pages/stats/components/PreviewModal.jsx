import React, { useState } from 'react';
import styles from '../StatsPage.module.css';

// Параметры для выбора с использованием данных из приложения
const reportParams = {
  group: ['АСОИР-211', 'АСОИР-212', 'ПИР-211'], // добавляем новые группы
  subject: [
    'Физика',
    'Психология',
    'Программирование',
    'Право',
    'Философия',
    'Английский язык',
    'География',
    'Социология',
    'Математика',
    'Экономика',
    'Базы данных'
  ],
  professor: [
    'Сидоров С.С.',
    'Орлов Н.Ф.',
    'Морозова А.С.',
    'Иванов И.И.',
    'Соколов А.В.',
    'Зайцева Е.В.',
    'Ковалева М.С.',
    'Николаев Д.К.',
    'Петров П.П.',
    'Васильева О.Н.',
    'Крылов М.П.',
    'Громова В.П.'
  ],
  classroom: [
    '302/1', '301/1', '103/1', '205/2',
    '201/1', '202/1', '401/1', '306/2',
    '101/1', '405/2', '402/1'
  ],
  groupDay: ['АСОИР-211']
};

const PreviewModal = ({ onClose, reportType, onGenerate }) => {
  const [selectedParam, setSelectedParam] = useState('');

  const getReportTypeName = () => {
    switch (reportType) {
      case 'group':
        return 'расписанию подгруппы';
      case 'subject':
        return 'расписанию предмета';
      case 'professor':
        return 'нагрузке преподавателя';
      case 'classroom':
        return 'занятости аудиторий';
      case 'groupDay':
        return 'количеству занятий в день';
      default:
        return '';    }
  };
  
  return (
    <div className={styles['modal-overlay']} onClick={onClose}>
      <div className={styles['modal-content']} onClick={e => e.stopPropagation()}>
        <h2>Выберите параметры отчета</h2>
        <p>Отчет по {getReportTypeName()}</p>
        
        <div className={styles['params-section']}>
          <label className={styles['param-label']}>
            {reportType === 'group' && 'Выберите группу:'}
            {reportType === 'subject' && 'Выберите предмет:'}
            {reportType === 'professor' && 'Выберите преподавателя:'}
            {reportType === 'classroom' && 'Выберите аудиторию:'}
            {reportType === 'groupDay' && 'Выберите группу:'}
          </label>
          
          <select 
            className={styles['param-select']}
            value={selectedParam}
            onChange={(e) => setSelectedParam(e.target.value)}
          >
            <option value="">Выберите значение</option>
            {reportParams[reportType]?.map((param) => (
              <option key={param} value={param}>
                {param}
              </option>
            ))}
          </select>
        </div>

        <div className={styles['modal-buttons']}>
          <button 
            className={styles['generate-button']} 
            onClick={() => onGenerate(selectedParam)}
            disabled={!selectedParam}
          >
            Сгенерировать
          </button>
          <button 
            className={styles['close-button']} 
            onClick={onClose}
          >
            Отмена
          </button>
        </div>
      </div>
    </div>
  );
};

export default PreviewModal;
