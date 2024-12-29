using System.Globalization;
using CommunityToolkit.Maui.Converters;

namespace MobileApp.Converters;

public class StringIsNullOrEmptyToHideConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        return !string.IsNullOrEmpty(value as string);
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        throw new NotSupportedException();
    }
}
