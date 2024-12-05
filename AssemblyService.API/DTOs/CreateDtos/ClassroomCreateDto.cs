namespace AssemblyService.API.DTOs.CreateDtos;

public record ClassroomCreateDto(
    int Number,
    int Capacity,
    Guid CampusId
);