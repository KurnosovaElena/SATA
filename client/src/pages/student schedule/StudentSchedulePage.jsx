import React from 'react'
import Menu from '../components/menu/Menu'
import "./studentschedulePage.css"

function StudentSchedulePage() {
    return (
        <div className="studentschedulepage">
            <Menu></Menu>
            <div className="students-content">
                <div className="student-schedule-time">
                    <p>Время</p>
                    <div className="line-under">
                        <svg width="87" height="2" viewBox="0 0 87 2" fill="none" xmlns="http://www.w3.org/2000/svg">
                            <path d="M1 1L85.5 1" stroke="#ABABAB" stroke-opacity="0.3" stroke-width="2" stroke-linecap="round" />
                        </svg>
                    </div>
                    <div className="par">
                        <div className="par-1-time">
                            <div className="line">
                                <svg width="3" height="76" viewBox="0 0 3 76" fill="none" xmlns="http://www.w3.org/2000/svg">
                                    <rect width="3" height="76" rx="1.5" fill="#ABABAB" />
                                </svg>
                            </div>
                            <div className="time">
                                <div className="time-up">08:30</div>
                                <div className="time-down">10:05</div>
                            </div>
                        </div>
                    </div>
                    <div className="par">
                        <div className="par-2-time">
                            <div className="line">
                                <svg width="3" height="76" viewBox="0 0 3 76" fill="none" xmlns="http://www.w3.org/2000/svg">
                                    <rect width="3" height="76" rx="1.5" fill="#ABABAB" />
                                </svg>
                            </div>
                            <div className="time">
                                <div className="time-up">10:25</div>
                                <div className="time-down">12:00</div>
                            </div>
                        </div>
                    </div>
                    <div className="par">
                        <div className="par-3-time">
                            <div className="line">
                                <svg width="3" height="76" viewBox="0 0 3 76" fill="none" xmlns="http://www.w3.org/2000/svg">
                                    <rect width="3" height="76" rx="1.5" fill="#ABABAB" />
                                </svg>
                            </div>
                            <div className="time">
                                <div className="time-up">12:30</div>
                                <div className="time-down">14:05</div>
                            </div>
                        </div>
                    </div>
                    <div className="par">
                        <div className="par-4-time">
                            <div className="line">
                                <svg width="3" height="76" viewBox="0 0 3 76" fill="none" xmlns="http://www.w3.org/2000/svg">
                                    <rect width="3" height="76" rx="1.5" fill="#ABABAB" />
                                </svg>
                            </div>
                            <div className="time">
                                <div className="time-up">14:20</div>
                                <div className="time-down">15:55</div>
                            </div>
                        </div>
                    </div>
                    <div className="par">
                        <div className="par-5-time">
                            <div className="line">
                                <svg width="3" height="76" viewBox="0 0 3 76" fill="none" xmlns="http://www.w3.org/2000/svg">
                                    <rect width="3" height="76" rx="1.5" fill="#ABABAB" />
                                </svg>
                            </div>
                            <div className="time">
                                <div className="time-up">16:05</div>
                                <div className="time-down">17:40</div>
                            </div>
                        </div>
                    </div>
                    <div className="par">
                        <div className="par-6-time">
                            <div className="line">
                                <svg width="3" height="76" viewBox="0 0 3 76" fill="none" xmlns="http://www.w3.org/2000/svg">
                                    <rect width="3" height="76" rx="1.5" fill="#ABABAB" />
                                </svg>
                            </div>
                            <div className="time">
                                <div className="time-up">17:50</div>
                                <div className="time-down">19:25</div>
                            </div>
                        </div>
                    </div>
                </div>
                <div className="student-schedule-days">
                    <div className="schedule-day-monday">monday
                        <div className="par-1">1</div>
                        <div className="par-2">2</div>
                        <div className="par-3">3</div>
                        <div className="par-4">4</div>
                        <div className="par-5">5</div>
                        <div className="par-6">6</div>
                    </div>
                    <div className="schedule-day-tuesday">tuesday
                        <div className="par-1">1</div>
                        <div className="par-2">2</div>
                        <div className="par-3">3</div>
                        <div className="par-4">4</div>
                        <div className="par-5">5</div>
                        <div className="par-6">6</div>
                    </div>
                    <div className="schedule-day-wednesday">wednesday
                        <div className="par-1">1</div>
                        <div className="par-2">2</div>
                        <div className="par-3">3</div>
                        <div className="par-4">4</div>
                        <div className="par-5">5</div>
                        <div className="par-6">6</div>
                    </div>
                    <div className="schedule-day-thursday">thursday
                        <div className="par-1">1</div>
                        <div className="par-2">2</div>
                        <div className="par-3">3</div>
                        <div className="par-4">4</div>
                        <div className="par-5">5</div>
                        <div className="par-6">6</div>
                    </div>
                    <div className="schedule-day-friday">friday
                        <div className="par-1">1</div>
                        <div className="par-2">2</div>
                        <div className="par-3">3</div>
                        <div className="par-4">4</div>
                        <div className="par-5">5</div>
                        <div className="par-6">6</div>
                    </div>
                    <div className="schedule-day-saturday">saturday
                        <div className="par-1">1</div>
                        <div className="par-2">2</div>
                        <div className="par-3">3</div>
                        <div className="par-4">4</div>
                        <div className="par-5">5</div>
                        <div className="par-6">6</div>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default StudentSchedulePage