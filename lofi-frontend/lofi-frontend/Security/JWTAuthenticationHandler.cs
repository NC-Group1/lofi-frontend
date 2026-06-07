using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;

namespace TokenPractice.Security;

public class JwtAuthenticationHandler : AuthenticationHandler<CustomOption>
{
    public JwtAuthenticationHandler(
        IOptionsMonitor<CustomOption> options, 
        ILoggerFactory logger, UrlEncoder encoder) : base(options, logger, encoder)
    { }

    protected override Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        try
        {
            try
            {
                var token = Request.Cookies["access_token"];
                if (string.IsNullOrEmpty(token))
                    return Task.FromResult(AuthenticateResult.NoResult());
            
                var readJwt = new JwtSecurityTokenHandler().ReadJwtToken(token);
                var identity = new ClaimsIdentity(readJwt.Claims, "JWT");
                var principal = new ClaimsPrincipal(identity);       
            
                var ticket = new AuthenticationTicket(principal, Scheme.Name);
            
                return Task.FromResult(AuthenticateResult.Success(ticket));
            }
            catch (Exception e)
            {
                return Task.FromResult(AuthenticateResult.NoResult());
            }
        }
        catch (Exception exception)
        {
            return Task.FromException<AuthenticateResult>(exception);
        }
    }

    protected override Task HandleChallengeAsync(AuthenticationProperties properties)
    {
        Response.Redirect("/login");
        return Task.CompletedTask;
    }

    protected override Task HandleForbiddenAsync(AuthenticationProperties properties)
    {
        Response.Redirect("/access-denied");
        return Task.CompletedTask;
    }
}

public class CustomOption : AuthenticationSchemeOptions
{
    
}