using BDO.Core.DataAccessObjects.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MobileApp.Services.Settings;

public class SettingsService : ISettingsService
{
    #region Setting Constants

    private const string AccessToken = "access_token";
    private const string IdToken = "id_token";
    private const string IdUseMocks = "use_mocks";
    private const string IdIdentityBase = "url_base";
    private const string IdGatewayMarketingBase = "url_marketing";
    private const string IdGatewayShoppingBase = "url_shopping";
    private const string IdUseFakeLocation = "use_fake_location";
    private const string IdLatitude = "latitude";
    private const string IdLongitude = "longitude";
    private const string IdAllowGpsLocation = "allow_gps_location";
    private readonly string AccessTokenDefault = string.Empty;
    private readonly string IdTokenDefault = string.Empty;
    private readonly bool UseMocksDefault = true;
    private readonly bool UseFakeLocationDefault = false;
    private readonly bool AllowGpsLocationDefault = false;
    private readonly double FakeLatitudeDefault = 47.604610d;
    private readonly double FakeLongitudeDefault = -122.315752d;
    private readonly string UrlIdentityDefault = GlobalSetting.Instance.BaseIdentityEndpoint;
    private readonly string UrlGatewayMarketingDefault = GlobalSetting.Instance.BaseGatewayMarketingEndpoint;
    private readonly string UrlGatewayShoppingDefault = GlobalSetting.Instance.BaseGatewayShoppingEndpoint;



    private const string IdHasData = "has_data";
    private const string IdHasEmployeeData = "has_employeedata";
    private const string IdHasVehicleData = "has_vehicledata";

    private readonly string DataEmployeeNameEnglish = GlobalSetting.Instance.BaseEmployeeNameEnglish;
    private readonly string DataEmployeeNameArabic = GlobalSetting.Instance.BaseEmployeeNameArabic;
    private readonly string DataEmployeeImagePath = GlobalSetting.Instance.BaseEmployeeImagePath;

    public const string KeyCachedPinCode = "cached_pincode";
    //public const string KeyFlowDirection = "cached_flowdirection";
    public const string KeyCurrentCulture = "cached_currentculture";
    public const string KeyHasData = "cached_hasdata";

    public const string KeyHasEmployeeData = "cached_hasemployeedata";
    public const string KeyEmployeeVerifyUrl = "KeyEmployeeVerifyUrl";
    public const string KeyEmployeeNameEnglishBase = "cached_employeenameenglish";
    public const string KeyEmployeeNameArabicBase = "cached_employeenamearabic";
    public const string KeyEmployeeImagePathBase = "cached_employeeimagepath";
    public const string KeyEmployeeInfoJson = "EmployeeInfoJson";


    public const string KeyVehicleVerifyUrl = "KeyVehicleVerifyUrl";
    public const string KeyVehicleInfoJson = "VehicleInfoJson";
    public const string KeyHasVehicleData = "cached_hasvehicledata";
    public const string KeyVehicleNumberPlate = "cached_vehiclenumberplate";
    public const string KeyVehicleColor = "cached_vehiclecolor";
    public const string KeyVehicleRegistrationImagePath = "cached_vehicleimagepath";

    #endregion

    #region Settings Properties

    public string CachedPinCode
    {
        get => Preferences.Get(KeyCachedPinCode, AccessTokenDefault);
        set => Preferences.Set(KeyCachedPinCode, value);
    }
    public string AuthAccessToken
    {
        get => Preferences.Get(AccessToken, AccessTokenDefault);
        set => Preferences.Set(AccessToken, value);
    }

    public string AuthIdToken
    {
        get => Preferences.Get(IdToken, IdTokenDefault);
        set => Preferences.Set(IdToken, value);
    }

