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

[QueryProperty(nameof(BarcodeText), "BarcodeText")]
public partial class TestPageViewModel : ViewModelBase
{
    private readonly IAppEnvironmentService _appEnvironmentService;
    private readonly ISettingsService _settingsService;
    private readonly IEmployeeService _employeeService;
    private readonly IVehicleService _vehicleService;
    private readonly IIdentityService _identityService;
    private readonly IDialogService _dialogService;

    public string BarcodeText { get; set; }

    private clsPrivateKeys objClsPrivate = new clsPrivateKeys();

    [ObservableProperty]
    private string _foundQrText;

    public TestPageViewModel(
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

        FoundQrText = BarcodeText;
    }

    public override async Task InitializeAsync()
    {
        FoundQrText = BarcodeText;

        string haspin = Preferences.Default.Get(SettingsService.KeyCachedPinCode, "");

        await base.InitializeAsync();
    }

}
