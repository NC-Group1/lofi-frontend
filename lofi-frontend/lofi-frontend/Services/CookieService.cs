using Microsoft.JSInterop;

namespace lofi_frontend.Services;

public class CookieService
{
    private readonly IJSRuntime _js;

    public CookieService(IJSRuntime jsRuntime)
    {
        _js = jsRuntime;
    }

    public async Task<string> Get(string key)
    {
        return await _js.InvokeAsync<string>("getCookie", key);
    }

    public async Task Remove(string key)
    {
        await _js.InvokeVoidAsync("deleteCookie", key);
    }

    public async Task Set(string key, string value, int days)
    {
        await _js.InvokeVoidAsync("setCookie", key, value);
    }
}