namespace Api.Constants;

public static class LogMessages
{
    public static class Program
    {
        public const string ConnectionStringEmpty = "Connection string is empty";
        public const string DatabaseChecked = "Database checked";
        public const string DatabaseInitializationFailed = "Database initialization failed";
        public const string ApiStarted = "API started";
    }

    public static class MailAlarmWorker
    {
        public const string AlarmTriggered = "Alarm {Alarm} triggered for user {Email} with value {Value}. E-mail sent.";
        public const string ProcessingError = "Error while processing mail alarms";
    }

    public static class PlcDataWorker
    {
        public const string ReadError = "Error while reading PLC data";
    }

    public static class PlcDataController
    {
        public const string CacheEmpty = "PLC data requested but cache is empty";
    }
}
