namespace Application.Constants;

public static class LogMessages
{
    public static class PlcData
    {
        public const string ReadOrSaveError = "PLC verisi okunurken veya kaydedilirken hata oluştu.";
    }

    public static class Stations
    {
        public const string CreatedSuccessfully = "İstasyon {StationId} başarıyla oluşturuldu.";
        public const string CreationError = "İstasyon {StationId} oluşturulurken hata oluştu.";
        public const string UpdatedSuccessfully = "İstasyon {StationId} başarıyla güncellendi.";
        public const string UpdateError = "İstasyon {StationId} güncellenirken hata oluştu.";
    }
}
