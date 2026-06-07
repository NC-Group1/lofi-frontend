using Microsoft.AspNetCore.Components;

namespace TokenPractice.Services;

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
        var status = await _client.PostAsJsonAsync("auth/login", new { email, password });
        if (!status.IsSuccessStatusCode) return false;
        
        var token = await status.Content.ReadFromJsonAsync<AuthResponse>();
        if (token?.AccessToken is not null) await _ats.SetToken(token.AccessToken);
        return true;
    }
}

public class AuthResponse
{
    public string AccessToken { get; set; }
    public string TokenType { get; set; }
}