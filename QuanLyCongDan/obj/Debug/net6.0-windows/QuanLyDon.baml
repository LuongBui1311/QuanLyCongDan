   M S B A M L   `   `   `  ����H  DQuanLyCongDan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyCongDanQuanLyCongDan  5   	       QuanLyCongDan.QuanLyDon   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   'localclr-namespace:QuanLyCongDan  5   	     � Title$  	QuanLyDon��5	   	   $	��750��6   $
��1140��6(      MaterialDesignBody#���   5
   	    � AllowsTransparency$
 True��5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   ��5   	   Z�  � 	Resources 5        	BoolToVis��%   &	       �� 5   
   6'   5      .��5      #  MaterialDesignThemes.Wpf.Card    MaterialDesignPaper#���  6      UniformCornerRadius$ 15Q�6M   $��25q�6f   .  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$	 Dp4=�6r   .��5   
   �  � ColumnDefinitions 5      �� 5      $	��190 �6#   �� 5      $��* �6#   .+�5      �� $��0��6   $	��700��6%    �� CornerRadius$ 	15 0 0 15��62    * &MaterialDesignLightSeparatorBackground#���  6K   ._�5      �� $��15q�6   .+�5      � $��	0 10 5 60q�6    $��Center=�63   .+�5      �� 	 �� BitmapScalingMode$	 HighQuality=�6    $+��%/Images/Bản sao của logo_MFIT.png��6N   $��30��6y   �� 5      $��
Công dân��6$   $��20(�64   $
��Bold"�6B   $
��Left=�6T   $��Center=�6o   $��10 0 0 0q�6�   5      �� 5      -   5        
 ��Name$
 btn_TrangChu��5        MaterialDesignFlatButton#��[ 63   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 6��6e   $
��auto��6�   $��35��5       +  %MaterialDesignThemes.Wpf.RippleAssist   Feedback
 �����$��0 0 0 15q�6V   .��5!      � $	��120��6$   .+�5"      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Home=�66   $��Center=�6B   $��0 0 20 0q�6]   �� 5#      $��Trang chủ��6(   5$      5%      �� 5&      -   5        $
 btn_CongDan��5&      #��[ 62   $ 6��6d   $
��auto��6�   $��35��5'      
 �����$��0 0 0 15q�6V   .��5(      � $	��120��6$   .+�5)        $ People=�66   $��Center=�6D   $��0 0 20 0q�6_   �� 5*      $��
Công dân��6(   5+      5,      �� 5-      -   5        $
 btn_QuanLyDon��5-      #��[ 64   $ 6��6f   $
��auto��6�   $��35��5.      
 �����$��0 0 0 15q�6V   .��5/      � $	��120��6$   .+�50        $ FolderMedia=�66   $��Center=�6I   $��0 0 20 0q�6d   �� 51      $��Quản lý đơn��6(   52      53      �� 54      #��[ 6   $ 6��6O   $
��auto��6|   $��35��55      
 �����$��0 0 0 15q�6V   .��56      � $	��120��6$   .+�57        $
 Help=�66   $��Center=�6B   $��0 0 20 0q�6]   �� 58      $��Trợ giúp��6(   59      5:      �� 5;       �� Orientation$ 
Horizontal=�6!   $��
10 0 10 15q�6:   $��Center=�6N   $
��auto��6i   $��35��6v   .+�5<        $ MoonAndStars=�62   $��Center=�6F   $��0 0 10 0q�6a   �� 5=      $��Center=�6$   $��	Dark Mode��6?   $��SemiBold"�6P   d� 5>      -   5         d�Name$ themeToggle��5?   '    � Cursor$
 Hand��5>   '    � ToolTip$ Enable Dark Mode��65   $��12 0 8 0q�6P    d� 	IsChecked 5?   <   �� *IsDarkTheme+5A      5B      (  "MaterialDesignThemes.Wpf.ColorZone  5D         Mode$ Light=�6/   
�������   CornerRadius$ 15��6S   $
��25 0q�6e   $��	0 170 0 0q�6t   .��5E      �� .+�5F      �� $	 HighQuality=�6$   $+��%/Images/Bản sao của logo_MFIT.png��6R   $��	0 -60 0 0q�6}   $	��100��6�   $	��100��6�   $��Center=�6�   �� 5G      
������$��11(�6@   $��SemiBold"�6N    �� TextAlignment$ Center=�6d   Upgrade to �� 6�   $��Heavy"�6�   .�6�   PRO6�    for�� 6�   more resources6�   �� 5H       ! MaterialDesignFlatMidBgButton#��[ 6%   $	 Dp0=�6\   $��28��6�   $ 6��6�   $��11(�5I   %   $��Upgrade��63   $��	0 20 0 25q�6E   5J      5K      5L      5M      � 5N      $��1��6   $��	30 12 0 0q�6#    � RowDefinitions 5O      �� 5P      $
��auto �6$   �� 5Q      $
��auto �6$   �� 5R      $��* �6$   �� 5S      $
��auto �6$   �� 5T      $
��auto �6$   .+�5V      ]� $��0��6   $��0 12 5 0q�6)   .+�5W      �� $
��Left=�6   $��Center=�69   $��15(�6T   $
��Bold"�6b   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tìm Kiếm��6t   �� 5X      -   5        $
 
btn_LogOut��5X        MaterialDesignIconButton#��[ 61   
 �����
�������$ 6��6�   $��40��6�   $��40��5Y      $��Right=�6(   $��Right=�6?   .��5Z        $ LogoutVariant=�62   5[      �� 5\      #��[ 6   $��40��6O   $��40��6[   $ 6��6f   $��Right=�6�   .��5]        $ Search=�62   5^      �� 5_      $��14 March 2023��6    
�����p�$��12(�6L   $
��Bold"�6Z   $��Center=�6l   $��Right=�6�   $��Right=�6�   $��0 0 20 0q�6�   5`      �� 5a      $��1��6   $��Quản lý đơn từ��6)   $��32(�6?   $��SemiBold"�6M   $��20 0 0 0q�6c   �� 5b      $��2��6   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6*    # MaterialDesignUniformTabControl#��[ 6O   $��0 5 10 5q�6�   .@�5c      �� $��Xem đơn từ��6   $
��auto��62   $��45��6?   5e      �� 5f      $��Duyệt đơn từ��6   $
��auto��64   $��45��6A   5h      5i      5j      5k      5l      5m      