using CommunityToolkit.Maui;
using MauiTestApp.Controls;
using MauiTestApp.Handlers;
using Microsoft.Extensions.Logging;

namespace MauiTestApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("Kastore-Bold.otf", "Kastore-Bold");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                }).ConfigureMauiHandlers(handlers =>
                {
                    handlers.AddHandler(typeof(CustomEntry), typeof(CustomEntryHandler));
                });
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}