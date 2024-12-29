namespace MobileApp.Views;

public partial class CreatePinView : ContentPageBase
{
    private readonly CreatePinViewModel _viewModel;
    public CreatePinView(CreatePinViewModel viewModel)
    {
        BindingContext = _viewModel = viewModel;
        InitializeComponent();
    }

    private async void ScanButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            _viewModel.ShowPinFrame=true;
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
            _viewModel.ShowPinFrame = false;
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
        
        //if (_viewModel.IsInitialized)
        //{
        //    _viewModel.RefreshCommand.Execute(null);
        //}
    }
}
