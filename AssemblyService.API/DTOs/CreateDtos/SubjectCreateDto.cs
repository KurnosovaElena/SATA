using AssemblyService.BusinessLogic.Models;

namespace AssemblyService.API.DTOs.CreateDtos;

public record SubjectCreateDto(Guid TeacherId, Guid DisciplineId, Guid SubjectTypeId, ICollection<DetailModel>? Details, ICollection<SubgroupModel>? Subgroups, ICollection<ClassroomModel>? Classrooms, ICollection<CompletedSlotModel>? CompletedSlots);