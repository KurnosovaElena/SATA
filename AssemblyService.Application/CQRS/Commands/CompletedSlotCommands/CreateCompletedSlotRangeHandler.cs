using MediatR;
using Npgsql;

namespace AssemblyService.Application.CQRS.Commands.CompletedSlotCommands
{
    internal class CreateCompletedSlotRangeHandler() : IRequestHandler<CreateCompletedSlotRangeCommand>
    {
        public async Task Handle(CreateCompletedSlotRangeCommand command, CancellationToken cancellationToken)
        {

        }

        private string connectionString = "Host=localhost;Username=postgres;Password=yourpassword;Database=university";

        public void CreateTimetable()
        {
            var daysOfWeek = new List<int> { 1, 2, 3, 4, 5 }; // Monday to Friday
            var slotsPerDay = 4;

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                // Fetch all classes
                var classes = FetchClasses(conn);

                // Dictionary to store timetable
                var timetable = new Dictionary<(int group, int day, int slot), int>();

                // Assign physical culture to the first slots
                AssignPhysicalCulture(classes, timetable, daysOfWeek);

                // Assign remaining classes
                foreach (var classInfo in classes)
                {
                    //
                    for (int day = 1; day <= 5; day++)
                    {
                        for (int slot = 1; slot <= slotsPerDay; slot++)
                        {
                            var key = (classInfo.GroupID, day, slot);
                            if (!timetable.ContainsKey(key))
                            {
                                timetable[key] = classInfo.ClassID;
                                break;
                            }
                        }
                    }
                }

                // Save timetable to database
                SaveTimetable(conn, timetable);
            }
        }

        private List<ClassInfo> FetchClasses(NpgsqlConnection conn)
        {
            var classes = new List<ClassInfo>();
            var cmd = new NpgsqlCommand("SELECT * FROM Classes", conn);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    classes.Add(new ClassInfo
                    {
                        ClassID = reader.GetInt32(0),
                        CourseID = reader.GetInt32(1),
                        LecturerID = reader.GetInt32(2),
                        GroupID = reader.GetInt32(3),
                        ClassType = reader.GetString(4),
                        Frequency = reader.GetString(5)
                    });
                }
            }
            return classes;
        }

        private void AssignPhysicalCulture(List<ClassInfo> classes, Dictionary<(int group, int day, int slot), int> timetable, List<int> daysOfWeek)
        {
            foreach (var classInfo in classes)
            {
                if (classInfo.CourseID == /*ID физической культуры*/)
                {
                    foreach (var day in daysOfWeek)
                    {
                        var key = (classInfo.GroupID, day, 1); // Assign to first slot
                        if (!timetable.ContainsKey(key))
                        {
                            timetable[key] = classInfo.ClassID;
                            break;
                        }
                    }
                }
            }
        }

        private void SaveTimetable(NpgsqlConnection conn, Dictionary<(int group, int day, int slot), int> timetable)
        {
            foreach (var entry in timetable)
            {
                var cmd = new NpgsqlCommand("INSERT INTO Timetable (GroupID, DayOfWeek, Slot, ClassID) VALUES (@GroupID, @DayOfWeek, @Slot, @ClassID)", conn);
                cmd.Parameters.AddWithValue("GroupID", entry.Key.group);
                cmd.Parameters.AddWithValue("DayOfWeek", entry.Key.day);
                cmd.Parameters.AddWithValue("Slot", entry.Key.slot);
                cmd.Parameters.AddWithValue("ClassID", entry.Value);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
