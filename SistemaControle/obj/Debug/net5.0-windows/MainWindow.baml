   M S B A M L   `   `   `  ����J  FSistemaControle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SistemaControleSistemaControle  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   h dSyncfusion.SfSkinManager.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89iLclr-namespace:Syncfusion.SfSkinManager;assembly=Syncfusion.SfSkinManager.WPFSyncfusion.SfSkinManager 5   	        SistemaControle.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9i+http://schemas.microsoft.com/xaml/behaviors     5   	   /localclr-namespace:SistemaControle     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	   l hSyncfusion.SfTextInputLayout.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89`	 \Syncfusion.Tools.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89f
 bSyncfusion.SfAccordion.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b ^Syncfusion.SfInput.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89m iSyncfusion.SfNavigationDrawer.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89@
syncfusion!http://schemas.syncfusion.com/wpf   	 
     5
   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   asyncfusionskinLclr-namespace:Syncfusion.SfSkinManager;assembly=Syncfusion.SfSkinManager.WPF  5   	     �Language$  pt-BR�5       -   5         � Title$ APLICAÇÕES��5   	   $	��703��6   $
��1100��6,   #��Z��6<   #��Z��6u    � WindowState$ 	Maximized=�5   	    � Icon$ /refresh.ico��6!   ,  &Syncfusion.SfSkinManager.SfSkinManager   VisualStyle 5      ��  �� ElementName$ comboVisualStyle�� �� Path$ SelectedValue� �� Mode$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=�	 � 	Resources	 5      ��%    5      .��5      �� 
 �� Orientation$
 Vertical=�6   $��0 0 0 10q�6(   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6#   $��2q�65   $��50��6A   .��5      ]� .+�5!      �� $
 
Horizontal=�6   $
��Left=�66   $
��Left=�6L   .+�5#      �� -   5         ��Name$ 	btCliente��5#      $��40��60   $��5 0 0 0q�6<    $   MaterialDesignRaisedAccentButton#��[  6M   $	��120��6�    � ToolTip$ Cliente��6�   .��5$      �� $
 
Horizontal=�6%   $	��0 0q�6>   .+�5%      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ AccountSearch=�66   $��30��6K   $��30��6V   $��Center=�6b   $��0q�6}   �� 5&      $��CLIENTE��6(   $��Center=�67   5'      5(      �� 5)      -   5        $ 
btProducao��5)      $��40��61   $��15 0 0 0q�6=   #��[  6O   $	��140��6�   $ 
Produção��6�   .��5*      �� $
 
