using Application.Features.SendDatas.Dtos;
using MediatR;
using System;

namespace Application.Features.SendDatas.Queries.GetByStationAndReadTime;

public sealed record GetSendDataByStationAndReadTimeQuery(Guid StationId, DateTime Readtime) : IRequest<SendDataDto?>;
