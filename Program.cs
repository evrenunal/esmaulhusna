using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Toolbelt.Blazor.Extensions.DependencyInjection;
using EsmaulHusna.Logic;

namespace EsmaulHusna
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddI18nText();
            builder.Services.AddSingleton<DragAndDropController>();
            builder.Services.AddBaseAddressHttpClient();


            await builder.Build().RunAsync();
        }
    }
}
