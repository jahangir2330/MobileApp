using MobileApp.Resources.Languages;
using System.Globalization;

namespace MobileApp.Views;

public partial class EmployeeView : ContentPageBase
{
    private readonly EmployeeViewModel _viewModel;

    public EmployeeView(EmployeeViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = viewModel;

    }

    protected override void OnAppearing()
    {
       
        base.OnAppearing();
        _viewModel.OnAppearing();
        if (_viewModel.IsInitialized)
        {
            //_viewModel.RefreshCommand.Execute(null);
        }
    }
    
}
