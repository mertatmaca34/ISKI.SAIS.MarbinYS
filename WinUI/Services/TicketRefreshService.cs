using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using WinUI.Constants;

namespace WinUI.Services;

public class TicketRefreshService : BackgroundService
{
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

            var delay = TimeSpan.FromMinutes(30);
            var expiry = StationConstants.TicketExpiry - DateTime.Now;
            if (expiry > TimeSpan.Zero && expiry < delay)
            {
                delay = expiry;
            }

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
}
