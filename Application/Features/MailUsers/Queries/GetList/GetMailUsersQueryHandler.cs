using MediatR;
using Application.Features.MailUsers.Dtos;
using AutoMapper;
using Infrastructure.Persistence.Abstract;

namespace Application.Features.MailUsers.Queries.GetList;

public class GetMailUsersQueryHandler(
    IMailUserRepository repository,
    IMapper mapper) : IRequestHandler<GetMailUsersQuery, List<MailUserDto>>
{
    public async Task<List<MailUserDto>> Handle(GetMailUsersQuery request, CancellationToken cancellationToken)
    {
        var items = await repository.GetAllAsync(x => true);
        return items.Select(mapper.Map<MailUserDto>).ToList();
    }
}
