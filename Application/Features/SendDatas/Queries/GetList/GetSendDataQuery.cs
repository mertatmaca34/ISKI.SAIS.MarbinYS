using MediatR;
using Application.Features.SendDatas.Dtos;

namespace Application.Features.SendDatas.Queries.GetList;

public record GetSendDataQuery() : IRequest<List<SendDataDto>>;
