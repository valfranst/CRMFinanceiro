   M S B A M L   `   `   `  ����A  =Backup, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BackupBackup  5   	       Backup.ProgressDialog   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Backup     5   	   8
syncfusion!http://schemas.syncfusion.com/wpf     5   	   -   5        $	��140��5   	   $	��340��6   $	��200��6"   $	��500��62     � Title$  CARREGANDO DADOS��6A   $��Segoe UI)�6Z    � 
ResizeMode$ 	CanResize=�6p    � WindowStyle$ SingleBorderWindow=�5   	    � WindowStartupLocation$ CenterScreen=�6*    � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType	 J� SnapsToDevicePixels
 {�Name �� Triggers P� Property P� Value �� 
TargetName N� EnterActions �� 
TargetName �� TargetProperty t� From	 t� To g� Duration g� AutoReverse g� RepeatBehavior�� 5   
   %�  '�       �� 5      " �61   .�5      ��  � �� �#54bdcd6/   �� 5       � �� �#0000006/   �� 5       � ��$ 0q�64   �� 5       � �� 5      �� 5      " �6*   .R�5      � $��TemplateRoot��6#   $
	 true��67   .+�5   "   �� #��z��6,   �� 5   "   $��
PART_Track��6,   $��0q�6>   {� 5   "   $
 PART_Indicator��6,   $
��Left=�6D   $��0q�6_   ._�5   &   � $��
Foreground��6+   .+�5   *   �� $��	Indicator��6X   #��z��64   6X   � 5   *   $��	Animation��6/   $
}�True��6@   .+�5   .   �� $��PART_GlowRect��65   $��0,0,0,0q�6K   $
��Left=�6\   #��z��6w   5    +   � 5!   *   $��Overlay��6/   5"   +   5#   '   5$   #   �� 5&   "   #��z��6)   #��z��5'      5(       5)      P� 5*   "    �@�IsIndeterminate$
 true��6E   . �5+   &   �� $ 	Indicator��6-    � ��
 ���� 6T   �� 5,   &   $ PART_GlowRect��6-    � ��$	 100��6Y    5-   &   �� 5.   *   .��5/   .   �� .��50   2   t� $ PART_GlowRect��51   )   $ Margin�52   )    	-50,0,0,053   )    	400,0,0,06;   $ 0:0:2D�6J   $
 True��54   )   $ Forever��6<   55   /   56   +   58   #   5:      5<      5=      5?      .��5B      ]� $��10q�6   .+�5C   
   � $��Bottom=�6    � ColumnDefinitions 5D      �� 5E      $��* �6#   �� 5F      $
��Auto �6#   .+�5H      � -   5         �Name$ pbStatus��5H      $��0��6,    � IsIndeterminate$
 True��6<   $��30��6S   �� 5J      -   5         ��Name$ CancelButton��5J      $��1��6+   $��10,0,0,0q�6;   $��90��6M   $��30��6X   $��Cancelar��6d   $y�Visible=�6w   $��Right=�6�   $��Bottom=�6�   6�   5K      �� 5L   
   -   5         ��Name$ 	TextLabel��5L      $%��Atualizando ...................��6'   $��CharacterEllipsis=�6N   $	��Top=�6o   $��20(�6�   5M      5N      