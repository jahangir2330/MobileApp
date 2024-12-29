using BDO.Core.DataAccessObjects.ExtendedEntities;
using IdentityModel.Client;
using MobileApp.Services;
using MobileApp.Services.Identity;
using MobileApp.Services.OpenUrl;
using MobileApp.Services.Settings;
using MobileApp.Validations;
using MobileApp.ViewModels.Base;
using MobileApp.Views;
using System.Diagnostics;
using ZXing.QrCode.Internal;

namespace MobileApp.ViewModels;

public partial class LoginViewModel : ViewModelBase
{
    private readonly ISettingsService _settingsService;
    private readonly IOpenUrlService _openUrlService;
    private readonly IIdentityService _identityService;
    private readonly IDialogService _dialogService;

    [ObservableProperty]
    private ValidatableObject<string> _userName = new();

    [ObservableProperty]
    ValidatableObject<string> _password = new();

    [ObservableProperty]
    ValidatableObject<string> _pinCode = new();

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(MockSignInCommand))]
    private bool _isValid;

    [ObservableProperty]
    private bool _isMock;

    [ObservableProperty]
    private bool _isLogin;

    [ObservableProperty]
    private string _loginUrl;

    [ObservableProperty]
    private string _employeeNameEnglish;

    [ObservableProperty]
    private string _employeeNameArabic;

    [ObservableProperty]
    private string _employeeImagePath;

    [ObservableProperty]
    private bool _hasData;

    [ObservableProperty]
    private bool _hasPin;

    [ObservableProperty]
    private bool _hasEmployeeData;
    [ObservableProperty]
    private bool _hasVehicleData;

    [ObservableProperty]
    private string _vehicleNumberPlate;

    [ObservableProperty]
    private string _vehicleColor;

    [ObservableProperty]
    private string _vehicleRegistrationImagePath;

    public LoginViewModel(
        IOpenUrlService openUrlService,
        IIdentityService identityService,
        IDialogService dialogService,
        INavigationService navigationService, ISettingsService settingsService)
        : base(navigationService)
    {
        _settingsService = settingsService;
        _dialogService = dialogService;
        _openUrlService = openUrlService;
        _identityService = identityService;

        InvalidateMock();
        // test();
    }

    public override void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        base.ApplyQueryAttributes(query);

        if (query.ValueAsBool("Logout") == true)
        {
            PerformLogout();
        }
    }

    public override Task InitializeAsync()
    {
        return Task.CompletedTask;
    }

    [RelayCommand(CanExecute = nameof(IsValid))]
    public async Task MockSignInAsync()
    {
        await IsBusyFor(
            async () =>
            {
                bool isAuthenticated = false;

                try
                {
                    await Task.Delay(1000);
                    string pincode = PinCode.Value.Trim();
                    AppConfig.EncryptionHandler.EncryptionHelper objEnc = new AppConfig.EncryptionHandler.EncryptionHelper();
                    string EncryptedPin = objEnc.encryptSimple(pincode);
                    string savedPinCode = _settingsService.GetEncryptedPinCode();
                    if (EncryptedPin == savedPinCode)
                    {
                        isAuthenticated = true;
                    }

                    if (isAuthenticated)
                    {
                        await NavigationService.NavigateToAsync("//Employee");
                    }
                    else
                    {
                        await _dialogService.ShowAlertAsync("Error", "invalid credentials", "Ok");
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"[SignIn] Error signing in: {ex}");
                }
            });
    }

    [RelayCommand]
    public async Task SignInWithFingurePrintAsync()
    {
        await IsBusyFor(
            async () =>
            {
                await Task.Delay(10);

                IsValid = true;
                IsLogin = true;
                await NavigationService.NavigateToAsync("//Employee");

            });
    }
    [RelayCommand]
    private async Task SignInAsync()
    {
        await IsBusyFor(
            async () =>
            {
                await Task.Delay(10);

                LoginUrl = _identityService.CreateAuthorizationRequest();

                IsValid = true;
                IsLogin = true;
            });
    }


    [RelayCommand]
    private Task RegisterAsync()
    {
        return _openUrlService.OpenUrl(GlobalSetting.Instance.RegisterWebsite);
    }

    [RelayCommand]
    private void PerformLogout()
    {
        var authIdToken = _settingsService.AuthIdToken;
        var logoutRequest = _identityService.CreateLogoutRequest(authIdToken);

        if (!string.IsNullOrEmpty(logoutRequest))
        {
            // Logout
            LoginUrl = logoutRequest;
        }

        if (_settingsService.UseMocks)
        {
            _settingsService.AuthAccessToken = string.Empty;
            _settingsService.AuthIdToken = string.Empty;
        }

        _settingsService.UseFakeLocation = false;

        UserName.Value = string.Empty;
        Password.Value = string.Empty;
    }

    [RelayCommand]
    private async Task NavigateAsync(string url)
    {
        var unescapedUrl = System.Net.WebUtility.UrlDecode(url);

        if (unescapedUrl.Equals(GlobalSetting.Instance.LogoutCallback, StringComparison.OrdinalIgnoreCase))
        {
            _settingsService.AuthAccessToken = string.Empty;
            _settingsService.AuthIdToken = string.Empty;
            IsLogin = false;
            LoginUrl = _identityService.CreateAuthorizationRequest();
        }
        else if (unescapedUrl.Contains(GlobalSetting.Instance.Callback, StringComparison.OrdinalIgnoreCase))
        {
            var authResponse = new AuthorizeResponse(url);
            if (!string.IsNullOrWhiteSpace(authResponse.Code))
            {
                var userToken = await _identityService.GetTokenAsync(authResponse.Code);
                string accessToken = userToken.AccessToken;

                if (!string.IsNullOrWhiteSpace(accessToken))
                {
                    _settingsService.AuthAccessToken = accessToken;
                    _settingsService.AuthIdToken = authResponse.IdentityToken;
                    await NavigationService.NavigateToAsync("//Main/Catalog");
                }
            }
        }
    }

    [RelayCommand]
    private Task SettingsAsync()
    {
        return NavigationService.NavigateToAsync("Settings");
    }


    [RelayCommand]
    private async Task GoToCreatePinPage()
    {
        try
        {
            await Shell.Current.GoToAsync($"{nameof(CreatePinView)}?RequestType=CreatePin");
        }
        catch (Exception ex)
        {
            await _dialogService.ShowAlertAsync("Error", ex.Message, "Ok");
        }
    }

    [RelayCommand]
    private void Validate()
    {
        IsValid = PinCode.Validate();
    }

    private void AddValidations()
    {
        PinCode.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "PIN is required." });
    }
    public void InvalidateMock()
    {
        IsMock = _settingsService.UseMocks;
    } 
    public void CheckPinExist()
    {
        HasData = CheckHasPin();
    }
    //public void GetEmployeeData()
    //{
    //    var imageServerPath = GlobalSetting.FtpRootAddress + "/PersonalPicture/Large/";
    //    EmployeeNameEnglish = Preferences.Default.Get(SettingsService.KeyEmployeeNameEnglishBase, "Unknown");
    //    EmployeeNameArabic = Preferences.Default.Get(SettingsService.KeyEmployeeNameArabicBase, "Unknown");
    //    EmployeeImagePath = imageServerPath + Preferences.Default.Get(SettingsService.KeyEmployeeImagePathBase, "Unknown");
    //    HasData = CheckHasData();
    //}
    //public void GetVehicleData()
    //{
    //    var imageServerPath = GlobalSetting.FtpRootAddress + "/VehicleRegistration/Large/";
    //    VehicleNumberPlate = Preferences.Default.Get(SettingsService.KeyVehicleNumberPlate, "Unknown");
    //    VehicleColor = Preferences.Default.Get(SettingsService.KeyVehicleColor, "Unknown");
    //    VehicleRegistrationImagePath = imageServerPath + Preferences.Default.Get(SettingsService.KeyVehicleRegistrationImagePath, "Unknown");
    //    HasData = CheckHasData();
    //}
    private bool CheckHasPin()
    {
        bool retunvalue = false;
        var encPinCode = Preferences.Default.Get(SettingsService.KeyCachedPinCode, "");

        
        if (!string.IsNullOrEmpty(encPinCode))
        {
            retunvalue = true;
        }
        return retunvalue;
    }
}