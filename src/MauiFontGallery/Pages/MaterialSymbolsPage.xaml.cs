using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiFontGallery.Pages.Base;

namespace MauiFontGallery.Pages;

public partial class MaterialSymbolsPage : BaseContentPage<MaterialSymbolsViewModel>
{
    public MaterialSymbolsPage(MaterialSymbolsViewModel viewModel)
        : base(viewModel)
    {
        InitializeComponent();
    }
}