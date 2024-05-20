import './App.css';
import {
  BrowserRouter as Router,
  Routes,
  Route,
} from 'react-router-dom';
import LoginPage from './pages/LoginPage';
import MainPage from './pages/main/MainPage';
import StudentSchedulePage from './pages/student schedule/StudentSchedulePage';
import StudentProfilePage from './pages/student profile/StudentProfilePage';
import ProfessorSchedulePage from './pages/professor schedule/ProfessorSchedulePage';
import ProfessorDoubleSchedule from './pages/professor double schedule/ProfessorDoubleSchedule';
import StudentDoubleSchedule from './pages/student double schedule/StudentDoubleSchedule';

function App() {
  return (
    <div className="App">
      <Router>
        <Routes> 
          <Route path="/st-double-schedule" element={<StudentDoubleSchedule />} />
          <Route path="/prof-double-schedule" element={<ProfessorDoubleSchedule />} />        
          <Route path="/profschedule" element={<ProfessorSchedulePage />} />
          <Route path="/stprofile" element={<StudentProfilePage />} />
          <Route path="/stschedule" element={<StudentSchedulePage />} />
          <Route path="/login" element={<LoginPage />} />
          <Route path="/" element={<MainPage />} />
        </Routes>
      </Router>
    </div>
  );
}

export default App;