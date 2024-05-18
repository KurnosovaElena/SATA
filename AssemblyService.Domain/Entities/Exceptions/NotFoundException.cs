namespace AssemblyService.Domain.Entities.Exceptions
{
    public class NotFoundException(string message) : Exception(message) { }
}