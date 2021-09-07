using System;
using System.Windows;
using System.Windows.Data;

namespace BinarySlideShowDemonstrationApp.Converters
{
    internal class VisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return Visibility.Hidden;

            Visibility v;
            var val = (bool?)value;
            var result = val.Value;

            switch (result)
            {
                case true: v = Visibility.Visible; break;
                case false: v = Visibility.Collapsed; break;
                default: v = Visibility.Hidden; break;
            }

            return v;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
