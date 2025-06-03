using Microsoft.Extensions.Logging;

namespace ZamoraRobertoSegundoProgreso;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => { /* ... */ });

        // Agrega estas líneas:
        builder.Services.AddSingleton<HttpClient>();
        builder.Services.AddTransient<ChistesPage>();
        builder.Services.AddTransient<AboutPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}