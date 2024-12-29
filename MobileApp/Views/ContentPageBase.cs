using MobileApp.Resources.Languages;
using MobileApp.ViewModels.Base;
using System.Globalization;

namespace MobileApp.Views;

public abstract class ContentPageBase : ContentPage
{
    public ContentPageBase()
    {
        NavigationPage.SetBackButtonTitle(this, string.Empty);
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (BindingContext is not IViewModelBase ivmb)
        {
            return;
        }
        if (Preferences.ContainsKey(SettingsService.KeyCurrentCulture))
        {
            this.FlowDirection = (AppResources.Culture.TextInfo.IsRightToLeft == true) ? FlowDirection.RightToLeft : FlowDirection.LeftToRight;

        }
        //FlowDirection = (FlowDirection)Preferences.Get(SettingsService.KeyFlowDirection, (int)FlowDirection.MatchParent);

        await ivmb.InitializeAsyncCommand.ExecuteAsync(null);
    }
   
}
