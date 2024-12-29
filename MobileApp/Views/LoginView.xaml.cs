using MobileApp.Resources.Languages;
using Plugin.Maui.Biometric;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Globalization;

namespace MobileApp.Views;

public partial class LoginView : ContentPageBase
{
    private readonly LoginViewModel _viewModel;
    public LocalizationResourceManager LocalizationResourceManager
      => LocalizationResourceManager.Instance;
    private bool _animate;

    public LoginView(LoginViewModel viewModel)
    {
        BindingContext = _viewModel = viewModel;
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        //var content = Content;
        //Content = null;
        //Content = content;

        _viewModel.InvalidateMock();
        _viewModel.CheckPinExist();
        //_viewModel.GetVehicleData();
        LanguageBtnText();
        if (!_viewModel.IsMock)
        {
            _animate = true;
            //await AnimateIn();
        }
    }

    protected override void OnDisappearing()
    {
        _animate = false;
    }

    public async Task AnimateIn()
    {
        if (DeviceInfo.Platform == DevicePlatform.WinUI)
        {
            return;
        }

        //await AnimateItem(Banner, 10500);
    }

    private async Task AnimateItem(View uiElement, uint duration)
    {
        try
        {
            while (_animate)
            {
                await uiElement.ScaleTo(1.05, duration, Easing.SinInOut);
                await Task.WhenAll(
                    uiElement.FadeTo(1, duration, Easing.SinInOut),
                    uiElement.LayoutTo(new Rect(new Point(0, 0), new Size(uiElement.Width, uiElement.Height))),
                    uiElement.FadeTo(.9, duration, Easing.SinInOut),
                    uiElement.ScaleTo(1.15, duration, Easing.SinInOut)
                );
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }
    }

    //private async void entryPin_TextChanged(object sender, TextChangedEventArgs e)
    //{
    //    if (e.NewTextValue.Length == 4)
    //    {
    //     await _viewModel.MockSignInAsync();
    //    }
    //}
    private void entryPin_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {
            // Add null checks for sender and other objects being used
            if (sender is Entry entry && entry != null)
            {
                // Example of accessing the entry's properties safely
                var newText = e.NewTextValue;
                // Your existing logic here
            }
            else
            {
                throw new NullReferenceException("Sender or entry is null.");
            }

        }
        catch (Exception ex)
        {
            // Log or handle the exception as needed
            Debug.WriteLine($"Exception in entryPin_TextChanged: {ex.Message}");
        }
    }
    private async void OnFingerprintClicked(object sender, EventArgs e)
    {
        var result = await BiometricAuthenticationService.Default.AuthenticateAsync(new AuthenticationRequest()
        {
            Title = "Use Fingerprint to unlock",
            NegativeText = "Cancel authentication"
        }, CancellationToken.None);

        if (result.Status == BiometricResponseStatus.Success)
        {
            await _viewModel.SignInWithFingurePrintAsync();
        }
        else if (result.Status == BiometricResponseStatus.Failure)
        {
            result.ErrorMsg = "Unrecognized Fingerprint";
        }
        else
        {
            await DisplayAlert("Nope", "Couldnt authenticate", "OK");
        }
    }

    protected void OnFlowDirectionChangeClicked(object sender, EventArgs e)
    {
        CultureInfo switchToCulture = AppResources.Culture.Name
            .Equals("ar-KW", StringComparison.InvariantCultureIgnoreCase) ?
            new CultureInfo("en-US") : new CultureInfo("ar-KW");

        LocalizationResourceManager.Instance.SetCulture(switchToCulture);


        this.FlowDirection = (AppResources.Culture.TextInfo.IsRightToLeft == true) ? FlowDirection.RightToLeft : FlowDirection.LeftToRight;


        //if (switchToCulture.TextInfo.IsRightToLeft == true)
        //{
        //    FlowDirection = FlowDirection.RightToLeft;
        //}
        //else
        //{
        //    FlowDirection = FlowDirection.LeftToRight;
        //}
        LanguageBtnText();
    }

    private void LanguageBtnText()
    {
       
        var currentLanguage = AppResources.Culture.Name;
        if (currentLanguage== "ar-KW")
        {
            LanguageChangeBtn.Text = "English";
        }
        else
        {
            LanguageChangeBtn.Text = "عربي";
        }
    }
}