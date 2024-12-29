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


namespace MobileApp.ViewModels;

public partial class ProfileViewModel : ViewModelBase
{
    private readonly IAppEnvironmentService _appEnvironmentService;
    private readonly ISettingsService _settingsService;
    private readonly IEmployeeService _employeeService;
    private readonly IIdentityService _identityService;
    private readonly IDialogService _dialogService;
    private clsPrivateKeys objClsPrivate = new clsPrivateKeys();

    [ObservableProperty]
    private bool _isValid;

    [ObservableProperty]
    private bool _showPinFrame;

    [ObservableProperty]
    ValidatableObject<string> _currentPinCode = new();

    [ObservableProperty]
    ValidatableObject<string> _pinCode = new();

    [ObservableProperty]
    ValidatableObject<string> _repeatPinCode = new();

    public ProfileViewModel(
        IAppEnvironmentService appEnvironmentService,
        IIdentityService identityService,
        IDialogService dialogService,
        ISettingsService settingsService,
        IEmployeeService employeeService,
        INavigationService navigationService)
        : base(navigationService)
    {
        _appEnvironmentService = appEnvironmentService;
        _settingsService = settingsService;
        _identityService = identityService;
        _dialogService = dialogService;
        _employeeService = employeeService;

    }

    public override Task InitializeAsync()
    {
        return Task.CompletedTask;
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
                    AppConfig.EncryptionHandler.EncryptionHelper objEnc = new AppConfig.EncryptionHandler.EncryptionHelper();

                    string pincode = PinCode.Value.Trim();
                    string repeatpincode = RepeatPinCode.Value.Trim();
                    string currentPinFromInput = CurrentPinCode.Value.Trim();
                    string encryptedCurrntPin = objEnc.encryptSimple(currentPinFromInput);
                    string currentPinFromCache = _settingsService.GetEncryptedPinCode().Trim();

                    if (encryptedCurrntPin != currentPinFromCache)
                    {
                        await _dialogService.ShowAlertAsync("Error", "Old PIN is incorrect", "Ok");
                        isAuthenticated = false; 
                        return;
                    }
                    if (pincode != repeatpincode)
                    {
                        await _dialogService.ShowAlertAsync("Error", "New PIN and Repeat PIN mismatch", "Ok");
                        isAuthenticated = false; 
                        return;
                    }

                    string EncryptedPin = objEnc.encryptSimple(pincode);

                    if (_settingsService.SetEncryptedPinCode(EncryptedPin))
                    {
                        string verifyUrl = Preferences.Default.Get(SettingsService.KeyEmployeeVerifyUrl, "");
                        if (string.IsNullOrEmpty(verifyUrl))
                        {
                            await _dialogService.ShowAlertAsync("Error", "Failed to store PIN, URL Not found", "Ok");
                        }
                        string onlyParamsValue = verifyUrl.Split('?')[1].Replace("params=", "");
                        var requestemployeeid = long.Parse(objClsPrivate.DecryptFromOnlyText("requestemployeeid", onlyParamsValue).ToString());

                        string authToken = string.IsNullOrEmpty(_settingsService.AuthAccessToken) || _settingsService.AuthAccessToken == "NO TOKEN" ? await GetAccessToken() : _settingsService.AuthAccessToken;
                        await _employeeService.SetEmployeeData(requestemployeeid, authToken);

                        isAuthenticated = true;
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
                        await NavigationService.NavigateToAsync("Employee");
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
    private async Task<string> GetAccessToken()
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

    [RelayCommand]
    private void Validate()
    {
        IsValid = PinCode.Validate();
        //UserName.Validate() && Password.Validate();
    }

   

}
