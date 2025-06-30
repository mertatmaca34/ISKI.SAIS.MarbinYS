using Application.Features.SendData.Dtos;
using MediatR;

namespace Application.Features.SendData.Commands;

public record SendDataCommand(string SensorTag, double Value) : IRequest<SendDataResultDto>;
