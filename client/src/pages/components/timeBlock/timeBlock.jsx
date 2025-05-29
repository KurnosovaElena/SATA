import React, { useEffect, useState } from 'react';
import './timeBlock.css'; 

const TimeBlock = ({ timeUp, timeDown }) => {
    const [isCurrent, setIsCurrent] = useState(false);

    useEffect(() => {
        const checkCurrentTimeBlock = () => {
            const currentTime = new Date();
            const currentHours = currentTime.getHours();
            const currentMinutes = currentTime.getMinutes();

            const [startHours, startMinutes] = timeUp.split(':').map(Number);
            const [endHours, endMinutes] = timeDown.split(':').map(Number);

            const startMinutesTotal = startHours * 60 + startMinutes;
            const endMinutesTotal = endHours * 60 + endMinutes;
            const currentMinutesTotal = currentHours * 60 + currentMinutes;

            if (currentMinutesTotal >= startMinutesTotal && currentMinutesTotal <= endMinutesTotal) {
                setIsCurrent(true);
            } else {
                setIsCurrent(false);
            }
        };

        checkCurrentTimeBlock();
        const intervalId = setInterval(checkCurrentTimeBlock, 60000); // Check every minute

        return () => clearInterval(intervalId);
    }, [timeUp, timeDown]);

    return (
        <div className={`par-time ${isCurrent ? 'current-time' : ''}`}>
            <div className="line">
                <svg width="3" height="76" viewBox="0 0 3 76" fill="none" xmlns="http://www.w3.org/2000/svg">
                    <rect width="3" height="76" rx="1.5" fill={isCurrent ? 'green' : '#ABABAB'} />
                </svg>
            </div>
            <div className="time">
                <div className="time-up">{timeUp}</div>
                <div className="time-down">{timeDown}</div>
            </div>
        </div>
    );
};

export default TimeBlock;