Horizontal=�6%   $	��0 0q�6>   .+�5+        $ CashRegister=�66   $��30��6J   $��30��6U   $��Center=�6a   $��0q�6|   �� 5,      $��
PRODUÇÃO��6(   $��Center=�68   5-      5.      �� 5/      -   5        $ btRecebimento��5/      $��40��64   $��15 0 0 0q�6@   #��[  6R   $	��160��6�   $ Recebimento��6�   .��50      �� $
 
Horizontal=�6%   $	��0 0q�6>   .+�51        $ CashUsd=�66   $��30��6E   $��30��6P   $��Center=�6\   $��0q�6w   �� 52      $��RECEBIMENTO��6(   $��Center=�6;   53      54      �� 55      -   5        $ btRefinanciamento��55      $��40��68   $��15 0 0 0q�6D   #��[  6V   $	��190��6�   $ Refinanciamento��6�   .��56      �� $
 
Horizontal=�6%   $	��0 0q�6>   .+�57        $ 
CashRefund=�66   $��30��6H   $��30��6S   $��Center=�6_   $��0q�6z   �� 58      $��REFINANCIAMENTO��6(   $��Center=�6?   59      5:      �� 5<      -   5        $ btAddCliente��5<      $��40��63   $��15 0 0 0q�6?   #��[  6Q   $	��150��6�   $ Refinanciamento��6�   .��5=      �� $
 
Horizontal=�6%   $	��0 0q�6>   .+�5>        $ 	PersonAdd=�66   $��30��6G   $��30��6R   $��Center=�6^   $��0q�6y   �� 5?      $��ADD CLIENTE��6(   $��Center=�6;   5@      5A      �� 5C      -   5        $ btReset��5C      $��10 0 0 0q�6.   
���  �� 0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6Q   $ Status Banco de Dados��6�   
����� �6�   �� 5E      -   5        $ btUpload��5E      $��10 0 0 0q�6/    , (MaterialDesignFloatingActionAccentButton#��[ 6A   $ Salvar Dados na Nuvem��6�   
����� �${�False��6�   $y�	Collapsed=�6�   $��40��5F      $��50��6%   $��Center=�60   $��Center=�6K   $��Center=�6h   .��5G        $ CloudUpload=�62   $��30��6E   $��40��6Q   5H      �� 5J      -	   5        $ 
btDownload��5J      $��10 0 0 0q�61   #��[ 6C   $ Baixar Dados da Nuvem��6�   
����� �${�False��6�   $y�	Collapsed=�6�   $��40��5K      $��50��6&   $��Center=�62   $��Center=�6M   $��Center=�6j   .��5L        $ CloudDownload=�62   $��30��6G   $��40��6S   5M      d� 5O      -
   5         d�Name$ btPenDriver��5O   #   $��50��68   $��30��6C   $��10 0 0 0q�6O   $��Center=�6b   $
��Left=�6}    $  MaterialDesignSwitchToggleButton#���  5P      ${�False��6r   $y�	Collapsed=�6�   �� 5Q      -   5         ��Name$ txtPemDriver��5Q      $
��Nulo��62   $��Center=�6A   $��20(�6\   $��Cooper Black)�6j   $
��Bold"�6�   
�������${�False��6�   $y�	Collapsed=�6�   5S      �� 5V      $
 
Horizontal=�6   $��Right=�66   $��Right=�6M   .+�5X      5 	 /Syncfusion.Windows.Tools.Controls.RibbonTextBox  -   5          Name$ txtPesquisa��5X   /   $	��220��6D   $��0 0 5 0q�6P   $��18(�6b   $��35��6p   
�������
���   �
�������5Y   a   '  !MaterialDesignThemes.Wpf.PopupBox  5[      $��Right=�6.      PlacementMode$ BottomAndAlignRightEdges=�6F      	StaysOpen$ False��6o   $��0 0 5 0q�6�      PopupContent. 5\      �� $
��Auto��6%   $	��175��63   .+�5_      �� -   5        $ btExtra��5_   %   .��5`   "   �� $
 
Horizontal=�6-   $	��0 0q�6F   .+�5a   &     $ FormatListChecks=�6>   $��30��6V   $��30��6a   $��Center=�6m   $��0q�6�   �� 5b   &   $��LISTAS��60   $��Center=�6>   5c   #   5d      �� 5g      -   5        $ btConfiguracao��5g   %   .��5h   "   �� $
 
Horizontal=�6-   $	��0 0q�6F   .+�5i   &     $ Settings=�6>   $��30��6N   $��30��6Y   $��Center=�6e   $��0q�6�   �� 5j   &   $��CONFIGURAÇÕES��60   $��Center=�6E   5k   #   5l      �� 5o      -   5        $ 
btEndereco��5o   %   ${�False��6R   $y�	Collapsed=�6d   .��5p   "   �� $
 
Horizontal=�6-   $	��0 0q�6F   .+�5q   &     $ LocalAtm=�6>   $��30��6N   $��30��6Y   $��Center=�6e   $��0q�6�   �� 5r   &   $��AtEnd��60   $��Center=�6=   5s   #   5t      5v      5w      5y      5|      5~      � 5�   
   -   5         �Name$ GridMain��5�      $��Stretch=�6!   $	��Top=�6?   $��5 3 5 0q�6W   $	��660��6h   $
��1090��6x   5�      5�      5�      