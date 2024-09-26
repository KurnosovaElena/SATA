using AssemblyService.BusinessLogic.Exceptions;
using AssemblyService.BusinessLogic.Exceptions.ExceptionMessages;
using AssemblyService.BusinessLogic.Models;
using AssemblyService.BusinessLogic.Services.Interfaces;
using AssemblyService.DataAccess.Enums;
using AssemblyService.DataAccess.UnitOfWork;
using Mapster;

namespace AssemblyService.BusinessLogic.Services.Implementations;

public class TimetableService(IUnitOfWork unitOfWork,
    IDepartmentService departmentService,
    ISubgroupService subgroupService,
    ITeacherService teacherService)
{
    /// <summary>
    /// Generate timetable for every group asigned to department
    /// </summary>
    /// <param name="departmentId"></param>
    /// <param name="workingDaysCount"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>List of slots</returns>
    /// <exception cref="BadRequestException"></exception>
    public async Task<IEnumerable<CompletedSlotModel>> GenerateTimeTableForDepartmentGroupsAsync(Guid departmentId, int workingDaysCount = 5, CancellationToken cancellationToken = default)
    {
        var department = await departmentService.GetByIdAsync(departmentId, cancellationToken);

        if (department.Groups is null || department.Groups.Count == 0)
        {
            throw new BadRequestException(DepartmentExceptionMessages.GroupsIsNullOrEmpty(departmentId));
        }

        //Order groups by course and name
        var groups = department.Groups.OrderBy(g => g.Course).ThenBy(g => g.Name);

        foreach (var group in groups)
        {
            if (group.Subgroups is null || group.Subgroups.Count == 0)
            {
                throw new BadRequestException(DepartmentExceptionMessages.SubgroupsIsNullOrEmpty(group.Id));
            }

            foreach (var subgroup in group.Subgroups)
            {
                var fullSubgroupData = await subgroupService.GetByIdAsync(subgroup.Id, cancellationToken);

                if (fullSubgroupData.Subjects is null || fullSubgroupData.Subjects.Count == 0)
                    continue;

                var subjects = fullSubgroupData.Subjects;

                var assignedSlots = new List<CompletedSlotModel>();

                //Get existing slots
                foreach (var subject in subjects)
                    if (subject.CompletedSlots is not null && subject.CompletedSlots.Count > 0)
                    {
                        assignedSlots.AddRange(subject.CompletedSlots);

                        foreach (var slot in subject.CompletedSlots)
                        {
                            if (slot.WeekType is WeekType.Neutral)
                                subject.RequestedHoursPerWeek -= 2;
                            else
                                subject.RequestedHoursPerWeek--;
                        }
                    }

                var newSlots = new List<CompletedSlotModel>();

                //Generate empty slots
                for (DayOfWeek day = DayOfWeek.Monday; day <= (DayOfWeek)workingDaysCount; day++)
                    for (TimeSlot timeSlot = TimeSlot.First; timeSlot <= TimeSlot.Fifth; timeSlot++)
                    {
                        //If slot already exists, skip
                        var currentSlots = assignedSlots.FindAll(slot =>
                        slot.DayOfWeek == day
                        && slot.TimeSlot == timeSlot);

                        if (currentSlots.Exists(slot => slot.WeekType == WeekType.Neutral))
                            continue;

                        else if (currentSlots.Exists(slot => slot.WeekType == WeekType.Upper))
                            newSlots.Add(new CompletedSlotModel
                            {
                                DayOfWeek = day,
                                TimeSlot = timeSlot,
                                WeekType = WeekType.Lower
                            });

                        else if (currentSlots.Exists(slot => slot.WeekType == WeekType.Lower))
                            newSlots.Add(new CompletedSlotModel
                            {
                                DayOfWeek = day,
                                TimeSlot = timeSlot,
                                WeekType = WeekType.Upper
                            });

                        else
                            newSlots.AddRange([
                            new CompletedSlotModel
                            {
                                DayOfWeek = day,
                                TimeSlot = timeSlot,
                                WeekType = WeekType.Upper
                            },
                            new CompletedSlotModel
                            {
                                DayOfWeek = day,
                                TimeSlot = timeSlot,
                                WeekType = WeekType.Lower
                            }
                            ]);
                    }

                //Generate timetable
                while (subjects.Count > 0 || newSlots.Count > 0)
                    foreach (var subject in subjects)
                    {
                        if (subject.RequestedHoursPerWeek == 0)
                            continue;

                        //get teachers slots
                        var teacher = await teacherService.GetByIdAsync(subject.TeacherId, cancellationToken);

                        if (teacher.Subjects is null || teacher.Subjects.Count == 0)
                            throw new BadRequestException("teacher has no assigned subjects");

                        var teacherSlots = new List<CompletedSlotModel>();
                        foreach (var teacherSubject in teacher.Subjects)
                            if (teacherSubject.CompletedSlots is not null && teacherSubject.CompletedSlots.Count > 0)
                                teacherSlots.AddRange(teacherSubject.CompletedSlots);

                        foreach (var newSlot in newSlots)
                        {
                            //If teacher has no free slots, continue
                            if (teacherSlots.Any(slot => slot.WeekType == newSlot.WeekType && slot.DayOfWeek == newSlot.DayOfWeek && slot.TimeSlot == newSlot.TimeSlot))
                                continue;

                            //get assigned slots of the subject in the same day
                            var similarAssignedSlots = assignedSlots.Where(slot => slot.SubjectId == subject.Id && slot.DayOfWeek == newSlot.DayOfWeek).ToList();

                            if (similarAssignedSlots.Count > 0)
                            {
                                //if it occurs every week, break
                                if (similarAssignedSlots.Any(slot => slot.WeekType is WeekType.Neutral))
                                    break;

                                var sameAssignedSlot = similarAssignedSlots.FirstOrDefault(slot => slot.TimeSlot == newSlot.TimeSlot);

                                //if it does not occur in the same time slot or if it occurs in the same week type, continue
                                if (sameAssignedSlot is null || sameAssignedSlot.WeekType == newSlot.WeekType)
                                    continue;

                                //else, make it occur every week
                                sameAssignedSlot.WeekType = WeekType.Neutral;

                                newSlot.Adapt(sameAssignedSlot);

                                subject.RequestedHoursPerWeek--;
                            }
                            else
                            {
                                newSlot.SubjectId = subject.Id;
                            }

                            //Get available classroom
                            var recommendedClassrooms = subject.Classrooms;

                            if (recommendedClassrooms is null || recommendedClassrooms.Count == 0)
                                throw new BadRequestException("teacher has no assigned subjects");

                            ClassroomModel? assignedClassroom = null;
                            foreach (var classroom in recommendedClassrooms)
                            {
                                if (classroom.CompletedSlots is not null)
                                {
                                    if (classroom.CompletedSlots.Count > 0 && classroom.CompletedSlots.Any(slot => slot.WeekType == newSlot.WeekType && slot.DayOfWeek == newSlot.DayOfWeek && slot.TimeSlot == newSlot.TimeSlot))
                                        continue;

                                    classroom.CompletedSlots.Add(newSlot);
                                }
                                else
                                {
                                    classroom.CompletedSlots = [newSlot];
                                }

                                assignedClassroom = classroom;
                            }

                            newSlots.Remove(newSlot);
                        }
                        //3. if false, check for teachers current slot
                    }

                //generate empty slots
                //if not, substract expected time from subjects by existing slots and make a gap in at least one day for next similar subject
                //if slot is free, get teacher by id from subject
                //if teacher slot is busy, move to other slot until true
                //use slot by pattern: 1. full week, 2. upper week, 3. lower week
                //if subject cannot be performed in full week, use either upper or lower
                //if teacher slot is free, get recommended classrooms
                //if recommended classromms are busy, move to all classrooms that are satisfy subject details
                //firstly search in current campus, then in campuses nearby(if 2, then 4 and 7)         (HOW TO DO THAT)
            }
        }
    }
}
