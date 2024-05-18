import './App.css';
import {
  BrowserRouter as Router,
  Routes,
  Route,
} from 'react-router-dom';
import LoginPage from './pages/LoginPage';
import MainPage from './pages/main/MainPage';

function App() {
  return (
    <div className="App">
      <Router>
        <Routes>
          <Route path="/login" element={<LoginPage/>} />
          <Route path="/" element={<MainPage/>} />
        </Routes>
      </Router>
    </div>
  );
}

export default App;