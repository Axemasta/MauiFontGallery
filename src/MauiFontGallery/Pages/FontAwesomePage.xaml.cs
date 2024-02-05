using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiFontGallery.Pages.Base;

namespace MauiFontGallery.Pages;

public partial class FontAwesomePage : BaseContentPage<FontAwesomeViewModel>
{
    public FontAwesomePage(FontAwesomeViewModel viewModel)
        : base(viewModel)
    {
        InitializeComponent();
    }
}