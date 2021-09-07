using System;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Binarymission.WPF.Controls.AdvancedInteractionControls;

namespace BinarySlideShowDemonstrationApp.Converters
{
    internal class ItemToBinarySlideShowItemConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return null;

            var uri = new Uri(value.ToString());
            var item = new BinarySlideShowItem();
            var panel = new DockPanel();
            var image = new Image {Stretch = Stretch.Fill};
            var bitmapItem = new BitmapImage(uri);

            image.Source = bitmapItem;
            panel.Children.Add(image);
            panel.LastChildFill = true;
            item.Content = panel;

            return item;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
