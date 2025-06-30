using Application.Features.MailUsers.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using MediatR;

namespace Application.Features.MailUsers.Queries.GetById;

public class GetMailUserByIdQueryHandler(
    IMailUserRepository repository,
    IMapper mapper) : IRequestHandler<GetMailUserByIdQuery, MailUserDto?>
{
    public async Task<MailUserDto?> Handle(GetMailUserByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        return entity is null ? null : mapper.Map<MailUserDto>(entity);
    }
}
