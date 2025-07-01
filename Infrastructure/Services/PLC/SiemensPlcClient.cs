using S7.Net;
using System.Threading.Tasks;

namespace Infrastructure.Services.PLC;

/// <summary>
/// PLC client implementation that uses the S7.Net library to communicate with
/// Siemens devices and read raw byte arrays from data blocks.
/// </summary>
public class SiemensPlcClient : IPlcClient
{
    private const CpuType DefaultCpu = CpuType.S71500;
    private const short DefaultRack = 0;
    private const short DefaultSlot = 0;

    public Task<byte[]> ReadBytesAsync(string ipAddress, int dbNumber, int startAddress, int length)
    {
        using var plc = new Plc(DefaultCpu, ipAddress, DefaultRack, DefaultSlot);
        plc.Open();
        byte[] data = plc.ReadBytes(DataType.DataBlock, dbNumber, startAddress, length);
        plc.Close();
        return Task.FromResult(data);
    }
}
