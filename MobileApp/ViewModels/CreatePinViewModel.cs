using MobileApp.Services;
using MobileApp.Services.AppEnvironment;
using MobileApp.Services.Settings;
using MobileApp.ViewModels.Base;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using IdentityModel.Client;
using MobileApp.Services.Identity;
using MobileApp.Services.OpenUrl;
using MobileApp.Validations;
using System.Diagnostics;
using ZXing.QrCode.Internal;
using AppConfig.HelperClasses;
using System.Web;
using MobileApp.Services.Employee;
using MobileApp.Services.Vehicle;
using MobileApp.Views;
namespace MobileApp.ViewModels;

[QueryProperty(nameof(RequestType), "RequestType")]
[QueryProperty(nameof(RequestCategory), "RequestCategory")]
public partial class CreatePinViewModel : ViewModelBase
{
    private readonly IAppEnvironmentService _appEnvironmentService;
    private readonly ISettingsService _settingsService;
    private readonly IEmployeeService _employeeService;
    private readonly IVehicleService _vehicleService;
    private readonly IIdentityService _identityService;
    private readonly IDialogService _dialogService;
    public string RequestType { get; set; }
    public string RequestCategory { get; set; }
    private clsPrivateKeys objClsPrivate = new clsPrivateKeys();
    string employeeVerifyUrl = Preferences.Default.Get(SettingsService.KeyEmployeeVerifyUrl, "");
    string vehicleVerifyUrl = Preferences.Default.Get(SettingsService.KeyVehicleVerifyUrl, "");

    [ObservableProperty]
    private bool _isValid;


    [ObservableProperty]
    private bool _showPinFrame;
    [ObservableProperty]
    private bool _showScanFrame;
    [ObservableProperty]
    private bool _showGoToFrame;

    [ObservableProperty]
    ValidatableObject<string> _pinCode = new();

    [ObservableProperty]
    ValidatableObject<string> _repeatPinCode = new();

    public CreatePinViewModel(
        IAppEnvironmentService appEnvironmentService,
        IIdentityService identityService,
        IDialogService dialogService,
        ISettingsService settingsService,
        IEmployeeService employeeService,
        IVehicleService vehicleService,
        INavigationService navigationService)
        : base(navigationService)
    {
        _appEnvironmentService = appEnvironmentService;
        _settingsService = settingsService;
        _identityService = identityService;
        _dialogService = dialogService;
        _employeeService = employeeService;
        _vehicleService = vehicleService;
    }

    public override async Task InitializeAsync()
    {
        employeeVerifyUrl = Preferences.Default.Get(SettingsService.KeyEmployeeVerifyUrl, "");
        vehicleVerifyUrl = Preferences.Default.Get(SettingsService.KeyVehicleVerifyUrl, "");
        string haspin = Preferences.Default.Get(SettingsService.KeyCachedPinCode, "");
        ShowScanFrame = false;
        ShowGoToFrame = false;
        ShowPinFrame = false;
        if (RequestType == "CreatePin")
        {
            ShowScanFrame = true;
        }
        //else if (RequestType == "QrDetected")
        //{
        //    if (!string.IsNullOrEmpty(haspin))
        //    {
        //        if (RequestCategory == "Employee" && !string.IsNullOrEmpty(employeeVerifyUrl))
        //        {
        //            await SetEmployeeDataInCache();
        //            await NavigationService.NavigateToAsync("///Employee");
        //        }
        //        else if (RequestCategory == "Vehicle" && !string.IsNullOrEmpty(vehicleVerifyUrl))
        //        {
        //            await SetVehicleDataInCache();
        //            await NavigationService.NavigateToAsync("///Vehicle");
        //        }
        //        else
        //        {
        //            await Shell.Current.GoToAsync($"{nameof(CreatePinView)}?RequestType=CreatePin&RequestCategory=updt");
        //        }
        //    }
        //    else
        //    {
        //        await Shell.Current.GoToAsync($"{nameof(CreatePinView)}?RequestType=CreatePin&RequestCategory=updt");

        //        ShowPinFrame = true;
        //    }
        //    RequestType = "";
        //}


    }
    [RelayCommand]
    public async Task SetPinCode()
    {

        await IsBusyFor(
            async () =>
            {
                bool isAuthenticated = false;

                try
                {
                    await Task.Delay(1000);
                    string pincode = PinCode.Value.Trim();
                    string repeatpincode = RepeatPinCode.Value.Trim();

                    AppConfig.EncryptionHandler.EncryptionHelper objEnc = new AppConfig.EncryptionHandler.EncryptionHelper();
                    string EncryptedPin = objEnc.encryptSimple(pincode);

                    if (_settingsService.SetEncryptedPinCode(EncryptedPin))
                    {
                        isAuthenticated = true;
                        await _dialogService.ShowAlertAsync("Pin Saved", "Success", "Ok");
                    }
                    else
                    {
                        isAuthenticated = false;
                        await _dialogService.ShowAlertAsync("Error", "Failed to store PIN", "Ok");
                    }

                    if (isAuthenticated)
                    {
                        ShowPinFrame = true;
                        _settingsService.AuthAccessToken = GlobalSetting.Instance.AuthToken;
                        await NavigationService.NavigateToAsync("//Employee");
                    }
                    else
                    {
                        await _dialogService.ShowAlertAsync("Error", "invalid credentials", "Ok");
                        await NavigationService.NavigateToAsync("Login");
                    }
                }
                catch (Exception ex)
                {
                    ShowPinFrame = false;
                    Debug.WriteLine($"[SignIn] Error signing in: {ex}");
                }
            });
    }

    private async Task SetEmployeeDataInCache()
    {
        string onlyParamsValue = employeeVerifyUrl.Split('?')[1].Replace("params=", "");
        var requestemployeeid = long.Parse(objClsPrivate.DecryptFromOnlyText("requestemployeeid", onlyParamsValue).ToString());

        string authToken = string.IsNullOrEmpty(_settingsService.AuthAccessToken) || _settingsService.AuthAccessToken == "NO TOKEN" ? await GetAccessToken() : _settingsService.AuthAccessToken;
        await _employeeService.SetEmployeeData(requestemployeeid, authToken);
    }

    private async Task SetVehicleDataInCache()
    {
        string onlyParamsValue = vehicleVerifyUrl.Split('?')[1].Replace("params=", "");
        var requestVehicleid = long.Parse(objClsPrivate.DecryptFromOnlyText("Vehicleinfoid", onlyParamsValue).ToString());

        string authToken = string.IsNullOrEmpty(_settingsService.AuthAccessToken) || _settingsService.AuthAccessToken == "NO TOKEN" ? await GetAccessToken() : _settingsService.AuthAccessToken;
        await _vehicleService.SetVehicleData(requestVehicleid, authToken);
    }

    private async Task<string> GetAccessToken()
    {
        try
        {
            string retunvalue = "";
            apiAccessToken apiAccessToken = await _identityService.GetToken(GlobalSetting.ApiUsername, GlobalSetting.ApiPassword, GlobalSetting.ApiIpAddress);
            if (!string.IsNullOrWhiteSpace(apiAccessToken.accessToken))
            {
                GlobalSetting.Instance.AuthToken = apiAccessToken.accessToken;
                _settingsService.AuthAccessToken = GlobalSetting.Instance.AuthToken;
                retunvalue = apiAccessToken.accessToken;
            }
            return retunvalue;
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    [RelayCommand]
    private void Validate()
    {
        IsValid = PinCode.Validate();
        //UserName.Validate() && Password.Validate();
    }

}
