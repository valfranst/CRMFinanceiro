   M S B A M L   `   `   `  ����M  ISistemaControle_V3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SistemaControle_V3SistemaControle_V3  5   	   #    SistemaControle_V3.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:SistemaControle_V3     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   ` \Syncfusion.Tools.Wpf, Version=19.1310.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=19.1310.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a	 ]Syncfusion.Shared.WPF, Version=19.1310.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b
 ^Syncfusion.SfInput.Wpf, Version=19.1310.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c898
syncfusion!http://schemas.syncfusion.com/wpf   	 
 5	   	     �Language$  pt-BR�5   b   -   5         � Title$ APLICAÇÕES��5   +    � WindowState$ 	Maximized=�6>   $	��700��5   	   $
��1100��6   #��Z��6)   #��Z��6b   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone  $��0��6#   $��0��60      Mode$ 
PrimaryMid=�6@   $��2q�6R   $��50��6^   .��5      ]� .+�5      ��  �� Orientation$ 
Horizontal=�6   $
��Left=�66   $
��Left=�6L   .+�5      �� -   5         ��Name$ 	btCliente��5      $��40��60   $��5 0 0 0q�6<    $   MaterialDesignRaisedAccentButton#��[  6M   $	��120��6�    � ToolTip$ Cliente��6�   .��5      �� $ 
Horizontal=�6%   $	��0 0q�6>   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 AccountSearch=�66   $��30��6K   $��30��6V   $��Center=�6b   $��0q�6}   �� 5      $��CLIENTE��6(   $��Center=�67   5       5!      �� 5"      -   5        $ 
btProducao��5"      $��40��61   $��15 0 0 0q�6=   #��[  6O   $	��140��6�   $ 
Produção��6�   .��5#      �� $ 
Horizontal=�6%   $	��0 0q�6>   .+�5$        $	 CashRegister=�66   $��30��6J   $��30��6U   $��Center=�6a   $��0q�6|   �� 5%      $��
PRODUÇÃO��6(   $��Center=�68   5&      5'      �� 5(      -   5        $ btRecebimento��5(      $��40��64   $��15 0 0 0q�6@   #��[  6R   $	��160��6�   $ Recebimento��6�   .��5)      �� $ 
Horizontal=�6%   $	��0 0q�6>   .+�5*        $	 AccountCash=�66   $��30��6I   $��30��6T   $��Center=�6`   $��0q�6{   �� 5+      $��RECEBIMENTO��6(   $��Center=�6;   $��4 0 0 0q�6V   5,      5-      �� 5.      -   5        $ btRefinanciamento��5.      $��40��68   $��15 0 0 0q�6D   #��[  6V   $	��200��6�   $ Refinanciamento��6�   .��5/      �� $ 
Horizontal=�6%   $	��0 0q�6>   .+�50        $	 
CashRefund=�66   $��30��6H   $��30��6S   $��Center=�6_   $��0 0 2 0q�6z   �� 51      $��REFINANCIAMENTO��6(   $��Center=�6?   52      53      �� 55      -   5        $ btAddCliente��55      $��40��63   $��15 0 0 0q�6?   #��[  6Q   $	��150��6�   $ Refinanciamento��6�   .��56      �� $ 
Horizontal=�6%   $	��0 0q�6>   .+�57        $	 	PersonAdd=�66   $��30��6G   $��30��6R   $��Center=�6^   $��0 0 2 0q�6z   �� 58      $��ADD CLIENTE��6(   $��Center=�6;   59      5:      �� 5<      -   5        $ btReset��5<      $��10 0 0 0q�6.   
���  �� 0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6Q   $ Status Banco de Dados��6�   
����� �6�   5?      �� 5B      $ 
Horizontal=�6   $��Right=�66   $��Right=�6M   .+�5D      5  /Syncfusion.Windows.Tools.Controls.RibbonTextBox  -   5        
  Name$
 txtPesquisa��5D   /   $	��240��6D   $��0 0 5 0q�6P   $��18(�6b   $��35��6p   
�������
���   �$
��Left=�5E   ;   $��Center=�6]   
�������5F   ;   '  !MaterialDesignThemes.Wpf.PopupBox  5H      $��Right=�6.      PlacementMode$ BottomAndAlignRightEdges=�6F      	StaysOpen$ False��6o   $��0 0 5 0q�6�      PopupContent. 5I      �� $
��Auto��6%   $	��175��63   .+�5L      �� -	   5        $ btExtra��5L   %   .��5M   "   �� $ 
Horizontal=�6-   $	��0 0q�6F   .+�5N   &     $	 FormatListChecks=�6>   $��30��6V   $��30��6a   $��Center=�6m   $��0q�6�   �� 5O   &   $��LISTAS��60   $��Center=�6>   5P   #   5Q      �� 5T      -
   5        $ btConfiguracao��5T   %   .��5U   "   �� $ 
Horizontal=�6-   $	��0 0q�6F   .+�5V   &     $	 Settings=�6>   $��30��6N   $��30��6Y   $��Center=�6e   $��0q�6�   �� 5W   &   $��CONFIGURAÇÕES��60   $��Center=�6E   5X   #   5Y      5[      5\      5^      5a      5c      � 5e   
   -   5         �Name$ GridMain��5e      $��1��6!   $��0��6.   $��Stretch=�6>   $��Stretch=�6\   $��0q�6x   
������� 5f      �� 5g      $��* �6#    5i      �� 5j      $��* �6    5m      5o      5p      