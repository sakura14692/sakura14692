#pragma checksum "..\..\..\..\..\Views\message_Box\messageBox_ThongBao_DangNhap_ThatBai.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83703379DF682C15EAB898C8B5BE1870C4C561A3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using TaiChinh_KinhDoanh.Views.message_Box;


namespace TaiChinh_KinhDoanh.Views.message_Box {
    
    
    /// <summary>
    /// messageBox_ThongBao_DangNhap_ThatBai
    /// </summary>
    public partial class messageBox_ThongBao_DangNhap_ThatBai : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\..\Views\message_Box\messageBox_ThongBao_DangNhap_ThatBai.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid_message_image;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\..\Views\message_Box\messageBox_ThongBao_DangNhap_ThatBai.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textblock_ThongBao;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\..\Views\message_Box\messageBox_ThongBao_DangNhap_ThatBai.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Dong;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TaiChinh_KinhDoanh;component/views/message_box/messagebox_thongbao_dangnhap_that" +
                    "bai.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\message_Box\messageBox_ThongBao_DangNhap_ThatBai.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 14 "..\..\..\..\..\Views\message_Box\messageBox_ThongBao_DangNhap_ThatBai.xaml"
            ((TaiChinh_KinhDoanh.Views.message_Box.messageBox_ThongBao_DangNhap_ThatBai)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.grid_message_image = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.textblock_ThongBao = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.button_Dong = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\..\..\Views\message_Box\messageBox_ThongBao_DangNhap_ThatBai.xaml"
            this.button_Dong.Click += new System.Windows.RoutedEventHandler(this.button_Dong_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

