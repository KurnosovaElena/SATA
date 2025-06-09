import React from 'react';
import schedules from '../../../data/schedules.json';
import { Document, Packer, Paragraph, TextRun } from 'docx';
import * as XLSX from 'xlsx';
import { jsPDF } from 'jspdf';

// 1. Отчет по расписанию подгруппы
export function generateGroupScheduleReport(groupName) {
    const schedule = schedules[groupName];
    if (!schedule) return `Нет расписания для группы ${groupName}`;
    let report = `Расписание для группы ${groupName}:\n`;
    
    // Добавляем информацию о количестве пар
    let totalLessons = 0;
    
    for (const [day, lessons] of Object.entries(schedule)) {
        report += `\n${day}:\n`;
        lessons.forEach((lesson, idx) => {
            if (lesson.className) {
                totalLessons++;
                report += `  ${idx + 1}) ${lesson.className} (${lesson.type}), ${lesson.professorName}, ауд. ${lesson.classroom}\n`;
            }
        });
    }
    
    // Добавляем итоговую статистику
    report += `\nВсего пар в неделю: ${totalLessons}`;
    return report;
}

// 2. Отчет по расписанию предмета
export function generateSubjectScheduleReport(subjectName) {
    let report = `Все занятия по предмету "${subjectName}":\n`;
    for (const group in schedules) {
        const schedule = schedules[group];
        for (const [day, lessons] of Object.entries(schedule)) {
            lessons.forEach((lesson, idx) => {
                if (lesson.className === subjectName) {
                    report += `Группа: ${group}, День: ${day}, Пара: ${idx + 1}, Преподаватель: ${lesson.professorName}, ауд. ${lesson.classroom}, тип: ${lesson.type}\n`;
                }
            });
        }
    }
    return report;
}

// 3. Отчет по нагрузке преподавателя
export function generateProfessorLoadReport(professorName) {
    let total = 0;
    const bySubject = {};
    const byDay = {};
    for (const group in schedules) {
        const schedule = schedules[group];
        for (const [day, lessons] of Object.entries(schedule)) {
            lessons.forEach((lesson) => {
                if (lesson.professorName === professorName) {
                    total++;
                    bySubject[lesson.className] = (bySubject[lesson.className] || 0) + 1;
                    byDay[day] = (byDay[day] || 0) + 1;
                }
            });
        }
    }
    let report = `Нагрузка преподавателя ${professorName}:\nВсего занятий: ${total}\n`;
    report += '\nПо предметам:\n';
    for (const [subj, count] of Object.entries(bySubject)) {
        report += `  ${subj}: ${count}\n`;
    }
    report += '\nПо дням недели:\n';
    for (const [day, count] of Object.entries(byDay)) {
        report += `  ${day}: ${count}\n`;
    }
    return report;
}

// 4. Отчет по занятости аудиторий (пример)
export function generateClassroomUsageReport(classroom) {
    let report = `Занятость аудитории ${classroom}:\n`;
    for (const group in schedules) {
        const schedule = schedules[group];
        for (const [day, lessons] of Object.entries(schedule)) {
            lessons.forEach((lesson, idx) => {
                if (lesson.classroom === classroom) {
                    report += `Группа: ${group}, День: ${day}, Пара: ${idx + 1}, Предмет: ${lesson.className}, Преподаватель: ${lesson.professorName}, тип: ${lesson.type}\n`;
                }
            });
        }
    }
    return report;
}

// 5. Отчет по количеству занятий в день по группам (пример)
export function generateGroupDayLoadReport(groupName) {
    const schedule = schedules[groupName];
    if (!schedule) return `Нет расписания для группы ${groupName}`;
    let report = `Количество занятий по дням недели для группы ${groupName}:\n`;
    for (const [day, lessons] of Object.entries(schedule)) {
        const count = lessons.filter(l => l.className).length;
        report += `${day}: ${count}\n`;
    }
    return report;
}

// Универсальная функция для скачивания отчета как txt-файла
export function downloadReport(reportText, fileName = 'report.txt') {
    const blob = new Blob([reportText], { type: 'text/plain' });
    const url = URL.createObjectURL(blob);
    const a = document.createElement('a');
    a.href = url;
    a.download = fileName;
    document.body.appendChild(a);
    a.click();
    setTimeout(() => {
        document.body.removeChild(a);
        URL.revokeObjectURL(url);
    }, 0);
}

// Функция для сохранения в формате DOCX
export async function saveAsDocx(text, fileName) {
    const doc = new Document({
        sections: [{
            properties: {},
            children: text.split('\n').map(line => 
                new Paragraph({
                    children: [
                        new TextRun({
                            text: line,
                            size: 24, // 12pt
                        })
                    ],
                    spacing: {
                        line: 360, // 1.5 line spacing
                    }
                })
            )
        }]
    });

    const buffer = await Packer.toBlob(doc);
    const url = URL.createObjectURL(buffer);
    const a = document.createElement('a');
    a.href = url;
    a.download = fileName;
    document.body.appendChild(a);
    a.click();
    document.body.removeChild(a);
    URL.revokeObjectURL(url);
}

// Функция для сохранения в формате XLSX
export function saveAsExcel(text, fileName) {
    const rows = text.split('\n').map(line => [line]);
    const ws = XLSX.utils.aoa_to_sheet(rows);
    const wb = XLSX.utils.book_new();
    XLSX.utils.book_append_sheet(wb, ws, "Отчет");
    
    // Автоматическая ширина столбцов
    const maxWidth = rows.reduce((w, r) => Math.max(w, r[0].length), 10);
    ws['!cols'] = [{ wch: maxWidth }];
    
    XLSX.writeFile(wb, fileName);
}

// Функция для сохранения в формате PDF
export function saveAsPdf(text, fileName) {
    const doc = new jsPDF();
    
    // Добавляем поддержку кириллицы
    doc.addFont('https://cdn.jsdelivr.net/npm/roboto-font@0.1.0/fonts/Roboto/roboto-regular-webfont.ttf', 'Roboto', 'normal');
    doc.setFont('Roboto');
    doc.setLanguage("ru");
    
    // Форматируем текст
    const pageWidth = doc.internal.pageSize.getWidth();
    const margin = 15;
    const maxWidth = pageWidth - (margin * 2);
    
    // Разбиваем текст с учетом кириллицы
    const lines = doc.splitTextToSize(text, maxWidth);
    
    let y = 20;
    doc.setFontSize(12);

    lines.forEach(line => {
        if (y > 280) {
            doc.addPage();
            y = 20;
        }
        // Используем UTF-8 кодировку для текста
        doc.text(line, margin, y, {
            charSpace: 0.5,
            lineHeightFactor: 1.5,
            lang: 'ru'
        });
        y += 7;
    });
    
    doc.save(fileName);
}

// Компонент предпросмотра отчета
export function ReportPreview({ report }) {
    return (
        <pre style={{
            background: '#f8f8f8',
            padding: '16px',
            borderRadius: '8px',
            maxHeight: '60vh',
            overflow: 'auto',
            fontFamily: 'monospace',
            fontSize: '1rem',
            whiteSpace: 'pre-wrap',
        }}>{report}</pre>
    );
}