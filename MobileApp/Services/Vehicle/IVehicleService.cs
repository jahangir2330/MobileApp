using BDO.Core.DataAccessObjects.Models;

namespace MobileApp.Services.Vehicle;

public interface IVehicleService
{
    Task<bool> SetVehicleData(long vehicleid, string token);
    tran_applicationreqforvehicledetlEntity GetVehicleDataFromCache();
    void SetDataToCache(tran_applicationreqforvehicledetlEntity obj);
}
