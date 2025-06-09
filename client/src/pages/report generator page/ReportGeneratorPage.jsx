import React, { useState, useEffect, useRef } from 'react';
import "./reportgenerator.css";
import Sidebar from "../components/sidebar/Sidebar";
import { Link } from 'react-router-dom';
import PreviewModal from '../stats/components/PreviewModal';
import {
  generateGroupScheduleReport,
  generateSubjectScheduleReport,
  generateProfessorLoadReport,
  generateClassroomUsageReport,
  generateGroupDayLoadReport
} from '../stats/services/ReportGenerator';

function ReportGeneratorPage() {
    const [isSidebarOpen, setSidebarOpen] = useState(false);
    const [isPreviewVisible, setPreviewVisible] = useState(false);
    const [reportData, setReportData] = useState(null);
    const [reportType, setReportType] = useState('');
    const reportTypesRef = useRef(null);

    const handleGroupReport = () => {
      const group = prompt("Введите название группы:");
      if (group) {
        const report = generateGroupScheduleReport(group);
        setReportData(report);
        setReportType('group');
        setPreviewVisible(true);
      }
    };

    const handleSubjectReport = () => {
      const subject = prompt("Введите название предмета:");
      if (subject) {
        const report = generateSubjectScheduleReport(subject);
        setReportData(report);
        setReportType('subject');
        setPreviewVisible(true);
      }
    };

    const handleProfessorReport = () => {
      const professor = prompt("Введите ФИО преподавателя:");
      if (professor) {
        const report = generateProfessorLoadReport(professor);
        setReportData(report);
        setReportType('professor');
        setPreviewVisible(true);
      }
    };

    const handleClassroomReport = () => {
      const classroom = prompt("Введите номер аудитории:");
      if (classroom) {
        const report = generateClassroomUsageReport(classroom);
        setReportData(report);
        setReportType('classroom');
        setPreviewVisible(true);
      }
    };

    const handleGroupDayReport = () => {
      const group = prompt("Введите название группы:");
      if (group) {
        const report = generateGroupDayLoadReport(group);
        setReportData(report);
        setReportType('groupDay');
        setPreviewVisible(true);
      }
    };

    useEffect(() => {
      const handleWheel = (event) => {
        if (reportTypesRef.current) {
          event.preventDefault();
          reportTypesRef.current.scrollLeft += event.deltaY;
        }
      };
  
      const reportTypesElement = reportTypesRef.current;
      if (reportTypesElement) {
        reportTypesElement.addEventListener('wheel', handleWheel);
      }
  
      return () => {
        if (reportTypesElement) {
          reportTypesElement.removeEventListener('wheel', handleWheel);
        }
      };
    }, []);
  
    const toggleSidebar = () => {
      setSidebarOpen(!isSidebarOpen);
    };
  
    const closeSidebar = () => {
      setSidebarOpen(false);
    };

    return (
      <div className="report-page">
        <Sidebar isOpen={isSidebarOpen} onClose={closeSidebar} />
        {isSidebarOpen && <div className="overlay active" onClick={toggleSidebar}></div>}
        <div className="report-header">
          <div className="header-left">
            <div className="menu-icon" onClick={toggleSidebar}>
              <svg width="41" height="27" viewBox="0 0 41 27" fill="none" xmlns="http://www.w3.org/2000/svg">
                <path d="M3 13.6567H38.3008H3ZM3 24.3134H38.3008H3ZM3 3H38.3008H3Z" fill="#ABABAB" />
                <path d="M3 13.6567H38.3008M3 24.3134H38.3008M3 3H38.3008" stroke="#ABABAB" strokeWidth="5" strokeLinecap="round" />
              </svg>
            </div>
          </div>
          <div className="header-right">
            <Link to="/">
              <div className="profile-icon">
                <svg className="default-icon" width="186" height="48" viewBox="0 0 186 48" fill="none" xmlns="http://www.w3.org/2000/svg">
                  <path d="M2 2L2 46" stroke="#83A36B" strokeWidth="4" strokeLinecap="round"/>
                </svg>
              </div>
            </Link>
          </div>
        </div>

        <div className="report-content">
          <div className="report-card">
            <h1 className="report-title">Отчет</h1>
            <div className="report-selection">
              <h2 className="report-selection-title">Выберите необходимый отчет</h2>
              <div className="report-types" ref={reportTypesRef}>
                <div className="report-type">
                  <button className="report-button" onClick={handleGroupReport}>
                    <div className="report-icon">
                      <img src={require('./report1.png')} alt="Иконка отчета" />
                    </div>
                    <div className="report-text">Отчет по расписанию подгруппы</div>
                  </button>
                </div>
                <div className="report-type">
                  <button className="report-button" onClick={handleSubjectReport}>
                    <div className="report-icon">
                      <img src={require('./report2.png')} alt="Иконка отчета" />
                    </div>
                    <div className="report-text">Отчет по расписанию предмета</div>
                  </button>
                </div>
                <div className="report-type">
                  <button className="report-button" onClick={handleProfessorReport}>
                    <div className="report-icon">
                      <img src={require('./report3.png')} alt="Иконка отчета" />
                    </div>
                    <div className="report-text">Отчет по нагрузке преподавателя</div>
                  </button>
                </div>
                <div className="report-type">
                  <button className="report-button" onClick={handleClassroomReport}>
                    <div className="report-icon">
                      <img src={require('./report4.png')} alt="Иконка отчета" />
                    </div>
                    <div className="report-text">Отчет по занятости аудиторий</div>
                  </button>
                </div>
                <div className="report-type">
                  <button className="report-button" onClick={handleGroupDayReport}>
                    <div className="report-icon">
                      <img src={require('./report5.png')} alt="Иконка отчета" />
                    </div>
                    <div className="report-text">Отчет по количеству занятий в день</div>
                  </button>
                </div>
              </div>
            </div>
          </div>
        </div>

        {isPreviewVisible && (
          <PreviewModal
            onClose={() => setPreviewVisible(false)}
            reportType={reportType}
            reportContent={reportData}
          />
        )}
      </div>
    );
}

export default ReportGeneratorPage;
