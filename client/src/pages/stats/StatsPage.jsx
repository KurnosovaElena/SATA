import React, { useState, useMemo } from 'react';
import './chartConfig';
import styles from './StatsPage.module.css';
import departmentsData from './departments.test.json';
import ProfessorLoadChart from './components/ProfessorLoadChart';
import DepartmentLoadChart from './components/DepartmentLoadChart';

const StatsPage = () => {
  const [selectedDept, setSelectedDept] = useState('');
  const [selectedProfIdx, setSelectedProfIdx] = useState(0);

  const departments = departmentsData;
  const currentDept = useMemo(() => departments.find(d => d.name === selectedDept), [departments, selectedDept]);  const professors = useMemo(() => currentDept ? currentDept.professors : [], [currentDept]);
  const selectedProf = professors[selectedProfIdx] || null;

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
