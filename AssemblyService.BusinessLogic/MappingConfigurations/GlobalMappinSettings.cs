using Mapster;

namespace AssemblyService.BusinessLogic.MappingConfigurations;

/// <summary>
/// Mapster Configuration
/// </summary>
public class GlobalMappingSettings : IRegister
{
    /// <summary>
    /// Register custom mapping configurations 
    /// </summary>
    /// <param name="config">config argument</param>
    public void Register(TypeAdapterConfig config)
    {
        TypeAdapterConfig.GlobalSettings.Default.MaxDepth(2);
        TypeAdapterConfig.GlobalSettings.Default.PreserveReference(true);
    }
}