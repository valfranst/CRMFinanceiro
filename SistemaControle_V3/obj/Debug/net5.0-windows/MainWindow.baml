   M S B A M L   `   `   `  ����M  ISistemaControle_V3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SistemaControle_V3SistemaControle_V3  5   	   #    SistemaControle_V3.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:SistemaControle_V3     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   ` \Syncfusion.Tools.Wpf, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a	 ]Syncfusion.Shared.WPF, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b
 ^Syncfusion.SfInput.Wpf, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c898
syncfusion!http://schemas.syncfusion.com/wpf   	 
 5	   	     �Language$  pt-BR�5   b   -   5         � Title$ APLICAÇÕES��5   +    � WindowState$ 	Maximized=�6>   $	��700��5   	   $
��1100��6   #��Z��6)   #��Z��6b   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��37 �6   �� 5      $��* �6   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone  $��0��6#   $��0��60      Mode$ 
PrimaryMid=�6@   $��2q�6R   $��35��6^   .��5      ]� .+�5      ��  �� Orientation$ 
Horizontal=�6   $
��Left=�66   $
��Left=�6L   .+�5      �� -   5         ��Name$ 	btCliente��5      $��30��60   $��5 0 0 0q�6<    $   MaterialDesignRaisedAccentButton#��[  6M   $	��120��6�    � ToolTip$ Cliente��6�   .��5      �� $ 
Horizontal=�6%   $	��0 0q�6>   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 AccountSearch=�66   $��30��6K   $��30��6V   $��Center=�6b   $��0q�6}   �� 5       $��CLIENTE��6(   $��Center=�67   $
��Bold"�6R   5!      5"      �� 5#      -   5        $ 
btProducao��5#      $��30��61   $��15 0 0 0q�6=   #��[  6O   $	��140��6�   $ 
Produção��6�   .��5$      �� $ 
Horizontal=�6%   $	��0 0q�6>   .+�5%        $	 CashRegister=�66   $��30��6J   $��30��6U   $��Center=�6a   $��0q�6|   �� 5&      $��
PRODUÇÃO��6(   $��Center=�68   $
��Bold"�6S   5'      5(      �� 5)      -   5        $ btRecebimento��5)      $��30��64   $��15 0 0 0q�6@   #��[  6R   $	��165��6�   $ Recebimento��6�   .��5*      �� $ 
Horizontal=�6%   $	��0 0q�6>   .+�5+        $	 AccountCash=�66   $��30��6I   $��30��6T   $��Center=�6`   $��0q�6{   �� 5,      $��RECEBIMENTO��6(   $��Center=�6;   $��4 0 0 0q�6V   $
��Bold"�6g   5-      5.      �� 5/      -   5        $ btRefinanciamento��5/      $��30��68   $��15 0 0 0q�6D   #��[  6V   $	��200��6�   $ Refinanciamento��6�   .��50      �� $ 
Horizontal=�6%   $	��0 0q�6>   .+�51        $	 
CashRefund=�66   $��27��6H   $��27��6S   $��Center=�6_   $��0 0 2 0q�6z   �� 52      $��REFINANCIAMENTO��6(   $��Center=�6?   $
��Bold"�6Z   53      54      �� 56      -   5        $ btAddCliente��56      $��30��63   $��15 0 0 0q�6?   #��[  6Q   $	��160��6�   $ Refinanciamento��6�   .��57      �� $ 
Horizontal=�6%   $	��0 0q�6>   .+�58        $	 	PersonAdd=�66   $��30��6G   $��30��6R   $��Center=�6^   $��0 0 2 0q�6z   �� 59      $��ADD CLIENTE��6(   $��Center=�6;   $
��Bold"�6V   5:      5;      �� 5=      -   5        $ btReset��5=      $��30��6.   $��30��6:   $��10 0 0 0q�6E   
���  �� 0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6h   $ Status Banco de Dados��6�   
����� �6�   �� 5?      -   5        $ btBackup��5?      $��15 0 0 0q�6/    , (MaterialDesignFloatingActionAccentButton#��[ 6A   $ Backup de Dados��6�   
��� � �$��30��5@      $��30��6%   $��Center=�60   $��Center=�6K   $��Center=�6h   $y�	Collapsed=�6�   .��5A        $	 ContentSaveCog=�62   $��18��6H   $��18��6T   5B      5D      �� 5G      $ 
Horizontal=�6   $��Right=�66   $��Right=�6M   .+�5I      5  /Syncfusion.Windows.Tools.Controls.RibbonTextBox  -	   5        
  Name$
 txtPesquisa��5I   /   $	��240��6D   $��0 0 5 0q�6P   $��18(�6b   $��30��6p   
�������
���   �$
��Left=�5J   ;   $��Center=�6]   
�������5K   ;   '  !MaterialDesignThemes.Wpf.PopupBox  5M      $��Right=�6.      PlacementMode$ BottomAndAlignRightEdges=�6F      	StaysOpen$ False��6o   $��0 0 5 0q�6�      PopupContent. 5N      �� $
��Auto��6%   $	��175��63   .+�5Q      �� -
   5        $ btExtra��5Q   %   .��5R   "   �� $ 
Horizontal=�6-   $	��0 0q�6F   .+�5S   &     $	 FormatListChecks=�6>   $��30��6V   $��30��6a   $��Center=�6m   $��0q�6�   �� 5T   &   $��LISTAS��60   $��Center=�6>   5U   #   5V      �� 5Y      -   5        $ btConfiguracao��5Y   %   .��5Z   "   �� $ 
Horizontal=�6-   $	��0 0q�6F   .+�5[   &     $	 Settings=�6>   $��30��6N   $��30��6Y   $��Center=�6e   $��0q�6�   �� 5\   &   $��CONFIGURAÇÕES��60   $��Center=�6E   5]   #   5^      5`      5a      5c      5f      5h      � 5j   
   -   5         �Name$ GridMain��5j      $��1��6!   $��0��6.   $��Stretch=�6>   $��Stretch=�6\   $��0q�6x   
������� 5k      �� 5l      $��* �6#    5n      �� 5o      $��* �6    5r      5t      5u      