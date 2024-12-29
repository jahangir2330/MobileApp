namespace MobileApp.Views;

public partial class RemoveDataView : ContentPageBase
{
    private readonly RemoveDataViewModel _viewModel;

    public RemoveDataView(RemoveDataViewModel viewModel)
    {
        _viewModel = viewModel;
        BindingContext = viewModel;
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();        
    }
}
