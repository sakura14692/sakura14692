   M S B A M L   `   `   `  ����l  hBinarymission.WPF.Controls.TabControl, Version=2.0.0.0, Culture=neutral, PublicKeyToken=5cf66fb45965060f�bclr-namespace:Binarymission.WPF.Controls.Containers;assembly=Binarymission.WPF.Controls.TabControl%Binarymission.WPF.Controls.Containers  5   	   I ETabControlDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:TabControlDemo.InfrastructureTabControlDemo.Infrastructure 5   	   )   #TabControlDemo.TabControlDemoWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   y
containersbclr-namespace:Binarymission.WPF.Controls.Containers;assembly=Binarymission.WPF.Controls.TabControl     5   	   Finfrastructure+clr-namespace:TabControlDemo.Infrastructure     5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � SizeToContent$ Manual=�5
   	    � Icon$ App.ico��5   	   $	��990��5   	    � Title$( "Binarymission WPF Tab Control Demo��5   	   ��5      �� 5   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$
 Gray��6    � Offset$ 0Q�5      � 5      $ 	#FF4E4B4B��6   $ 1Q�5      5       � 	Resources 5      	 �� 
TargetType
 �� Property �� Value3   -Binarymission.WPF.Controls.Containers.TabItem �� ElementName �� Path6   0Binarymission.WPF.Controls.Containers.TabControl6  0TabControlDemo.Infrastructure.PlacementConverter   PlacementConverter��%j  '��       '�� �     '      '  �    &	  %    �� 5   
   "	 ��6   .�5      �� 
 � ��
 �����6+   �� 5      
 � ��$ 14(�6)   �� 5      
 � ��$ SemiBold"�6+   5      �� 5   
   "	 ��6   .�5      �� 
 � ��
 �����6+   �� 5       
 � ��$ 14(�6)   �� 5!      
 � ��$ Normal"�6+   �� 5"      
 � ��$ Center=�69   �� 5#      
 � ��$ 0 2 0 2q�6'   5$      �� 5&   
   "	  6   .�5'      �� &
 �@ IsAnimationEnabledOnMouseEnter 6?   �� $, &CheckBoxIsAnimationEnabledOnMouseEnter��$ 	IsChecked��� 5(      .
 �@ &IsDimmedStateEnabledForUnSelectedItems 6G   �� $4 .CheckBoxIsDimmedStateEnabledForUnSelectedItems��$ 	IsChecked�5)      �� 5+   
   "	  6   .�5,      �� 
 � ��$ 	0 20 10 0q�6'   6;   �� 5-      
 � ��$	 930��6&   �� 5.      
 � ��$ 14(�6)   �� 5/      
 �@�UseLayoutRounding . 62   �� 50      
 � ��$ 1q�60   �� 51      
 � �� �	#FF0000196,   �� 52      
 � ��$ Stretch=�62   �� 53      
 � ��$ Stretch=�64   54        56   
   6,   57      .��59      �� $
��Auto=�6   $
��Auto=�66   .��5:   
   � $��20 10 10 10q�6    � RowDefinitions 5<      �� 5=      $
��Auto �6    �� 5>      $��* �6    �� 5?      $
��Auto �6    .+�5B      �� $.��(Binarymission WPF Tab control in action:��6   $��0��5C      $��Center=�5D      $
��Left=�5E        5G      $��1��6$      ScrollButtonBrush
 ����� �� TabStripPlacement 5H   $   �� $ TabPlacementModeComboBox��$ SelectedItem� �� 	Converter# [     RenderingMode 5I   $   �� $ RenderingModeComboBox��$ SelectedItem�   TabItemBorderBrush 5J   $   �� *TabControlBackground+ �� RelativeSource �� *Self+.@�5M        $��
Work Stuff��6%     5N      $��Books, Magzs.��6%     5O      $��DVDs, CDs, E-Books��6%     5P      $��More Media files��6%    �� 
IsSelected . 6?     5Q      $��Movies and Music��6%   $��Right=�6?     5R      $��Holiday pictures��6%   5T      �� 5V       �� Orientation$ 
Horizontal=�6   $��2��5W      $	��Top=�5X      $��	0,20,0,15q�5Y      .+�5[      �� $ Vertical=�6   .+�5]      �� $��Choose rendering options:��6    �� 5_      $��2q�6   ���	#FFFCFAF2$��
0,10,25,12q�5a      $	��Top=�5b      ._�5c      �� $ Vertical=�6%   $��10q�6<   .+�5d      �� -   5        $,��&CheckBoxIsAnimationEnabledOnMouseEnter��5e   '   $5��/Is animation enabled on mouse-enter into items?��5d   '   ���	#FFFCF2F25f   '   �� 5g      -   5        $4��.CheckBoxIsDimmedStateEnabledForUnSelectedItems��5i   '   $4��.Is dimmed state enabled for un-selected items?��5g   '   ���	#FFFCF2F25i   '   5j      5k      5l      �� 5m      $ 
Horizontal=�6   $��Center=�5n   !   .+�5o      �� $��Choose rendering style: ��6    $��0 5 15 5q�5p        � ForceCursor .  5q       �� 5r      -   5        $��RenderingModeComboBox��5s   #   $	��125��5t   #   $��Center=�5u   #    �� SelectedIndex$ 1��5v   #   ��5r      �� *TabControlRenderingModes+��5w      �� 5x      .R�5y   "   �� $��Center=�6=   
���   ���6,   �� 6X   5z      5|      �� 5~      $!��Choose tabstrip placement: ��6    $��	15 5 15 5q�5        .  5�       �� 5�      -   5        $��TabPlacementModeComboBox��5�      $��Center=�5�   #   $��65��5�   #   $ 0��5�   #   .@�5�      �� .��6'   Top6,   �� 5�      .��6'   Bottom6/   5�      5�      5�      5�      5�      5�      