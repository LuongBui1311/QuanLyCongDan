   M S B A M L   `   `   `  ����H  DQuanLyCongDan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyCongDanQuanLyCongDan  5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aeHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.WpfMaterialDesignThemes.Wpf 5          QuanLyCongDan.App   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      -localclr-namespace:QuanLyCongDan     5      XwpfHclr-namespace:MaterialDesignThemes.Wpf;assembly=MaterialDesignThemes.Wpf     5        �� 	Resources  5       �� MergedDictionaries �� Source   DataGridRowStyle1 �� 
TargetType)  #System.Windows.Controls.DataGridRow �� Property * &MaterialDesignLightSeparatorBackground �� Value �� 
TargetType ��Name �� Padding	 �� CornerRadius
 J� SnapsToDevicePixels?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid � ColumnDefinitions � RowDefinitions?  9System.Windows.Controls.Primitives.DataGridCellsPresenter   
ItemsPanelA  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter   DetailsVisibility:  4System.Windows.Controls.Primitives.DataGridRowHeader7  1System.Windows.Controls.DataGridHeadersVisibility
   Row �� ConverterParameter&   System.Windows.Controls.DataGrid!   HeadersVisibilityConverter �� 	Converter �� RelativeSource �� AncestorType �� Triggers P� Property P� Value ]� 
Conditions �� Property �� Value  DataGridCellStyle1*  $System.Windows.Controls.DataGridCell�� 5	   
    5
      �� 5      $d ^pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Dark.xaml?�6%   �� 5      $e _pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml?�6%   �� 5      $s mpack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.Red.xaml?�6%   �� 5      $s mpack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.Lime.xaml?�6%   %	  &	        &	 9    �� 5      "  6.   .�5      ��  � ��# �  6/   �� 5       � ��$ 0 4 0 0q�6+   �� 5       �@J�SnapsToDevicePixels$
 true��68   �� 5       �@=�ErrorTemplate 6=   Z� �� 5       �@ ValidationErrorTemplate 5      �� 5      .R�5      �� 
���  ��$��2,0,0,0q�69   $��!��6J   $��Center=�6S   5      5      �� 5       � �� 5       �� 5!      "  6*   .R�5"      �� $ 
DGR_Border��6%   $	 0 8q�69   #��z��6G   $��0q�6q   $	 5��6�   $

 True��6�   ._�5#   "      5$   &   �� 5%   *   $
��Auto �6;   �� 5&   *   $��* �6;    5(   &   �� 5)   *   $��* �68   �� 5*   *   $
��Auto �68   .+�5,   &     $��1��6=   #��z 6M   #
 z
 6w     5-   &   $��1��6?   $��1��6O   #y�z 6\     5.   &   $��0��68   $��2��6H   $��0��6Y   y�6f   �� *HeadersVisibility+# Z # Z  �� "  5/   #   50      51      53      �� 54       �@=�ErrorTemplate 6=   Z� �� 55       �@ ValidationErrorTemplate 56      �� 57      .R�58      �� ���#d50000$��2,0,0,0q�6=   $��!��6N   $��Center=�6W   59      5;       5<      P� 5=       �@ 
IsSelected$
 True��64   . �5>      ��  � ��
 �r���67   5?      P� 5@       �@J�IsMouseOver$
 True��65   . �5A      ��  � ��
 �z���67   5B      ]� 5C       5D      �� 5E       �@ 
IsSelected$
 True��6>   �� 5F       �@��IsSelectionActive$ False��6N   ./�5H      ��  � �� �#dfdfdf67   5I      5K      �� 5L      "  6/   .�5M      ��  � ��
 ���� 6/   �� 5N       � ��
 ���� 60   �� 5O       � ��$ Center=�66   �� 5P       �@�FocusVisualStyle 65   Z� �� 5Q       � ��$
 15 0q�6+   �� 5R       � �� 5S      �� 5T      "  6*   .R�5U      �� #��z��6%   $��0q�6O   $

 True��6c   ._�5V   "   �� #
 z
 63   5W      5X      5Z       5[      P� 5\       �@ 
IsSelected$
 True��64   . �5]      ��  � ��
 ���� 67   5^      ]� 5b       5c      �� 5d       �@ 
IsSelected$
 true��6>   �� 5e       �@��IsSelectionActive$ false��6N   ./�5g      ��  � ��
 ���� 67   5h      5j      5l      5n      