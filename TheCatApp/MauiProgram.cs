using Microsoft.Extensions.Logging;
using TheCatApp.Model.User;
using TheCatApp.View.COTD;
using TheCatApp.View.EndlessCats;
using TheCatApp.View.Games;
using TheCatApp.View.Main;
using TheCatApp.View.TherapyMode;
using TheCatApp.ViewModel.COTD;
using TheCatApp.ViewModel.EndlessCats;
using TheCatApp.ViewModel.Games;
using TheCatApp.ViewModel.Main;
using TheCatApp.ViewModel.TherapyMode;

namespace TheCatApp
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

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<CotdPage>();
            builder.Services.AddSingleton<CotdPageViewModel>();
            builder.Services.AddSingleton<EndlessCatsPage>();
            builder.Services.AddSingleton<EndlessCatsViewModel>();
            builder.Services.AddSingleton<TherapyModePage>();
            builder.Services.AddSingleton<TherapyModeViewModel>();
            builder.Services.AddSingleton<GamesPage>();
            builder.Services.AddSingleton<GamesPageViewModel>();
            builder.Services.AddSingleton<UserModel>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
