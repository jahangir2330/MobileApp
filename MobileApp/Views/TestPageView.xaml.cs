namespace MobileApp.Views;

public partial class TestPageView : ContentPageBase
{
    private readonly TestPageViewModel _viewModel;
    public TestPageView(TestPageViewModel viewModel)
    {
        BindingContext = _viewModel = viewModel;
        InitializeComponent();
    }

    private async void ScanButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Shell.Current.GoToAsync(nameof(QrCodeScanView));
        }
        catch (Exception ex)
        {
            await DisplayAlert("a", ex.Message, "ok");
        }
    }

    private async void btnSetPin_Clicked(object sender, EventArgs e)
    {
        try
        {
           await Shell.Current.GoToAsync("../Employee");
        }
        catch (Exception ex)
        {
            await DisplayAlert("a", ex.Message, "ok");
        }
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();        
    }


    
}
