namespace Api.Constants;

public static class LogMessages
{
    public static class Program
    {
        public const string ConnectionStringEmpty = "Bağlantı dizesi boş.";
        public const string DatabaseChecked = "Veritabanı kontrol edildi.";
        public const string DatabaseInitializationFailed = "Veritabanı başlatılamadı.";
        public const string ApiStarted = "API başlatıldı.";
    }

    public static class MailAlarmWorker
    {
        public const string AlarmTriggered = "Alarm {Alarm}, {Email} kullanıcısı için {Value} değeriyle tetiklendi. E-posta gönderildi.";
        public const string ProcessingError = "E-posta alarmları işlenirken hata oluştu.";
    }

    public static class PlcDataWorker
    {
        public const string ReadError = "PLC verisi okunurken hata oluştu.";
    }

    public static class PlcDataController
    {
        public const string CacheEmpty = "PLC verisi istendi ancak önbellek boş.";
    }
}
