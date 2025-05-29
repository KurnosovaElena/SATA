import React from 'react';
import './popup.css';

const weekLabel = (w) => w === 'upper' ? 'Верхняя' : w === 'lower' ? 'Нижняя' : w;

const AuditLogPopup = ({ isVisible, onClose }) => {
  if (!isVisible) return null;
  const logs = JSON.parse(localStorage.getItem('lessonMoveAudit') || '[]').sort((a, b) => new Date(b.timestamp) - new Date(a.timestamp));
  return (
    <div className="popup" style={{zIndex: 3000}}>
      <div className="popup-content" style={{minWidth: 420, maxWidth: 700, maxHeight: '80vh', overflowY: 'auto', position: 'relative'}}>
        <button className="popup-close-btn" style={{position:'absolute',top:14,right:18,zIndex:2,fontSize:22,background:'none',border:'none',cursor:'pointer',color:'#888',fontWeight:600}} onClick={onClose} aria-label="Закрыть журнал">✕</button>
        <h3 style={{marginBottom: 12, textAlign:'center'}}>Журнал переносов занятий</h3>
        <div style={{fontSize: 14, color: '#666', marginBottom: 10}}>Всего записей: {logs.length}</div>
        <table style={{width:'100%', fontSize:15, borderCollapse:'collapse'}}>
          <thead>
            <tr style={{background:'#f5f5f5'}}>
              <th style={{padding:4}}>Дата/время</th>
              <th>Преподаватель</th>
              <th>Группа</th>
              <th>Дисциплина</th>
              <th>Откуда</th>
              <th>Куда</th>
            </tr>
          </thead>
          <tbody>
            {logs.map(log => (
              <tr key={log.id} style={{borderBottom:'1px solid #eee'}}>
                <td style={{padding:4}}>{new Date(log.timestamp).toLocaleString('ru-RU')}</td>
                <td>{log.professor}</td>
                <td>{log.group}</td>
                <td>{log.subject}</td>
                <td>{weekLabel(log.old.week)}, {log.old.day}, {log.old.slot+1}</td>
                <td>{weekLabel(log.new.week)}, {log.new.day}, {log.new.slot+1}</td>
              </tr>
            ))}
          </tbody>
        </table>
        {logs.length === 0 && <div style={{margin:'24px 0',textAlign:'center',color:'#888'}}>Журнал пуст</div>}
      </div>
    </div>
  );
};

export default AuditLogPopup;
