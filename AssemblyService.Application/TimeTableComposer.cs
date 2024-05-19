using AssemblyService.Domain.Entities.Models;

namespace AssemblyService.Application
{
    public class Timetable
    {
        public int ClassroomId { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }

    public class TimetableComposer
    {
        private List<Classroom> classrooms;
        private List<Subject> subjects;
        private List<Teacher> teachers;
        private List<TimeSlot> timeSlots;
        private List<Timetable> timetable;

        public TimetableComposer(List<Classroom> classrooms, List<Subject> subjects, List<Teacher> teachers)
        {
            this.classrooms = classrooms;
            this.subjects = subjects;
            this.teachers = teachers;
            this.timeSlots = GenerateTimeSlots();
            this.timetable = new List<Timetable>();
        }

        private List<TimeSlot> GenerateTimeSlots()
        {
            var slots = new List<TimeSlot>();
            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>().Where(d => d >= DayOfWeek.Monday && d <= DayOfWeek.Friday))
            {
                for (int hour = 8; hour <= 17; hour++)
                {
                    slots.Add(new TimeSlot { Day = day, Start = new TimeSpan(hour, 0, 0), End = new TimeSpan(hour + 1, 0, 0) });
                }
            }
            return slots;
        }

        public void ComposeTimetable()
        {
            var subjectsPerDay = new Dictionary<DayOfWeek, int>();
            foreach (var day in Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>().Where(d => d >= DayOfWeek.Monday && d <= DayOfWeek.Friday))
            {
                subjectsPerDay[day] = 0;
            }

            foreach (var subject in subjects.OrderBy(s => s.SubjectType.Name == "PE" ? 0 : 1).ThenBy(s => s.DisciplineId))
            {
                var availableClassrooms = classrooms
                    .Where(c => c.Capacity >= subject.SubjectType.Id)
                    .ToList();

                var teacher = teachers.First(t => t.Id == subject.TeacherId);

                foreach (var day in subjectsPerDay.Keys)
                {
                    if (subjectsPerDay[day] >= 4)
                        continue;

                    var daySlots = timeSlots.Where(slot => slot.Day == day).ToList();
                    foreach (var slot in daySlots)
                    {
                        if (IsTeacherAvailable(teacher, slot) && IsClassroomAvailable(availableClassrooms, slot, out Classroom assignedClassroom))
                        {
                            timetable.Add(new Timetable
                            {
                                ClassroomId = assignedClassroom.Id,
                                SubjectId = subject.Id,
                                TeacherId = teacher.Id,
                                Day = slot.Day,
                                StartTime = slot.Start,
                                EndTime = slot.End
                            });
                            subjectsPerDay[day]++;
                            MarkSlotAsTaken(teacher, assignedClassroom, slot);
                            break;
                        }
                    }
                    if (subjectsPerDay[day] >= 4)
                        break;
                }
            }
        }

        private bool IsTeacherAvailable(Teacher teacher, TimeSlot slot)
        {
            return !timetable.Any(t => t.TeacherId == teacher.Id && t.Day == slot.Day && t.StartTime == slot.Start);
        }

        private bool IsClassroomAvailable(List<Classroom> availableClassrooms, TimeSlot slot, out Classroom assignedClassroom)
        {
            assignedClassroom = availableClassrooms.FirstOrDefault(c => !timetable.Any(t => t.ClassroomId == c.Id && t.Day == slot.Day && t.StartTime == slot.Start));
            return assignedClassroom != null;
        }

        private void MarkSlotAsTaken(Teacher teacher, Classroom classroom, TimeSlot slot)
        {
            timetable.Add(new Timetable
            {
                ClassroomId = classroom.Id,
                SubjectId = -1,
                TeacherId = teacher.Id,
                Day = slot.Day,
                StartTime = slot.Start,
                EndTime = slot.End
            });
        }

        public List<Timetable> GetTimetable()
        {
            return timetable;
        }
    }

    public class TimeSlot
    {
        public DayOfWeek Day { get; set; }
        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }
    }
}

// Example usage:
// var composer = new TimetableComposer(classrooms, subjects, teachers);
// composer.ComposeTimetable();
// var result = composer.GetTimetable();}


// Algorithm Description
// Initialize Data Structures:
// 
// Create lists for classrooms, subjects, teachers, and time slots.
// Define a structure to represent the timetable.
// Data Validation:
// 
// Ensure that there are enough classrooms and teachers to accommodate all subjects.
// Verify that classrooms are appropriately equipped for the subject types they will host.
// Sort Subjects:
// 
// Sort subjects by priority (e.g., core subjects first), class size, and other constraints.
// Assign Classrooms and Timeslots:
// 
// Iterate through each subject.
// For each subject, find available classrooms that meet the capacity and type requirements.
// Check teacher availability for the subject's preferred time slots.
// Assign the classroom and time slot to the subject and update the availability of the classroom and teacher.
// Conflict Resolution:
// 
// If conflicts arise (e.g., no available classroom or time slot), implement strategies like:
// Shifting less critical subjects.
// Using alternative time slots or classrooms.
// Generate Timetable:
// 
// Create a timetable structure that maps each subject to its assigned classroom and time slot.
// Ensure that the generated timetable is easily readable and exportable.