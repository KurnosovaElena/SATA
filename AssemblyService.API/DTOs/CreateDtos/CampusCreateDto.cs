namespace AssemblyService.API.DTOs.CreateDtos;

public record CampusCreateDto(
    int Number,
    string? Coordinates
);