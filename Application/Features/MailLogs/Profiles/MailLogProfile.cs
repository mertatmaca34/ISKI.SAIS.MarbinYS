using Application.Features.MailLogs.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.MailLogs.Profiles;

public class MailLogProfile : Profile
{
    public MailLogProfile()
    {
        CreateMap<MailLog, MailLogDto>();
    }
}
