using Sharp7;
using System.Threading.Tasks;

namespace Infrastructure.Services.PLC;

/// <summary>
/// PLC client implementation that uses the Sharp7 library to communicate with
/// Siemens devices and read raw byte arrays from data blocks.
/// </summary>
public class SiemensPlcClient : IPlcClient
{
    private const short DefaultRack = 0;
    private const short DefaultSlot = 0;

    public Task<byte[]> ReadBytesAsync(string ipAddress, int dbNumber, int startAddress, int length)
    {
        var client = new S7Client();
        client.ConnectTo(ipAddress, DefaultRack, DefaultSlot);
        byte[] buffer = new byte[length];
        client.DBRead(dbNumber, startAddress, length, buffer);
        client.Disconnect();
        return Task.FromResult(buffer);
    }
}
