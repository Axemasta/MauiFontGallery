namespace MauiFontGallery.Fonts.Hosting;

public static class MauiAppBuilderExtensions
{
    public static MauiAppBuilder RegisterFonts(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.ConfigureFonts(fonts =>
        {
            // Font Awesome
            fonts.AddFont("fa-brands-400.ttf", FontConstants.FontAwesomeFreeBrands);
            fonts.AddFont("fa-regular-400.ttf", FontConstants.FontAwesomeFreeRegular);
            fonts.AddFont("fa-solid-900.ttf", FontConstants.FontAwesomeFreeSolid);
            
            // Material Symbols
            fonts.AddFont("MaterialSymbolsRounded.ttf", FontConstants.MaterialSymbolsRounded);
            fonts.AddFont("MaterialSymbolsOutlined.ttf", FontConstants.MaterialSymbolsOutlined);
            fonts.AddFont("MaterialSymbolsSharp.ttf", FontConstants.MaterialSymbolsSharp);
        });
        
        return mauiAppBuilder;
    }
}