using MobileApp.Resources.Languages;
using System.ComponentModel;
using System.Globalization;

namespace MobileApp
{
    public class LocalizationResourceManager : INotifyPropertyChanged
    {
        private LocalizationResourceManager()
        {
            SetCulture(CultureInfo.CurrentCulture);
        }

        public event EventHandler CultureChanged;
        public static LocalizationResourceManager Instance { get; } = new();

        public object this[string resourceKey]
            => AppResources.ResourceManager.GetObject(resourceKey, AppResources.Culture) ?? Array.Empty<byte>();

        public event PropertyChangedEventHandler PropertyChanged;

        public void SetCulture(CultureInfo culture)
        {

            AppResources.Culture = culture;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
                UpdateFlowDirection(culture);
            if (AppResources.Culture != culture)
            {
                CultureChanged?.Invoke(this, EventArgs.Empty);
                OnPropertyChanged(null); 
            }
        }

        private void UpdateFlowDirection(CultureInfo culture)
        {
            Preferences.Set(SettingsService.KeyCurrentCulture, culture.Name);

            //FlowDirection = culture.Name == "ar-KW" ? FlowDirection.RightToLeft : FlowDirection.LeftToRight;
            //Preferences.Set(SettingsService.KeyFlowDirection, (int)FlowDirection);

        }

        private FlowDirection _flowDirection;
        public FlowDirection FlowDirection
        {
            get => _flowDirection;
            private set
            {
                if (_flowDirection != value)
                {
                    _flowDirection = value;
                    OnPropertyChanged(nameof(FlowDirection));
                }
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
