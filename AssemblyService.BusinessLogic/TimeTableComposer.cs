using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.Enums;

namespace AssemblyService.Application
{
    public record EmptySlot
    {
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSlot TimeSlot { get; set; }
        public WeekType WeekType { get; set; }
    }

    public class TimetableComposer
    {
        private List<Classroom> classrooms;
        private List<Subject> subjects;
        private List<Teacher> teachers;
        private List<EmptySlot> timeSlots;
        private List<CompletedSlot> timetable;
        private List<Group> groups;

        public TimetableComposer(List<Classroom> classrooms, List<Subject> subjects, List<Teacher> teachers, List<Group> groups)
        {
            this.classrooms = classrooms;
            this.subjects = subjects;
            this.teachers = teachers;
            this.timeSlots = GenerateTimeSlots();
            this.timetable = [];
            this.groups = groups;
        }

        private List<EmptySlot> GenerateTimeSlots()
        {
            var slots = new List<EmptySlot>();

            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>().Where(d => d >= DayOfWeek.Monday && d <= DayOfWeek.Friday))
            {
                for (TimeSlot timeSlot = TimeSlot.First; timeSlot <= TimeSlot.Fifth; timeSlot++)
                {
                    slots.AddRange(
                        new List<EmptySlot>
                        {
                            new()
                            {
                                DayOfWeek = day,
                                TimeSlot = timeSlot,
                                WeekType = WeekType.Upper
                            },
                            new()
                            {
                                DayOfWeek = day,
                                TimeSlot = timeSlot,
                                WeekType = WeekType.Lower
                            }
                        });
                }
            }

            return slots;
        }

        public void ComposeTimetable()
        {
            //Count of subjects per day
            var subjectsPerDay = new Dictionary<DayOfWeek, int>();

            foreach (var day in Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>().Where(d => d >= DayOfWeek.Monday && d <= DayOfWeek.Friday))
            {
                //Erase all
                subjectsPerDay[day] = 0;
            }

            foreach (var subject in subjects.OrderBy(s => s.SubjectType.Name == "PE" ? 0 : 1).ThenBy(s => s.DisciplineId))
            {
                //assign according to groups count
                var availableClassrooms = classrooms
                    .Where(c => c.Capacity >= subject.SubjectType.Id)
                    .ToList();

                var teacher = teachers.FirstOrDefault(t => t.Id == subject.TeacherId);

                foreach (var day in subjectsPerDay.Keys)
                {
                    if (subjectsPerDay[day] >= 4)
                        continue;

                    var daySlots = timeSlots.Where(slot => slot.DayOfWeek == day).ToList();
                    foreach (var slot in daySlots)
                    {
                        if (IsTeacherAvailable(teacher, slot) && IsClassroomAvailable(availableClassrooms, slot, out Classroom assignedClassroom))
                        {
                            //Remove taken slot from emptySlots
                            if (slot.WeekType is WeekType.Lower || slot.WeekType is WeekType.Upper)
                            {
                                subject.HoursPerWeek--;
                                timetable.Add(new CompletedSlot
                                {
                                    ClassroomId = assignedClassroom.Id,
                                    SubjectId = subject.Id,
                                    WeekType = slot.WeekType
                                });

                                daySlots.Remove(slot);
                            }
                            else
                            {
                                if (subject.HoursPerWeek % 2 != 0)
                                {
                                    subject.HoursPerWeek--;
                                    timetable.Add(new CompletedSlot
                                    {
                                        ClassroomId = assignedClassroom.Id,
                                        SubjectId = subject.Id,
                                        WeekType = WeekType.Upper
                                    });

                                    daySlots.Remove(slot);
                                }
                                else
                                {
                                    subject.HoursPerWeek -= 2;
                                    timetable.Add(new CompletedSlot
                                    {
                                        ClassroomId = assignedClassroom.Id,
                                        SubjectId = subject.Id,
                                        WeekType = WeekType.Neutral
                                    });

                                    daySlots.Remove(slot);
                                    daySlots.Remove(daySlots.Where(s => s.DayOfWeek == slot.DayOfWeek && s.TimeSlot == slot.TimeSlot).FirstOrDefault());
                                }
                            }
                            subjectsPerDay[day]++;
                            MarkSlotAsTaken(teacher, assignedClassroom, slot);
                            break;
                        }
                    }
                }
            }
        }

        private bool IsTeacherAvailable(Teacher teacher, EmptySlot slot)
        {
            return !timetable.Any(t => t.Id == teacher.Id && t.DayOfWeek == slot.DayOfWeek && t.WeekType == slot.WeekType && t.TimeSlot == slot.TimeSlot);
        }

        private bool IsClassroomAvailable(List<Classroom> availableClassrooms, EmptySlot slot, out Classroom assignedClassroom)
        {
            assignedClassroom = availableClassrooms.FirstOrDefault(c => !timetable.Any(t => t.ClassroomId == c.Id
            && t.DayOfWeek == slot.DayOfWeek
            && (t.WeekType == slot.WeekType || t.WeekType is WeekType.Neutral)));
            return assignedClassroom != null;
        }

        private void MarkSlotAsTaken(Teacher teacher, Classroom classroom, EmptySlot slot)
        {
            timetable.Add(new CompletedSlot
            {
                ClassroomId = classroom.Id,
                SubjectId = -1,
            });
        }

        public List<CompletedSlot> GetTimetable()
        {
            return timetable;
        }
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