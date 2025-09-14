using Application.Features.SendDatas.Dtos;
using MediatR;

namespace Application.Features.SendDatas.Commands;

public class SendDataCommandHandler() : IRequestHandler<SendDataCommand, SendDataResultDto>
{
    public Task<SendDataResultDto> Handle(SendDataCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new SendDataResultDto { SentMailCount = 0 });
    }
}

