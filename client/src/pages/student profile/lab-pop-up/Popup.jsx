import React, { useState } from 'react';
import './popup.css';

const Popup = ({ isVisible, onClose, subjects, setSubjects }) => {
  const handleAddSubject = () => {
    const newSubject = { name: '', labCount: 0, labs: [] };
    setSubjects([...subjects, newSubject]);
  };

  const handleChangeName = (index, newName) => {
    const newSubjects = [...subjects];
    newSubjects[index].name = newName;
    setSubjects(newSubjects);
  };

  const handleChangeLabCount = (index, newLabCount) => {
    const newSubjects = [...subjects];
    newSubjects[index].labCount = newLabCount;
    newSubjects[index].labs = Array.from({ length: newLabCount }, (_, i) => ({
      number: i + 1,
      completed: false,
    }));
    setSubjects(newSubjects);
  };

  const handleToggleLabCompletion = (subjectIndex, labIndex) => {
    const newSubjects = [...subjects];
    newSubjects[subjectIndex].labs[labIndex].completed = !newSubjects[subjectIndex].labs[labIndex].completed;
    setSubjects(newSubjects);
  };

  const handleRemoveSubject = (index) => {
    const newSubjects = [...subjects];
    newSubjects.splice(index, 1);
    setSubjects(newSubjects);
  };

  const handleAddLab = (subjectIndex) => {
    const newSubjects = [...subjects];
    const newLabCount = newSubjects[subjectIndex].labs.length + 1;
    newSubjects[subjectIndex].labs.push({ number: newLabCount, completed: false });
    setSubjects(newSubjects);
  };

  const handleRemoveLab = (subjectIndex) => {
    const newSubjects = [...subjects];
    if (newSubjects[subjectIndex].labs.length > 0) {
      newSubjects[subjectIndex].labs.pop();
      setSubjects(newSubjects);
    }
  };

  if (!isVisible) return null;

  return (
    <div className="popup" onClick={onClose}>
      <div className="popup-content" onClick={(e) => e.stopPropagation()}>
        <div className="popup-header">
          <div className="lab-work-header">
            <div className="lab-work-icon">
              <svg width="25" height="25" viewBox="0 0 25 25" fill="none" xmlns="http://www.w3.org/2000/svg">
                <path d="M23 10.1667V21.25C23 22.2165 22.2165 23 21.25 23H3.75C2.7835 23 2 22.2165 2 21.25V3.75C2 2.7835 2.7835 2 3.75 2H16" stroke="black" strokeWidth="2.33333" strokeLinecap="round" strokeLinejoin="round" />
                <path d="M7.8335 10.1666L13.6668 14.8333L22.4168 2.58331" stroke="black" strokeWidth="2.33333" strokeLinecap="round" strokeLinejoin="round" />
              </svg>
            </div>
            <h3 className="popup-section-title">Лабораторные работы</h3>
          </div>
          <button className="add-subject" onClick={handleAddSubject}>Добавить предмет</button>
        </div>
        <div className="subjects-container">
          {subjects.map((subject, subjectIndex) => (
            <div className="subject-block" key={subjectIndex}>
              <input
                type="text"
                value={subject.name}
                onChange={(e) => handleChangeName(subjectIndex, e.target.value)}
                placeholder="Название предмета"
                className="subject-name-input"
              />
              <div className="labs-container">
                {subject.labs.map((lab, labIndex) => (
                  <div
                    key={labIndex}
                    className={`lab-circle ${lab.completed ? 'completed' : ''}`}
                    onClick={() => handleToggleLabCompletion(subjectIndex, labIndex)}
                  >
                    {lab.number}
                  </div>
                ))}
                {subject.labs.length < 12 && (
                  <div
                    className="lab-circle add-lab"
                    onClick={() => handleAddLab(subjectIndex)}
                  >
                    +
                  </div>
                )}
                {subject.labs.length > 0 && (
                  <div
                    className="lab-circle remove-lab"
                    onClick={() => handleRemoveLab(subjectIndex)}
                  >
                    -
                  </div>
                )}
              </div>
              <button className="remove-subject" onClick={() => handleRemoveSubject(subjectIndex)}>Удалить предмет</button>
            </div>
          ))}
        </div>
      </div>
    </div>
  );
};

export default Popup;
