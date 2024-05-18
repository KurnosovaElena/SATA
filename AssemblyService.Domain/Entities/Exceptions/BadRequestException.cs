namespace AssemblyService.Domain.Entities.Exceptions
{
    public class BadRequestException(string message) : Exception(message) { }
}