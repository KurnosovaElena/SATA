import React, { useState, useMemo, useEffect } from 'react';
import './chartConfig';
import styles from './StatsPage.module.css';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { 
  faUsers, 
  faBook, 
  faChalkboardTeacher, 
  faDoorOpen, 
  faCalendarCheck 
} from '@fortawesome/free-solid-svg-icons';
import { getProfessorsByDepartment } from './utils/dataExtractor';
import ProfessorLoadChart from './components/ProfessorLoadChart';
import DepartmentLoadChart from './components/DepartmentLoadChart';
import PreviewModal from './components/PreviewModal';
import ReportPreview from './components/ReportPreview';
import {
  generateGroupScheduleReport,
  generateSubjectScheduleReport,
  generateProfessorLoadReport,
  generateClassroomUsageReport,
  generateGroupDayLoadReport
} from './services/reportGenerator.jsx';
import DateRangeSelector from './components/DateRangeSelector';

const StatsPage = () => {
  const [selectedDept, setSelectedDept] = useState('');
  const [selectedProfIdx, setSelectedProfIdx] = useState(0);
  const [isLoading, setIsLoading] = useState(false);
  const [dateRange, setDateRange] = useState([new Date(), new Date()]);

  // Получаем данные напрямую из расписания
  const departments = useMemo(() => getProfessorsByDepartment(), []);
  const currentDept = useMemo(() => 
    departments.find(d => d.name === selectedDept), 
    [departments, selectedDept]
  );

  const professors = useMemo(() => currentDept ? currentDept.professors : [], [currentDept]);
  const selectedProf = professors[selectedProfIdx] || null;

  // Состояния для отчетов
  const [showParams, setShowParams] = useState(false);
  const [showPreview, setShowPreview] = useState(false);
  const [reportData, setReportData] = useState(null);
  const [reportType, setReportType] = useState('');

  const handleReportSelect = (type) => {
    setReportType(type);
    setShowParams(true);
  };

  const handleGenerateReport = (param) => {
    let report;
    switch (reportType) {
      case 'group':
        report = generateGroupScheduleReport(param);
        break;
      case 'subject':
        report = generateSubjectScheduleReport(param);
        break;
      case 'professor':
        report = generateProfessorLoadReport(param);
        break;
      case 'classroom':
        report = generateClassroomUsageReport(param);
        break;
      case 'groupDay':
        report = generateGroupDayLoadReport(param);
        break;
      default:
        return;
    }
    setReportData(report);
    setShowParams(false);
    setShowPreview(true);
  };

  const calculateHoursInRange = (load, range) => {
    if (!range[0] || !range[1]) return load;
    
    const [start, end] = range;
    const days = Math.ceil((end - start) / (1000 * 60 * 60 * 24));
    const weeks = Math.ceil(days / 7);
    
    // Предполагаем, что нагрузка равномерно распределена на учебный год (40 недель)
    return Math.round((load / 40) * weeks);
  };

  const handleDateRangeChange = (range) => {
    setIsLoading(true);
    setDateRange(range);
    
    setTimeout(() => {
      setIsLoading(false);
    }, 800);
  };

  useEffect(() => {
    // Отладочный вывод для проверки данных
    console.log('Departments:', departments);
    console.log('Current Department:', currentDept);
    console.log('Selected Professor:', selectedProf);
  }, [departments, currentDept, selectedProf]);

  return (    <div className={styles['stats-root']}>
      <div className={styles['stats-sidebar']}>
        <h2 className={styles['sidebar-title']}>
          <span className={styles['sidebar-title-top']}>Настройки</span>
          <span className={styles['sidebar-title-bottom']}>cтатистики</span>
        </h2>
        <div className={styles['department-block']}>
          <label className={styles['stats-label']}>Кафедра</label>
          <select
            value={selectedDept}
            onChange={e => { setSelectedDept(e.target.value); setSelectedProfIdx(0); }}
            className={styles['stats-select']}
          >
            <option value="" disabled>Выберите кафедру</option>
            {departments.map(d => (
              <option key={d.name} value={d.name}>
                {d.name}
              </option>
            ))}
          </select>
        </div>

        {currentDept && (
          <>
            <div className={styles['professor-block']}>
              <label className={styles['stats-label']}>Преподаватель</label>
              <div className={styles['stats-prof-slider']}>
                <button
                  onClick={() => setSelectedProfIdx(i => Math.max(i - 1, 0))}
                  disabled={selectedProfIdx === 0}
                  className={styles['stats-prof-btn']}
                >
                  &#8592;
                </button>
                <div className={styles['stats-prof-name']}>
                  {selectedProf?.name || '—'}
                </div>
                <button
                  onClick={() => setSelectedProfIdx(i => Math.min(i + 1, professors.length - 1))}
                  disabled={selectedProfIdx === professors.length - 1}
                  className={styles['stats-prof-btn']}
                >
                  &#8594;
                </button>
              </div>
            </div>
            <div className={styles['period-block']}>
              <DateRangeSelector onRangeChange={handleDateRangeChange} />
            </div>
          </>
        )}
      </div>      <div className={`${styles['stats-charts']} ${isLoading ? styles['stats-charts-loading'] : ''}`}>
        <div className={styles['stats-chart-wrapper']}>
          <ProfessorLoadChart 
            professor={selectedProf} 
            dateRange={dateRange}
            calculateHours={calculateHoursInRange}
          />
        </div>
        <div className={styles['stats-chart-wrapper']}>
          <DepartmentLoadChart 
            professors={professors}
            dateRange={dateRange}
            calculateHours={calculateHoursInRange}
          />
        </div>
      </div>
  
        <div className={styles['reports-section']}>
        <h2 className={styles['reports-title']}>
          <span className={styles['sidebar-title-top']}>Генерация</span>
          <span className={styles['sidebar-title-bottom']}>отчетов</span>
        </h2>
        <div className={styles['reports-grid']}>
          <button className={styles['report-button']} onClick={() => handleReportSelect('group')}>
            <div className={styles['report-button-icon']}>
              <FontAwesomeIcon icon={faUsers} />
            </div>
            <div className={styles['report-button-text']}>
              <span className={styles['report-button-title']}>Расписание подгруппы</span>
              <span className={styles['report-button-subtitle']}>Детальный отчет по занятиям</span>
            </div>
          </button>
          
          <button className={styles['report-button']} onClick={() => handleReportSelect('subject')}>
            <div className={styles['report-button-icon']}>
              <FontAwesomeIcon icon={faBook} />
            </div>
            <div className={styles['report-button-text']}>
              <span className={styles['report-button-title']}>Расписание предмета</span>
              <span className={styles['report-button-subtitle']}>График занятий по дисциплине</span>
            </div>
          </button>
          
          <button className={styles['report-button']} onClick={() => handleReportSelect('professor')}>
            <div className={styles['report-button-icon']}>
              <FontAwesomeIcon icon={faChalkboardTeacher} />
            </div>
            <div className={styles['report-button-text']}>
              <span className={styles['report-button-title']}>Нагрузка преподавателя</span>
              <span className={styles['report-button-subtitle']}>Анализ рабочих часов</span>
            </div>
          </button>
          
          <button className={styles['report-button']} onClick={() => handleReportSelect('classroom')}>
            <div className={styles['report-button-icon']}>
              <FontAwesomeIcon icon={faDoorOpen} />
            </div>
            <div className={styles['report-button-text']}>
              <span className={styles['report-button-title']}>Занятость аудиторий</span>
              <span className={styles['report-button-subtitle']}>Статистика использования</span>
            </div>
          </button>
          
          <button className={styles['report-button']} onClick={() => handleReportSelect('groupDay')}>
            <div className={styles['report-button-icon']}>
              <FontAwesomeIcon icon={faCalendarCheck} />
            </div>
            <div className={styles['report-button-text']}>
              <span className={styles['report-button-title']}>Количество занятий</span>
              <span className={styles['report-button-subtitle']}>Ежедневная статистика</span>
            </div>
          </button>
        </div>
      </div>      {showParams && (
        <PreviewModal
          onClose={() => setShowParams(false)}
          reportType={reportType}
          onGenerate={handleGenerateReport}
        />
      )}

      {showPreview && (
        <ReportPreview
          onClose={() => setShowPreview(false)}
          reportType={reportType}
          reportContent={reportData}
        />
      )}

      <div className={styles['logo-container']}>
        <div className={styles['logo-top']}>Генератор</div>
        <div className={styles['logo-bottom']}>статистики и отчетов</div>
      </div>
      
      <button
        className={styles['home-button']}
        onClick={() => window.location.href = '/'}
      >
        НА ГЛАВНУЮ
      </button>
    </div>
  );
};

export default StatsPage;
