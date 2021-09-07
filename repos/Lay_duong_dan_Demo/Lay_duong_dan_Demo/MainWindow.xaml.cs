using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lay_duong_dan_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            string tmpPath = @"Lay_duong_dan_Demo\Lay_duong_dan_Demo.csproj";

            string fileExtension = System.IO.Path.GetExtension(tmpPath);
            string filename = System.IO.Path.GetFileName(tmpPath);
            string filenameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(tmpPath);
            string rootPath = System.IO.Path.GetPathRoot(tmpPath);
            string directory = System.IO.Path.GetDirectoryName(tmpPath);
            string fullPath = System.IO.Path.GetFullPath(tmpPath);

            MessageBox.Show(fullPath);



        }
    }
}
