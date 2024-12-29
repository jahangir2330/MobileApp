using BDO.Core.DataAccessObjects.Models;

namespace MobileApp.Services.Settings;

public interface ISettingsService
{
    string AuthAccessToken { get; set; }
    string AuthIdToken { get; set; }
    bool UseMocks { get; set; }
    bool HasData { get; set; }
    bool HasEmployeeData { get; set; }
    bool HasVehicleData { get; set; }
    string IdentityEndpointBase { get; set; }
    string GatewayShoppingEndpointBase { get; set; }
    string GatewayMarketingEndpointBase { get; set; }
    bool UseFakeLocation { get; set; }
    string Latitude { get; set; }
    string Longitude { get; set; }
    bool AllowGpsLocation { get; set; }
  
    string GetEncryptedPinCode();
    bool SetEncryptedPinCode(string encPincode);
}
