namespace AssemblyService.BusinessLogic.Exceptions.ExceptionMessages;

/// <summary>
/// Exception messages builder
/// </summary>
public static class DepartmentExceptionMessages
{
    public static string GroupsIsNullOrEmpty(Guid id) =>
        $"department {id} groups is null or empty";

    public static string SubgroupsIsNullOrEmpty(Guid id) =>
        $"group {id} does not have subgroups";
}