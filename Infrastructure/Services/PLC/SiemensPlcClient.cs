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
    // Many Siemens PLCs, including S7-1200/1500 families, expose the CPU on
    // rack 0 and slot 1. Using the wrong slot often causes "TCP: Error receiving
    // Data" when attempting to read from the device.
    private const short DefaultRack = 0;
    private const short DefaultSlot = 1;

    public async Task<byte[]> ReadBytesAsync(string ipAddress, int dbNumber, int startAddress, int length)
    {
        var client = new S7Client();
        try
        {
            int connectResult = client.ConnectTo(ipAddress, DefaultRack, DefaultSlot);
            if (connectResult != 0)
            {
                throw new Exception(client.ErrorText(connectResult));
            }

            byte[] buffer = new byte[length];
            const int maxRetries = 3;
            int readResult = -1;
            for (int attempt = 0; attempt < maxRetries; attempt++)
            {
                readResult = client.DBRead(dbNumber, startAddress, length, buffer);
                if (readResult == 0)
                {
                    return buffer;
                }

                // Transient network errors can occur; wait briefly and retry.
                await Task.Delay(100);
            }

            throw new Exception(client.ErrorText(readResult));
        }
        finally
        {
            client.Disconnect();
        }
    }
}
