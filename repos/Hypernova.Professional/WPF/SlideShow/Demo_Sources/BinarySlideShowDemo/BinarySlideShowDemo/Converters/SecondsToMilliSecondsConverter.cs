using System;
using System.Globalization;
using System.Windows.Data;

namespace BinarySlideShowDemonstrationApp.Converters
{
    public class SecondsToMilliSecondsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return 0;

            var val = (double) value;

            return val/1000d;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return 0;

            var val = (double)value;

            return val * 1000d;
        }
    }
}
