import React, { useState } from 'react';
import styles from '../StatsPage.module.css';
import { saveAsDocx, saveAsExcel, saveAsPdf, downloadReport } from '../services/reportGenerator.jsx';

const ReportPreview = ({ onClose, reportType, reportContent }) => {
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
        return '';
    }
  };

  const handleDownload = () => {
    if (!reportContent) return;
    
    let fileName;
    switch (reportType) {
      case 'group':
        fileName = 'расписание_группы.txt';
        break;
      case 'subject':
        fileName = 'расписание_предмета.txt';
        break;
      case 'professor':
        fileName = 'нагрузка_преподавателя.txt';
        break;
      case 'classroom':
        fileName = 'занятость_аудитории.txt';
        break;
      case 'groupDay':
        fileName = 'количество_занятий.txt';
        break;
      default:
        fileName = 'отчет.txt';
    }
    
    downloadReport(reportContent, fileName);
  };
  const [selectedFormat, setSelectedFormat] = useState('txt');

  const handleFormatSelect = async (format) => {
    if (!reportContent) return;
    
    let fileName;
    switch (reportType) {
      case 'group':
        fileName = 'расписание_группы';
        break;
      case 'subject':
        fileName = 'расписание_предмета';
        break;
      case 'professor':
        fileName = 'нагрузка_преподавателя';
        break;
      case 'classroom':
        fileName = 'занятость_аудитории';
        break;
      case 'groupDay':
        fileName = 'количество_занятий';
        break;
      default:
        fileName = 'отчет';
    }

    switch (format) {
      case 'docx':
        await saveAsDocx(reportContent, `${fileName}.docx`);
        break;
      case 'xlsx':
        await saveAsExcel(reportContent, `${fileName}.xlsx`);
        break;
      case 'pdf':
        await saveAsPdf(reportContent, `${fileName}.pdf`);
        break;
      default:
        downloadReport(reportContent, `${fileName}.txt`);
    }
  };

  return (
    <div className={styles['modal-overlay']} onClick={onClose}>
      <div className={styles['modal-content']} onClick={e => e.stopPropagation()}>
        <h2>Предпросмотр отчета</h2>
        <p>Отчет по {getReportTypeName()}</p>
        <div className={styles['preview-content']}>
          <pre>{reportContent}</pre>
        </div>
        <div className={styles['format-buttons']}>
          <button 
            className={`${styles['format-button']} ${styles['format-button-blue']} ${selectedFormat === 'docx' ? styles['selected'] : ''}`}
            onClick={() => {
              setSelectedFormat('docx');
              handleFormatSelect('docx');
            }}
            disabled={!reportContent}
          >
            DOCX
          </button>
          <button 
            className={`${styles['format-button']} ${styles['format-button-green']} ${selectedFormat === 'xlsx' ? styles['selected'] : ''}`}
            onClick={() => {
              setSelectedFormat('xlsx');
              handleFormatSelect('xlsx');
            }}
            disabled={!reportContent}
          >
            XLSX
          </button>
          <button 
            className={`${styles['format-button']} ${styles['format-button-red']} ${selectedFormat === 'pdf' ? styles['selected'] : ''}`}
            onClick={() => {
              setSelectedFormat('pdf');
              handleFormatSelect('pdf');
            }}
            disabled={!reportContent}
          >
            PDF
          </button>
        </div>
        <div className={styles['modal-buttons']}>
          <button className={styles['close-button']} onClick={onClose}>
            Закрыть
          </button>
        </div>
      </div>
    </div>
  );
};

export default ReportPreview;
