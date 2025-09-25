using MediatR;
using System;

namespace Application.Features.SendDatas.Queries.GetLatestReadTime;

public record GetLatestReadTimeQuery() : IRequest<DateTime?>;
