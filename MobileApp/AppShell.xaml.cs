using MobileApp.Resources.Languages;
using MobileApp.Services;
using MobileApp.Views;
using System.Globalization;
using MobileApp.Services.Settings;
using ZXing.QrCode.Internal;
namespace MobileApp;

public partial class AppShell : Shell
{
    private readonly INavigationService _navigationService;
    private readonly AppShellPageViewModel _viewModel;
    private bool isChangingFlowDirection = false;
    public AppShell(INavigationService navigationService)
    {
        BindingContext = _viewModel = new AppShellPageViewModel(navigationService);
        _navigationService = navigationService;

        AppShell.InitializeRouting();
        InitializeComponent();
        LoadFlowDirection();
    }

    protected override async void OnHandlerChanged()
    {
        base.OnHandlerChanged();

        if (Handler is not null)
        {
            await _navigationService.InitializeAsync();
        }
    }

    private static void InitializeRouting()
    {
        Routing.RegisterRoute("Settings", typeof(SettingsView));
        Routing.RegisterRoute(nameof(CreatePinView), typeof(CreatePinView));
        Routing.RegisterRoute(nameof(QrCodeScanView), typeof(QrCodeScanView));
        Routing.RegisterRoute(nameof(NewQrScanView), typeof(NewQrScanView));
        Routing.RegisterRoute(nameof(TestPageView), typeof(TestPageView));
    }

    private void LoadFlowDirection()
    {
        //Load the saved state
        if (Preferences.ContainsKey(SettingsService.KeyCurrentCulture))
        {
            this.FlowDirection = (AppResources.Culture.TextInfo.IsRightToLeft == true) ? FlowDirection.RightToLeft : FlowDirection.LeftToRight;

            //var savedFlowDirection = (FlowDirection)Preferences.Get(SettingsService.KeyFlowDirection, (int)FlowDirection.LeftToRight);
            //this.FlowDirection = savedFlowDirection;
        }
    }

    protected override async void OnNavigating(ShellNavigatingEventArgs args)
    {
        base.OnNavigating(args);

        if (isChangingFlowDirection)
        {
            // Cancel navigation if we are just changing the flow direction
            args.Cancel();
            isChangingFlowDirection = false;
        }
    }
    private void OnToggleLanguage(object sender, EventArgs e)
    {
        // var x = AppResources.Culture.Name;
        var switchToCulture = AppResources.Culture.Name
            .Equals("ar-KW", StringComparison.InvariantCultureIgnoreCase) ?
            new CultureInfo("en-US") : new CultureInfo("ar-KW");
        LocalizationResourceManager.Instance.SetCulture(switchToCulture);
        var currentpage = Shell.Current.CurrentPage;

        if (switchToCulture.Name == "ar-KW")
        {
            currentpage.FlowDirection = FlowDirection.RightToLeft;
        }
        else
        {
            currentpage.FlowDirection = FlowDirection.LeftToRight;
        }
    }
    //private async void OnLogoutClicked(object sender, EventArgs e)
    //{
    //    await LogOut();
    //}
    //private async Task LogOut()
    //{

    //    //Application current = new Application();
    //    //bool isLoggedIn = current.Properties.ContainsKey("IsLoggedIn") ? Convert.ToBoolean(current.Properties["IsLoggedIn"]) : false;

    //    Preferences.Remove("userId");
    //    Preferences.Remove("userName");
    //    Preferences.Remove("userPassword");
    //    Preferences.Remove("fullName");
    //    Preferences.Remove("imageName");
    //    Preferences.Remove("phonenumber");
    //    Preferences.Remove("IsDoctor");
    //    Preferences.Remove("IsAdmin");
    //    //Application.Current.Properties["IsLoggedIn"] = Boolean.FalseString;
    //    //App.IsUserLoggedIn = false;
    //    await Shell.Current.GoToAsync($"///{nameof(LoginView)}");
    //}



    //private async void OnResetEmployeeClicked(object sender, EventArgs e)
    //{
    //    await ResetEmployeeInfo();
    //}
    //private async Task ResetEmployeeInfo()
    //{
    //    //Preferences.Remove(SettingsService.KeyEmployeeVerifyUrl);
    //    //Preferences.Remove(SettingsService.KeyEmployeeNameEnglishBase);
    //    //Preferences.Remove(SettingsService.KeyEmployeeNameArabicBase);
    //    //Preferences.Remove(SettingsService.KeyEmployeeImagePathBase);
    //    //Preferences.Remove(SettingsService.KeyEmployeeInfoJson);
    //    //Preferences.Remove(SettingsService.KeyHasEmployeeData);

    //    await Shell.Current.GoToAsync($"///{nameof(LoginView)}");
    //}

}
