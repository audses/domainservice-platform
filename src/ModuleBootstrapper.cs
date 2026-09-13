using Microsoft.Extensions.DependencyInjection;

namespace Workflowgroup.Platform;

public static partial class ModuleBootstrapper
{
    /// <summary>Registers every tenant workflow's services. Add hand-wired infrastructure (crypto/hash providers, pepper descriptors, ...) here alongside the generated registrations.</summary>
    public static IServiceCollection AddPlatformWorkflows(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddPlatformWorkflowsGenerated();
        return serviceCollection;
    }
}