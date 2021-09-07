using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace TabControlDemo
{
    /// <summary>
    /// Interaction logic for TabControlDemoWindow.xaml
    /// </summary>
    public partial class TabControlDemoWindow
    {
        public TabControlDemoWindow()
        {
            InitializeComponent();
            TabControlRenderingModes =
                new ObservableCollection<string>(
                    Enum.GetNames(typeof (Binarymission.WPF.Controls.Containers.TabControl.TabControlRenderingMode)));
            DataContext = this;
        }

        public static readonly DependencyProperty TabControlRenderingModesProperty = DependencyProperty.Register(
            "TabControlRenderingModes", typeof (ObservableCollection<string>), typeof (TabControlDemoWindow), new PropertyMetadata(default(ObservableCollection<string>)));

        public ObservableCollection<string> TabControlRenderingModes
        {
            get { return (ObservableCollection<string>) GetValue(TabControlRenderingModesProperty); }
            set { SetValue(TabControlRenderingModesProperty, value); }
        }
    }
}
