namespace Application.Constants;

public static class LogMessages
{
    public static class PlcData
    {
        public const string ReadOrSaveError = "Error reading or saving PLC data";
    }

    public static class Stations
    {
        public const string CreatedSuccessfully = "Station {StationId} created successfully";
        public const string CreationError = "Error creating station {StationId}";
        public const string UpdatedSuccessfully = "Station {StationId} updated successfully";
        public const string UpdateError = "Error updating station {StationId}";
    }
}
