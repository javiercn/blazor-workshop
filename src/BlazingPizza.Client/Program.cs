using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace BlazingPizza.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = CreateBuilder(args);

            await builder.Build().RunAsync();
        }

        public static WebAssemblyHostBuilder CreateBuilder(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddRemoteAuthentication<PizzaAuthenticationState, ApiAuthorizationProviderOptions>();
            builder.Services.AddApiAuthorization();

            builder.Services.AddBaseAddressHttpClient();

            builder.Services.AddScoped<OrderState>();

            builder.RootComponents.Add<App>("app");
            
            return builder;
        }
    }
}
