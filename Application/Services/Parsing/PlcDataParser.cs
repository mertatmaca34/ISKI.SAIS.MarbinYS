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
        return new AnalogSensorData
        {
            Readtime = DateTime.Now,
            AkisHizi = ReadReal(data, 4),
            Akm = ReadReal(data, 36, 60),
            CozunmusOksijen = ReadReal(data, 24),
            Debi = ReadReal(data, 0, 60),
            DesarjDebi = ReadReal(data, 60, 60),
            HariciDebi = ReadReal(data, 52, 60),
            HariciDebi2 = ReadReal(data, 56, 60),
            Koi = ReadReal(data, 32),
            Ph = ReadReal(data, 16),
            Sicaklik = ReadReal(data, 40),
            Iletkenlik = ReadReal(data, 20)
        };
    }

    public DigitalSensorData ParseDigital(byte[] data)
    {
        // Interpret each byte as boolean flag.
        return new DigitalSensorData
        {
            ReadTime = DateTime.Now,
            KabinOto = ReadBit(data, 0, 0),
            KabinBakim = ReadBit(data, 0, 1),
            KabinKalibrasyon = ReadBit(data, 0, 2),
            KabinDuman = ReadBit(data, 0, 3),
            KabinSuBaskini = ReadBit(data, 0, 4),
            KabinKapiAcildi = ReadBit(data, 0, 5),
            KabinEnerjiYok = ReadBit(data, 0, 6),
            KabinAcilStopBasili = ReadBit(data, 0, 7),
            KabinHaftalikYikamada = ReadBit(data, 1, 0),
            KabinSaatlikYikamada = ReadBit(data, 1, 1),
            Pompa1Termik = ReadBit(data, 1, 2),
            Pompa2Termik = ReadBit(data, 1, 3),
            Pompa3Termik = ReadBit(data, 1, 4),
            TankDolu = ReadBit(data, 1, 5),
            Pompa1Calisiyor = ReadBit(data, 1, 6),
            Pompa2Calisiyor = ReadBit(data, 1, 7),
            Pompa3Calisiyor = ReadBit(data, 2, 0),
            AkmTetik = ReadBit(data, 2, 1),
            KoiTetik = ReadBit(data, 2, 2),
            PhTetik = ReadBit(data, 2, 3),
            ManuelTetik = ReadBit(data, 2, 4),
            SimNumuneTetik = ReadBit(data, 2, 5),
            AkmMail = ReadBit(data, 3, 0),
            KoiMail = ReadBit(data, 3, 1),
            PhMail = ReadBit(data, 3, 2),
        };
    }

    public PlcTimeParameters ParseTimeParameter(byte[] data)
    {
        return new PlcTimeParameters
        {
            SystemTime = ReadTime(data, 0),
            WeeklyWashDay = ReadByte(data, 14),
            WeeklyWashHour = ReadByte(data, 15),
            DailyWashHour = ReadByte(data, 16),
            Minute = ReadByte(data, 17),
            Second = ReadByte(data, 18)
        };
    }

    public static double ReadReal(byte[] buffer, int offset, int divider = 1)
    {
        double value = S7.GetRealAt(buffer, offset) / divider;
        return Math.Round(value, 2);
    }

    public static byte ReadByte(byte[] buffer, int offset) => S7.GetByteAt(buffer, offset);

    public static DateTime ReadTime(byte[] buffer, int offset) => S7.GetDTLAt(buffer, offset);

    public static bool ReadBit(byte[] buffer, int pos, int bit) => S7.GetBitAt(buffer, pos, bit);
}
