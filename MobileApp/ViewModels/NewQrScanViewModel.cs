using MobileApp.Services;
using MobileApp.Services.AppEnvironment;
using MobileApp.Services.Identity;
using MobileApp.Services.Vehicle;
using MobileApp.ViewModels.Base;
using MobileApp.Views;
using System.Windows.Input;
using ZXing.Net.Maui;

namespace MobileApp.ViewModels;

public partial class NewQrScanViewModel : ViewModelBase
{
    private readonly IAppEnvironmentService _appEnvironmentService;
    private readonly ISettingsService _settingsService;
    private readonly IVehicleService _vehicleService;
    private readonly IIdentityService _identityService;
    private readonly IDialogService _dialogService;

    [ObservableProperty]
    private bool _isDetecting = true;

    [ObservableProperty]
    private string _detectedBarcode;

    public ICommand RestartScanningCommand { get; }
    public ICommand StopScanningCommand { get; }

    public NewQrScanViewModel(
        IAppEnvironmentService appEnvironmentService,
        IIdentityService identityService,
        IDialogService dialogService,
        ISettingsService settingsService,
        IVehicleService vehicleService,
        INavigationService navigationService)
        : base(navigationService)
    {
        _appEnvironmentService = appEnvironmentService;
        _settingsService = settingsService;
        _identityService = identityService;
        _dialogService = dialogService;
        _vehicleService = vehicleService;
        RestartScanningCommand = new Command(RestartScanning);
        StopScanningCommand = new Command(StopScanning);
    }

    public override async Task InitializeAsync()
    {

        IsDetecting = true;
        await base.InitializeAsync();
    }
    public void HandleBarcodeDetected(ZXing.Net.Maui.BarcodeResult result)
    {
        if (result is null)
            return; 
        StopScanning(); 
        DetectedBarcode = result.Value;
    }

    public void RestartScanning()
    {
        IsDetecting = false;
        DetectedBarcode = string.Empty;
        IsDetecting = true;
    }

    public void StopScanning()
    {
        IsDetecting = false; // Disable the scanner
    }

}
