using ZXing.Net.Maui;

namespace MobileApp.Views;

public partial class NewQrScanView : ContentPageBase
{
    private readonly NewQrScanViewModel _viewModel;

    public NewQrScanView(NewQrScanViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = _viewModel = viewModel;
    }


    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewModel.RestartScanning();
        // Explicitly restart scanning when the page appears
        if (!_viewModel.IsDetecting)
        {
        }
    }

    private void OnBarcodesDetected(object sender, BarcodeDetectionEventArgs e)
    {
        ZXing.Net.Maui.BarcodeResult firstBarcode = e.Results?.FirstOrDefault();

        if (firstBarcode != null)
        {
            _viewModel.HandleBarcodeDetected(firstBarcode);
        }
        Dispatcher.DispatchAsync(async () =>
        {
            await Shell.Current.GoToAsync($"{nameof(TestPageView)}?BarcodeText={firstBarcode.Value}");
        });
    }

    void SwitchCameraButton_Clicked(object sender, EventArgs e)
    {
        cameraBarcodeReaderView.CameraLocation = cameraBarcodeReaderView.CameraLocation == CameraLocation.Rear ? CameraLocation.Front : CameraLocation.Rear;
    }

    void TorchButton_Clicked(object sender, EventArgs e)
    {
        cameraBarcodeReaderView.IsTorchOn = !cameraBarcodeReaderView.IsTorchOn;
    }

}
