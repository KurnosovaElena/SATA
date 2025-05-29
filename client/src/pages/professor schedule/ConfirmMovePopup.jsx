import React, { useEffect, useRef, useState } from 'react';
import './popup.css';

const TIMER_MS = 5000;

const ConfirmMovePopup = ({
  isVisible,
  from,
  to,
  onUndo,
  onConfirm
}) => {
  const [progress, setProgress] = useState(100);
  const timerRef = useRef();
  const startTimeRef = useRef();

  useEffect(() => {
    if (!isVisible) return;
    setProgress(100);
    startTimeRef.current = Date.now();
    timerRef.current = setInterval(() => {
      const elapsed = Date.now() - startTimeRef.current;
      const percent = Math.max(0, 100 - (elapsed / TIMER_MS) * 100);
      setProgress(percent);
      if (elapsed >= TIMER_MS) {
        clearInterval(timerRef.current);
        onConfirm();
      }
    }, 30);
    return () => clearInterval(timerRef.current);
  }, [isVisible, onConfirm]);

  if (!isVisible) return null;

  return (
    <div className="popup" style={{zIndex: 2000}}>
      <div className="popup-content" style={{ minWidth: 340, maxWidth: 420, position: 'relative' }}>
        <div style={{ position: 'absolute', top: 0, left: 0, height: 5, width: '100%', background: '#eee', borderRadius: '8px 8px 0 0', overflow: 'hidden' }}>
          <div style={{ height: '100%', width: progress + '%', background: '#83A36B', transition: 'width 0.1s linear' }} />
        </div>
        <h3 style={{marginTop: 16}}>Перенос выполнен</h3>
        <div style={{margin: '18px 0', textAlign: 'center'}}>
          <div><b>Откуда:</b> {from.weekLabel}, {from.day}, пара {from.slot+1}</div>
          <div style={{fontSize: 22, margin: '8px 0'}}>→</div>
          <div><b>Куда:</b> {to.weekLabel}, {to.day}, пара {to.slot+1}</div>
        </div>
        <div className="popup-actions" style={{justifyContent: 'center'}}>
          <button onClick={onUndo} style={{background:'#eedc7c', color:'#222'}}>Отменить</button>
          <button onClick={onConfirm} style={{background:'#83A36B', color:'#fff'}}>Подтвердить</button>
        </div>
      </div>
    </div>
  );
};

export default ConfirmMovePopup;
