using MobileApp.Services.Settings;

namespace MobileApp.Services;

public class MauiNavigationService : INavigationService
{
    private readonly ISettingsService _settingsService;

    public MauiNavigationService(ISettingsService settingsService)
    {
        _settingsService = settingsService;
    }

    public Task InitializeAsync() =>
        NavigateToAsync(string.IsNullOrEmpty(_settingsService.AuthAccessToken) ? "//Login" : "//Login");
       // NavigateToAsync(string.IsNullOrEmpty(_settingsService.AuthAccessToken) ? "//Login" : "//Main/Employee");

    public Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null)
    {
        var shellNavigation = new ShellNavigationState(route);

        return routeParameters != null
            ? Shell.Current.GoToAsync(shellNavigation, routeParameters)
            : Shell.Current.GoToAsync(shellNavigation);
    }

    public Task PopAsync() =>
        Shell.Current.GoToAsync("..");
    public void ReloadCurrentPage()
    {
        var navigation = Application.Current.MainPage.Navigation;
        var currentPage = navigation.NavigationStack.LastOrDefault();

        if (currentPage != null)
        {
            navigation.RemovePage(currentPage);
            var newPage = Activator.CreateInstance(currentPage.GetType());
            navigation.PushAsync(newPage as Page);
        }
    }
}
