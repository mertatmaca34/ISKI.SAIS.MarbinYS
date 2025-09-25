using Application.Features.PlcData.Dtos;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.PlcData;

public class AnalogSensorStatisticsService(IBKSContext context) : IAnalogSensorStatisticsService
{
    private readonly IBKSContext _context = context;

    public async Task<AnalogSensorAverageDto> GetHourlyAverageAsync(DateTime referenceTime, CancellationToken cancellationToken = default)
    {
        DateTime endTime = referenceTime;
        DateTime startTime = endTime.AddHours(-1);

        var query = _context.AnalogSensorData
            .Where(x => x.Readtime >= startTime && x.Readtime <= endTime);

        if (!await query.AnyAsync(cancellationToken))
        {
            return new AnalogSensorAverageDto();
        }

        var averages = await query
            .GroupBy(_ => 1)
            .Select(g => new AnalogSensorAverageDto
            {
                AkisHizi = Math.Round(g.Average(x => x.AkisHizi), 2),
                Akm = Math.Round(g.Average(x => x.Akm), 2),
                CozunmusOksijen = Math.Round(g.Average(x => x.CozunmusOksijen), 2),
                Debi = Math.Round(g.Average(x => x.Debi), 2),
                Koi = Math.Round(g.Average(x => x.Koi), 2),
                Ph = Math.Round(g.Average(x => x.Ph), 2),
                Sicaklik = Math.Round(g.Average(x => x.Sicaklik), 2),
                Iletkenlik = Math.Round(g.Average(x => x.Iletkenlik), 2)
            })
            .FirstAsync(cancellationToken);

        return averages;
    }
}
