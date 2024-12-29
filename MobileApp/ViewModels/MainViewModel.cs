using MobileApp.Services;
using MobileApp.ViewModels.Base;

namespace MobileApp.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public MainViewModel(INavigationService navigationService)
        : base(navigationService)
    {
    }

    [RelayCommand]
    private async Task SettingsAsync()
    {
        await NavigationService.NavigateToAsync("Settings");
    }
}
