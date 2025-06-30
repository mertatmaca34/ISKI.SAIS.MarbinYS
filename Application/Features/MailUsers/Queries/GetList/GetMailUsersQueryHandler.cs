using MediatR;
using Application.Features.MailUsers.Dtos;
using Application.Services.Repositories;

namespace Application.Features.MailUsers.Queries.GetList;

public class GetMailUsersQueryHandler(IMailUserRepository repository) : IRequestHandler<GetMailUsersQuery, List<MailUserDto>>
{
    public async Task<List<MailUserDto>> Handle(GetMailUsersQuery request, CancellationToken cancellationToken)
    {
        var items = await repository.GetAllAsync(x => true);
        return items.Select(entity => new MailUserDto
        {
            Id = entity.Id,
            FullName = entity.FullName,
            Email = entity.Email,
            Role = entity.Role,
            IsActive = entity.IsActive
        }).ToList();
    }
}
