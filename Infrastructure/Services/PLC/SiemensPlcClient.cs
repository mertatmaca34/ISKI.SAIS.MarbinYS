using Sharp7;
using System.Threading.Tasks;
using System;

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
        int connectResult = client.ConnectTo(ipAddress, DefaultRack, DefaultSlot);
        if (connectResult != 0)
        {
            throw new Exception(client.ErrorText(connectResult));
        }

        byte[] buffer = new byte[length];
        int readResult = client.DBRead(dbNumber, startAddress, length, buffer);
        client.Disconnect();
        if (readResult != 0)
        {
            throw new Exception(client.ErrorText(readResult));
        }

        return Task.FromResult(buffer);
    }
}
