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
  // Для примера: роль хранится в user["https://getrent.ru/roles"]
  // или в user.role, если вы так настроили Auth0 Rules/Actions
  const userRole = user["https://getrent.ru/roles"] || user.role;
  if (!roles.includes(userRole) && !(roles.includes('admin') && user.email === 'getrent.v1@gmail.com')) {
    return <div style={{padding:32, color:'red'}}>Доступ запрещён</div>;
  }
  return children;
}
