import React, { useState, useEffect } from 'react';
import './popup.css';
import { addDays, startOfWeek, isBefore, isSameDay, addWeeks, differenceInCalendarWeeks } from 'date-fns';

const dayNames = ['Понедельник', 'Вторник', 'Среда', 'Четверг', 'Пятница'];
const timeBlocks = [
    { timeUp: '08:30', timeDown: '10:05' },
    { timeUp: '10:25', timeDown: '12:00' },
    { timeUp: '12:30', timeDown: '14:05' },
    { timeUp: '14:20', timeDown: '15:55' },
    { timeUp: '16:05', timeDown: '17:40' },
    { timeUp: '17:50', timeDown: '19:25' }
];

const SEMESTER_START = new Date(new Date().getFullYear(), 8, 1); // 1 сентября
const SEMESTER_END = new Date(new Date().getFullYear() + (new Date().getMonth() >= 8 ? 1 : 0), 5, 1); // 1 июня

function getWeekTypeByIndex(weekIdx) {
    // 0 - верхняя, 1 - нижняя, 2 - верхняя и т.д.
    return weekIdx % 2 === 0 ? 'upper' : 'lower';
}
function getWeekLabel(weekType) {
    return weekType === 'upper' ? 'Верхняя неделя' : 'Нижняя неделя';
}

const MoveLessonPopup = ({ isVisible, onClose, selectedPair, availableSlots, currentSlot, onMoveConfirm }) => {
    const today = new Date();
    // Вычисляем номер текущей недели семестра
    const baseMonday = startOfWeek(SEMESTER_START, { weekStartsOn: 1 });
    const currentWeekIdx = Math.max(0, differenceInCalendarWeeks(startOfWeek(today, { weekStartsOn: 1 }), baseMonday));
    const lastWeekIdx = Math.max(0, differenceInCalendarWeeks(startOfWeek(SEMESTER_END, { weekStartsOn: 1 }), baseMonday));

    const [weekIdx, setWeekIdx] = useState(currentWeekIdx);
    const [selected, setSelected] = useState({ day: null, slot: null });

    useEffect(() => {
        setWeekIdx(currentWeekIdx);
        setSelected({ day: null, slot: null });
    }, [isVisible, selectedPair]);

    if (!isVisible || !selectedPair) return null;

    // Даты для текущей недели
    const weekMonday = addWeeks(baseMonday, weekIdx);
    const weekDates = dayNames.map((_, idx) => addDays(weekMonday, idx));
    const weekType = getWeekTypeByIndex(weekIdx);
    const weekLabel = getWeekLabel(weekType);

    // Проверка: можно ли листать недели
    const canGoPrev = weekIdx > currentWeekIdx;
    const canGoNext = weekIdx < lastWeekIdx;

    // Доступные слоты для этой недели
    const weekAvailableSlots = availableSlots?.[weekType] || {};

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
                <div className="popup-section" style={{ display: 'flex', alignItems: 'center', justifyContent: 'center', gap: 16 }}>
                    <button onClick={() => canGoPrev && setWeekIdx(weekIdx - 1)} disabled={!canGoPrev}>&lt;</button>
                    <div style={{ minWidth: 180, textAlign: 'center' }}>
                        <b>{weekLabel}</b><br/>
                        {weekDates[0].toLocaleDateString('ru-RU')} — {weekDates[4].toLocaleDateString('ru-RU')}
                    </div>
                    <button onClick={() => canGoNext && setWeekIdx(weekIdx + 1)} disabled={!canGoNext}>&gt;</button>
                </div>
                <div className="move-calendar">
                    {dayNames.map((day, dayIdx) => {
                        const date = weekDates[dayIdx];
                        const isPast = isBefore(date, today) && !isSameDay(date, today);
                        return (
                            <div className="move-calendar-row" key={day}>
                                <div className="move-calendar-dayname">{day}<br/><span style={{ fontSize: 12, color: '#888' }}>{date.toLocaleDateString('ru-RU')}</span></div>
                                <div className="move-calendar-slots">
                                    {timeBlocks.map((tb, slotIdx) => {
                                        const isAvailable = !isPast && weekAvailableSlots[day]?.includes(slotIdx);
                                        const isCurrent = currentSlot && weekType === currentSlot.week && day === currentSlot.day && slotIdx === currentSlot.slot;
                                        const isSelected = selected.day === day && selected.slot === slotIdx;
                                        return (
                                            <button
                                                key={slotIdx}
                                                className={`move-slot-btn${isAvailable ? '' : ' disabled'}${isSelected ? ' selected' : ''}${isCurrent ? ' current-slot' : ''}`}
                                                disabled={!isAvailable}
                                                onClick={() => isAvailable && setSelected({ day, slot: slotIdx })}
                                            >
                                                {slotIdx + 1}<br/>{tb.timeUp}-{tb.timeDown}
                                            </button>
                                        );
                                    })}
                                </div>
                            </div>
                        );
                    })}
                </div>
                <div className="popup-actions">
                    <button onClick={onClose}>Отмена</button>
                    <button
                        onClick={() => {
                            if (selected.day && selected.slot !== null) {
                                onMoveConfirm(weekType, selected.day, selected.slot, weekIdx);
                            }
                        }}
                        disabled={!selected.day || selected.slot === null}
                    >
                        Перенести
                    </button>
                </div>
            </div>
        </div>
    );
};

export default MoveLessonPopup;
