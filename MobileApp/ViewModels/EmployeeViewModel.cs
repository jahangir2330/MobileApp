using BDO.Core.DataAccessObjects.Models;
using MobileApp.Services;
using MobileApp.Services.AppEnvironment;
using MobileApp.Services.Employee;
using MobileApp.Services.Identity;
using MobileApp.ViewModels.Base;

namespace MobileApp.ViewModels;

public partial class EmployeeViewModel : ViewModelBase
{
    private readonly IAppEnvironmentService _appEnvironmentService;
    private readonly ISettingsService _settingsService;
    private readonly IEmployeeService _employeeService;

    private tran_applicationreqforempdetlEntity _employee;
    private readonly IDialogService _dialogService;
    private readonly IIdentityService _identityService;
    [ObservableProperty]
    private bool _hasEmployeeData; 
    
    public tran_applicationreqforempdetlEntity employee
    {
        get => _employee;
        set => SetProperty(ref _employee, value);
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

    public EmployeeViewModel(
        IAppEnvironmentService appEnvironmentService,
        ISettingsService settingsService,
        IDialogService dialogService,
        IIdentityService identityService,
        IEmployeeService employeeService,
        INavigationService navigationService)
        : base(navigationService)
    {
        _appEnvironmentService = appEnvironmentService;
        _settingsService = settingsService;
        _dialogService = dialogService;
        _identityService = identityService;
        _employeeService = employeeService;
        employee = new tran_applicationreqforempdetlEntity();
    }
    public void OnAppearing()
    {
        HasEmployeeData = Preferences.Default.Get(SettingsService.KeyHasEmployeeData, false);
    }
    public override async Task InitializeAsync()
    {
        //var x = CLL.LLClasses.Models._exchangedocument.CivilIdAuthenticatedMessage;
        await SetData();
    }
    private async Task SetData()
    {
        try
        {
            await IsBusyFor(
               async () =>
               {
                   if (_settingsService.HasEmployeeData && _employeeService.GetEmployeeDataFromCache() is not null)
                   {
                       employee = _employeeService.GetEmployeeDataFromCache();
                   }
                   else
                   {
                       employee = new tran_applicationreqforempdetlEntity();
                       //await _dialogService.ShowAlertAsync("Error", "Failed to fetch Data, Scan QR code again please", "Ok");
                   }

               });
        }
        catch (Exception ex)
        {
            await _dialogService.ShowAlertAsync("Error", ex.Message, "Ok");
            employee = new tran_applicationreqforempdetlEntity();
        }
    }

   
    //[RelayCommand]
    //private async Task RefreshAsync()
    //{
    //    if (IsBusy)
    //    {
    //        return;
    //    }

    //    await IsBusyFor(
    //        async () =>
    //        {
    //            // Get orders
    //            var authToken = _settingsService.AuthAccessToken;
    //            var orders = await _appEnvironmentService.OrderService.GetOrdersAsync(authToken);

    //            // _orders.ReloadData(orders);
    //        });
    //}

    //[RelayCommand]
    //private async Task OrderDetailAsync(Order order)
    //{
    //    if (order is null || IsBusy)
    //    {
    //        return;
    //    }
    //    //xxxxx
    //    await NavigationService.NavigateToAsync(
    //        "OrderDetail",
    //        new Dictionary<string, object> { { nameof(Order.OrderNumber), order.OrderNumber } });
    //}
}
