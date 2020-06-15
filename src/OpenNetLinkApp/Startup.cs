using Microsoft.Extensions.DependencyInjection;
using OpenNetLinkApp.Pages.Services;
using WebWindows.Blazor;

namespace OpenNetLinkApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<DragAndDropService>();
        }

        public void Configure(DesktopApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
