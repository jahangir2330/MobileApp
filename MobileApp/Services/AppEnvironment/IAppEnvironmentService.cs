using MobileApp.Services.Employee;
using MobileApp.Services.User;

namespace MobileApp.Services.AppEnvironment;

public interface IAppEnvironmentService
{
    IUserService UserService { get; }
    IEmployeeService EmployeeService { get; }

    void UpdateDependencies(bool useMockServices);
}
