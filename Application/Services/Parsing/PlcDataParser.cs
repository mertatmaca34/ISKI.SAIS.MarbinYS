using Domain.Entities;
using System;

namespace Application.Services.Parsing;

/// <summary>
/// Default implementation that interprets the raw byte arrays as sequential
/// little-endian double/boolean values.
/// </summary>
public class PlcDataParser : IPlcDataParser
{
    public AnalogSensorData ParseAnalog(byte[] data)
    {
        // Expect sequential double values for each analog field.
        var result = new AnalogSensorData
        {
            Readtime = DateTime.UtcNow,
            AkisHizi = ReadDouble(data, 0),
            Akm = ReadDouble(data, 8),
            CozunmusOksijen = ReadDouble(data, 16),
            Debi = ReadDouble(data, 24),
            DesarjDebi = ReadDouble(data, 32),
            HariciDebi = ReadDouble(data, 40),
            HariciDebi2 = ReadDouble(data, 48),
            Koi = ReadDouble(data, 56),
            Ph = ReadDouble(data, 64),
            Sicaklik = ReadDouble(data, 72),
            Iletkenlik = ReadDouble(data, 80)
        };
        return result;
    }

    public DigitalSensorData ParseDigital(byte[] data)
    {
        // Interpret each byte as boolean flag.
        return new DigitalSensorData
        {
            ReadTime = DateTime.UtcNow,
            Kapi = ReadBool(data, 0),
            Duman = ReadBool(data, 1),
            SuBaskini = ReadBool(data, 2),
            AcilStop = ReadBool(data, 3),
            Pompa1Termik = ReadBool(data, 4),
            Pompa2Termik = ReadBool(data, 5),
            TemizSuTermik = ReadBool(data, 6),
            YikamaTanki = ReadBool(data, 7),
            Enerji = ReadBool(data, 8),
            Pompa1CalisiyorMu = ReadBool(data, 9),
            Pompa2CalisiyorMu = ReadBool(data, 10)
        };
    }

    private static double ReadDouble(byte[] data, int offset)
    {
        if (data.Length < offset + 8) return 0;
        return BitConverter.ToDouble(data, offset);
    }

    private static bool ReadBool(byte[] data, int offset)
    {
        if (data.Length <= offset) return false;
        return data[offset] != 0;
    }
}
