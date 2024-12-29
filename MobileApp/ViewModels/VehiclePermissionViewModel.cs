using BDO.Core.DataAccessObjects.Models;
using MobileApp.Services;
using MobileApp.Services.AppEnvironment;
using MobileApp.Services.Identity;
using MobileApp.Services.Vehicle;
using MobileApp.ViewModels.Base;

namespace MobileApp.ViewModels;

public partial class VehiclePermissionViewModel : ViewModelBase
{
    private readonly IAppEnvironmentService _appEnvironmentService;
    private readonly ISettingsService _settingsService;
    private readonly IVehicleService _vehicleService;

    private tran_applicationreqforvehicledetlEntity _vehicle;
    private readonly IDialogService _dialogService;
    private readonly IIdentityService _identityService; 

    [ObservableProperty]
    private bool _hasVehicleData;
    public tran_applicationreqforvehicledetlEntity vehicle
    {
        get => _vehicle;
        set => SetProperty(ref _vehicle, value);
    }
    #region Field

    #endregion
    public async void LoadItemId(string itemId)
    {
        try
        {
            await App.Current.MainPage.DisplayAlert("Error", "Failed to Load Item", "Ok");
        }
        catch (Exception)
        {
            await App.Current.MainPage.DisplayAlert("Error", "Failed to Load Item", "Ok");
        }
    }

    public VehiclePermissionViewModel(
        IAppEnvironmentService appEnvironmentService,
        ISettingsService settingsService,
        IDialogService dialogService,
        IIdentityService identityService,
        IVehicleService vehicleService,
        INavigationService navigationService)
        : base(navigationService)
    {
        _appEnvironmentService = appEnvironmentService;
        _settingsService = settingsService;
        _dialogService = dialogService;
        _identityService = identityService;
        _vehicleService = vehicleService;
        vehicle = new tran_applicationreqforvehicledetlEntity();
    }
    public void OnAppearing()
    {
        HasVehicleData = Preferences.Default.Get(SettingsService.KeyHasVehicleData, false);
    }
    public override async Task InitializeAsync()
    {
        await SetData();
    }
    private async Task SetData()
    {
        try
        {
            await IsBusyFor(
               async () =>
               {
                   if (_settingsService.HasVehicleData && _vehicleService.GetVehicleDataFromCache() is not null)
                   {
                       vehicle = _vehicleService.GetVehicleDataFromCache();
                   }
                   else
                   {
                       vehicle = new tran_applicationreqforvehicledetlEntity();
                       //await _dialogService.ShowAlertAsync("Error", "Failed to fetch Data, Scan QR code again please", "Ok");
                   }
               });
        }
        catch (Exception ex)
        {
            await _dialogService.ShowAlertAsync("Error", ex.Message, "Ok");
            vehicle = new tran_applicationreqforvehicledetlEntity();
        }
    }

}
