using System.Threading.Tasks;

namespace Infrastructure.Services.PLC;

/// <summary>
/// Abstraction for reading raw byte data from a PLC device.
/// </summary>
public interface IPlcClient
{
    /// <summary>
    /// Reads a range of bytes from the PLC.
    /// </summary>
    /// <param name="ipAddress">Target PLC IP address.</param>
    /// <param name="dbNumber">DB number to read from.</param>
    /// <param name="startAddress">Start byte address within the DB.</param>
    /// <param name="length">Number of bytes to read.</param>
    /// <returns>Byte array with data read from the PLC.</returns>
    Task<byte[]> ReadBytesAsync(string ipAddress, int dbNumber, int startAddress, int length);
}
