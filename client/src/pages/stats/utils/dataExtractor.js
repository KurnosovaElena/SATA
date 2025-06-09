import schedules from '../../../data/schedules.json';

// Определяем кафедру по предмету
const getDepartmentBySubject = (subject) => {
  const departmentMap = {
    'Математика': 'Математика',
    'Физика': 'Физика',
    'Программирование': 'Информатика',
    'Базы данных': 'Информатика',
    'Английский язык': 'Лингвистика',
    'Психология': 'Психология',
    'Право': 'Юриспруденция',
    'Философия': 'Философия',
    'География': 'География',
    'Социология': 'Социология',
    'Экономика': 'Экономика'
  };
  return departmentMap[subject] || 'Другое';
};

// Группируем преподавателей по кафедрам на основе данных из расписания
export const getProfessorsByDepartment = () => {
  const departments = {};
  const professorLoads = {};
  
  // Проходим по всем группам и их расписаниям
  Object.values(schedules).forEach(schedule => {
    Object.values(schedule).forEach(lessons => {
      lessons.forEach(lesson => {
        if (lesson.className && lesson.professorName) {
          const department = getDepartmentBySubject(lesson.className);
          
          // Добавляем кафедру и преподавателя
          if (!departments[department]) {
            departments[department] = new Set();
          }
          departments[department].add(lesson.professorName);
          
          // Подсчитываем часы (каждый слот = 2 академических часа)
          if (!professorLoads[lesson.professorName]) {
            professorLoads[lesson.professorName] = 0;
          }
          
          // Добавляем 2 часа за каждое занятие
          professorLoads[lesson.professorName] += 2;
        }
      });
    });
  });

  // Формируем результат с подсчитанными часами
  const result = Object.entries(departments).map(([name, professors]) => ({
    name,
    professors: Array.from(professors).map(profName => ({
      name: profName,
      // Умножаем на количество недель в семестре (17)
      load: professorLoads[profName] * 17
    }))
  }));

  // Сортируем кафедры по алфавиту
  return result.sort((a, b) => a.name.localeCompare(b.name));
};

// Обновляем отладочную функцию
export const debugProfessorLoads = () => {
  const loads = {};
  Object.values(schedules).forEach(schedule => {
    Object.values(schedule).forEach(lessons => {
      lessons.forEach(lesson => {
        if (lesson.className && lesson.professorName) {
          if (!loads[lesson.professorName]) {
            loads[lesson.professorName] = [];
          }
          loads[lesson.professorName].push({
            class: lesson.className,
            type: lesson.type || 'не указан',
            hours: 2 // Фиксированное значение - 2 часа за слот
          });
        }
      });
    });
  });
  console.log('Debug Professor Loads:', loads);
  return loads;
};