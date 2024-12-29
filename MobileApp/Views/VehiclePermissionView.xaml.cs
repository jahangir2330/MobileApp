namespace MobileApp.Views
{
    public partial class VehiclePermissionView : ContentPageBase
    {
        private readonly VehiclePermissionViewModel _viewModel;
       
        public VehiclePermissionView(VehiclePermissionViewModel viewModel)
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
            }
        }

    }
}
