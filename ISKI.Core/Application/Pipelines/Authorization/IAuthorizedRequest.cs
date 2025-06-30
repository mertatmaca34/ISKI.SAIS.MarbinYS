namespace ISKI.Core.Application.Pipelines.Authorization;

public interface IAuthorizedRequest
{
    List<string> RequiredRoles { get; }
}
