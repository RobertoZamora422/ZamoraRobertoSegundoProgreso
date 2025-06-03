using Microsoft.Extensions.Logging;
using ZamoraRobertoSegundoProgreso.Services;

namespace ZamoraRobertoSegundoProgreso
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

            // Registrar servicios
            builder.Services.AddSingleton<HttpClient>();
            builder.Services.AddSingleton<IChistesService, ChistesService>();

            // Registrar páginas
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<ChistesPage>();
            builder.Services.AddTransient<AboutPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}