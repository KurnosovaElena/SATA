import React, { useState } from 'react';
import "./reportgenerator.css";
import Sidebar from "../components/sidebar/Sidebar";
import { Link } from 'react-router-dom';

function ReportGeneratorPage() {
  const [isSidebarOpen, setSidebarOpen] = useState(false);

  const toggleSidebar = () => {
    setSidebarOpen(!isSidebarOpen);
  };

  const closeSidebar = () => {
    setSidebarOpen(false);
  };

  return (
    <div className="report-page">
      <Sidebar isOpen={isSidebarOpen} onClose={closeSidebar} />
      {isSidebarOpen && <div className="overlay active" onClick={toggleSidebar}></div>}
      <div className="report-header">
        <div className="header-left">
          <div className="menu-icon" onClick={toggleSidebar}>
          <svg width="41" height="27" viewBox="0 0 41 27" fill="none" xmlns="http://www.w3.org/2000/svg">
              <path d="M3 13.6567H38.3008H3ZM3 24.3134H38.3008H3ZM3 3H38.3008H3Z" fill="#ABABAB" />
              <path d="M3 13.6567H38.3008M3 24.3134H38.3008M3 3H38.3008" stroke="#ABABAB" strokeWidth="5" strokeLinecap="round" />
            </svg>
          </div>
          <div className="notification-icon">
          <svg width="30" height="37" viewBox="0 0 30 37" fill="none" xmlns="http://www.w3.org/2000/svg">
              <path d="M26.0192 15.4828V15.4825C26.0157 12.4377 25.0051 9.4986 23.1772 7.23397C21.3984 5.03026 18.9665 3.61582 16.3269 3.25452V1V0.75H16.0769H13.9231H13.6731V1V3.25452C11.0335 3.61582 8.6016 5.03026 6.82281 7.23397C4.99486 9.4986 3.98429 12.4377 3.98077 15.4825V15.4828V19.7153L1.1289 22.9113C0.883691 23.1861 0.750038 23.5533 0.75 23.931V27.5518C0.75 27.9295 0.883651 28.2968 1.12889 28.5716C1.37496 28.8474 1.71521 29.0087 2.07692 29.0087H9.36539V29.6943C9.34165 31.2784 9.83984 32.8204 10.77 34.0247C11.701 35.2301 13.0017 36.0145 14.4262 36.218L14.4262 36.2181L14.4339 36.2189C15.2216 36.3065 16.0166 36.2083 16.7671 35.9312C17.5176 35.6541 18.2058 35.2049 18.7883 34.6144C19.3708 34.0239 19.8349 33.305 20.1523 32.5048C20.4696 31.7046 20.6337 30.8398 20.6346 29.9658V29.9656V29.0087H27.9231C28.2848 29.0087 28.625 28.8474 28.8711 28.5716C29.1164 28.2968 29.25 27.9295 29.25 27.5518V23.9311C29.25 23.5533 29.1163 23.1861 28.8711 22.9113L26.0192 19.7153V15.4828ZM6.63462 20.3104V20.3104V15.4828C6.63462 12.9798 7.52211 10.5842 9.09454 8.82198C10.6661 7.06071 12.7912 6.07759 15 6.07759C17.2089 6.07759 19.3339 7.06071 20.9055 8.82198C22.4779 10.5842 23.3654 12.9798 23.3654 15.4828V20.3104V20.3104C23.3655 20.6882 23.4992 21.0553 23.7444 21.3301L26.5962 24.5262V26.0949H3.40385V24.5262L6.25559 21.3301C6.50084 21.0553 6.63454 20.6882 6.63462 20.3104ZM17.9808 29.9656C17.9808 30.8681 17.6606 31.7288 17.098 32.3593C16.5362 32.9889 15.7808 33.3362 15 33.3362C14.2192 33.3362 13.4638 32.9889 12.902 32.3593C12.3394 31.7288 12.0192 30.8681 12.0192 29.9656V29.0087H17.9808V29.9656Z" fill="#ABABAB" stroke="#ABABAB" strokeWidth="0.5" />
            </svg>
          </div>
        </div>
        <div className="header-right">
        <Link to="/">
            <div className="profile-icon">
            <svg className="default-icon" width="186" height="48" viewBox="0 0 186 48" fill="none" xmlns="http://www.w3.org/2000/svg">
            <path d="M2 2L2 46" stroke="#83A36B" stroke-width="4" stroke-linecap="round"/>
            <path d="M9.436 22V2.4H23.268L23.24 6.096H12.88L13.916 5.06L13.944 22H9.436ZM30.2057 10.296H39.6417V13.824H30.2057V10.296ZM30.5417 18.36H41.2097V22H26.0337V2.4H40.8457V6.04H30.5417V18.36ZM58.3135 2.4H62.8495V22H58.3135V2.4ZM49.4095 22H44.8735V2.4H49.4095V22ZM58.6495 13.964H49.0735V10.128H58.6495V13.964ZM71.9322 10.296H81.3682V13.824H71.9322V10.296ZM72.2682 18.36H82.9362V22H67.7602V2.4H82.5722V6.04H72.2682V18.36ZM86.6001 22V2.4H95.0841C96.8387 2.4 98.3507 2.68933 99.6201 3.268C100.889 3.828 101.869 4.64 102.56 5.704C103.251 6.768 103.596 8.03733 103.596 9.512C103.596 10.968 103.251 12.228 102.56 13.292C101.869 14.356 100.889 15.1773 99.6201 15.756C98.3507 16.316 96.8387 16.596 95.0841 16.596H89.1201L91.1361 14.552V22H86.6001ZM91.1361 15.056L89.1201 12.9H94.8321C96.2321 12.9 97.2774 12.6013 97.9681 12.004C98.6587 11.4067 99.0041 10.576 99.0041 9.512C99.0041 8.42933 98.6587 7.58933 97.9681 6.992C97.2774 6.39467 96.2321 6.096 94.8321 6.096H89.1201L91.1361 3.94V15.056ZM103.392 22L112.128 2.4H116.608L125.372 22H120.612L113.444 4.696H115.236L108.04 22H103.392ZM107.76 17.8L108.964 14.356H119.044L120.276 17.8H107.76ZM131.215 22V5.06L132.251 6.096H124.971V2.4H141.967V6.096H134.687L135.695 5.06V22H131.215ZM153.921 22.336C152.372 22.336 150.935 22.084 149.609 21.58C148.303 21.076 147.164 20.3667 146.193 19.452C145.241 18.5373 144.495 17.464 143.953 16.232C143.431 15 143.169 13.656 143.169 12.2C143.169 10.744 143.431 9.4 143.953 8.168C144.495 6.936 145.251 5.86267 146.221 4.948C147.192 4.03333 148.331 3.324 149.637 2.82C150.944 2.316 152.363 2.064 153.893 2.064C155.443 2.064 156.861 2.316 158.149 2.82C159.456 3.324 160.585 4.03333 161.537 4.948C162.508 5.86267 163.264 6.936 163.805 8.168C164.347 9.38133 164.617 10.7253 164.617 12.2C164.617 13.656 164.347 15.0093 163.805 16.26C163.264 17.492 162.508 18.5653 161.537 19.48C160.585 20.376 159.456 21.076 158.149 21.58C156.861 22.084 155.452 22.336 153.921 22.336ZM153.893 18.472C154.771 18.472 155.573 18.3227 156.301 18.024C157.048 17.7253 157.701 17.296 158.261 16.736C158.821 16.176 159.251 15.5133 159.549 14.748C159.867 13.9827 160.025 13.1333 160.025 12.2C160.025 11.2667 159.867 10.4173 159.549 9.652C159.251 8.88667 158.821 8.224 158.261 7.664C157.72 7.104 157.076 6.67467 156.329 6.376C155.583 6.07733 154.771 5.928 153.893 5.928C153.016 5.928 152.204 6.07733 151.457 6.376C150.729 6.67467 150.085 7.104 149.525 7.664C148.965 8.224 148.527 8.88667 148.209 9.652C147.911 10.4173 147.761 11.2667 147.761 12.2C147.761 13.1147 147.911 13.964 148.209 14.748C148.527 15.5133 148.956 16.176 149.497 16.736C150.057 17.296 150.711 17.7253 151.457 18.024C152.204 18.3227 153.016 18.472 153.893 18.472ZM168.112 22V2.4H176.596C178.35 2.4 179.862 2.68933 181.132 3.268C182.401 3.828 183.381 4.64 184.072 5.704C184.762 6.768 185.108 8.03733 185.108 9.512C185.108 10.968 184.762 12.228 184.072 13.292C183.381 14.356 182.401 15.1773 181.132 15.756C179.862 16.316 178.35 16.596 176.596 16.596H170.632L172.648 14.552V22H168.112ZM172.648 15.056L170.632 12.9H176.344C177.744 12.9 178.789 12.6013 179.48 12.004C180.17 11.4067 180.516 10.576 180.516 9.512C180.516 8.42933 180.17 7.58933 179.48 6.992C178.789 6.39467 177.744 6.096 176.344 6.096H170.632L172.648 3.94V15.056Z" fill="#83A36B"/>
            <path d="M18.816 45.336C17.2667 45.336 15.8293 45.084 14.504 44.58C13.1973 44.076 12.0587 43.3667 11.088 42.452C10.136 41.5373 9.38933 40.464 8.848 39.232C8.32533 38 8.064 36.656 8.064 35.2C8.064 33.744 8.32533 32.4 8.848 31.168C9.38933 29.936 10.1453 28.8627 11.116 27.948C12.0867 27.0333 13.2253 26.324 14.532 25.82C15.8387 25.316 17.2573 25.064 18.788 25.064C20.3373 25.064 21.756 25.316 23.044 25.82C24.3507 26.324 25.48 27.0333 26.432 27.948C27.4027 28.8627 28.1587 29.936 28.7 31.168C29.2413 32.3813 29.512 33.7253 29.512 35.2C29.512 36.656 29.2413 38.0093 28.7 39.26C28.1587 40.492 27.4027 41.5653 26.432 42.48C25.48 43.376 24.3507 44.076 23.044 44.58C21.756 45.084 20.3467 45.336 18.816 45.336ZM18.788 41.472C19.6653 41.472 20.468 41.3227 21.196 41.024C21.9427 40.7253 22.596 40.296 23.156 39.736C23.716 39.176 24.1453 38.5133 24.444 37.748C24.7613 36.9827 24.92 36.1333 24.92 35.2C24.92 34.2667 24.7613 33.4173 24.444 32.652C24.1453 31.8867 23.716 31.224 23.156 30.664C22.6147 30.104 21.9707 29.6747 21.224 29.376C20.4773 29.0773 19.6653 28.928 18.788 28.928C17.9107 28.928 17.0987 29.0773 16.352 29.376C15.624 29.6747 14.98 30.104 14.42 30.664C13.86 31.224 13.4213 31.8867 13.104 32.652C12.8053 33.4173 12.656 34.2667 12.656 35.2C12.656 36.1147 12.8053 36.964 13.104 37.748C13.4213 38.5133 13.8507 39.176 14.392 39.736C14.952 40.296 15.6053 40.7253 16.352 41.024C17.0987 41.3227 17.9107 41.472 18.788 41.472ZM37.6609 45V28.06L38.6969 29.096H31.4169V25.4H48.4129V29.096H41.1329L42.1409 28.06V45H37.6609ZM64.0609 37.692C63.0903 38.084 62.1569 38.3827 61.2609 38.588C60.3649 38.7747 59.5063 38.868 58.6849 38.868C56.0529 38.868 54.0369 38.2427 52.6369 36.992C51.2369 35.7227 50.5369 33.9027 50.5369 31.532V25.4H55.0169V31.028C55.0169 32.372 55.3809 33.3893 56.1089 34.08C56.8369 34.752 57.8729 35.088 59.2169 35.088C60.0756 35.088 60.9063 34.9947 61.7089 34.808C62.5116 34.6027 63.2583 34.3133 63.9489 33.94L64.0609 37.692ZM63.4169 45V25.4H67.8969V45H63.4169ZM77.6416 33.296H87.0776V36.824H77.6416V33.296ZM77.9776 41.36H88.6456V45H73.4696V25.4H88.2816V29.04H77.9776V41.36ZM97.2374 45V28.06L98.2734 29.096H90.9934V25.4H107.989V29.096H100.709L101.717 28.06V45H97.2374ZM120.644 45.336C119.095 45.336 117.657 45.084 116.332 44.58C115.025 44.076 113.887 43.3667 112.916 42.452C111.964 41.5373 111.217 40.464 110.676 39.232C110.153 38 109.892 36.656 109.892 35.2C109.892 33.744 110.153 32.4 110.676 31.168C111.217 29.936 111.973 28.8627 112.944 27.948C113.915 27.0333 115.053 26.324 116.36 25.82C117.667 25.316 119.085 25.064 120.616 25.064C122.165 25.064 123.584 25.316 124.872 25.82C126.179 26.324 127.308 27.0333 128.26 27.948C129.231 28.8627 129.987 29.936 130.528 31.168C131.069 32.3813 131.34 33.7253 131.34 35.2C131.34 36.656 131.069 38.0093 130.528 39.26C129.987 40.492 129.231 41.5653 128.26 42.48C127.308 43.376 126.179 44.076 124.872 44.58C123.584 45.084 122.175 45.336 120.644 45.336ZM120.616 41.472C121.493 41.472 122.296 41.3227 123.024 41.024C123.771 40.7253 124.424 40.296 124.984 39.736C125.544 39.176 125.973 38.5133 126.272 37.748C126.589 36.9827 126.748 36.1333 126.748 35.2C126.748 34.2667 126.589 33.4173 126.272 32.652C125.973 31.8867 125.544 31.224 124.984 30.664C124.443 30.104 123.799 29.6747 123.052 29.376C122.305 29.0773 121.493 28.928 120.616 28.928C119.739 28.928 118.927 29.0773 118.18 29.376C117.452 29.6747 116.808 30.104 116.248 30.664C115.688 31.224 115.249 31.8867 114.932 32.652C114.633 33.4173 114.484 34.2667 114.484 35.2C114.484 36.1147 114.633 36.964 114.932 37.748C115.249 38.5133 115.679 39.176 116.22 39.736C116.78 40.296 117.433 40.7253 118.18 41.024C118.927 41.3227 119.739 41.472 120.616 41.472ZM135.534 45V25.4H144.662C146.94 25.4 148.713 25.8387 149.982 26.716C151.252 27.5933 151.886 28.844 151.886 30.468C151.886 32.0733 151.289 33.324 150.094 34.22C148.9 35.0973 147.313 35.536 145.334 35.536L145.866 34.36C148.069 34.36 149.777 34.7987 150.99 35.676C152.204 36.5533 152.81 37.8227 152.81 39.484C152.81 41.2013 152.157 42.5547 150.85 43.544C149.562 44.5147 147.677 45 145.194 45H135.534ZM140.042 41.64H145.026C146.072 41.64 146.865 41.4347 147.406 41.024C147.948 40.6133 148.218 39.9787 148.218 39.12C148.218 38.2987 147.948 37.692 147.406 37.3C146.865 36.8893 146.072 36.684 145.026 36.684H140.042V41.64ZM140.042 33.52H144.27C145.26 33.52 146.006 33.324 146.51 32.932C147.014 32.5213 147.266 31.924 147.266 31.14C147.266 30.356 147.014 29.768 146.51 29.376C146.006 28.9653 145.26 28.76 144.27 28.76H140.042V33.52Z" fill="#ABABAB"/>
            </svg>

            <svg className="hover-icon" component={Link} to="/" width="165" height="48" viewBox="0 0 165 48" fill="none" xmlns="http://www.w3.org/2000/svg">
            <path d="M2 2L2 46" stroke="#83A36B" stroke-width="4" stroke-linecap="round"/>
            <path d="M22.876 2.4H27.412V22H22.876V2.4ZM13.972 22H9.436V2.4H13.972V22ZM23.212 13.964H13.636V10.128H23.212V13.964ZM30.1107 22L38.8467 2.4H43.3267L52.0907 22H47.3307L40.1627 4.696H41.9547L34.7587 22H30.1107ZM34.4787 17.8L35.6827 14.356H45.7627L46.9947 17.8H34.4787Z" fill="#83A36B"/>
            <path d="M9.436 45V25.4H23.268L23.24 29.096H12.88L13.916 28.06L13.944 45H9.436ZM24.4961 45.308C24.1601 45.308 23.8054 45.28 23.4321 45.224C23.0774 45.168 22.6854 45.0933 22.2561 45L22.5361 41.164C22.7974 41.2387 23.0681 41.276 23.3481 41.276C24.1134 41.276 24.7107 40.968 25.1401 40.352C25.5694 39.7173 25.8774 38.812 26.0641 37.636C26.2507 36.46 26.3721 35.032 26.4281 33.352L26.7081 25.4H41.7721V45H37.2921V28.06L38.3281 29.096H29.6761L30.6001 28.004L30.4321 33.184C30.3761 35.1067 30.2454 36.8147 30.0401 38.308C29.8347 39.8013 29.5174 41.0707 29.0881 42.116C28.6587 43.1613 28.0707 43.9547 27.3241 44.496C26.5774 45.0373 25.6347 45.308 24.4961 45.308ZM45.1553 45L53.8913 25.4H58.3713L67.1353 45H62.3753L55.2073 27.696H56.9993L49.8033 45H45.1553ZM49.5233 40.8L50.7273 37.356H60.8073L62.0393 40.8H49.5233ZM70.4344 45V25.4H79.5624C81.8398 25.4 83.6131 25.8387 84.8824 26.716C86.1518 27.5933 86.7864 28.844 86.7864 30.468C86.7864 32.0733 86.1891 33.324 84.9944 34.22C83.7998 35.0973 82.2131 35.536 80.2344 35.536L80.7664 34.36C82.9691 34.36 84.6771 34.7987 85.8904 35.676C87.1038 36.5533 87.7104 37.8227 87.7104 39.484C87.7104 41.2013 87.0571 42.5547 85.7504 43.544C84.4624 44.5147 82.5771 45 80.0944 45H70.4344ZM74.9424 41.64H79.9264C80.9718 41.64 81.7651 41.4347 82.3064 41.024C82.8478 40.6133 83.1184 39.9787 83.1184 39.12C83.1184 38.2987 82.8478 37.692 82.3064 37.3C81.7651 36.8893 80.9718 36.684 79.9264 36.684H74.9424V41.64ZM74.9424 33.52H79.1704C80.1598 33.52 80.9064 33.324 81.4104 32.932C81.9144 32.5213 82.1664 31.924 82.1664 31.14C82.1664 30.356 81.9144 29.768 81.4104 29.376C80.9064 28.9653 80.1598 28.76 79.1704 28.76H74.9424V33.52ZM105.438 25.4H109.974V45H105.438V25.4ZM96.5337 45H91.9977V25.4H96.5337V45ZM105.774 36.964H96.1977V33.128H105.774V36.964ZM116.256 41.304C117.339 41.6213 118.244 41.7147 118.972 41.584C119.719 41.4347 120.382 40.912 120.96 40.016L121.912 38.588L122.332 38.112L128.828 25.4H133.28L124.936 40.912C124.19 42.312 123.303 43.3853 122.276 44.132C121.268 44.8787 120.158 45.2987 118.944 45.392C117.731 45.504 116.471 45.2893 115.164 44.748L116.256 41.304ZM122.248 41.892L113.4 25.4H118.244L124.74 38.56L122.248 41.892ZM136.136 45V25.4H140.644V33.1H145.712V37.02H140.644V45H136.136ZM153.44 45.336C151.947 45.336 150.565 45.084 149.296 44.58C148.045 44.076 146.953 43.376 146.02 42.48C145.087 41.5653 144.359 40.492 143.836 39.26C143.332 38.0093 143.08 36.656 143.08 35.2C143.08 33.7253 143.332 32.372 143.836 31.14C144.359 29.908 145.087 28.844 146.02 27.948C146.953 27.0333 148.045 26.324 149.296 25.82C150.565 25.316 151.947 25.064 153.44 25.064C154.915 25.064 156.287 25.316 157.556 25.82C158.825 26.324 159.917 27.0333 160.832 27.948C161.765 28.844 162.493 29.9173 163.016 31.168C163.539 32.4 163.8 33.744 163.8 35.2C163.8 36.656 163.539 38.0093 163.016 39.26C162.493 40.492 161.765 41.5653 160.832 42.48C159.917 43.376 158.825 44.076 157.556 44.58C156.287 45.084 154.915 45.336 153.44 45.336ZM153.44 41.472C154.261 41.472 155.017 41.3227 155.708 41.024C156.399 40.7253 157.005 40.3053 157.528 39.764C158.051 39.204 158.461 38.5413 158.76 37.776C159.059 37.0107 159.208 36.152 159.208 35.2C159.208 34.248 159.059 33.3893 158.76 32.624C158.461 31.8587 158.051 31.2053 157.528 30.664C157.005 30.104 156.399 29.6747 155.708 29.376C155.017 29.0773 154.261 28.928 153.44 28.928C152.637 28.928 151.881 29.0773 151.172 29.376C150.481 29.6747 149.875 30.104 149.352 30.664C148.829 31.2053 148.419 31.8587 148.12 32.624C147.821 33.3893 147.672 34.248 147.672 35.2C147.672 36.152 147.821 37.0107 148.12 37.776C148.419 38.5413 148.829 39.204 149.352 39.764C149.875 40.3053 150.481 40.7253 151.172 41.024C151.881 41.3227 152.637 41.472 153.44 41.472Z" fill="#83A36B"/>
            </svg>
          </div>
          </Link>
        </div>
      </div>

      <div className="report-content">
        <div className="report-card">
          {/* Центральное белое окно */}
        </div>
      </div>
    </div>
  );
}

export default ReportGeneratorPage;
