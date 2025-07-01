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
            Readtime = DateTime.Now,
            AkisHizi = ReadDouble(data, 4),
            Akm = ReadDouble(data, 12),
            CozunmusOksijen = ReadDouble(data, 24),
            Debi = ReadDouble(data, 0),
            DesarjDebi = ReadDouble(data, 60),
            HariciDebi = ReadDouble(data, 52),
            HariciDebi2 = ReadDouble(data, 56),
            Koi = ReadDouble(data, 32),
            Ph = ReadDouble(data, 16),
            Sicaklik = ReadDouble(data, 40),
            Iletkenlik = ReadDouble(data, 20)
        };
        return result;
    }

    public DigitalSensorData ParseDigital(byte[] data)
    {
        // Interpret each byte as boolean flag.
        return new DigitalSensorData
        {
            ReadTime = DateTime.Now,
            Kapi = ReadBool(data, 5),
            Duman = ReadBool(data, 3),
            SuBaskini = ReadBool(data, 4),
            AcilStop = ReadBool(data, 7),
            Pompa1Termik = ReadBool(data, 9),
            Pompa2Termik = ReadBool(data, 10),
            TemizSuTermik = ReadBool(data, 11),
            YikamaTanki = ReadBool(data, 12),
            Enerji = ReadBool(data, 6),
            Pompa1CalisiyorMu = ReadBool(data, 14),
            Pompa2CalisiyorMu = ReadBool(data, 15)
        };
    }

    private static double ReadDouble(byte[] data, int offset)
    {
        if (data.Length < offset + 4) return 0;
        return BitConverter.ToDouble(data, offset);
    }

    private static bool ReadBool(byte[] data, int offset)
    {
        if (data.Length <= offset) return false;
        return data[offset] != 0;
    }
}
