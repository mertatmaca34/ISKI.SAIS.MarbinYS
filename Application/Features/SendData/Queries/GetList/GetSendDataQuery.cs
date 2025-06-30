using MediatR;
using Application.Features.SendData.Dtos;

namespace Application.Features.SendData.Queries.GetList;

public record GetSendDataQuery() : IRequest<List<SendDataDto>>;
