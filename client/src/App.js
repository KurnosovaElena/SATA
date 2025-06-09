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
import AdminRolesPage from './pages/admin/AdminRolesPage';
import StatsPage from './pages/stats/StatsPage';
import RequireRole from './components/auth/RequireRole';

function App() {
  return (
    <div className="App">
      <Router>
        <Routes> 
          {/* Главная страница — доступна всем */}
          <Route path="/" element={<MainPage />} />
          {/* Страница расписания студента — доступна всем авторизованным */}
          <Route path="/stschedule" element={<RequireRole role={["student","user","teacher","admin"]}><StudentSchedulePage /></RequireRole>} />
          {/* Страница расписания преподавателя — доступна всем авторизованным, но без системы переносов */}
          <Route path="/profschedule" element={<RequireRole role={["teacher","user","student","admin"]}><ProfessorSchedulePage /></RequireRole>} />
          {/* Личный профиль — доступен всем авторизованным */}
          <Route path="/stprofile" element={<RequireRole role={["student","user","teacher","admin"]}><StudentProfilePage /></RequireRole>} />
          {/* Остальные страницы — только для соответствующих ролей */}          <Route path="/st-double-schedule" element={<RequireRole role={["student","admin"]}><StudentDoubleSchedule /></RequireRole>} />
          <Route path="/prof-double-schedule" element={<RequireRole role={["teacher","admin"]}><ProfessorDoubleSchedule /></RequireRole>} />
          <Route path="/admin/roles" element={<RequireRole role="admin"><AdminRolesPage /></RequireRole>} />
          <Route path="/login" element={<LoginPage />} />
          <Route path="/stats" element={<RequireRole role={["student","user","teacher","admin"]}><StatsPage /></RequireRole>} />
        </Routes>
      </Router>
    </div>
  );
}

export default App;