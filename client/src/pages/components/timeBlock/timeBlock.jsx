import React from 'react';
import './timeBlock.css'; 

const TimeBlock = ({ timeUp, timeDown, isCurrent }) => {
    return (
        <div className={`par ${isCurrent ? 'current-time' : ''}`}>
            <div className="par-time">
                <div className="line">
                    <svg width="3" height="76" viewBox="0 0 3 76" fill="none" xmlns="http://www.w3.org/2000/svg">
                        <rect width="3" height="76" rx="1.5" fill="#ABABAB" />
                    </svg>
                </div>
                <div className="time">
                    <div className="time-up">{timeUp}</div>
                    <div className="time-down">{timeDown}</div>
                </div>
            </div>
        </div>
    );
};

export default TimeBlock;