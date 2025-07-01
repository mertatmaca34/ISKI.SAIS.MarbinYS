using System.Net.Sockets;
using System.Threading.Tasks;

namespace Infrastructure.Services.PLC;

/// <summary>
/// Simple PLC client that connects to a Siemens device and reads raw bytes.
/// This implementation is intentionally naive and assumes the PLC exposes
/// the DB data directly via TCP. In a real scenario you would use a library
/// such as S7.Net to communicate with the device.
/// </summary>
public class SiemensPlcClient : IPlcClient
{
    private const int DefaultPort = 102; // Default S7 port

    public async Task<byte[]> ReadBytesAsync(string ipAddress, int dbNumber, int startAddress, int length)
    {
        // NOTE: This is a simplified example. Production code should use
        // a full featured S7 protocol library.
        using var client = new TcpClient();
        await client.ConnectAsync(ipAddress, DefaultPort);
        using NetworkStream stream = client.GetStream();

        // Build request packet. This is NOT a real S7 request but kept
        // as placeholder to make the sample compile.
        byte[] request = System.Text.Encoding.ASCII.GetBytes($"READ {dbNumber} {startAddress} {length}\n");
        await stream.WriteAsync(request, 0, request.Length);

        byte[] buffer = new byte[length];
        int totalRead = 0;
        while (totalRead < length)
        {
            int read = await stream.ReadAsync(buffer, totalRead, length - totalRead);
            if (read == 0) break;
            totalRead += read;
        }

        return buffer;
    }
}
