using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace TabControlDemo.Infrastructure
{
    public class PlacementConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (((ComboBoxItem)value).Content.ToString() == "Top") ? Dock.Top : Dock.Bottom;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
