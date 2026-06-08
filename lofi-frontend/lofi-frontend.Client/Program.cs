using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace lofi_frontend.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddScoped(sp => 
                new HttpClient(new HttpClientHandler())
            {
                BaseAddress = new Uri("https://localhost:7245/")
            });
            
            builder.Services.AddAuthorizationCore();
            await builder.Build().RunAsync();
        }
    }
}
