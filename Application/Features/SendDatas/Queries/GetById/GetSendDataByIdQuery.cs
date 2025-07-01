using MediatR;
using Application.Features.SendDatas.Dtos;

namespace Application.Features.SendDatas.Queries.GetById;

public record GetSendDataByIdQuery(int Id) : IRequest<SendDataDto?>;
