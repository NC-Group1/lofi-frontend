using Microsoft.JSInterop;

namespace TokenPractice.Services;

public class CookieService
{
    private readonly IJSRuntime js;

    public CookieService(IJSRuntime jsRuntime)
    {
        js = jsRuntime;
    }

    public async Task<string> Get(string key)
    {
        return await js.InvokeAsync<string>("getCookie", key);
    }

    public async Task Remove(string key)
    {
        await js.InvokeVoidAsync("deleteCookie", key);
    }

    public async Task Set(string key, string value, int days)
    {
        await js.InvokeVoidAsync("setCookie", key, value);
    }
}