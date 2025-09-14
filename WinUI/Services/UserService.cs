using System.Net.Http.Json;
using WinUI.Constants;
using WinUI.Models;

namespace WinUI.Services;

public record CreateUserCommand(
    string UserName,
    string Email,
    string Password);

public interface IUserService
{
    Task<List<UserDto>?> GetListAsync();
    Task<UserDto?> CreateAsync(CreateUserCommand command);
}

public class UserService(HttpClient httpClient) : IUserService
{
    public async Task<List<UserDto>?> GetListAsync()
        => await httpClient.GetFromJsonAsync<List<UserDto>>(UserConstants.ApiUrl);

    public async Task<UserDto?> CreateAsync(CreateUserCommand command)
    {
        using var response = await httpClient.PostAsJsonAsync(UserConstants.ApiUrl, command);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<UserDto>();
    }
}
