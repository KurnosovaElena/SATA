import React from 'react';
import './daySchedule.css'; 

const DaySchedule = ({ dayName, schedule, isCurrentDay }) => {
    const getLineColor = (type) => {
        switch (type) {
            case 'lecture':
                return '#F5AC82';
            case 'practice':
                return '#EEDC7C';
            case 'no-class':
            default:
                return '#ABABAB';
        }
    };

    const getTextClass = (type) => {
        switch (type) {
            case 'lecture':
                return 'lecture';
            case 'practice':
                return 'practice';
            case 'no-class':
            default:
                return 'no-class';
        }
    };

    return (
        <div className={`schedule-day ${isCurrentDay ? 'current-day' : ''}`}>
            <div className="hat">
                <p>{dayName}</p>
                <div className="line-days-gor">
                    <svg width="180" height="2" viewBox="0 0 180 2" fill="none" xmlns="http://www.w3.org/2000/svg">
                        <line x1="1" y1="1" x2="199" y2="1" stroke="#ABABAB" stroke-opacity="0.3" stroke-width="2" stroke-linecap="round" />
                    </svg>
                </div>
            </div>
            {schedule.map((par, index) => (
                <div key={index} className={`par-${index + 1}`}>
                    <div className="line">
                        <svg width="3" height="76" viewBox="0 0 3 76" fill="none" xmlns="http://www.w3.org/2000/svg">
                            <rect width="3" height="76" rx="1.5" fill={getLineColor(par.type)} />
                        </svg>
                    </div>
                    <div className="class-content">
                        <div className="name-and-professor">
                            <div className={`classname ${getTextClass(par.type)}`}>
                                <p>{par.className}</p>
                            </div>
                            <div className="professor-name">
                                <p>{par.professorName}</p>
                            </div>
                        </div>
                        <div className="classroom">
                            {par.classroom}
                        </div>
                    </div>
                </div>
            ))}
        </div>
    );
};

export default DaySchedule;