using FluentValidation;

namespace Application.Features.SendData.Commands;

public class SendDataCommandValidator : AbstractValidator<SendDataCommand>
{
    public SendDataCommandValidator()
    {
        RuleFor(x => x.SensorTag).NotEmpty();
    }
}
