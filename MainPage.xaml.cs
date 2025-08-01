namespace MauiAlertModalNavigationIssue;

public partial class MainPage
{
    public MainPage() => InitializeComponent();
    
    protected override void OnAppearing()
    {
        base.OnAppearing();
        Dispatcher.DispatchAsync(ShowAlert);
    }

    private async Task ShowAlert()
    {
        await Task.Delay(250);
        StateLabel.Text = "Alert showing!\nCan you see it?";
        await DisplayAlert("My alert", "Can you see this alert?", "Yes");
        StateLabel.Text = "Alert closed";
    }

    private void OnOpenModalClicked(object? sender, EventArgs e) => Navigation.PushModalAsync(new SubPage(true));

    private void OnOpenPageClicked(object? sender, EventArgs e) => Navigation.PushAsync(new SubPage(false));
}