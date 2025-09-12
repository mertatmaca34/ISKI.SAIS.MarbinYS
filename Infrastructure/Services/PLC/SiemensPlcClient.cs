using Sharp7;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Services.PLC;

/// <summary>
/// PLC client implementation that uses the Sharp7 library to communicate with
/// Siemens devices and read raw byte arrays from data blocks.
/// </summary>
public class SiemensPlcClient : IPlcClient, IDisposable
{
    // Many Siemens PLCs, including S7-1200/1500 families, expose the CPU on
    // rack 0 and slot 1. Using the wrong slot often causes "TCP: Error receiving
    // Data" when attempting to read from the device.
    private const short DefaultRack = 0;
    private const short DefaultSlot = 1;

    // Reuse a single S7Client instance instead of reconnecting on every read.
    private readonly S7Client _client = new();
    private readonly SemaphoreSlim _sync = new(1, 1);

    public async Task<byte[]> ReadBytesAsync(string ipAddress, int dbNumber, int startAddress, int length)
    {
        await _sync.WaitAsync();
        try
        {
            if (!_client.Connected)
            {
                int connectResult = _client.ConnectTo(ipAddress, DefaultRack, DefaultSlot);
                if (connectResult != 0)
                {
                    throw new Exception(_client.ErrorText(connectResult));
                }
            }

            byte[] buffer = new byte[length];
            const int maxRetries = 3;
            int readResult = -1;
            for (int attempt = 0; attempt < maxRetries; attempt++)
            {
                readResult = _client.DBRead(dbNumber, startAddress, length, buffer);
                if (readResult == 0)
                {
                    return buffer;
                }

                // Transient network errors can occur; wait briefly and retry.
                await Task.Delay(100);
            }

            // If we reach here, the read failed; reset the connection for next time.
            _client.Disconnect();
            throw new Exception(_client.ErrorText(readResult));
        }
        finally
        {
            _sync.Release();
        }
    }

    public void Dispose()
    {
        _client.Disconnect();
        _client.Dispose();
        _sync.Dispose();
    }
}
