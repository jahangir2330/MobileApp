using ZXing.Net.Maui;
using ZXing.Net.Maui.Controls;

namespace MobileApp.Views
{
    public partial class QrDisplayEmployeeView : ContentPageBase
    {
        private readonly QrDisplayEmployeeViewModel _viewModel;
        public QrDisplayEmployeeView(QrDisplayEmployeeViewModel viewModel)
        {
            BindingContext = _viewModel = viewModel;
            InitializeComponent();
            GenerateEmployeeQrCode();
        }

        private void GenerateEmployeeQrCode()
        {
            employeeBarcodeGeneratorView.ClearValue(BarcodeGeneratorView.ValueProperty);
            var url = Preferences.Default.Get(SettingsService.KeyEmployeeVerifyUrl, "");
            employeeBarcodeGeneratorView.Format = BarcodeFormat.QrCode;
            employeeBarcodeGeneratorView.Value = url;
        } 
        
        private void employeeShowButton_Clicked(object sender, EventArgs e)
        {
           
        }

        private void vehicleShowButton_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}
