using MobileApp.Services;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MobileApp.ViewModels.Base;

public abstract partial class ViewModelBase : ObservableObject, IViewModelBase
{


    private FlowDirection _flowDirection = FlowDirection.LeftToRight;
    public FlowDirection FlowDirection
    {
        get => _flowDirection;
        set
        {
            if (_flowDirection != value)
            {
                _flowDirection = value;
                OnPropertyChanged();
            }
        }
    }

    public ICommand ToggleFlowDirectionCommand { get; }

    private long _isBusy;

    public bool IsBusy => Interlocked.Read(ref _isBusy) > 0;

    [ObservableProperty]
    private bool _isInitialized;

    public INavigationService NavigationService { get; }

    public IAsyncRelayCommand InitializeAsyncCommand { get; }

    public ViewModelBase(INavigationService navigationService)
    {
        NavigationService = navigationService;
        ToggleFlowDirectionCommand = new Command(ToggleFlowDirection);
        InitializeAsyncCommand =
            new AsyncRelayCommand(
                async () =>
                {
                    await IsBusyFor(InitializeAsync);
                    IsInitialized = true;
                },
                AsyncRelayCommandOptions.FlowExceptionsToTaskScheduler);
    }


    public virtual void ApplyQueryAttributes(IDictionary<string, object> query)
    {
    }

    public virtual Task InitializeAsync()
    {
        return Task.CompletedTask;
    }

    public async Task IsBusyFor(Func<Task> unitOfWork)
    {
        Interlocked.Increment(ref _isBusy);
        OnPropertyChanged(nameof(IsBusy));

        try
        {
            await unitOfWork();
        }
        finally
        {
            Interlocked.Decrement(ref _isBusy);
            OnPropertyChanged(nameof(IsBusy));
        }
    }
    private void ToggleFlowDirection()
    {
        FlowDirection = (FlowDirection == FlowDirection.LeftToRight) ? FlowDirection.RightToLeft : FlowDirection.LeftToRight;

        // Update flow direction for all pages
        if (Application.Current.MainPage is NavigationPage navPage)
        {
            foreach (var page in navPage.Navigation.NavigationStack)
            {
                page.FlowDirection = FlowDirection;
            }
        }
        else
        {
            Application.Current.MainPage.FlowDirection = FlowDirection;
        }
    }

    [RelayCommand]
    private async Task LogoutAsync()
    {
        try
        {
            //ClearEmployeeRelatedCache();
            //ClearVehicleRelatedCache();
            //ClearCommonCache();
            await PerformeLogout();
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Exception: {ex.Message}");
        }
    }

    private async Task PerformeLogout()
    {
        if (NavigationService == null)
        {
            Debug.WriteLine("NavigationService is null");
            return;
        }

        if (IsBusyFor == null)
        {
            Debug.WriteLine("IsBusyFor is null");
            return;
        }
        await IsBusyFor(
           async () =>
           {
               await NavigationService.NavigateToAsync("//Login", new Dictionary<string, object> { { "Logout", true } });
           });
    }

    [RelayCommand]
    private async Task ResetEmployeeAsync()
    {
        ClearEmployeeRelatedCache();

        await PerformeLogout();
    }

    [RelayCommand]
    private async Task ResetVehicleAsync()
    {
        ClearVehicleRelatedCache();
        await PerformeLogout();
    }
    private void ClearCommonCache()
    {
        Preferences.Remove(SettingsService.KeyCachedPinCode);
        Preferences.Remove(SettingsService.KeyCurrentCulture);
        Preferences.Remove(SettingsService.KeyHasData);
    }
    private void ClearEmployeeRelatedCache()
    {
        Preferences.Remove(SettingsService.KeyEmployeeVerifyUrl);
        Preferences.Remove(SettingsService.KeyEmployeeNameEnglishBase);
        Preferences.Remove(SettingsService.KeyEmployeeNameArabicBase);
        Preferences.Remove(SettingsService.KeyEmployeeImagePathBase);
        Preferences.Remove(SettingsService.KeyEmployeeInfoJson);
        Preferences.Remove(SettingsService.KeyHasEmployeeData);
    }

    private void ClearVehicleRelatedCache()
    {
        Preferences.Remove(SettingsService.KeyVehicleVerifyUrl);
        Preferences.Remove(SettingsService.KeyVehicleNumberPlate);
        Preferences.Remove(SettingsService.KeyVehicleColor);
        Preferences.Remove(SettingsService.KeyVehicleRegistrationImagePath);
        Preferences.Remove(SettingsService.KeyVehicleInfoJson);
        Preferences.Remove(SettingsService.KeyHasVehicleData);
    }

}

