namespace AssemblyService.BusinessLogic.Exceptions;

/// <summary>
/// Exception class for bad client requests (status code 400)
/// </summary>
/// <param name="message">explanation message</param>
public class BadRequestException(string message) : Exception(message);