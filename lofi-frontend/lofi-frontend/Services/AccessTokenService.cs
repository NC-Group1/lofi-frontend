using System.Net;
using lofi_frontend.Services;

namespace lofi_frontend.Services;

public class AccessTokenService
{
    private readonly CookieService _cookieService;
    private readonly string _tokenKey = "jwt";

    public AccessTokenService(CookieService cookieService)
    {
        _cookieService = cookieService;
    }

    public async Task SetToken(string accessToken)
    {
        await _cookieService.Set(_tokenKey, accessToken, 1);
    }
    
    public async Task<string> GetToken()
    {
        return await _cookieService.Get(_tokenKey);
    }

    public async Task RemoveToken()
    {
        await _cookieService.Remove(_tokenKey);
    }
}