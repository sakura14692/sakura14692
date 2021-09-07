using System;
using System.Windows.Input;
using System.Windows.Media;

namespace ZoomAndPanControlDemo
{
    /// <summary>
    /// Interaction logic for ZoomAndPanDemoWindow.xaml
    /// </summary>
    public partial class ZoomAndPanDemoWindow
    {
        private static Brush _borderBrush;

        public ZoomAndPanDemoWindow()
        {
            InitializeComponent();
            _borderBrush = new SolidColorBrush(Color.FromArgb(185, 255, 218, 198));
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            ZoomPanControlInstance.Focus();            
        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            BorderInstance.Background = _borderBrush;
        }

        private void Border_MouseLeave(object sender, MouseEventArgs e)
        {
            BorderInstance.Background = Brushes.Transparent;
            ZoomPanControlInstance.Focus();
        }

        private void mainWindow_LocationChanged(object sender, EventArgs e)
        {
            // This is just a little trick to keep the toolbar window re-positioned with the window's new location...
            // Anyway this has got nothing to do with the ZoomAndPan control. This is just for the fancy toolbar I have put together for the demo application :)...
            ToolbarInstance.IsOpen = false;
            ToolbarInstance.IsOpen = true;
        }
    }
}
