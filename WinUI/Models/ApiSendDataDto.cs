using System;

namespace WinUI.Models;

public class ApiSendDataDto
{
    public Guid StationId { get; set; }
    public DateTime StartTime { get; set; }
    public string SoftwareVersion { get; set; } = string.Empty;
    public string Regions { get; set; } = string.Empty;
    public string StationStatus { get; set; } = string.Empty;
    public double AAKM { get; set; }
    public double BGM { get; set; }
    public string AAKM_Status { get; set; } = string.Empty;
    public string BGM_Status { get; set; } = string.Empty;
    public double CozunmusOksijen { get; set; }
    public string COJ_Status { get; set; } = string.Empty;
    public string COJ_ND { get; set; } = string.Empty;
    public double Koi { get; set; }
    public string Koi_Status { get; set; } = string.Empty;
    public double Debi { get; set; }
    public string Debi_Status { get; set; } = string.Empty;
    public double Sicaklik { get; set; }
}
