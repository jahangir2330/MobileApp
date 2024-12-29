using System;
using System.Linq;
using Microsoft.Maui.Controls;
using MobileApp.Services.Settings;
using ZXing.Net.Maui;
using ZXing.Net.Maui.Controls;

namespace MobileApp.Views
{
    public partial class QrDisplayVehicleView : ContentPageBase
    {
        public QrDisplayVehicleView(QrShowViewModel viewModel)
        {
            BindingContext = viewModel;
            InitializeComponent();
            GenerateVehicleQrCode();
        }

    
        private void GenerateVehicleQrCode()
        {
            vehicleBarcodeGeneratorView.ClearValue(BarcodeGeneratorView.ValueProperty);
            var url = Preferences.Default.Get(SettingsService.KeyVehicleVerifyUrl, "");
            vehicleBarcodeGeneratorView.Format = BarcodeFormat.QrCode;
            vehicleBarcodeGeneratorView.Value = url;
        }

        
    }
}
