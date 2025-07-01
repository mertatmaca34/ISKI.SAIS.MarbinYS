using Application.Features.SendDatas.Dtos;
using MediatR;

namespace Application.Features.SendDatas.Commands;

public record SendDataCommand(string SensorTag, double Value) : IRequest<SendDataResultDto>;
