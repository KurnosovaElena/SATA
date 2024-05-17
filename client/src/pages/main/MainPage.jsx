import React from 'react'
import "./main.css"
import Button from "@mui/material/Button";
import { createTheme, ThemeProvider } from "@mui/material";
import Menu from "../components/Menu"

function MainPage() {
  const theme = createTheme({
    palette: {
      primary: {
        main: "#83A36B",
      },
    }, 
  });

  return (
    <div className='main-page'>
      <Menu></Menu>
      <div className='main-page-content'>
        <div className="main-card">
          logo
          {/* "Гость" меняется на имя пользователя в зависимости от роли входа */}
          <h1>Добро пожаловать, Гость</h1>
          <div className="search-bar">
            <div className="aw h">
              <div className="ab ax ay az ba q bb bc">
                <div className="bl" aria-hidden="false" aria-describedby="searchResults" aria-labelledby="searchResults">
                </div>
                <div className="bm bn ab">
                  <svg width="24" height="24" viewBox="0 0 24 24" border="1px solid">
                    <path fill-rule="evenodd" clip-rule="evenodd" d="M4.1 11.06a6.95 6.95 0 1 1 13.9 0 6.95 6.95 0 0 1-13.9 0zm6.94-8.05a8.05 8.05 0 1 0 5.13 14.26l3.75 3.75a.56.56 0 1 0.8-.79l-3.74-3.73A8.05 8.05 0 0 0 11.04 3v.01z" fill="#ABABAB"></path>
                  </svg>
                </div>
                <input role="combobox" aria-controls="searchResults" aria-expanded="false" aria-label="search" data-testid="headerSearchInput" tabindex="0" className="ax bd be bf z bg bh bi bj bk" placeholder="Введите преподавателя" value="" />
              </div>
            </div>
          </div>
          <div className="tripple-bar">
            <div className="bar-course">1</div>
            <div className="bar-group">2</div>
            <div className="bar-minigroup">3</div>
          </div>
          <ThemeProvider theme={theme}>
          <Button
              className="main-button"
              variant="contained"
              sx={{ width: "55%" , background: "#83A36B", fontFamily: "Montserrat", fontWeight: "bold", color:"white", borderRadius: "10px", }}
              type="submit"
            >
              Подтвердить
            </Button>
            </ThemeProvider>
        </div>
      </div>
    </div>
  )
}

export default MainPage