    public bool UseMocks
    {
        get => Preferences.Get(IdUseMocks, UseMocksDefault);
        set => Preferences.Set(IdUseMocks, value);
    }
    public bool HasData
    {
        get => Preferences.Get(IdHasData, HasDataInCache());
        set => Preferences.Set(IdHasData, value);
    }
    public bool HasEmployeeData
    {
        get => Preferences.Get(IdHasEmployeeData, HasEmployeeInfoInCache());
        set => Preferences.Set(IdHasEmployeeData, value);
    }
    public bool HasVehicleData
    {
        get => Preferences.Get(IdHasVehicleData, HasVehicleInfoInCache());
        set => Preferences.Set(IdHasVehicleData, value);
    }

    public string IdentityEndpointBase
    {
        get => Preferences.Get(IdIdentityBase, UrlIdentityDefault);
        set
        {
            Preferences.Set(IdIdentityBase, value);
            GlobalSetting.Instance.BaseIdentityEndpoint = value;
        }
    }

    public string GatewayShoppingEndpointBase
    {
        get => Preferences.Get(IdGatewayShoppingBase, UrlGatewayShoppingDefault);
        set
        {
            Preferences.Set(IdGatewayShoppingBase, value);
            GlobalSetting.Instance.BaseGatewayShoppingEndpoint = value;
        }
    }

    public string GatewayMarketingEndpointBase
    {
        get => Preferences.Get(IdGatewayMarketingBase, UrlGatewayMarketingDefault);
        set
        {
            Preferences.Set(IdGatewayMarketingBase, value);
            GlobalSetting.Instance.BaseGatewayMarketingEndpoint = value;
        }
    }

    public string EmployeeNameEnglish
    {
        get => Preferences.Get(KeyEmployeeNameEnglishBase, DataEmployeeNameEnglish);
        set
        {
            Preferences.Set(KeyEmployeeNameEnglishBase, value);
            GlobalSetting.Instance.BaseEmployeeNameEnglish = value;
        }
    }
    public string EmployeeNameArabic
    {
        get => Preferences.Get(KeyEmployeeNameArabicBase, DataEmployeeNameArabic);
        set
        {
            Preferences.Set(KeyEmployeeNameArabicBase, value);
            GlobalSetting.Instance.BaseEmployeeNameArabic = value;
        }
    }
    public string EmployeeImagePath
    {
        get => Preferences.Get(KeyEmployeeImagePathBase, DataEmployeeImagePath);
        set
        {
            Preferences.Set(KeyEmployeeImagePathBase, value);
            GlobalSetting.Instance.BaseEmployeeImagePath = value;
        }
    }
    public bool UseFakeLocation
    {
        get => Preferences.Get(IdUseFakeLocation, UseFakeLocationDefault);
        set => Preferences.Set(IdUseFakeLocation, value);
    }

    public string Latitude
    {
        get => Preferences.Get(IdLatitude, FakeLatitudeDefault.ToString());
        set => Preferences.Set(IdLatitude, value);
    }

    public string Longitude
    {
        get => Preferences.Get(IdLongitude, FakeLongitudeDefault.ToString());
        set => Preferences.Set(IdLongitude, value);
    }

    public bool AllowGpsLocation
    {
        get => Preferences.Get(IdAllowGpsLocation, AllowGpsLocationDefault);
        set => Preferences.Set(IdAllowGpsLocation, value);
    }

    #endregion

    #region Functions
    private bool HasDataInCache()
    {        
        return Preferences.Default.Get(SettingsService.KeyHasData, false);
    }
    private bool HasEmployeeInfoInCache()
    {        
        return Preferences.Default.Get(SettingsService.KeyHasEmployeeData, false);
    }
 private bool HasVehicleInfoInCache()
    {        
        return Preferences.Default.Get(SettingsService.KeyHasVehicleData, false);
    }

    public string GetEncryptedPinCode()
    {
        if (Preferences.Default.ContainsKey(KeyCachedPinCode))
        {
            return Preferences.Default.Get(KeyCachedPinCode, "Unknown");
        }
        else
        {
            return null;
        }
    }
    public bool SetEncryptedPinCode(string encPincode)
    {
        bool returnvalue=false;
        if (!string.IsNullOrEmpty(encPincode))
        {
            Preferences.Default.Set(KeyCachedPinCode, encPincode);
            returnvalue= true;
        }
        return returnvalue;

    }
    #endregion
}
