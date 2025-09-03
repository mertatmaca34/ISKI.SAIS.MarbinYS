namespace WinUI.Models;

public class ApiEndpointDto
{
    public int Id { get; set; }
    public string ApiAddress { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
