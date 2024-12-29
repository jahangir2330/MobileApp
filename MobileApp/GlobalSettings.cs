namespace MobileApp;

public class GlobalSetting
{
    public const string AzureTag = "Azure";
    public const string MockTag = "Mock";
    //public const string DefaultEndpoint = "https://tallgreenboard53.conveyor.cloud";
    public const string DefaultEndpoint = "https://test17.kuwaitarmy.gov.kw";
    //public const string DefaultEndpoint = "https://gipmsapi.kuwaitarmy.gov.kw";
    public const string ApiUsername = "jahangir.spp@gmail.com";
    public const string ApiPassword = "12345";
    public const string ApiIpAddress = "Mobile";
    public const string FtpRootAddress = "https://gipmsuploads.kuwaitarmy.gov.kw";

    private string _baseIdentityEndpoint;
    private string _baseGatewayShoppingEndpoint;
    private string _baseGatewayMarketingEndpoint;

    private string _baseEmployeeNameEnglish;
    private string _baseEmployeeNameArabic;
    private string _baseEmployeeImagePath;
    public GlobalSetting()
    {
        AuthToken = "";// "INSERT AUTHENTICATION TOKEN";
        BaseIdentityEndpoint = DefaultEndpoint;
        BaseGatewayShoppingEndpoint = DefaultEndpoint;
        BaseGatewayMarketingEndpoint = DefaultEndpoint;
    }

    public static GlobalSetting Instance { get; } = new GlobalSetting();

    public string BaseIdentityEndpoint
    {
        get => _baseIdentityEndpoint;
        set
        {
            _baseIdentityEndpoint = value;
            UpdateEndpoint(_baseIdentityEndpoint);
        }
    }

    public string BaseGatewayShoppingEndpoint
    {
        get => _baseGatewayShoppingEndpoint;
        set
        {
            _baseGatewayShoppingEndpoint = value;
            UpdateGatewayShoppingEndpoint(_baseGatewayShoppingEndpoint);
        }
    }


    public string BaseGatewayMarketingEndpoint
    {
        get => _baseGatewayMarketingEndpoint;
        set
        {
            _baseGatewayMarketingEndpoint = value;
            UpdateGatewayMarketingEndpoint(_baseGatewayMarketingEndpoint);
        }
    }

    public string BaseEmployeeNameEnglish
    {
        get => _baseEmployeeNameEnglish;
        set
        {
            _baseEmployeeNameEnglish = value;
            UpdateEmployeeNameEnglish(_baseEmployeeNameEnglish);
        }
    }

    public string BaseEmployeeNameArabic
    {
        get => _baseEmployeeNameArabic;
        set
        {
            _baseEmployeeNameArabic = value;
            UpdateEmployeeNameArabic(_baseEmployeeNameArabic);
        }
    }
    public string BaseEmployeeImagePath
    {
        get => _baseEmployeeImagePath;
        set
        {
            _baseEmployeeImagePath = value;
            UpdateEmployeeImagePath(_baseEmployeeImagePath);
        }
    }
    public string ClientId { get; } = "xamarin";

    public string ClientSecret { get; } = "secret";

    public string AuthToken { get; set; }

    public string RegisterWebsite { get; set; }

    public string AuthorizeEndpoint { get; set; }

    public string UserInfoEndpoint { get; set; }

    public string TokenEndpoint { get; set; }

    public string LogoutEndpoint { get; set; }

    public string Callback { get; set; }

    public string LogoutCallback { get; set; }

    public string GatewayShoppingEndpoint { get; set; }

    public string GatewayMarketingEndpoint { get; set; }

    public string EmployeeNameEnglish { get; set; }

    public string EmployeeNameArabic { get; set; }
    public string EmployeeImagePath { get; set; }

    private void UpdateEndpoint(string endpoint)
    {
        RegisterWebsite = $"{endpoint}/Account/Register";
        LogoutCallback = $"{endpoint}/Account/Redirecting";

        var connectBaseEndpoint = $"{endpoint}/connect";
        AuthorizeEndpoint = $"{connectBaseEndpoint}/authorize";
        UserInfoEndpoint = $"{connectBaseEndpoint}/userinfo";
        TokenEndpoint = $"{connectBaseEndpoint}/token";
        LogoutEndpoint = $"{connectBaseEndpoint}/endsession";

        var baseUri = GlobalSetting.ExtractBaseUri(endpoint);
        Callback = $"{baseUri}/xamarincallback";
    }

    private void UpdateGatewayShoppingEndpoint(string endpoint)
    {
        GatewayShoppingEndpoint = endpoint;
    }

    private void UpdateGatewayMarketingEndpoint(string endpoint)
    {
        GatewayMarketingEndpoint = endpoint;
    }
    private void UpdateEmployeeNameEnglish(string employeeNameEnglish)
    {
        EmployeeNameEnglish = employeeNameEnglish;
    }
    private void UpdateEmployeeNameArabic(string employeeNameArabic)
    {
        EmployeeNameArabic = employeeNameArabic;
    }
    private void UpdateEmployeeImagePath(string employeeImagePath)
    {
        EmployeeImagePath = employeeImagePath;
    }
    private static string ExtractBaseUri(string endpoint)
    {
        try
        {
            var uri = new Uri(endpoint);
            var baseUri = uri.GetLeftPart(UriPartial.Authority);

            return baseUri;
        }
        catch (Exception ex)
        {
            _ = ex;
            return DefaultEndpoint;
        }
    }
}
