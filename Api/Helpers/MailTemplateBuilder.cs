using System;
using System.Globalization;

namespace Api.Helpers;

public static class MailTemplateBuilder
{
    private static readonly CultureInfo Culture = CultureInfo.GetCultureInfo("tr-TR");

    public static string Build(
        string alarmName,
        string severity,
        string stationName,
        DateTime timestamp,
        string parameterName,
        string measuredValue,
        string unit,
        string limit,
        string description,
        string sampleTaken,
        string sampleId,
        string nextSampleAt,
        string alarmId)
    {
        var localTime = timestamp.Kind == DateTimeKind.Unspecified ? timestamp : timestamp.ToLocalTime();
        var formattedTimestamp = localTime.ToString("dd.MM.yyyy HH:mm", Culture);

        var displayValue = string.IsNullOrWhiteSpace(unit)
            ? measuredValue
            : $"{measuredValue} ({unit})";

        var descriptionSection = string.IsNullOrWhiteSpace(description)
            ? string.Empty
            : $"<div style=\"margin-top:24px;padding:16px 20px;background-color:#f8fafc;border-radius:12px;line-height:1.6;color:#1e293b;\">{description}</div>";

        return $@"<!DOCTYPE html>
<html lang=\"tr\">
<head>
<meta charset=\"utf-8\" />
<title>{alarmName}</title>
</head>
<body style=\"margin:0;background-color:#f4f6fb;padding:24px;font-family:'Segoe UI', Arial, sans-serif;\">
  <div style=\"max-width:520px;margin:0 auto;background-color:#ffffff;border-radius:16px;box-shadow:0 20px 50px rgba(15,23,42,0.15);overflow:hidden;\">
    <div style=\"background:linear-gradient(135deg,#1e293b,#0f172a);color:#ffffff;padding:28px 32px;\">
      <div style=\"text-transform:uppercase;letter-spacing:2px;font-size:12px;opacity:0.7;\">Otomatik Bildirim</div>
      <div style=\"margin-top:12px;font-size:22px;font-weight:600;\">{alarmName} — {severity}</div>
      <div style=\"margin-top:8px;font-size:13px;color:rgba(255,255,255,0.75);\">{DisplayOrDash(stationName)} · {formattedTimestamp}</div>
    </div>
    <div style=\"padding:28px 32px;color:#0f172a;\">
      <table style=\"width:100%;border-collapse:collapse;font-size:14px;\">
        <tr>
          <td style=\"padding:8px 0;font-weight:600;color:#475569;width:50%;\">Parametre</td>
          <td style=\"padding:8px 0;text-align:right;\">{DisplayOrDash(parameterName)}</td>
        </tr>
        <tr>
          <td style=\"padding:8px 0;font-weight:600;color:#475569;\">Ölçülen Değer</td>
          <td style=\"padding:8px 0;text-align:right;\">{DisplayOrDash(displayValue)}</td>
        </tr>
        <tr>
          <td style=\"padding:8px 0;font-weight:600;color:#475569;\">Tanımlı Limit</td>
          <td style=\"padding:8px 0;text-align:right;\">{DisplayOrDash(limit)}</td>
        </tr>
        <tr>
          <td style=\"padding:8px 0;font-weight:600;color:#475569;\">İstasyon</td>
          <td style=\"padding:8px 0;text-align:right;\">{DisplayOrDash(stationName)}</td>
        </tr>
        <tr>
          <td style=\"padding:8px 0;font-weight:600;color:#475569;\">Zaman</td>
          <td style=\"padding:8px 0;text-align:right;\">{formattedTimestamp}</td>
        </tr>
        <tr>
          <td style=\"padding:8px 0;font-weight:600;color:#475569;\">Örnek Alındı</td>
          <td style=\"padding:8px 0;text-align:right;\">{DisplayOrDash(sampleTaken)}</td>
        </tr>
        <tr>
          <td style=\"padding:8px 0;font-weight:600;color:#475569;\">Örnek ID</td>
          <td style=\"padding:8px 0;text-align:right;\">{DisplayOrDash(sampleId)}</td>
        </tr>
        <tr>
          <td style=\"padding:8px 0;font-weight:600;color:#475569;\">Bir Sonraki Otomatik Örnek</td>
          <td style=\"padding:8px 0;text-align:right;\">{DisplayOrDash(nextSampleAt)}</td>
        </tr>
        <tr>
          <td style=\"padding:8px 0;font-weight:600;color:#475569;\">Olay/Alarm ID</td>
          <td style=\"padding:8px 0;text-align:right;\">{DisplayOrDash(alarmId)}</td>
        </tr>
      </table>
      {descriptionSection}
      <div style=\"margin-top:28px;text-align:center;\">
        <a href=\"#\" style=\"display:inline-block;padding:12px 24px;border-radius:999px;background:linear-gradient(135deg,#2563eb,#0ea5e9);color:#ffffff;text-decoration:none;font-weight:600;\">Detayları Görüntüle</a>
      </div>
    </div>
    <div style=\"padding:20px 24px;background-color:#f8fafc;color:#64748b;font-size:12px;text-align:center;\">
      Bu e-posta sistem tarafından otomatik oluşturulmuştur. Lütfen yanıtlamayınız.
    </div>
  </div>
</body>
</html>";
    }

    private static string DisplayOrDash(string? value) => string.IsNullOrWhiteSpace(value) ? "-" : value.Trim();
}
