using MobileApp.Services;
using MobileApp.Services.AppEnvironment;
using MobileApp.Services.Settings;
using MobileApp.ViewModels.Base;

namespace MobileApp.ViewModels;

public partial class QrDisplayEmployeeViewModel : ViewModelBase
{
    private readonly IAppEnvironmentService _appEnvironmentService;
    private readonly ISettingsService _settingsService;
   
    public QrDisplayEmployeeViewModel(
        IAppEnvironmentService appEnvironmentService,
        INavigationService navigationService, ISettingsService settingsService)
        : base(navigationService)
    {
        _appEnvironmentService = appEnvironmentService;
        _settingsService = settingsService;

   }

    public override async Task InitializeAsync()
    {
        await Task.Delay(100);
        var authToken = _settingsService.AuthAccessToken;
        var userInfo = await _appEnvironmentService.UserService.GetUserInfoAsync(authToken);

       
    }


}
