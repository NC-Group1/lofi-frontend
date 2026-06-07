using lofi_frontend.Client;
using lofi_frontend.Client.Pages;
using lofi_frontend.Components;
using Microsoft.AspNetCore.Components.Authorization;
using TokenPractice.Security;
using TokenPractice.Services;

namespace lofi_frontend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents()
                .AddInteractiveWebAssemblyComponents();

            builder.Services.AddHttpClient("BackendApi", client => {
                client.BaseAddress = new Uri("https://localhost:7245/");
            });

            builder.Services.AddScoped<CookieService>();
            builder.Services.AddScoped<AccessTokenService>();
            builder.Services.AddScoped<AuthService>();
            
            builder.Services.AddAuthorization();
            builder.Services.AddAuthentication(options =>
            {
                options.DefaultScheme = "JwtAuth";
                options.DefaultChallengeScheme = "JwtAuth";
                options.DefaultSignInScheme = "JwtAuth";
            }).AddScheme<CustomOption, JwtAuthenticationHandler>(
                "JwtAuth", options => { });
            
            builder.Services.AddScoped<JWTAuthenticationStateProvider>();
            builder.Services.AddScoped<AuthenticationStateProvider, JWTAuthenticationStateProvider>();
            builder.Services.AddCascadingAuthenticationState();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode()
                .AddInteractiveWebAssemblyRenderMode()
                .AddAdditionalAssemblies(typeof(Client._Imports).Assembly);

            app.Run();
        }
    }
}
