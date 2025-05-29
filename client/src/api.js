// API для работы с пользователями и ролями

const API_BASE = process.env.REACT_APP_API_URL || 'http://localhost:5000';

export async function getUsers(token) {
  const res = await fetch(`${API_BASE}/api/users`, {
    headers: {
      Authorization: `Bearer ${token}`,
    },
  });
  if (!res.ok) throw new Error('Ошибка получения пользователей');
  return res.json();
}

export async function updateUserRole(email, role, token) {
  const res = await fetch(`${API_BASE}/api/users/role`, {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
      Authorization: `Bearer ${token}`,
    },
    body: JSON.stringify({ email, role }),
  });
  if (!res.ok) throw new Error('Ошибка изменения роли');
  return res.json();
}
