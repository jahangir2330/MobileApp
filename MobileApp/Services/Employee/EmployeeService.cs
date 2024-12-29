using BDO.Core.DataAccessObjects.Models;
using MobileApp.Helpers;
using MobileApp.Services.RequestProvider;
using Newtonsoft.Json;

namespace MobileApp.Services.Employee;

public class EmployeeService : IEmployeeService
{
    private readonly IRequestProvider _requestProvider;

    private readonly ISettingsService _settingsService;

    private const string ApiUrlBase = "api/Tran_ApplicationReqForEmpDetl";

    public EmployeeService(IRequestProvider requestProvider,

        ISettingsService settingsService)
    {
        _requestProvider = requestProvider;
        _settingsService = settingsService;

    }

    public async Task<bool> SetEmployeeData(long employeeid, string token)
    {
        try
        {

            var uri = UriHelper.CombineUri(GlobalSetting.Instance.GatewayMarketingEndpoint, $"{ApiUrlBase}/Verify?params={employeeid}");

            tran_applicationreqforempdetlEntity employeeObject = await _requestProvider.GetAsync<tran_applicationreqforempdetlEntity>(uri, token).ConfigureAwait(false);
            if (employeeObject != null)
            {
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


    public tran_applicationreqforempdetlEntity GetEmployeeDataFromCache()
    {
        if (Preferences.Default.ContainsKey(SettingsService.KeyEmployeeInfoJson))
        {
            string cachedObject = Preferences.Default.Get(SettingsService.KeyEmployeeInfoJson, "Unknown");
            tran_applicationreqforempdetlEntity employee = JsonConvert.DeserializeObject<tran_applicationreqforempdetlEntity>(cachedObject);
            var imageServerPath = GlobalSetting.FtpRootAddress + "/PersonalPicture/Large/";
            employee.largepersonalpicure = imageServerPath + Preferences.Default.Get(SettingsService.KeyEmployeeImagePathBase, "Unknown");

            return employee;
        }
        else
        {
            return null;
        }

    }
    public void SetDataToCache(tran_applicationreqforempdetlEntity obj)
    {
        if (obj != null)
        {
            Preferences.Default.Set(SettingsService.KeyEmployeeInfoJson, JsonConvert.SerializeObject(obj));
            Preferences.Default.Set(SettingsService.KeyEmployeeNameEnglishBase, obj.fullnameen);
            Preferences.Default.Set(SettingsService.KeyEmployeeNameArabicBase, obj.fullname);
            Preferences.Default.Set(SettingsService.KeyEmployeeImagePathBase, obj.personalpicurepath);
            Preferences.Default.Set(SettingsService.KeyHasEmployeeData, true);
        }

    }
}
