using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Logging;
namespace MauiFontGallery.ViewModels;

public abstract partial class ViewModelBase(ILogger logger) : ObservableObject
{
    protected ILogger logger { get; } = Guard.Against.Null(logger, nameof(logger));
    
    [ObservableProperty]
    private string? title;
}