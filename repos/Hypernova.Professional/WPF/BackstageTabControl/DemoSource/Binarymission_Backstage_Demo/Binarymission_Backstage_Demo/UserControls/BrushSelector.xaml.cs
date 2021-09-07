using System.Windows;
using System.Windows.Media;

namespace Binarymission.Demos.BackstageTabControlDemo.UserControls
{
    /// <summary>
    /// Interaction logic for BrushSelector.xaml
    /// </summary>
    public partial class BrushSelector
    {
        public BrushSelector()
        {
            InitializeComponent();
            DataContext = this;
        }

        public static readonly DependencyProperty LabelTextProperty = DependencyProperty.Register(
            "LabelText", typeof (string), typeof (BrushSelector), new PropertyMetadata(default(string)));

        public string LabelText
        {
            get { return (string) GetValue(LabelTextProperty); }
            set { SetValue(LabelTextProperty, value); }
        }

        public static readonly DependencyProperty SelectedColorBrushProperty = DependencyProperty.Register(
            "SelectedColorBrush", typeof (Brush), typeof (BrushSelector), new PropertyMetadata(default(Brush)));

        public Brush SelectedColorBrush
        {
            get { return (Brush) GetValue(SelectedColorBrushProperty); }
            set { SetValue(SelectedColorBrushProperty, value); }
        }
    }
}
