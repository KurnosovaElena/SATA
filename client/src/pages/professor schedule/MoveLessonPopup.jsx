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

// ТЕСТОВЫЕ ГРАНИЦЫ СЕМЕСТРА (весь 2024-2025 год)
const SEMESTER_START = new Date(2024, 0, 1); // 1 января 2024
const SEMESTER_END = new Date(2025, 11, 31); // 31 декабря 2025

function getWeekTypeByIndex(weekIdx) {
    // 0 - верхняя, 1 - нижняя, 2 - верхняя и т.д.
    return weekIdx % 2 === 0 ? 'upper' : 'lower';
}
function getWeekLabel(weekType) {
    return weekType === 'upper' ? 'Верхняя неделя' : 'Нижняя неделя';
}

const MoveLessonPopup = ({ isVisible, onClose, selectedPair, availableSlots, currentSlot, onMoveConfirm, initialWeekIdx }) => {
    const today = new Date();
    // Вычисляем номер текущей недели семестра
    const baseMonday = startOfWeek(SEMESTER_START, { weekStartsOn: 1 });
    const currentWeekIdx = Math.max(0, differenceInCalendarWeeks(startOfWeek(today, { weekStartsOn: 1 }), baseMonday));
    const lastWeekIdx = Math.max(0, differenceInCalendarWeeks(startOfWeek(SEMESTER_END, { weekStartsOn: 1 }), baseMonday));

    const [weekIdx, setWeekIdx] = useState(initialWeekIdx ?? currentWeekIdx);
    const [selected, setSelected] = useState({ day: null, slot: null });
    const [error, setError] = useState("");

    useEffect(() => {
        setWeekIdx(initialWeekIdx ?? currentWeekIdx);
        setSelected({ day: null, slot: null });
        setError("");
    }, [isVisible, selectedPair, initialWeekIdx, currentWeekIdx]);

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
                    <button
                        className="move-arrow-btn"
                        onClick={() => { if (canGoPrev) { setWeekIdx(weekIdx - 1); setError(""); setSelected({ day: null, slot: null }); } }}
                        disabled={!canGoPrev}
                        tabIndex={0}
                        aria-label="Предыдущая неделя"
                    >&lt;</button>
                    <div style={{ minWidth: 180, textAlign: 'center' }}>
                        <b>{weekLabel}</b><br/>
                        {weekDates[0].toLocaleDateString('ru-RU')} — {weekDates[4].toLocaleDateString('ru-RU')}
                    </div>
                    <button
                        className="move-arrow-btn"
                        onClick={() => { if (canGoNext) { setWeekIdx(weekIdx + 1); setError(""); setSelected({ day: null, slot: null }); } }}
                        disabled={!canGoNext}
                        tabIndex={0}
                        aria-label="Следующая неделя"
                    >&gt;</button>
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
                                                onClick={() => { setError(""); if (isAvailable) setSelected({ day, slot: slotIdx }); }}
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
                            if (!selected.day || selected.slot === null) return;
                            const dateIdx = dayNames.indexOf(selected.day);
                            const date = weekDates[dateIdx];
                            const isPast = isBefore(date, today) && !isSameDay(date, today);
                            const isAvailable = !isPast && weekAvailableSlots[selected.day]?.includes(selected.slot);
                            // Проверка: выбран тот же слот, что и исходный
                            if (
                                currentSlot &&
                                String(weekType) === String(currentSlot.week) &&
                                selected.day === currentSlot.day &&
                                selected.slot === currentSlot.slot
                            ) {
                                setError("Выберите другую дату и пару для переноса.");
                                return;
                            }
                            if (!isAvailable) {
                                setError(isPast ? "Нельзя переносить на прошедшую дату." : "Этот слот недоступен для переноса.");
                                return;
                            }
                            // Проверка на границы семестра
                            if (date < SEMESTER_START || date > SEMESTER_END) {
                                setError("Нельзя переносить за пределы учебного семестра.");
                                return;
                            }
                            setError("");
                            console.log('[MoveLessonPopup] Кнопка Перенести:', { weekType, day: selected.day, slot: selected.slot, weekIdx, oldWeek: currentSlot?.week });
                            onMoveConfirm(weekType, selected.day, selected.slot, weekIdx, currentSlot?.week);
                        }}
                        disabled={!selected.day || selected.slot === null}
                    >
                        Перенести
                    </button>
                </div>
                {error && <div style={{ color: 'red', marginTop: 8, textAlign: 'center', fontWeight: 500 }}>{error}</div>}
            </div>
        </div>
    );
};

export default MoveLessonPopup;
