   M S B A M L   `   `   `  ����M  ITaiChinh_KinhDoanh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:TaiChinh_KinhDoanh.Views.PhuTroTaiChinh_KinhDoanh.Views.PhuTro  5   	   2    ,TaiChinh_KinhDoanh.Views.PhuTro.form_Thu_Vao   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:TaiChinh_KinhDoanh.Views.PhuTro     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962a@Material1http://materialdesigninxaml.net/winfx/xaml/themes  6E   -   5          � Title$  form_Thu_Vao��5   	    � WindowStyle$
 None=�5	   	    � AllowsTransparency$
 True��5
   	   $	��700��5      $
��1200��6   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   � 5      $ 	#FF1D2B5C��6    � Offset$ 1Q�61   5      .+�5   
   �� $	��Top=�5      $��30��5       �� Orientation$ 
Horizontal=�5      .+�5      �� 
����·�$��Center=�5      $��20(�5      $��20,0,0,0q�5       
Thu vào5"      �� 5$      -   5         ��Name$ button_Close��5$      $��Center=�5%      $��
1080,0,0,0q�5&      .��5(      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 Power=�5)      
�������$��Center=�5+      5/      50      53      � 58   
   $	��Top=�59      $	��200��5:      $
��1100��5;      $��40q�5<      
 � ColumnDefinitions
 5@      �� 5B      6&    � RowDefinitions 5F      �� 5G      6"   �� 5H      6"   �� 5I      6"   �� 5J      6#   .+�5R      ��  �� CornerRadius$ 5��5S      $��2q�5T      
����·�$
��Left=�5V      $	��350��5W      $��1��5X      $��0,10,0,0q�5Y      ._�5\      �� $ 
Horizontal=�5]   !   $��Center=�5^   !   $��Right=�5_   !   .+�5b      �� $��0,0,12,0q�5c   %   $��Center=�5d   %   
����·�$��20��5f   !   Mã số khoản thu5i      �� 5j      -   5         ��Name$ textbox_ma_so_khoan_thu��5k       �� 
IsReadOnly$
 True��5l   %   $��0,0,10,0q�5m   %   $��Center=�5n   $   $	��223��5o   %   $��25��5p   $   $��15(�5q   %   
������ 
������ 
������ �� 
CaretBrush
 ������5v       �� *SelectedItem.ma_so_khoan_thu+ �� ElementName$ listview_Thu_Vao�� �� Mode$ OneWay=�.��5w   &   5y      5z      5{      �� 5      $ 5��5�      $��2q�5�      
����·�$
��Left=�5�      $	��400��5�      $��3��5�      $��0,10,0,0q�5�      ._�5�      �� $ 
Horizontal=�5�   !   $��Center=�5�   !   $��Right=�5�   !   .+�5�      �� $��0,0,12,0q�5�   %   $��Center=�5�   %   
����·�$��20��5�   !   Nguồn gốc5�      �� 5�      -   5        $ textbox_nguon_goc��5�      $
 True��5�   %   $��0,0,10,0q�5�   %   $��Center=�5�   $   $	��300��5�   %   $��25��5�   $   $��15(�5�   %   
������ 
������ 
������
 ������5�       �� *SelectedItem.nguon_goc+$ listview_Thu_Vao��$ OneWay=�.��5�   &   5�      5�      5�      �� 5�      $ 5��5�      $��2q�5�      
����·�$
��Left=�5�      $	��400��5�      $��0,10,0,0q�5�      $��3��5�      $��1��5�      ._�5�      �� $ 
Horizontal=�5�   !   $��Center=�5�   !   $��Right=�5�   !   .+�5�      �� $��0,0,12,0q�5�   %   $��Center=�5�   %   
����·�$��20��5�   !   Tên khoản thu5�      �� 5�      -   5        $ textbox_ten_khoan_thu��5�      $
 True��5�   %   $��0,0,10,0q�5�   %   $��Center=�5�   $   $	��285��5�   %   $��25��5�   $   $��15(�5�   %   
������ 
������ 
������
 ������5�   !   �� *SelectedItem.ten_khoan_thu+$ listview_Thu_Vao��$ OneWay=�.��5�   &   5�      5�      5�      �� 5�      $ 5��5�      $��2q�5�      
����·�$
��Left=�5�      $	��300��5�      $��0,10,0,0q�5�      $��1��5�      $��2��5�      ._�5�      �� $ 
Horizontal=�5�   !   $��Center=�5�   !   $��Right=�5�   !   .+�5�      �� $��0,0,12,0q�5�   %   $��Center=�5�   %   
����·�$��20��5�   !   Số tiền5�      �� 5�      -   5        $ textbox_So_tien��5�      $
 True��5�   %   $��0,0,10,0q�5�   %   $��Center=�5�   $   $	��223��5�   %   $��25��5�   $   $��15(�5�   %   
������ 
������ 
������
 ������5  "   �� *SelectedItem.so_tien+$ listview_Thu_Vao��$ OneWay=�.��5  &   5     5     5     5
     � 5  
   $��Bottom=�5     $	��400��5     ��5     �� 5     $ 0.5,1&�6&   $ 0.5,0&�67   .��5     � $ Black��6#   � 5     $ 	#FF1D2B5C��6#   $ 1Q�65   5     .+�5     �� $	��Top=�5     $ 
Horizontal=�5     $��60��5     $
��1100��5     ��5     �� 5     $ 0.3,1&�6*   $ 0.5,0&�6;   .��5     � $ Black��6'   � 5      $ 	#FF120838��6'   $ 1Q�69   5!     .+�5$     �� -   5        $ button_thu_vao_Them��5%     $��5q�5&     $��40��5'     $��80��5(     $��5q�5)     
����·�.��5+     � $��60��5,     .+�5.       $		 Add=�5/     
������53     �� 54     $��Right=�55     
����·�$��16(�57     Thêm5:     5;     5=     �� 5A     -   5        $ button_thu_vao_Sua��5B     $��5q�5C     $��40��5D     $��80��5E     $��5q�5F     
����·�.��5I     � $��60��5J     .+�5L       $
	 Edit=�5M     
��� d �5Q     �� 5R     $��Right=�5S     
����·�$��16(�5U     Sửa5X     5Y     5[     �� 5_     -	   5        $ button_thu_vao_Xoa��5`     $��5q�5a     $��40��5b     $��80��5c     $��5q�5d     
����·�.��5g     � $��60��5h     .+�5j       $	 Delete=�5k     
���  ��5o     �� 5p     $��Right=�5q     
����·�$��16(�5s     Xóa5v     5w     5y     �� 5     -
   5        $ button_thu_vao_Luu��5�     $��60,0,0,0q�5�     $��40��5�     $��80��5�     $��5q�5�     
����·�.��5�     � $��60��5�     .+�5�       $	 ContentSaveEdit=�5�     
����� �5�     �� 5�     $��Right=�5�     
����·�$��16(�5�     Lưu5�     5�     5�     �� 5�     -   5        $ button_thu_vao_Huy��5�     $��5q�5�     $��40��5�     $��80��5�     $��5q�5�     
����·�.��5�     � $��60��5�     .+�5�       $	 Cancel=�5�     
�������5�     �� 5�     $��Right=�5�     
����·�$��16(�5�     Hủy5�     5�     5�     �� 5�     $ 5��5�     $��2q�5�     
����·�$
��Left=�5�     $	��300��5�     $��	300,0,0,0q�5�     $��Center=�5�     $��40��5�     ._�5�     �� $ 
Horizontal=�5�  !   $��Center=�5�  !   $��Right=�5�  !   $	��280��5�  %   .+�5�       $	 Search=�5�  )   $��Center=�5�  )   
����Zj�5�  )   �� 5�     $��10,0,0,0q�5�  %   $��Center=�5�  %   
����·�$��20��5�  !   Tìm kiếm5�     �� 5�     -   5        $ textbox_tim_kiem��5�     $��20,0,0,0q�5�  %   $��Center=�5�  $   $	��175��5�  %   $��25��5�  $   $��15(�5�  %   
������ 
������ 
������
 ����.��5�  &   5�     5�     5�     5�     �� 5�     -   5         ��Name$ listview_Thu_Vao��5�     $��20(�5�     
����·�
������$��Bottom=�5�     $��15q�5�     $	��300��5      $��Center=�5     $
��1100��5      �� View 5	     �� 5     .P�5     �� $��Mã số khoản thu��5  %    �� DisplayMemberBinding 5  &   �� *ma_so_khoan_thu+5     �� 5     $��Tên khoản thu��5  '    5  '   �� *ten_khoan_thu+5!     �� 5'     $��Số tiền��5(  '    5)  *   �� *	so_tien+5-     �� 53     $��Nguồn gốc��54  '    55  *   �� *	nguon_goc+59     5F     5I     5L     5O     5P     