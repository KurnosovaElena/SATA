namespace AssemblyService.BusinessLogic.Exceptions.ExceptionMessages;

/// <summary>
/// Exception messages builder
/// </summary>
public static class ExceptionMessages
{
    public static string GroupsIsNullOrEmpty(Guid id) =>
        $"department {id} groups is null or empty";

    public static string SubgroupsIsNullOrEmpty(Guid id) =>
        $"group {id} does not have subgroups";

    public static string EntityNotFoundMessage(string type, Guid id) =>
        $"{type} of id {id} was not found";
}