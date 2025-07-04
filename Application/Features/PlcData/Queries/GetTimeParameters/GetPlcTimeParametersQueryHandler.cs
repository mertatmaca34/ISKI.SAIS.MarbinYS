using Application.Features.PlcData.Dtos;
using Application.Services.Parsing;
using AutoMapper;
using Infrastructure.Services.PLC;
using Application.Features.PlcData.Rules;
using MediatR;

namespace Application.Features.PlcData.Queries.GetTimeParameters;

public class GetPlcTimeParametersQueryHandler(
    IPlcClient plcClient,
    IPlcDataParser parser,
    IMapper mapper) : IRequestHandler<GetPlcTimeParametersQuery, PlcTimeParametersDto>
{
    public async Task<PlcTimeParametersDto> Handle(GetPlcTimeParametersQuery request, CancellationToken cancellationToken)
    {
        byte[] bytes = await plcClient.ReadBytesAsync(request.IpAddress, request.DbNumber, request.Start, request.Length);
        var entity = parser.ParseTimeParameters(bytes);
        PlcDataBusinessRules.EntityShouldNotBeNull(entity);
        return mapper.Map<PlcTimeParametersDto>(entity);
    }
}
