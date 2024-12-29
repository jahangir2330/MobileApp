using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Web;
using System.Windows.Input;
using AppConfig.HelperClasses;
using BDO.Core.DataAccessObjects.Models;
using MobileApp.Services;
using MobileApp.Services.AppEnvironment;
using MobileApp.Services.Location;
using MobileApp.Services.Settings;
using MobileApp.ViewModels.Base;
using MobileApp.Views;

namespace MobileApp.ViewModels;
public partial class QrCodeScanViewModel : ViewModelBase
{
    private readonly ISettingsService _settingsService;
    private readonly ILocationService _locationService;
    private readonly IAppEnvironmentService _appEnvironmentService;
    private readonly IDialogService _dialogService;


    [ObservableProperty]
    private bool _showCamera;
    [ObservableProperty]
    private bool _isDetecting;
    [ObservableProperty]
    private string _detectedUrl;
    public bool UserIsLogged => !string.IsNullOrEmpty(_settingsService.AuthAccessToken);



    public QrCodeScanViewModel(
        ILocationService locationService, IAppEnvironmentService appEnvironmentService,
        INavigationService navigationService,
        IDialogService dialogService,
        ISettingsService settingsService)
        : base(navigationService)
    {
        _settingsService = settingsService;
        _locationService = locationService;
        _dialogService = dialogService;
        _appEnvironmentService = appEnvironmentService;
        ShowCamera = true;
        IsDetecting = true;
    }
    

    public async Task HandleBarcodeDetectedAsync(string barcode)
    {
        string myUri = new Uri(barcode).AbsolutePath;
        //string requestcategory = "";
        //if (myUri== "/Tran_ApplicationReqForEmpDetl/Verify")
        //{
        //    Preferences.Default.Set(SettingsService.KeyEmployeeVerifyUrl, barcode);
        //    requestcategory = "Employee";
        //}
        //else if (myUri == "/Tran_ApplicationReqForVehicleDetl/Verify") {

        //    Preferences.Default.Set(SettingsService.KeyVehicleVerifyUrl, barcode);
        //    requestcategory = "Vehicle";
        //}
        //else
        //{
           
        //    //await _dialogService.ShowAlertAsync("Error", "Invalid QR Code", "Ok");
        //}


        MainThread.BeginInvokeOnMainThread(async () =>
        {
            await Task.Delay(1000);
            DetectedUrl = barcode;
            IsDetecting = false;
            ShowCamera = false;
        });
        IsDetecting = false;
        await Shell.Current.GoToAsync($"{nameof(TestPageView)}?BarcodeText={barcode}");
    }

  }
