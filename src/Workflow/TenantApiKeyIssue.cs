using Appfoundation.Orchestrator.Abstraction;
using Domaincontext.Platform;

namespace Workflowgroup.Platform.Workflow;

public partial class TenantApiKeyIssueWorkflow
{
    private partial Task<ApiKeyHash> ProvideKeyHash(WorkflowContext<TenantApiKeyIssueCommand> ctx, CancellationToken cancellationToken)
    {
        var hashBytes = System.Security.Cryptography.SHA256.HashData(System.Text.Encoding.UTF8.GetBytes(ctx.Request.RawApiKey));
        return Task.FromResult(new ApiKeyHash(Convert.ToHexString(hashBytes).ToUpperInvariant()));
    }
}