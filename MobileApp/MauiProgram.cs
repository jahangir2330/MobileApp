using CommunityToolkit.Maui;
using MobileApp.Services;
using MobileApp.Services.AppEnvironment;
using MobileApp.Services.FixUri;
using MobileApp.Services.Identity;
using MobileApp.Services.Location;
using MobileApp.Services.Employee;
using MobileApp.Services.Vehicle;
using MobileApp.Services.OpenUrl;
using MobileApp.Services.RequestProvider;
using MobileApp.Services.Settings;
using MobileApp.Services.Theme;
using MobileApp.Services.User;
using MobileApp.Views;
using Microsoft.Extensions.Logging;
using ZXing.Net.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Platform;
using Camera.MAUI;
using Plugin.Maui.Biometric;
using CommunityToolkit.Maui.Markup;

namespace MobileApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
        => MauiApp
            .CreateBuilder()
            .UseMauiApp<App>()
            .ConfigureEffects(
                effects =>
                {
                })
            .UseMauiCommunityToolkit()
            .UseMauiCommunityToolkitMarkup()
            .ConfigureFonts(
                fonts =>
                {
                    fonts.AddFont("Font_Awesome_5_Free-Regular-400.otf", "FontAwesome-Regular");
                    fonts.AddFont("Font_Awesome_5_Free-Solid-900.otf", "FontAwesome-Solid");
                    fonts.AddFont("fa-regular-400.ttf", "fa6regular");
                    fonts.AddFont("fa-brands-400.ttf", "fa6brand");
                    fonts.AddFont("fa-solid-900.ttf", "fa6solid");
                    fonts.AddFont("NotoKufiArabic-Regular.ttf", "NotoKufiArabicRegular");

                    fonts.AddFont("Poppins-Bold.ttf", "PoppinsBold");
                    fonts.AddFont("Poppins-Light.ttf", "PoppinsLight");
                    fonts.AddFont("Poppins-Regular.ttf", "Poppins");
                })
            .ConfigureEssentials(
                essentials =>
                {
                    essentials
                        .AddAppAction(AppActions.ViewProfileAction)
                        .OnAppAction(App.HandleAppActions);
                })
        .UseBarcodeReader()
                .UseMauiCameraView()
            .UseMauiMaps()
            .RegisterAppServices()
            .RegisterViewModels()
            .RegisterViews()
            .ConfigureEntryHandler()
            .Build();

    public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<ISettingsService, SettingsService>();
        mauiAppBuilder.Services.AddSingleton<INavigationService, MauiNavigationService>();
        mauiAppBuilder.Services.AddSingleton<IDialogService, DialogService>();
        mauiAppBuilder.Services.AddSingleton<IOpenUrlService, OpenUrlService>();
        mauiAppBuilder.Services.AddSingleton<IRequestProvider, RequestProvider>();
        mauiAppBuilder.Services.AddSingleton<IIdentityService, IdentityService>();
        mauiAppBuilder.Services.AddSingleton<IFixUriService, FixUriService>();
        mauiAppBuilder.Services.AddSingleton<ILocationService, LocationService>();
        mauiAppBuilder.Services.AddSingleton<IEmployeeService, EmployeeService>();
        mauiAppBuilder.Services.AddSingleton<IVehicleService, VehicleService>();

        mauiAppBuilder.Services.AddSingleton<ITheme, Theme>();

        mauiAppBuilder.Services.AddSingleton<IAppEnvironmentService, AppEnvironmentService>(
            serviceProvider =>
            {
                var requestProvider = serviceProvider.GetService<IRequestProvider>();
                var fixUriService = serviceProvider.GetService<IFixUriService>();
                var settingsService = serviceProvider.GetService<ISettingsService>();

                var aes =
                    new AppEnvironmentService(
                        new UserMockService(), new UserService(requestProvider),
                        new EmployeeService(requestProvider, settingsService));

                aes.UpdateDependencies(settingsService.UseMocks);
                return aes;
            });
        mauiAppBuilder.Services.AddHttpClient("api", httpClient => httpClient.BaseAddress = new Uri(""));
        mauiAppBuilder.Services.AddSingleton<IBiometric>(BiometricAuthenticationService.Default);

#if DEBUG
        mauiAppBuilder.Logging.AddDebug();
#endif

        return mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<MainViewModel>();
        mauiAppBuilder.Services.AddSingleton<LoginViewModel>();
        mauiAppBuilder.Services.AddSingleton<MapViewModel>();
        mauiAppBuilder.Services.AddSingleton<ProfileViewModel>();
        mauiAppBuilder.Services.AddSingleton<EmployeeViewModel>();
        mauiAppBuilder.Services.AddSingleton<QrCodeScanViewModel>();
        mauiAppBuilder.Services.AddSingleton<QrShowViewModel>();
        mauiAppBuilder.Services.AddSingleton<QrDisplayEmployeeViewModel>();
        mauiAppBuilder.Services.AddSingleton<CreatePinViewModel>();
        mauiAppBuilder.Services.AddSingleton<VehiclePermissionViewModel>();
        mauiAppBuilder.Services.AddSingleton<RemoveDataViewModel>();
        mauiAppBuilder.Services.AddSingleton<TestPageViewModel>();
        mauiAppBuilder.Services.AddSingleton<NewQrScanViewModel>();

        mauiAppBuilder.Services.AddTransient<SettingsViewModel>();

        return mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddTransient<LoginView>();
        mauiAppBuilder.Services.AddTransient<MapView>();
        mauiAppBuilder.Services.AddTransient<ProfileView>();
        mauiAppBuilder.Services.AddTransient<SettingsView>();
        mauiAppBuilder.Services.AddTransient<EmployeeView>();
        mauiAppBuilder.Services.AddTransient<QrCodeScanView>();
        mauiAppBuilder.Services.AddTransient<QrDisplayEmployeeView>();
        mauiAppBuilder.Services.AddTransient<QrDisplayVehicleView>();
        mauiAppBuilder.Services.AddTransient<CreatePinView>();
        mauiAppBuilder.Services.AddTransient<VehiclePermissionView>();
        mauiAppBuilder.Services.AddTransient<RemoveDataView>();
        mauiAppBuilder.Services.AddTransient<TestPageView>();
        mauiAppBuilder.Services.AddTransient<NewQrScanView>();

        return mauiAppBuilder;
    }
    // Configure custom entry handler
    public static MauiAppBuilder ConfigureEntryHandler(this MauiAppBuilder mauiAppBuilder)
    {
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(Entry), (handler, view) =>
        {
#if ANDROID
            handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.LightGray);
#endif
        });
        //handler.PlatformView.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.Transparent);

        return mauiAppBuilder;
    }
}
