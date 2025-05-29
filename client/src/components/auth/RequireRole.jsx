import React from 'react';
import { useAuth0 } from '@auth0/auth0-react';

/**
 * Компонент для защиты роутов по роли пользователя
 * @param {string|string[]} role - требуемая роль или массив ролей
 * @param {React.ReactNode} children - защищённый контент
 */
export default function RequireRole({ role, children }) {
  const { isAuthenticated, user, isLoading } = useAuth0();
  if (isLoading) return <div>Загрузка...</div>;
  if (!isAuthenticated) return <div style={{padding:32, color:'red'}}>Требуется вход</div>;
  if (!user) return null;
  const roles = Array.isArray(role) ? role : [role];

  // Жёсткая привязка email-роль
  let userRole = null;
  if (user.email === 'getrent.v1@gmail.com') userRole = 'admin';
  else if (user.email === 'getrent.v2@gmail.com') userRole = 'teacher';
  else userRole = 'user';

  if (!roles.includes(userRole)) {
    return <div style={{padding:32, color:'red'}}>Доступ запрещён</div>;
  }
  return children;
}
