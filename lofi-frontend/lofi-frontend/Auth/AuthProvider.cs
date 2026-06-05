using System.Security.Claims;
using lofi_frontend.Models;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;

namespace lofi_frontend.Client
{
    public class AuthProvider : AuthenticationStateProvider
    {
        private readonly HttpClient _httpClient;
        private ClaimsPrincipal _anonymous = new ClaimsPrincipal(new ClaimsIdentity());

        public AuthProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "api/auth/me");
                request.SetBrowserRequestCredentials(BrowserRequestCredentials.Include);

                var response = await _httpClient.SendAsync(request);

                if (!response.IsSuccessStatusCode)
                {
                    return new AuthenticationState(_anonymous);
                }
                var userInfo = await response.Content.ReadFromJsonAsync<UserInfo>();

                if (userInfo == null)
                {
                    return new AuthenticationState(_anonymous);
                }

                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, userInfo.Email),
                    new Claim(ClaimTypes.NameIdentifier, userInfo.Id)
                };

                var identity = new ClaimsIdentity(claims, "CookieAuth");
                return new AuthenticationState(new ClaimsPrincipal(identity));

            }
            catch (Exception ex)
            {
                return new AuthenticationState(_anonymous);
            }
        }
    }

    public record UserInfo(string Id, string Email);
}
