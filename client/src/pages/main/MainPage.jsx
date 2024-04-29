import React from 'react'
import "./main.css"
import Menu from "../components/Menu"
function MainPage() {
  return (
    <div className='main-page'>
      <Menu></Menu>
      <div className='main-page-content'>
        main
      </div>
    </div>
  )
}

export default MainPage