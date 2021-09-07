using System;
using System.Windows;
using Binarymission.WPF.Controls.WindowControls;
using Binarymission.WPF.Controls.WindowControls.Enums;

namespace Binarymission.Demos.BackstageTabControlDemo
{
    /// <summary>
    /// Interaction logic for BackstageTabDemoWindow.xaml
    /// </summary>
    public partial class BackstageTabDemoWindow
    {
        public BackstageTabDemoWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            BinaryRibbonBuiltInSkinController.Skin = RibbonSkin.OfficeSilver;
        }

        public static readonly DependencyProperty MenuItemSelectedStateBorderThicknessProperty = DependencyProperty.Register(
            "MenuItemSelectedStateBorderThickness", typeof (Thickness), typeof (BackstageTabDemoWindow), new PropertyMetadata(default(Thickness)));

        public Thickness MenuItemSelectedStateBorderThickness
        {
            get { return (Thickness) GetValue(MenuItemSelectedStateBorderThicknessProperty); }
            set { SetValue(MenuItemSelectedStateBorderThicknessProperty, value); }
        }
        
        private void ToggleButton_OnChecked(object sender, RoutedEventArgs e)
        {
            MenuItemSelectedStateBorderThickness = new Thickness(1);
        }

        private void ToggleButton_OnUnchecked(object sender, RoutedEventArgs e)
        {
            MenuItemSelectedStateBorderThickness = new Thickness(0);
        }

        private void AppExitRequested(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Close();
        }
    }
}
