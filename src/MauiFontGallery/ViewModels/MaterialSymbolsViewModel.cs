using System.Reflection;
using MaterialDesign;
using MauiFontGallery.Fonts;
namespace MauiFontGallery.ViewModels;

public class MaterialSymbolsViewModel : ViewModelBase
{
    public ObservableRangeCollection<FontDisplayItem> DisplayItems { get; } = new ObservableRangeCollection<FontDisplayItem>();
    
    public MaterialSymbolsViewModel(ILogger<MaterialSymbolsViewModel> logger)
        : base(logger)
    {
        Title = "Material Symbols";

        LoadFontIcons();
    }
    
    private void LoadFontIcons()
    {
        var displayItems = new List<FontDisplayItem>();

        var fields = typeof(MaterialSymbols).GetFields(BindingFlags.Public | BindingFlags.Static)
            .Where(f => f.FieldType == typeof(string))
            .ToList();

        foreach (var field in fields)
        {
            // There is currently no easy way to know if a font is a brand or not.

            displayItems.Add(new FontDisplayItem()
            {
                Title = field.Name,
                Glyph = field.GetValue(null) as string ?? string.Empty,
                FontFamily = FontConstants.MaterialSymbolsOutlined,
            });
        }

        DisplayItems.AddRange(displayItems);
    }
}