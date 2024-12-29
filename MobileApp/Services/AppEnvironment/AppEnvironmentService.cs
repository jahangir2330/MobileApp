using MobileApp.Services.Employee;
using MobileApp.Services.User;

namespace MobileApp.Services.AppEnvironment;

public class AppEnvironmentService : IAppEnvironmentService
{

    private readonly IUserService _mockUserService;
    private readonly IUserService _userService;

    //private readonly IUserService _mockUserService;
    private readonly IEmployeeService _employeeService;

    

    public IUserService UserService { get; private set; }
    public IEmployeeService EmployeeService { get; private set; }

    public AppEnvironmentService(
        IUserService mockUserService, IUserService userService,
        IEmployeeService employeeService)
    {

        _mockUserService = mockUserService;
        _userService = userService;
        _employeeService = employeeService;
    }

    public void UpdateDependencies(bool useMockServices)
    {
        if (useMockServices)
        {
            UserService = _mockUserService;
            //Orizinal
            EmployeeService = _employeeService;
        }
        else
        {
            UserService = _userService;
            EmployeeService = _employeeService;
        }
    }
}

