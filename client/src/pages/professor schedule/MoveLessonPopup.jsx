import React, { useState, useEffect } from 'react';
import './popup.css';

// dayNames и timeBlocks должны совпадать с ProfessorSchedulePage.jsx
const dayNames = ['Понедельник', 'Вторник', 'Среда', 'Четверг', 'Пятница', 'Суббота'];
const timeBlocks = [
    { timeUp: '08:30', timeDown: '10:05' },
    { timeUp: '10:25', timeDown: '12:00' },
    { timeUp: '12:30', timeDown: '14:05' },
    { timeUp: '14:20', timeDown: '15:55' },
    { timeUp: '16:05', timeDown: '17:40' },
    { timeUp: '17:50', timeDown: '19:25' }
];

const MoveLessonPopup = ({ isVisible, onClose, selectedPair, availableSlots, currentSlot, onMoveConfirm }) => {
    const [selectedDay, setSelectedDay] = useState(null);
    const [selectedSlot, setSelectedSlot] = useState(null);

    useEffect(() => {
        setSelectedDay(null);
        setSelectedSlot(null);
    }, [isVisible, selectedPair]);

    if (!isVisible || !selectedPair) return null;

    return (
        <div className="popup" onClick={onClose}>
            <div className="popup-content" onClick={e => e.stopPropagation()}>
                <h3>Перенос занятия</h3>
                <div className="popup-section">
                    <div><b>Текущее занятие:</b></div>
                    <div>{selectedPair.block.className} ({selectedPair.block.type})</div>
                    <div>Группа: {selectedPair.block.groupName}</div>
                    <div>День: {selectedPair.day}, Пара: {selectedPair.blockIdx + 1}</div>
                </div>
                <div className="popup-section">
                    <div><b>Выберите новый день и пару:</b></div>
                    <div className="move-calendar">
                        {dayNames.map((day, dIdx) => (
                            <div key={day} className="move-calendar-row">
                                <div className="move-calendar-dayname">{day}</div>
                                <div className="move-calendar-slots">
                                    {timeBlocks.map((tb, tIdx) => {
                                        const isAvailable = availableSlots?.[day]?.includes(tIdx);
                                        const isCurrent = currentSlot && day === currentSlot.day && tIdx === currentSlot.slot;
                                        return (
                                            <button
                                                key={tIdx}
                                                className={`move-slot-btn${isAvailable ? '' : ' disabled'}${selectedDay === day && selectedSlot === tIdx ? ' selected' : ''}${isCurrent ? ' current-slot' : ''}`}
                                                disabled={!isAvailable}
                                                onClick={() => {
                                                    setSelectedDay(day);
                                                    setSelectedSlot(tIdx);
                                                }}
                                            >
                                                {tIdx + 1}<br/>{tb.timeUp}-{tb.timeDown}
                                            </button>
                                        );
                                    })}
                                </div>
                            </div>
                        ))}
                    </div>
                </div>
                <div className="popup-actions">
                    <button onClick={onClose}>Отмена</button>
                    <button
                        onClick={() => {
                            if (selectedDay !== null && selectedSlot !== null) {
                                onMoveConfirm(selectedDay, selectedSlot);
                            }
                        }}
                        disabled={selectedDay === null || selectedSlot === null}
                    >
                        Перенести
                    </button>
                </div>
            </div>
        </div>
    );
};

export default MoveLessonPopup;
