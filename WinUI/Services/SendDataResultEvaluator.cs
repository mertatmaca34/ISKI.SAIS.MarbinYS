using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Enums;
using WinUI.Models;

namespace WinUI.Services;

public static class SendDataResultEvaluator
{
    public static HashSet<InvalidSensorStatusCode> ExtractInvalidStatusCodes(SendDataResult? result)
    {
        var codes = new HashSet<InvalidSensorStatusCode>();
        if (result is null)
            return codes;

        foreach (var property in typeof(SendDataResult).GetProperties())
        {
            if (!property.Name.EndsWith("_N", StringComparison.Ordinal))
                continue;

            var value = property.GetValue(result);
            if (value is null)
                continue;

            if (!double.TryParse(value.ToString(), out var numericValue))
                continue;

            var intValue = (int)Math.Round(numericValue, MidpointRounding.AwayFromZero);
            if (!Enum.IsDefined(typeof(InvalidSensorStatusCode), intValue))
                continue;

            codes.Add((InvalidSensorStatusCode)intValue);
        }

        return codes;
    }

    public static SendDataInvalidStatusFlags MapInvalidStatusFlags(IReadOnlyCollection<InvalidSensorStatusCode> invalidCodes)
    {
        bool Contains(InvalidSensorStatusCode code) => invalidCodes.Contains(code);

        return new SendDataInvalidStatusFlags(
            Contains(InvalidSensorStatusCode.GecersizYikama),
            Contains(InvalidSensorStatusCode.GecersizHaftalikYikama),
            Contains(InvalidSensorStatusCode.GecersizKalibrasyon),
            Contains(InvalidSensorStatusCode.GecersizAkisHizi),
            Contains(InvalidSensorStatusCode.GecersizDebi),
            Contains(InvalidSensorStatusCode.TekrarVeri),
            Contains(InvalidSensorStatusCode.GecersizOlcumBirimi));
    }
}

public readonly record struct SendDataInvalidStatusFlags(
    bool SaatlikYikamaGecersiz,
    bool HaftalikYikamaGecersiz,
    bool KalibrasyonGecersiz,
    bool AkisHiziGecersiz,
    bool GecersizDebi,
    bool TekrarVeriGecersiz,
    bool GecersizOlcumBirimi);
