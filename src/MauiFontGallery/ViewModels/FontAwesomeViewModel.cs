using System.Reflection;
using FontAwesome;
using MauiFontGallery.Extensions;
using MauiFontGallery.Fonts;
namespace MauiFontGallery.ViewModels;

public class FontAwesomeViewModel : ViewModelBase
{
    public ObservableRangeCollection<FontDisplayItem> DisplayItems { get; } = new ObservableRangeCollection<FontDisplayItem>();
    
    public FontAwesomeViewModel(ILogger<FontAwesomeViewModel> logger)
    : base(logger)
    {
        Title = "Font Awesome";
        
        LoadFontIcons();
    }
    
    private void LoadFontIcons()
    {
        var displayItems = new List<FontDisplayItem>();

        var fields = typeof(FontAwesomeIcons).GetFields(BindingFlags.Public | BindingFlags.Static)
            .Where(f => f.FieldType == typeof(string))
            .ToList();

        foreach (var field in fields)
        {
            string fontFamily;
            
            if (field.TryGetCustomAttribute(out SupportedFreeFontsAttribute? attribute) && attribute is not null)
            {
                if (attribute.SupportedFonts.Contains(FAStyle.Unsupported))
                {
                    // Dont display this font, you need the pro fonts!
                    logger.LogDebug("Skipping icon {IconName} due to being unsupported at the free tier", field.Name);
                    continue;
                }
                
                fontFamily = attribute.SupportedFonts.Contains(FAStyle.Brands)
                    ? FontConstants.FontAwesomeFreeBrands
                    : FontConstants.FontAwesomeFreeSolid;
            }
            else
            {
                logger.LogWarning("Icon {IconName} did not have a supported font attribute", field.Name);
                continue;
            }

            displayItems.Add(new FontDisplayItem()
            {
                Title = field.Name,
                Glyph = field.GetValue(null) as string ?? string.Empty,
                FontFamily = fontFamily,
            });
        }

        DisplayItems.AddRange(displayItems);
    }
}