import React, { useEffect, useState } from 'react';
import { useAuth0 } from '@auth0/auth0-react';
import { getUsers, updateUserRole } from '../../api';

function AdminRolesPage() {
  const { getAccessTokenSilently } = useAuth0();
  const [users, setUsers] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);
  const [updating, setUpdating] = useState('');

  useEffect(() => {
    setLoading(true);
    setError(null);
    getAccessTokenSilently()
      .then(token => getUsers(token))
      .then(data => setUsers(data))
      .catch(e => setError(e.message))
      .finally(() => setLoading(false));
  }, [getAccessTokenSilently]);

  const handleChangeRole = async (email, role) => {
    setUpdating(email + role);
    setError(null);
    try {
      const token = await getAccessTokenSilently();
      await updateUserRole(email, role, token);
      // обновить локально
      setUsers(users => users.map(u => u.email === email ? { ...u, role } : u));
    } catch (e) {
      setError(e.message);
    } finally {
      setUpdating('');
    }
  };

  return (
    <div style={{ padding: 32 }}>
      <h2>Управление ролями пользователей</h2>
      {loading && <div>Загрузка...</div>}
      {error && <div style={{color:'red'}}>{error}</div>}
      {!loading && (
        <table style={{ width: '100%', borderCollapse: 'collapse', marginTop: 24 }}>
          <thead>
            <tr style={{ background: '#f2f2f2' }}>
              <th style={{ padding: 8, border: '1px solid #ccc' }}>Email</th>
              <th style={{ padding: 8, border: '1px solid #ccc' }}>Роль</th>
              <th style={{ padding: 8, border: '1px solid #ccc' }}>Действия</th>
            </tr>
          </thead>
          <tbody>
            {users.map(u => (
              <tr key={u.email}>
                <td style={{ padding: 8, border: '1px solid #ccc' }}>{u.email}</td>
                <td style={{ padding: 8, border: '1px solid #ccc' }}>{u.role}</td>
                <td style={{ padding: 8, border: '1px solid #ccc' }}>
                  <button 
                    disabled={u.email === 'getrent.v1@gmail.com' || updating}
                    onClick={() => handleChangeRole(u.email, 'student')}
                  >Сделать студентом</button>
                  <button 
                    disabled={u.email === 'getrent.v1@gmail.com' || updating}
                    style={{ marginLeft: 8 }}
                    onClick={() => handleChangeRole(u.email, 'teacher')}
                  >Сделать преподавателем</button>
                  <button 
                    disabled={u.email !== 'getrent.v1@gmail.com' || updating}
                    style={{ marginLeft: 8 }}
                    onClick={() => handleChangeRole(u.email, 'admin')}
                  >Сделать админом</button>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      )}
      <div style={{ marginTop: 24, color: '#888' }}>
        * Только email getrent.v1@gmail.com может быть админом
      </div>
    </div>
  );
}

export default AdminRolesPage;
