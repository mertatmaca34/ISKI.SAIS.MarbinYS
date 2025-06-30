using Application.Features.MailTriggerRecipients.Commands.Create;
using Application.Features.MailTriggerRecipients.Dtos;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.MailTriggerRecipients.Profiles;

public class MailTriggerRecipientProfile : Profile
{
    public MailTriggerRecipientProfile()
    {
        CreateMap<CreateMailTriggerRecipientCommand, MailTriggerRecipient>();
        CreateMap<MailTriggerRecipient, MailTriggerRecipientDto>();
    }
}
