using System.Globalization;
using CommunityToolkit.Maui.Converters;

namespace MobileApp.Converters;

public class DateTimeToVisibilityConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value != null && (DateTime)value != DateTime.MinValue;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
