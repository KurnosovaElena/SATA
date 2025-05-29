import React, { useState } from "react";
import TextField from "@mui/material/TextField";
import { createTheme, ThemeProvider } from "@mui/material";
import Button from "@mui/material/Button";
import Sidebar from "../pages/components/sidebar/Sidebar";
// import InputAdornment from '@mui/material/InputAdornment';
// import AccountCircle from '@mui/icons-material/AccountCircle';
import "./login.css"

function Login_page() {
  const [isSidebarOpen, setIsSidebarOpen] = useState(false);

  const toggleSidebar = () => {
    setIsSidebarOpen(!isSidebarOpen);
  };

  const theme = createTheme({
    palette: {
      primary: {
        main: "#83A36B",
      },
    },
  });

  return (
    <ThemeProvider theme={theme}>
      <div className="authentication">
        <Sidebar isOpen={isSidebarOpen} toggleSidebar={toggleSidebar} />
        {isSidebarOpen && <div className="overlay active" onClick={toggleSidebar}></div>}
        <div className="authentication-form card">
          <div className="card-title">
            <svg
              width="140"
              height="48"
              viewBox="0 0 150 48"
              fill="none"
              xmlns="http://www.w3.org/2000/svg"
            >
              <path
                d="M2 2L2 46"
                stroke="#83A36B"
                stroke-width="4"
                stroke-linecap="round"
              />
              <path
                d="M9.436 22V2.4H18.564C20.8413 2.4 22.6147 2.83867 23.884 3.716C25.1533 4.59333 25.788 5.844 25.788 7.468C25.788 9.07333 25.1907 10.324 23.996 11.22C22.8013 12.0973 21.2147 12.536 19.236 12.536L19.768 11.36C21.9707 11.36 23.6787 11.7987 24.892 12.676C26.1053 13.5533 26.712 14.8227 26.712 16.484C26.712 18.2013 26.0587 19.5547 24.752 20.544C23.464 21.5147 21.5787 22 19.096 22H9.436ZM13.944 18.64H18.928C19.9733 18.64 20.7667 18.4347 21.308 18.024C21.8493 17.6133 22.12 16.9787 22.12 16.12C22.12 15.2987 21.8493 14.692 21.308 14.3C20.7667 13.8893 19.9733 13.684 18.928 13.684H13.944V18.64ZM13.944 10.52H18.172C19.1613 10.52 19.908 10.324 20.412 9.932C20.916 9.52133 21.168 8.924 21.168 8.14C21.168 7.356 20.916 6.768 20.412 6.376C19.908 5.96533 19.1613 5.76 18.172 5.76H13.944V10.52ZM34.4713 10.296H43.9073V13.824H34.4713V10.296ZM34.8073 18.36H45.4753V22H30.2993V2.4H45.1113V6.04H34.8073V18.36ZM49.1391 22V2.4H57.6231C59.3778 2.4 60.8898 2.68933 62.1591 3.268C63.4285 3.828 64.4085 4.64 65.0991 5.704C65.7898 6.768 66.1351 8.03733 66.1351 9.512C66.1351 10.968 65.7898 12.228 65.0991 13.292C64.4085 14.356 63.4285 15.1773 62.1591 15.756C60.8898 16.316 59.3778 16.596 57.6231 16.596H51.6591L53.6751 14.552V22H49.1391ZM53.6751 15.056L51.6591 12.9H57.3711C58.7711 12.9 59.8165 12.6013 60.5071 12.004C61.1978 11.4067 61.5431 10.576 61.5431 9.512C61.5431 8.42933 61.1978 7.58933 60.5071 6.992C59.8165 6.39467 58.7711 6.096 57.3711 6.096H51.6591L53.6751 3.94V15.056ZM66.9819 2.4H72.2179L76.2779 8.336L80.3379 2.4H85.6579L79.1339 11.78L86.1899 22H80.8419L76.2779 15.504L71.7699 22H66.5339L73.5339 11.976L66.9819 2.4ZM101.708 2.4H106.244V22H101.708V2.4ZM92.804 22H88.268V2.4H92.804V22ZM102.044 13.964H92.468V10.128H102.044V13.964ZM122.327 22V15.812L123.447 16.792H118.071C116.372 16.792 114.907 16.512 113.675 15.952C112.443 15.392 111.5 14.58 110.847 13.516C110.193 12.452 109.867 11.1827 109.867 9.708C109.867 8.17733 110.212 6.87067 110.903 5.788C111.612 4.68667 112.601 3.84667 113.871 3.268C115.14 2.68933 116.633 2.4 118.351 2.4H126.807V22H122.327ZM109.923 22L114.795 14.972H119.387L114.711 22H109.923ZM122.327 14.356V4.92L123.447 6.096H118.463C117.175 6.096 116.185 6.39467 115.495 6.992C114.823 7.58933 114.487 8.476 114.487 9.652C114.487 10.7907 114.813 11.668 115.467 12.284C116.12 12.9 117.081 13.208 118.351 13.208H123.447L122.327 14.356ZM142.889 22V15.812L144.009 16.792H138.633C136.935 16.792 135.469 16.512 134.237 15.952C133.005 15.392 132.063 14.58 131.409 13.516C130.756 12.452 130.429 11.1827 130.429 9.708C130.429 8.17733 130.775 6.87067 131.465 5.788C132.175 4.68667 133.164 3.84667 134.433 3.268C135.703 2.68933 137.196 2.4 138.913 2.4H147.369V22H142.889ZM130.485 22L135.357 14.972H139.949L135.273 22H130.485ZM142.889 14.356В4.92L144.009 6.096H139.025C137.737 6.096 136.748 6.39467 136.057 6.992C135.385 7.58933 135.049 8.476 135.049 9.652C135.049 10.7907 135.376 11.668 136.029 12.284C136.683 12.9 137.644 13.208 138.913 13.208H144.009L142.889 14.356Z"
                fill="#83A36B"
              />
            </svg>
          </div>
          <div className="menu-vector" onClick={toggleSidebar}>
            <svg
              width="41"
              height="27"
              viewBox="0 0 41 27"
              fill="none"
              xmlns="http://www.w3.org/2000/svg"
            >
              <path
                d="M3 13.6567H38.3008H3ZM3 24.3134H38.3008H3ZM3 3H38.3008H3Z"
                fill="#ABABAB"
              />
              <path
                d="M3 13.6567H38.3008M3 24.3134H38.3008M3 3H38.3008"
                stroke="#ABABAB"
                stroke-width="5"
                stroke-linecap="round"
              />
            </svg>
          </div>
          <form
            className="box"
            autoComplete="off"
            style={{
              autoComplete: "off",
              marginTop: "0.7em",
              width: "fit-content",
            }}
          >
            <span className="normal-text">Логин</span>
            <div>
              <TextField
                id="filled-basic"
                variant="outlined"
                sx={{
                  width: "100%",
                  mb: "0.7em",
                  borderRadius: "10px",
                  background: "#F2F2F2",
                  outline: "none",
                  "& fieldset": {
                    border: "none",
                  },
                  "& input": { autoComplete: "off" },
                }}
                size="small"
              />
            </div>
            <span className="normal-text">Пароль</span>
            <div>
              <TextField
                id="outlined-basic"
                type="password"
                variant="outlined"
                sx={{
                  width: "100%",
                  mb: "0.7em",
                  background: "#F2F2F2",
                  outline: "none",
                  "& fieldset": { border: "none" },
                  borderRadius: "10px",
                  "& input": { autoComplete: "off" },
                }}
                size="small"
              />
            </div>
            <Button
              className="primary-button"
              variant="contained"
              sx={{
                width: "100%",
                background: "#83A36B",
                fontFamily: "Montserrat",
                fontWeight: "bold",
                color: "white",
                borderRadius: "10px",
              }}
              type="submit"
            >
              ВОЙТИ
            </Button>
          </form>
        </div>
      </div>
    </ThemeProvider>
  );
}

export default Login_page;