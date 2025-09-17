using System.Collections.Generic;
using System.Linq;
using Domain.Entities;

namespace WinUI.Services;

public interface IChannelNameProvider
{
    IEnumerable<string> GetChannelNames();
}

public class ChannelNameProvider : IChannelNameProvider
{
    public IEnumerable<string> GetChannelNames()
    {
        var analogChannels = typeof(AnalogSensorData).GetProperties()
            .Where(p => p.PropertyType == typeof(double) || p.PropertyType == typeof(double?))
            .Select(p => p.Name);

        var digitalChannels = typeof(DigitalSensorData).GetProperties()
            .Where(p => p.PropertyType == typeof(bool) || p.PropertyType == typeof(bool?))
            .Select(p => p.Name);

        var sendDataChannels = typeof(SendData).GetProperties()
            .Where(p => p.PropertyType == typeof(bool))
            .Select(p => p.Name);

        return analogChannels
            .Concat(digitalChannels)
            .Concat(sendDataChannels);
    }
}
