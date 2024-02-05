using CommunityToolkit.Maui;
using MauiFontGallery.Fonts.Hosting;
using MauiFontGallery.Pages;
using Sharpnado.CollectionView;

namespace MauiFontGallery;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .RegisterFonts()
            .UseMauiCommunityToolkit()
            .UseSharpnadoCollectionView(true)
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        builder.Services.AddTransient<FontAwesomePage>();
        builder.Services.AddTransient<MaterialSymbolsPage>();
        
        builder.Services.AddTransient<FontAwesomeViewModel>();
        builder.Services.AddTransient<MaterialSymbolsViewModel>();

        return builder.Build();
    }
}