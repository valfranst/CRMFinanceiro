   M S B A M L   `   `   `  ����M  ISistemaControle_V3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SistemaControle_V3SistemaControle_V3  5   	   '    !SistemaControle_V3.ProgressDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:SistemaControle_V3     5   	   ` \Syncfusion.Tools.Wpf, Version=19.1310.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=19.1310.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=19.1310.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b	 ^Syncfusion.SfInput.Wpf, Version=19.1310.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c898
syncfusion!http://schemas.syncfusion.com/wpf    	 5   	   -   5        $	��140��5   	   $	��340��6   $	��200��6"   $	��500��62     � Title$  CARREGANDO DADOS��6A   $��Segoe UI)�6Z    � 
ResizeMode$ 	CanResize=�6p    � WindowStyle$ SingleBorderWindow=�5   	    � WindowStartupLocation$ CenterScreen=�6*    � 	Resources 5       �� MergedDictionaries �� Source �� 
TargetType �� Property	 �� Value
 �� 
TargetType J� SnapsToDevicePixels {�Name �� Triggers P� Property P� Value �� 
TargetName N� EnterActions �� 
TargetName �� TargetProperty t� From	 t� To g� Duration g� AutoReverse g� RepeatBehavior�� 5   
    5      �� 5      $k epack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.ProgressBar.xaml?�6%   %�  '�       �� 5      " �61   .�5      ��  � ��	 �#54bdcd6/   �� 5       � ��	 �#0000006/   �� 5       � ��$	 0q�64   �� 5       � ��	 5      �� 5      "
 �6*   .R�5      � $��TemplateRoot��6#   $
 true��67   .+�5   "   �� #��z��6,   �� 5   "   $��
PART_Track��6,   $��0q�6>   {� 5   "   $ PART_Indicator��6,   $
��Left=�6D   $��0q�6_   ._�5    &   � $��
Foreground��6+   .+�5!   *   �� $��	Indicator��6X   #��z��64   6X   � 5"   *   $��	Animation��6/   $
}�True��6@   .+�5#   .   �� $��PART_GlowRect��65   $��0,0,0,0q�6K   $
��Left=�6\   #��z��6w   5$   +   � 5%   *   $��Overlay��6/   5&   +   5'   '   5(   #   �� 5*   "   #��z��6)   #��z��5+      5,       5-      P� 5.   "    �@�IsIndeterminate$
 true��6E   . �5/   &   �� $ 	Indicator��6-    � ��
	 ���� 6T   �� 50   &   $ PART_GlowRect��6-    � ��$		 100��6Y    51   &   �� 52   *   .��53   .   �� .��54   2   t� $ PART_GlowRect��55   )   $ Margin�56   )    	-50,0,0,057   )    	400,0,0,06;   $ 0:0:2D�6J   $
 True��58   )   $ Forever��6<   59   /   5:   +   5<   #   5>      5@      5A      5C      .��5F      ]� $��10q�6   .+�5G   
   � $��Bottom=�6    � ColumnDefinitions 5H      �� 5I      $��* �6#   �� 5J      $
��Auto �6#   .+�5L      � -   5         �Name$ pbStatus��5L      $��0��6,    � IsIndeterminate$
 True��6<   $��30��6S   �� 5N      -   5         ��Name$ CancelButton��5N      $��1��6+   $��10,0,0,0q�6;   $��90��6M   $��30��6X   $��Cancelar��6d   $y�Visible=�6w   $��Right=�6�   $��Bottom=�6�   6�   5O      �� 5P   
   -   5         ��Name$ 	TextLabel��5P      $%��Atualizando ...................��6'   $��CharacterEllipsis=�6N   $	��Top=�6o   $��20(�6�   5Q      5R      