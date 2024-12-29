using BDO.Core.DataAccessObjects.Models;

namespace MobileApp.Services.Employee;

public interface IEmployeeService
{
    Task<bool> SetEmployeeData(long employeeid, string token);
    tran_applicationreqforempdetlEntity GetEmployeeDataFromCache();
    void SetDataToCache(tran_applicationreqforempdetlEntity obj);
}
