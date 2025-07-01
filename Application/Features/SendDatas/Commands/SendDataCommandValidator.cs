using FluentValidation;

namespace Application.Features.SendDatas.Commands;

public class SendDataCommandValidator : AbstractValidator<SendDataCommand>
{
    public SendDataCommandValidator()
    {
        RuleFor(x => x.SensorTag).NotEmpty();
    }
}
