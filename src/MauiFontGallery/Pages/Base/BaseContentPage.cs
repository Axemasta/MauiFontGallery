namespace MauiFontGallery.Pages.Base;

public abstract class BaseContentPage<TViewModel> : ContentPage
    where TViewModel : ViewModelBase
{
    protected TViewModel ViewModel { get; }

    protected BaseContentPage(TViewModel viewModel)
    {
        viewModel = Guard.Against.Null(viewModel, nameof(viewModel));

        BindingContext = viewModel;
        ViewModel = viewModel;
    }
}