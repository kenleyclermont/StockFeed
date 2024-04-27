using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using StockFeed.Views;
using StockFeed.Services;
using StockFeed.ViewModels;

namespace StockFeed
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
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<IBMPage>();
            builder.Services.AddSingleton<IBMService>();
            builder.Services.AddSingleton<IBMPageViewModel>();
            return builder.Build();
        }
    }
}
