import React, { useState, useMemo, useEffect } from 'react';
import './chartConfig';
import styles from './StatsPage.module.css';
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

const StatsPage = () => {
  const [selectedDept, setSelectedDept] = useState('');
  const [selectedProfIdx, setSelectedProfIdx] = useState(0);

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

  useEffect(() => {
    // Отладочный вывод для проверки данных
    console.log('Departments:', departments);
    console.log('Current Department:', currentDept);
    console.log('Selected Professor:', selectedProf);
  }, [departments, currentDept, selectedProf]);

  return (
    <div className={styles['stats-root']}>
      <div className={styles['stats-sidebar']}>
        <div>
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
          <div>
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
        )}
      </div>      <div className={styles['stats-charts']}>
        <div className={styles['stats-chart-wrapper']}>
          <ProfessorLoadChart professor={selectedProf} />
        </div>
        <div className={styles['stats-chart-wrapper']}>
          <DepartmentLoadChart professors={professors} />
        </div>
      </div>
      
      <div className={styles['reports-section']}>
        <h2 className={styles['reports-title']}>Генерация отчетов</h2>
        <div className={styles['reports-grid']}>          <button className={styles['report-button']} onClick={() => handleReportSelect('group')}>
            Отчет по расписанию подгруппы
          </button>
          <button className={styles['report-button']} onClick={() => handleReportSelect('subject')}>
            Отчет по расписанию предмета
          </button>
          <button className={styles['report-button']} onClick={() => handleReportSelect('professor')}>
            Отчет по нагрузке преподавателя
          </button>
          <button className={styles['report-button']} onClick={() => handleReportSelect('classroom')}>
            Отчет по занятости аудиторий
          </button>
          <button className={styles['report-button']} onClick={() => handleReportSelect('groupDay')}>
            Отчет по количеству занятий в день
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
