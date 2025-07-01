namespace Application.Features.CalibrationLimits.Dtos;

public class CalibrationLimitDto
{
    public int Id { get; set; }
    public string Parameter { get; set; }
    public int ZeroRef { get; set; }
    public int ZeroTimeStamp { get; set; }
    public int SpanRef { get; set; }
    public int SpanTimeStamp { get; set; }
}
