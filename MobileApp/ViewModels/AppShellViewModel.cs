using MobileApp.Services;
using MobileApp.ViewModels.Base;
using System.Windows.Input;

namespace MobileApp.ViewModels;

public class AppShellPageViewModel : ViewModelBase
{
   // public LocalizedString Version { get; } = new(() => string.Format(AppResources.Version, AppInfo.VersionString));

    public ICommand ChangeLanguageCommand { get; }
    private string userName;
    public string LogoutUserName
    {
        get => userName;
        set => SetProperty(ref userName, value);
    }
    public AppShellPageViewModel(INavigationService navigationService) : base(navigationService)
    {
        //CurrentLanguage = new(GetCurrentLanguageName);
        //ChangeLanguageCommand = new AsyncCommand(ChangeLanguage);
        Init();
    }
    public void OnAppearing()
    {
        //Init();
    }

    private void Init()
    {
        //IsBusy = true;
        //IsAdmin = Convert.ToBoolean(Preferences.Get("IsAdmin", "false"));
        //string isDoctorString = Preferences.Get("IsDoctor", "false");
        //if (isDoctorString == "true")
        //{
        //    IsAdmin = true;
        //}
        //string username = Preferences.Get("fullName", "no");
        //LogoutUserName = GetCurrentLanguageName() == "bn-BD" ? "লগআউট (" + username + ")" : "Logout (" + username + ")";

        //IsBusy = false;
    }

}
