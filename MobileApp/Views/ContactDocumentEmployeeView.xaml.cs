using ZXing.Net.Maui;
using ZXing.Net.Maui.Controls;

namespace MobileApp.Views
{
    public partial class ContactDocumentEmployeeView : ContentPageBase
    {
        private readonly ContactDocumentEmployeeViewModel _viewModel;
        public ContactDocumentEmployeeView(ContactDocumentEmployeeViewModel viewModel)
        {
            BindingContext = _viewModel = viewModel;
            InitializeComponent();
        }

      
    }
}
