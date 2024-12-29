using BDO.Core.DataAccessObjects.Models;
using MobileApp.Helpers;
using MobileApp.Services.FixUri;
using MobileApp.Services.RequestProvider;
using MobileApp.Services.Settings;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace MobileApp.Services.Vehicle;

public class VehicleService : IVehicleService
{
    private readonly IRequestProvider _requestProvider;

    private readonly ISettingsService _settingsService;

    private const string ApiUrlBase = "api/Tran_ApplicationReqForVehicleDetl";

    public VehicleService(IRequestProvider requestProvider,

        ISettingsService settingsService)
    {
        _requestProvider = requestProvider;
        _settingsService = settingsService;

    }

    public async Task<bool> SetVehicleData(long employeeid, string token)
    {
        try
        {

            var uri = UriHelper.CombineUri(GlobalSetting.Instance.GatewayMarketingEndpoint, $"{ApiUrlBase}/Verify?params={employeeid}");

            tran_applicationreqforvehicledetlEntity employeeObject = await _requestProvider.GetAsync<tran_applicationreqforvehicledetlEntity>(uri, token).ConfigureAwait(false);
            if (employeeObject != null)
            {
                var imageServerPath = GlobalSetting.FtpRootAddress + "/VehicleRegistration/Large/";
                employeeObject.largevehicleregistrationimage = imageServerPath + Preferences.Default.Get(SettingsService.KeyVehicleRegistrationImagePath, "Unknown");
                SetDataToCache(employeeObject);
                return true;
            }

            return false;
        }
        catch (Exception ex)
        {
            var a = ex.Message;
            throw;
        }

    }


    public tran_applicationreqforvehicledetlEntity GetVehicleDataFromCache()
    {
        if (Preferences.Default.ContainsKey(SettingsService.KeyVehicleInfoJson))
        {
            string cachedObject = Preferences.Default.Get(SettingsService.KeyVehicleInfoJson, "Unknown");
            tran_applicationreqforvehicledetlEntity employee = JsonConvert.DeserializeObject<tran_applicationreqforvehicledetlEntity>(cachedObject);
            var imageServerPath = GlobalSetting.FtpRootAddress + "/VehicleRegistration/Large/";
            employee.largevehicleregistrationimage = imageServerPath + Preferences.Default.Get(SettingsService.KeyVehicleRegistrationImagePath, "Unknown");
            return employee;
        }
        else
        {
            return null;
        }
    }

    public void SetDataToCache(tran_applicationreqforvehicledetlEntity obj)
    {
        if (obj != null)
        {
            Preferences.Default.Set(SettingsService.KeyVehicleInfoJson, JsonConvert.SerializeObject(obj));
            Preferences.Default.Set(SettingsService.KeyVehicleNumberPlate, obj.carnumberplate);
            Preferences.Default.Set(SettingsService.KeyHasVehicleData, true);
        }

    }
}
