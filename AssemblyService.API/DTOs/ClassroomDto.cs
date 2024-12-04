namespace AssemblyService.API.DTOs;

public record ClassroomDto(
    Guid Id,
    int Number,
    int Capacity,
    CampusDto Campus,
    IEnumerable<DetailDto> DetailDtos,
    IEnumerable<CompletedSlotDto> CompletedSlots,
    IEnumerable<SubjectDto> Subjects
    );