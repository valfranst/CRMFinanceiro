   M S B A M L   `   `   `  ����M  ISistemaControle_V3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SistemaControle_V3SistemaControle_V3  5      (    "SistemaControle_V3.ClienteListView   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:SistemaControle_V3     5      ` \Syncfusion.Tools.Wpf, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b	 ^Syncfusion.SfInput.Wpf, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c898
syncfusion!http://schemas.syncfusion.com/wpf    	 5      -   5        $	��630��5
      $
��1090��6/     � 	Resources  5      3  -Syncfusion.UI.Xaml.Grid.GridHeaderCellControl �� 
TargetType   headerStyle �� Property �� Value/  )Syncfusion.UI.Xaml.Grid.GridRowHeaderCell �� 
TargetType ��Name �� TextAlignment��%�  &	        '  p     �� 5   
   "  6   .�5      ��  � ��
 �   �6+   �� 5       � ��$
 Bold"�6+   5      �� 5   
   "  6   .�5      ��  � �� 5      �� 5      "  6&   .R�5      �� $ PART_RowHeaderCellBorder��6!   #��z��5      #��z��5      #��z��5      ._�5      � .+�5   "   �� $��Center=�6,   $��Center=�5   )   $ Center=�5!   )   ��5    )   �� *
RowIndex+5!   )   5"      5#      5$      5&      5'      5)      .��5+      � $��0 0 0 20q�6   $��Center=�6    � ColumnDefinitions 5,   
   �� 5-      $��* �6    � RowDefinitions 5/   
   �� 50      $��* �6   .+�53   
   �� 	 �� Orientation$	 
Horizontal=�6   $	��Top=�6.   $��Center=�6F   $��0 3 0 0q�6c   .+�54      �� -   5        $��btAll��54      $��30��6"   $	��150��6.   $��TODOS��6:   6J   �� 55      $��INATIVOS��6   $��Center=�6(   $��22(�6C   $
��Bold"�6Q   $��20 0 0 0q�6c   �� 56      -   5        $
��bt36��56      $��30��6!   $	��150��6-   $��3 A 6 MESES��69   $��20 0 0 0q�6O   6a   �� 57      -   5        $
��bt69��57      $��30��6!   $	��150��6-   $��6 A 9 MESES��69   $��20 0 0 0q�6O   6a   �� 58      -   5        $��bt912��58      $��30��6"   $	��150��6.   $��9 A 12 MESES��6:   $��20 0 0 0q�6Q   6c   �� 59      -   5        $��bt12Mais��59      $��30��6%   $	��150��61   $��
12 MESES +��6=   $��20 0 0 0q�6R   6d   5:      (  "Syncfusion.UI.Xaml.Grid.SfDataGrid  5<   
   -   5        
  Name$
 DG_ClienteList��5<          HeaderStyle# [  5=   !   
���   �$��16(�5>   !   (  "Syncfusion.UI.Xaml.Grid.SfGridBase   	RowHeight$ 35Q�6/   $��0 40 0 5q�6>      
IsReadOnly$
 True��5?   !      AutoGenerateColumns$ False��63      NavigationMode$	 Row=�5@   !      SelectionUnit$	 Row=�67      AllowEditing$ False��6K      SelectionMode$ Single=�5A   !      
SourceType(   "SistemaControle_V3.ViewListCliente"  5B   I      ItemsSource 6!   �� *ViewListCliente+   Columns 5G      ,  &Syncfusion.UI.Xaml.Grid.GridTextColumn  -   5        	IdCliente��,  &Syncfusion.UI.Xaml.Grid.GridColumnBase   MappingName$ 	IdCliente��5G   ?      
HeaderText$  ��6W      Width$ 0Q�6e      AllowSorting$ False��6o     5H      -	   5        Pesquisa��$ Pesquisa��5H   >   $  ��6U   $ 0Q�6c   $ False��6m     5I      -
   5        NomeCliente��$ NomeCliente��5I   A   $
 NOME��6[      AllowEditing$ False��6m      Padding$ 5 0 0 0q�6�      MinimumWidth$	 350Q�6�   0  *Syncfusion.UI.Xaml.Grid.GridTextColumnBase   TextWrapping$ NoWrap=�6�   (	  "Syncfusion.UI.Xaml.Grid.GridColumn" 	  ImmediateUpdateColumnFilter$
 True��6�   $
 True��6�     5J      -   5        Cpf��$	 Cpf��5J   9   $	 CPF��6K   $	 115Q�6\      TextAlignment$ Center=�6h   $	 130Q�6   $
 True��6�   $
 True��6�     5K      -   5        TelResidencial��$ TelResidencial��5K   D   $ TEL. RESIDENCIAL��6a   $	 150Q�6   $ Center=�6�   $
 True��6�   $
 True��6�   $ False��6�     5L      -   5        TelCelularzap��$ TelCelularzap��5L   C   $ WHATSAPP��6_   $	 150Q�6u   $ Center=�6�   $
 True��6�   $
 True��6�   $ False��6�     5M      -   5        TelCelular2��$ TelCelular2��5M   A   $ CELULAR��6[   $	 150Q�6p   $ Center=�6�   $
 True��6�   $
 True��6�   $ False��6�   0
  *Syncfusion.UI.Xaml.Grid.GridTemplateColumn
  5P      $ CADASTRO��60   $	 100Q�6F   $ False��6Y     	  AllowFiltering$  False��6o   !   CellTemplate! 5Q      �� 5R      .R�5S      �� " ��Name$" bt_ClienteCadastro��68   -   5        $��CADASTRO��5S   %   $��20��6T   $��70��6`   $��Center=�6l   $��12(�5T   %   $��0 0 0 0q�63   # � ToolTip$# Cadastro do Cliente��6E     	AllButton#���  6�   5U      5W      
  5Y      $ FICHA��60   $ 80Q�6C   $ False��6U   $  False��6j   ! 5Z      �� 5[      .R�5\      �� $" bt_ClienteFicha��65   -   5        $��FICHA��5\   %   $��20��6N   $��70��6Z   $��Center=�6f   $��12(�5]   %   $��0 0 0 0q�63   $# Ficha do Cliente��6E   #���  6~   5^      5`      $   SortColumnDescriptions$ 5f      3  -Syncfusion.UI.Xaml.Grid.SortColumnDescription  %   
ColumnName$% NomeCliente��63   &   SortDirection$& 	Ascending=�6L   5i      5k      5l      