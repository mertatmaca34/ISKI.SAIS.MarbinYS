using Domain.Entities;
using Sharp7;

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
            AkisHizi = GetReal(data, 4),
            Akm = GetReal(data, 36, 60),
            CozunmusOksijen = GetReal(data, 24),
            Debi = GetReal(data, 0, 60),
            DesarjDebi = GetReal(data, 60, 60),
            HariciDebi = GetReal(data, 52, 60),
            HariciDebi2 = GetReal(data, 56, 60),
            Koi = GetReal(data, 32),
            Ph = GetReal(data, 16),
            Sicaklik = GetReal(data, 40),
            Iletkenlik = GetReal(data, 20)
        };
        return result;
    }

    public DigitalSensorData ParseDigital(byte[] data)
    {
        // Interpret each byte as boolean flag.
        return new DigitalSensorData
        {
            ReadTime = DateTime.Now,
            Kapi = GetBit(data, 0, 5),
            Duman = GetBit(data, 0, 3),
            SuBaskini = GetBit(data, 0, 4),
            AcilStop = GetBit(data, 0, 7),
            Pompa1Termik = GetBit(data, 1, 2),
            Pompa2Termik = GetBit(data, 1, 3),
            TemizSuTermik = GetBit(data, 1, 4),
            YikamaTanki = GetBit(data, 1, 5),
            Enerji = GetBit(data, 0, 6),
            Pompa1CalisiyorMu = GetBit(data, 1, 6),
            Pompa2CalisiyorMu = GetBit(data, 1, 7)
        };
    }

    static public double GetReal(byte[] buffer, int offset, int? divider = null)
    {
        if (divider.HasValue)
        {
            return Math.Round((double)(S7.GetRealAt(buffer, offset) / divider), 2);
        }
        else
        {
            return Math.Round(S7.GetRealAt(buffer, offset), 2);
        }
    }
    static public Byte GetByte(byte[] buffer, int offset)
    {
        return S7.GetByteAt(buffer, offset);
    }
    static public DateTime GetTime(byte[] buffer, int offset)
    {
        return S7.GetDTLAt(buffer, offset);
    }
    static public Boolean GetInput(byte[] buffer, int pos, int bit)
    {
        return S7.GetBitAt(buffer, pos, bit);
    }
    static public Boolean GetMB(byte[] buffer, int pos, int bit)
    {
        return S7.GetBitAt(buffer, pos, bit);
    }
    static public Boolean GetBit(byte[] buffer, int pos, int bit)
    {
        return S7.GetBitAt(buffer, pos, bit);
    }
}