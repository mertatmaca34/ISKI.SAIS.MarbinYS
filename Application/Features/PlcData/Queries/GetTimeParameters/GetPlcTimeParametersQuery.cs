using Application.Features.PlcData.Dtos;
using MediatR;

namespace Application.Features.PlcData.Queries.GetTimeParameters;

public record GetPlcTimeParametersQuery(string IpAddress, int DbNumber, int Start, int Length) : IRequest<PlcTimeParametersDto>;
