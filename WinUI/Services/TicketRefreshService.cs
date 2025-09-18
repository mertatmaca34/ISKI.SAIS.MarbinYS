using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace WinUI.Services;

public class TicketRefreshService : BackgroundService
{
    private static readonly TimeSpan MinimumDelay = TimeSpan.FromMinutes(1);
    private readonly ITicketService _ticketService;

    public TicketRefreshService(ITicketService ticketService)
    {
        _ticketService = ticketService;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                await _ticketService.EnsureTicketAsync();
            }
            catch
            {
                // ignore refresh errors
            }

            var delay = CalculateDelay();
            try
            {
                await Task.Delay(delay, stoppingToken);
            }
            catch (TaskCanceledException)
            {
                // ignore cancellation
            }
        }
    }

    private TimeSpan CalculateDelay()
    {
        var session = _ticketService.CurrentTicket;
        if (session is null)
        {
            return MinimumDelay;
        }

        var delay = session.Expiration - DateTime.Now - MinimumDelay;
        return delay < MinimumDelay ? MinimumDelay : delay;
    }
}
