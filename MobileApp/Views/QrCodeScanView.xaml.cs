using ZXing;
using ZXing.Net.Maui.Controls;
using ZXing.Net.Maui;

namespace MobileApp.Views;
[XamlCompilation(XamlCompilationOptions.Skip)]
public partial class QrCodeScanView : ContentPage
{
    private readonly QrCodeScanViewModel _viewModel;
    public QrCodeScanView(QrCodeScanViewModel viewModel)
    {
        BindingContext = _viewModel = viewModel;
        InitializeComponent();

        barcodeView.Options = new BarcodeReaderOptions
        {
            Formats = BarcodeFormats.All,
            AutoRotate = true,
            Multiple = false
        };
    }

    protected override void OnAppearing()
    {
        _viewModel.IsDetecting = true;
    }

    protected async void BarcodesDetected(object sender, BarcodeDetectionEventArgs e)
    {
        try
        {
            foreach (var barcode in e.Results)
                Console.WriteLine($"Barcodes: {barcode.Format} -> {barcode.Value}");

            BarcodeResult first = e.Results?.FirstOrDefault();
            if (first is not null)
            {
                Dispatcher.Dispatch(async () =>
                {
                    // Update BarcodeGeneratorView
                    barcodeGenerator.ClearValue(BarcodeGeneratorView.ValueProperty);
                    barcodeGenerator.Format = first.Format;
                    barcodeGenerator.Value = first.Value;

                    await _viewModel.HandleBarcodeDetectedAsync(first.Value);
                    ResultLabel.Text = $"QR Code Detected! Set your PIN Now.";
                    barcodeView.IsDetecting = false;
                    //var navigationparam = new Dictionary<string, object>()
                    //{
                    //    {"qrcoderesult", first }
                    //};



                });
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "Ok");
        }
    }

    void SwitchCameraButton_Clicked(object sender, EventArgs e)
    {
        barcodeView.CameraLocation = barcodeView.CameraLocation == CameraLocation.Rear ? CameraLocation.Front : CameraLocation.Rear;
    }

    void TorchButton_Clicked(object sender, EventArgs e)
    {
        barcodeView.IsTorchOn = !barcodeView.IsTorchOn;
    }

    //void GoToCreatePin_Clicked(object sender, EventArgs e)
    //{
    //    App.Current.MainPage = new NavigationPage(new CreatePinView());
    //}

}
