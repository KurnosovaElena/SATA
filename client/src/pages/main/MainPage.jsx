import React, { useState }  from 'react';
import "./main.css"
import Button from "@mui/material/Button";
import { createTheme, ThemeProvider } from "@mui/material";
import Sidebar from "../components/sidebar/Sidebar";
import { Link } from 'react-router-dom';

function MainPage() {
  const [isSidebarOpen, setSidebarOpen] = useState(false);
  const [searchInputValue, setSearchInputValue] = useState('');

  const theme = createTheme({
    palette: {
      primary: {
        main: '#83A36B',
      },
    },
  });

  const toggleSidebar = () => {
    setSidebarOpen(!isSidebarOpen);
  };

  const closeSidebar = () => {
    setSidebarOpen(false);
  };
  

  return (
    <div className='main-page'>
      <Sidebar isOpen={isSidebarOpen} onClose={closeSidebar} />
      {isSidebarOpen && <div className="overlay active" onClick={toggleSidebar}></div>}
      <div className='content'>
        <div className="menu-lines" onClick={toggleSidebar}>
          <svg width="41" height="27" viewBox="0 0 41 27" fill="none" xmlns="http://www.w3.org/2000/svg">
            <path d="M3 13.6567H38.3008H3ZM3 24.3134H38.3008H3ZM3 3H38.3008H3Z" fill="#ABABAB" />
            <path d="M3 13.6567H38.3008M3 24.3134H38.3008M3 3H38.3008" stroke="#ABABAB" stroke-width="5" stroke-linecap="round" />
          </svg>
        </div>
        <div className="button-in">
          <ThemeProvider theme={theme}>
            <Button
              className="primary-button"
              variant="contained"
              sx={{ width: "100%", background: "#83A36B", fontFamily: "Montserrat", fontWeight: "bold", color: "white", borderRadius: "10px", }}
              type="submit"
              component={Link} to="/login"
            >
              Вход
            </Button>
          </ThemeProvider>
        </div>
      </div>
      <div className='main-page-content'>
        <div className="main-card">
          <div className="logo">
          <svg width="150" height="48" viewBox="0 0 150 48" fill="none" xmlns="http://www.w3.org/2000/svg">
              <path d="M2 2L2 46" stroke="#83A36B" stroke-width="4" stroke-linecap="round" />
              <path d="M9.436 22V2.4H18.564C20.8413 2.4 22.6147 2.83867 23.884 3.716C25.1533 4.59333 25.788 5.844 25.788 7.468C25.788 9.07333 25.1907 10.324 23.996 11.22C22.8013 12.0973 21.2147 12.536 19.236 12.536L19.768 11.36C21.9707 11.36 23.6787 11.7987 24.892 12.676C26.1053 13.5533 26.712 14.8227 26.712 16.484C26.712 18.2013 26.0587 19.5547 24.752 20.544C23.464 21.5147 21.5787 22 19.096 22H9.436ZM13.944 18.64H18.928C19.9733 18.64 20.7667 18.4347 21.308 18.024C21.8493 17.6133 22.12 16.9787 22.12 16.12C22.12 15.2987 21.8493 14.692 21.308 14.3C20.7667 13.8893 19.9733 13.684 18.928 13.684H13.944V18.64ZM13.944 10.52H18.172C19.1613 10.52 19.908 10.324 20.412 9.932C20.916 9.52133 21.168 8.924 21.168 8.14C21.168 7.356 20.916 6.768 20.412 6.376C19.908 5.96533 19.1613 5.76 18.172 5.76H13.944V10.52ZM34.4713 10.296H43.9073V13.824H34.4713V10.296ZM34.8073 18.36H45.4753V22H30.2993V2.4H45.1113V6.04H34.8073V18.36ZM49.1391 22V2.4H57.6231C59.3778 2.4 60.8898 2.68933 62.1591 3.268C63.4285 3.828 64.4085 4.64 65.0991 5.704C65.7898 6.768 66.1351 8.03733 66.1351 9.512C66.1351 10.968 65.7898 12.228 65.0991 13.292C64.4085 14.356 63.4285 15.1773 62.1591 15.756C60.8898 16.316 59.3778 16.596 57.6231 16.596H51.6591L53.6751 14.552V22H49.1391ZM53.6751 15.056L51.6591 12.9H57.3711C58.7711 12.9 59.8165 12.6013 60.5071 12.004C61.1978 11.4067 61.5431 10.576 61.5431 9.512C61.5431 8.42933 61.1978 7.58933 60.5071 6.992C59.8165 6.39467 58.7711 6.096 57.3711 6.096H51.6591L53.6751 3.94V15.056ZM66.9819 2.4H72.2179L76.2779 8.336L80.3379 2.4H85.6579L79.1339 11.78L86.1899 22H80.8419L76.2779 15.504L71.7699 22H66.5339L73.5339 11.976L66.9819 2.4ZM101.708 2.4H106.244V22H101.708V2.4ZM92.804 22H88.268V2.4H92.804V22ZM102.044 13.964H92.468V10.128H102.044V13.964ZM122.327 22V15.812L123.447 16.792H118.071C116.372 16.792 114.907 16.512 113.675 15.952C112.443 15.392 111.5 14.58 110.847 13.516C110.193 12.452 109.867 11.1827 109.867 9.708C109.867 8.17733 110.212 6.87067 110.903 5.788C111.612 4.68667 112.601 3.84667 113.871 3.268C115.14 2.68933 116.633 2.4 118.351 2.4H126.807V22H122.327ZM109.923 22L114.795 14.972H119.387L114.711 22H109.923ZM122.327 14.356V4.92L123.447 6.096H118.463C117.175 6.096 116.185 6.39467 115.495 6.992C114.823 7.58933 114.487 8.476 114.487 9.652C114.487 10.7907 114.813 11.668 115.467 12.284C116.12 12.9 117.081 13.208 118.351 13.208H123.447L122.327 14.356ZM142.889 22V15.812L144.009 16.792H138.633C136.935 16.792 135.469 16.512 134.237 15.952C133.005 15.392 132.063 14.58 131.409 13.516C130.756 12.452 130.429 11.1827 130.429 9.708C130.429 8.17733 130.775 6.87067 131.465 5.788C132.175 4.68667 133.164 3.84667 134.433 3.268C135.703 2.68933 137.196 2.4 138.913 2.4H147.369V22H142.889ZM130.485 22L135.357 14.972H139.949L135.273 22H130.485ZM142.889 14.356V4.92L144.009 6.096H139.025C137.737 6.096 136.748 6.39467 136.057 6.992C135.385 7.58933 135.049 8.476 135.049 9.652C135.049 10.7907 135.376 11.668 136.029 12.284C136.683 12.9 137.644 13.208 138.913 13.208H144.009L142.889 14.356Z" fill="#83A36B" />
              <path d="M22.876 25.4H27.412V45H22.876V25.4ZM13.972 45H9.436V25.4H13.972V45ZM23.212 36.964H13.636V33.128H23.212V36.964ZM33.0227 45V25.4H37.5307V38.168L46.8827 25.4H51.1387V45H46.6587V32.26L37.3067 45H33.0227ZM78.8948 45L73.6308 35.564L77.4668 33.352L84.1308 45H78.8948ZM70.2988 37.104V33.324H76.4028V37.104H70.2988ZM77.7188 35.704L73.5188 35.2L78.9788 25.4H83.7668L77.7188 35.704ZM59.8828 45H54.6468L61.3108 33.352L65.1468 35.564L59.8828 45ZM71.6428 45H67.1908V25.4H71.6428V45ZM68.5068 37.104H62.3748V33.324H68.5068V37.104ZM61.0868 35.704L55.0108 25.4H59.7988L65.2308 35.2L61.0868 35.704ZM100.445 25.4H104.981V45H100.445V25.4ZM91.5407 45H87.0047V25.4H91.5407V45ZM100.781 36.964H91.2047V33.128H100.781V36.964ZM121.763 45V38.812L122.883 39.792H117.507C115.809 39.792 114.343 39.512 113.111 38.952C111.879 38.392 110.937 37.58 110.283 36.516C109.63 35.452 109.303 34.1827 109.303 32.708C109.303 31.1773 109.649 29.8707 110.339 28.788C111.049 27.6867 112.038 26.8467 113.307 26.268C114.577 25.6893 116.07 25.4 117.787 25.4H126.243V45H121.763ZM109.359 45L114.231 37.972H118.823L114.147 45H109.359ZM121.763 37.356V27.92L122.883 29.096H117.899C116.611 29.096 115.622 29.3947 114.931 29.992C114.259 30.5893 113.923 31.476 113.923 32.652C113.923 33.7907 114.25 34.668 114.903 35.284C115.557 35.9 116.518 36.208 117.787 36.208H122.883L121.763 37.356ZM143.026 45V38.812L144.146 39.792H138.77C137.071 39.792 135.606 39.512 134.374 38.952C133.142 38.392 132.199 37.58 131.546 36.516C130.893 35.452 130.566 34.1827 130.566 32.708C130.566 31.1773 130.911 29.8707 131.602 28.788C132.311 27.6867 133.301 26.8467 134.57 26.268C135.839 25.6893 137.333 25.4 139.05 25.4H147.506V45H143.026ZM130.622 45L135.494 37.972H140.086L135.41 45H130.622ZM143.026 37.356V27.92L144.146 29.096H139.162C137.874 29.096 136.885 29.3947 136.194 29.992C135.522 30.5893 135.186 31.476 135.186 32.652C135.186 33.7907 135.513 34.668 136.166 35.284C136.819 35.9 137.781 36.208 139.05 36.208H144.146L143.026 37.356Z" fill="#ABABAB" />
            </svg>
          </div>
          <h1 className='hello'>Добро пожаловать, Гость</h1>
          <div className="search-bar">
            <div className="aw h">
              <div className="ab ax ay az ba q bb bc">
                <div className="bl" aria-hidden="false" aria-describedby="searchResults" aria-labelledby="searchResults">
                </div>
                <div className="bm bn ab">
                  <svg width="24" height="24" viewBox="0 0 24 24" border="1px solid">
                    <path fill-rule="evenodd" clip-rule="evenodd" d="M4.1 11.06a6.95 6.95 0 1 1 13.9 0 6.95 6.95 0 0 1-13.9 0zm6.94-8.05a8.05 8.05 0 1 0 5.13 14.26l3.75 3.75a.56.56 0 1 0 .8-.79l-3.74-3.73A8.05 8.05 0 0 0 11.04 3v.01z" fill="#ABABAB"></path>
                  </svg>
                </div>
                <input
                  role="combobox"
                  aria-controls="searchResults"
                  aria-expanded="false"
                  aria-label="search"
                  data-testid="headerSearchInput"
                  tabindex="0"
                  className="ax bd be bf z bg bh bi bj bk"
                  style={{ paddingLeft: "1px" }}
                  placeholder="Введите преподавателя"
                  value={searchInputValue}
                  onChange={(e) => setSearchInputValue(e.target.value)}
                />
              </div>
            </div>
          </div>
          <div className="tripple-bar">
            <div className="bar-course">
              <div className="bar-content">
                <div className="course">Курс</div>
                <div className="text-course">
                  <div className="mini-line">
                    <svg width="3" height="33" viewBox="0 0 3 33" fill="none" xmlns="http://www.w3.org/2000/svg">
                      <rect width="3" height="33" rx="1.5" fill="#ABABAB" />
                    </svg>
                  </div>
                  <span>1 курс</span>
                </div>
              </div>
            </div>
            <div className="bar-group">
              <div className="bar-content">
                <div className="course">Группа</div>
                <div className="text-course">
                  <div className="mini-line">
                    <svg width="3" height="33" viewBox="0 0 3 33" fill="none" xmlns="http://www.w3.org/2000/svg">
                      <rect width="3" height="33" rx="1.5" fill="#ABABAB" />
                    </svg>
                  </div>
                  <span>ПИР-211</span>
                </div>
              </div>
            </div>
            <div className="bar-minigroup">
              <div className="bar-content">
                <div className="course">Подгруппа</div>
                <div className="text-course">
                  <div className="mini-line">
                    <svg width="3" height="33" viewBox="0 0 3 33" fill="none" xmlns="http://www.w3.org/2000/svg">
                      <rect width="3" height="33" rx="1.5" fill="#ABABAB" />
                    </svg>
                  </div>
                  <span>Первая</span>
                </div>
              </div>
            </div>
          </div>
          <ThemeProvider theme={theme}>
            <Button
              className="main-button"
              variant="contained"
              sx={{ width: "55%", background: "#83A36B", fontFamily: "Montserrat", fontWeight: "bold", color: "white", borderRadius: "10px", }}
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

export default MainPage;