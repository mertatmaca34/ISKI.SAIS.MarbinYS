using MediatR;
using Application.Features.SendData.Dtos;

namespace Application.Features.SendData.Queries.GetById;

public record GetSendDataByIdQuery(int Id) : IRequest<SendDataDto?>;
