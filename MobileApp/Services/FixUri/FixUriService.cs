using System.Diagnostics;
using System.Text.RegularExpressions;
using MobileApp.Services.Settings;

namespace MobileApp.Services.FixUri;

public class FixUriService : IFixUriService
{
    private readonly ISettingsService _settingsService;

    private readonly Regex IpRegex = new(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");

    public FixUriService(ISettingsService settingsService)
    {
        _settingsService = settingsService;
    }


    //public void FixCampaignItemPictureUri(IEnumerable<CampaignItem> campaignItems)
    //{
    //    if (campaignItems is null)
    //    {
    //        return;
    //    }

    //    try
    //    {
    //        if (!_settingsService.UseMocks && _settingsService.IdentityEndpointBase != GlobalSetting.DefaultEndpoint)
    //        {
    //            foreach (var campaignItem in campaignItems)
    //            {
    //                MatchCollection serverResult = IpRegex.Matches(campaignItem.PictureUri);
    //                MatchCollection localResult = IpRegex.Matches(_settingsService.IdentityEndpointBase);

    //                if (serverResult.Count != -1 && localResult.Count != -1)
    //                {
    //                    var serviceIp = serverResult[0].Value;
    //                    var localIp = localResult[0].Value;

    //                    campaignItem.PictureUri = campaignItem.PictureUri.Replace(serviceIp, localIp);
    //                }
    //            }
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        Debug.WriteLine(ex.Message);
    //    }
    //}
}
