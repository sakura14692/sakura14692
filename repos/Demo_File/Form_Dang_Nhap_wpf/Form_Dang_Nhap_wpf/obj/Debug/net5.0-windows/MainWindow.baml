   M S B A M L   `   `   `  ����N  JForm_Dang_Nhap_wpf., Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Form_Dang_Nhap_wpf_Form_Dang_Nhap_wpf_  5   	   $    Form_Dang_Nhap_wpf_.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Form_Dang_Nhap_wpf_     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	     � Title$  
MainWindow��5	   	   $	��700��6   $	��600��6)    � AllowsTransparency$
 True��5
   	   
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      6"   �� 5      6"   .+�5      �� -   5         �� CornerRadius$ 20��5      $��2��6'   ���	#FFA03131��5      �� 5      .��5      �  � Color$ 	#FF7BE9F6��6'   � 5      $ 	#FFB1409B��6'    � Offset$ 1Q�69   5      5!      �� 5#      $��Center=�6   .+�5%      �� $��/trungpro.png��5&      $	��200��5'      5-      �� 5/      $��Tài chính- Kinh doanh��50      $��Center=�51      $��Light"�52      $��Arial)�53      $��30(�54      
�������
������ 56      5<      �� 5>      $��1��6   .+�5?      �� 	 �� Orientation$	 
Horizontal=�5@      .+�5D      �� -   5        
 ��Name$
 textBox_Ten_Dang_Nhap��5E      $��Arial)�5F      $��Light"�5G      $��Tên đăng nhập��5H      $��22(�5I      
�������
������ $��0q�5L      $	��235��5M      $��Center=�5N      $
��Left=�5O       J� Opacity$	 0.5Q�5P      $��25��5Q      $��115,0q�5R      6%   .  (MahApps.Metro.IconPacks.PackIconMaterial  5W         Kind$ Account=�5X      $��Center=�5Y      $��Center=�5Z      
�������5_      5c      �� 5e      $	��371��5f      $��2��5g      
�������$	 0.5Q�5i      5l      �� 5p      $	 
Horizontal=�5q      .+�5u      G� -   5         G�Name$ textBox_Mat_Khau��5v      $��Arial)�5w      $��Light"�5x       G� Password$ Mật khẩu��5y      $��22(�5z      
�������
������ $��0q�5}      $	��235��5~      $��Center=�5      $
��Left=�5�      $	 0.5Q�5�      $��25��5�      $��115,0q�5�      6%     5�      $	 Key=�5�      $��Center=�5�      $��Center=�5�      
�������5�      5�      �� 5�      $	��371��5�      $��2��5�      
�������$	 0.5Q�5�      5�      �� 5�      $	 
Horizontal=�5�      $��0,30,0,0q�5�      .+�5�      �� -   5         ��Name$ Button_Dang_NHap��5�      $	��150��5�      $��50��5�      $��Đăng nhập��5�      $��	112,0,0,0q�5�      $��21(�5�      5�      �� 5�      -   5        $ Button_Dang_Ki��5�      $	��150��5�      $��50��5�      $��
Đăng kí��5�      $��80,0,0,0q�5�      $��21(�5�      5�      5�      5�      5�      �� 5�   
   -   5        $ Button_Thoat��5�      $	��150��5�      $��50��5�      $��Thoát��5�      $��Bottom=�5�      $��21(�5�      $��20q�5�      5�      �� 5�   
   $	��155��5�      $��30��5�      
������ $��Bottom=�5�      $��Light"�5�      $	��150q�5�      $��20(�5�      $��Arial)�5�      �� 5�      .�6   Quên mật khẩu ?6*   5�      5�      5�      