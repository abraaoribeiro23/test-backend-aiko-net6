using Microsoft.FeatureManagement;

namespace Aiko.Api.Modules.Common.FeatureFlags;

/// <summary>
///     Feature Flags Extension.
/// </summary>
public static class FeatureFlagsExtensions
{
    /// <summary>
    ///     Add Feature Flags dependencies.
    /// </summary>
    public static IServiceCollection AddFeatureFlags(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddFeatureManagement(configuration);

        return services;
    }
}