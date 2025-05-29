import React from 'react';
import "./up_down.css";

const ButtonUpDown = ({ label, isActive, onClick }) => {
  return (
    <button className={`custom-button ${isActive ? 'active' : ''}`} onClick={onClick}>
      {label}
    </button>
  );
};

export default ButtonUpDown;
