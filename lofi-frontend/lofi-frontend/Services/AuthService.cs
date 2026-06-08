using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Components;

namespace lofi_frontend.Services;

public class AuthService
{
    private readonly AccessTokenService _ats;
    private readonly NavigationManager _nav;
    private readonly HttpClient _client;

    public AuthService(
        AccessTokenService accessTokenService,
        NavigationManager nav,
        IHttpClientFactory httpClientFactory
        )
    {
        _ats =  accessTokenService;
        _nav = nav;
        _client = httpClientFactory.CreateClient("BackendApi");
    }

    public async Task<bool> Login(string email, string password)
    {
        Console.WriteLine("Making login request");
        var status = await _client.PostAsJsonAsync(
            "Auth/sign-in", new { email, password });
        if (!status.IsSuccessStatusCode) return false;
        
        Console.WriteLine($"Login successful: {await status.Content.ReadAsStringAsync()}");
        
        var token = await status.Content.ReadFromJsonAsync<Dictionary<string, string>>();
        if (token is null) return false;
        Console.WriteLine($"Token: {token["accessToken"]}");

        if (!string.IsNullOrWhiteSpace(token["accessToken"])) 
            await _ats.SetToken(token["accessToken"]);
        else return false;
        Console.WriteLine("Token set");
        return true;
    }
}

public class AuthResponse
{
    public string AccessToken { get; init; } = "";
    
    public string RefreshToken { get; } = "";
}