   M S B A M L   `   `   `  ���� M  ISistemaControle_V3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SistemaControle_V3SistemaControle_V3  #    SistemaControle_V3.MainWindow   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:SistemaControle_V3     b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  ` \Syncfusion.Tools.Wpf, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a	 ]Syncfusion.Shared.WPF, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b
 ^Syncfusion.SfInput.Wpf, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c898
syncfusion!http://schemas.syncfusion.com/wpf   	 
   �Language$  pt-BR�-    � Title$% APLICAÇÕES     Software V:4.0�� � WindowState$ 	Maximized=�$	��700��$
��1100��#��Z��#��Z��.���  � ColumnDefinitions �� $��* � � RowDefinitions �� $��37 ��� $��* �.+�(  "MaterialDesignThemes.Wpf.ColorZone  $��0��$��0��   Mode$ 
PrimaryMid=�$��2q�$��35��.��]� .+���  �� Orientation$ 
Horizontal=�$
��Left=�$
��Left=�.+��� -    ��Name$ 	btCliente��$��30��$��5 0 0 0q� $   MaterialDesignRaisedAccentButton#��[  $	��120�� � ToolTip$ Cliente��.���� $ 
Horizontal=�$	��0 0q�.+�'  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 AccountSearch=�$��30��$��30��$��Center=�$��0q��� $��CLIENTE��$��Center=�$
��Bold"��� -   $ 
btProducao��$��30��$��15 0 0 0q�#��[  $	��140��$ 
Produção��.���� $ 
Horizontal=�$	��0 0q�.+�  $	 CashRegister=�$��30��$��30��$��Center=�$��0q��� $��
PRODUÇÃO��$��Center=�$
��Bold"��� -   $ btRecebimento��$��30��$��15 0 0 0q�#��[  $	��165��$ Recebimento��.���� $ 
Horizontal=�$	��0 0q�.+�  $	 AccountCash=�$��30��$��30��$��Center=�$��0q��� $��RECEBIMENTO��$��Center=�$��4 0 0 0q�$
��Bold"��� -   $ btRefinanciamento��$��30��$��15 0 0 0q�#��[  $	��200��$ Refinanciamento��.���� $ 
Horizontal=�$	��0 0q�.+�  $	 
CashRefund=�$��27��$��27��$��Center=�$��0 0 2 0q��� $��REFINANCIAMENTO��$��Center=�$
��Bold"��� -   $ btAddCliente��$��30��$��15 0 0 0q�#��[  $	��160��$ Refinanciamento��.���� $ 
Horizontal=�$	��0 0q�.+�  $	 	PersonAdd=�$��30��$��30��$��Center=�$��0 0 2 0q��� $��ADD CLIENTE��$��Center=�$
��Bold"��� -   $ btReset��$��30��$��30��$��10 0 0 0q�
���  �� 0 ,MaterialDesignFloatingActionMiniAccentButton#��[ $ Status Banco de Dados��
����� ��� -   $ btBackup��$��15 0 0 0q� , (MaterialDesignFloatingActionAccentButton#��[ $ Backup de Dados��
��� � �$��30��$��30��$��Center=�$��Center=�$��Center=�$y�	Collapsed=�.��  $	 ContentSaveCog=�$��18��$��18���� $ 
Horizontal=�$��Right=�$��Right=�.+�5  /Syncfusion.Windows.Tools.Controls.RibbonTextBox  -	   
  Name$
 txtPesquisa��$	��240��$��0 0 5 0q�$��18(�$��30��
�������
���   �$
��Left=�$��Center=�
�������'  !MaterialDesignThemes.Wpf.PopupBox  $��Right=�   PlacementMode$ BottomAndAlignRightEdges=�   	StaysOpen$ False��$��0 0 5 0q�   PopupContent. �� $
��Auto��$	��175��.+��� -
   $ btExtra��.���� $ 
Horizontal=�$	��0 0q�.+�  $	 FormatListChecks=�$��30��$��30��$��Center=�$��0q��� $��LISTAS��$��Center=��� -   $ btConfiguracao��.���� $ 
Horizontal=�$	��0 0q�.+�  $	 Settings=�$��30��$��30��$��Center=�$��0q��� $��CONFIGURAÇÕES��$��Center=�� -    �Name$ GridMain��$��1��$��0��$��Stretch=�$��Stretch=�$��0q�
������� �� $��* � �� $��* �