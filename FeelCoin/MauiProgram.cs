using FeelCoin.Services;
using FeelCoin.Services.Interfaces;
using FeelCoin.ViewModel;
using Microsoft.Extensions.Logging;

namespace FeelCoin
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddScoped<IStatisticsService, StatisticsService>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<StatisticsViewModel>();
            return builder.Build();
        }
    }
}
