using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAlertModalNavigationIssue;

public partial class SubPage
{
    private readonly bool _isModal;

    public SubPage(bool isModal)
    {
        _isModal = isModal;
        InitializeComponent();
    }

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        if (_isModal)
            Navigation.PopModalAsync(true);
        else
            Navigation.PopAsync(true);
    }
}