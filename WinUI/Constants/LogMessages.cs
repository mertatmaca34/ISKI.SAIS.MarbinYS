namespace WinUI.Constants;

public static class LogMessages
{
    public const string SaisApiNotConfigured = "SAIS API kurulumu yapılmamış.";

    public static class TicketService
    {
        public const string TicketMissingOrExpired = "SAIS ticket missing or expired. Refreshing ticket.";
    }

    public static class SaisApiService
    {
        public const string SessionNotFoundOrExpired = "SAIS session not found or expired. Refreshing ticket and retrying.";
    }

    public static class DatabaseSelectionService
    {
        public const string SettingsSaved = "Database settings saved for server {Server}";
        public const string ApiConfigurationUpdateFailed = "Failed to update API configuration";
    }

    public static class PlcDataSendService
    {
        public const string UnexpectedError = "SAIS veri gönderimi sırasında beklenmeyen hata oluştu.";
        public const string StationInfoNotFound = "İstasyon bilgisi bulunamadı.";
        public const string PlcInfoNotFound = "PLC bilgileri bulunamadı.";
        public const string PlcDataUnavailable = "PLC verisi alınamadı.";
        public const string SendDataFailed = "SAIS SendData failed: {Message}";
        public const string UnknownError = "Unknown error";
        public const string SendDataRequestFailed = "SAIS SendData isteği tamamlanamadı.";
    }

    public static class PlcDataService
    {
        public const string PlcInfoNotFound = "PLC bilgileri bulunamadı";
        public const string PlcApiError = "PLC API hatası {StatusCode}: {Error}";
    }

    public static class HomePage
    {
        public const string PlcConfigurationMissing = "PLC yapılandırması eksik: IP adresi tanımlı değil";
        public const string TicketMissingOrExpired = "Ticket yok veya süresi doldu";
        public const string PlcDataRead = "PLC verisi okundu";
        public const string PlcInfoNotYetConfigured = "PLC bilgileri henüz kurulmadı";
        public const string ApiAccessError = "API erişim hatası";
        public const string PlcDataReadFailed = "PLC verisi okunamadı";
    }

    public static class Program
    {
        public const string ApplicationStarted = "WinUI started";
    }
}
