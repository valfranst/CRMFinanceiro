   M S B A M L   `   `   `  ���� M  ISistemaControle_V3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SistemaControle_V3SistemaControle_V3  (    "SistemaControle_V3.ClienteListView   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     2local clr-namespace:SistemaControle_V3     ` \Syncfusion.Tools.Wpf, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b	 ^Syncfusion.SfInput.Wpf, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c898
syncfusion!http://schemas.syncfusion.com/wpf    	 -   $	��630��$
��1090��  � 	Resources  3  -Syncfusion.UI.Xaml.Grid.GridHeaderCellControl �� 
TargetType   headerStyle �� Property �� Value/  )Syncfusion.UI.Xaml.Grid.GridRowHeaderCell �� 
TargetType ��Name �� TextAlignment��%  &	        '  =     �� "  .���  � ��
 �   ���  � ��$
 Bold"��� "  .���  � �� �� "  .R��� $ PART_RowHeaderCellBorder��#��z��#��z��#��z��._�� .+��� $��Center=�$��Center=�$ Center=����� *
RowIndex+.��� $��0 0 0 20q�$��Center=� � ColumnDefinitions �� $��* � � RowDefinitions �� $��* �.+��� 	 �� Orientation$	 
Horizontal=�$	��Top=�$��Center=�$��0 3 0 0q�.+��� -   $��btAll��$��30��$	��150��$��TODOS���� $��INATIVOS��$��Center=�$��22(�$
��Bold"�$��20 0 0 0q��� -   $
��bt36��$��30��$	��150��$��3 A 6 MESES��$��20 0 0 0q��� -   $
��bt69��$��30��$	��150��$��6 A 9 MESES��$��20 0 0 0q��� -   $��bt912��$��30��$	��150��$��9 A 12 MESES��$��20 0 0 0q��� -   $��bt12Mais��$��30��$	��150��$��
12 MESES +��$��20 0 0 0q�(  "Syncfusion.UI.Xaml.Grid.SfDataGrid  -   
  Name$
 DG_ClienteList��   HeaderStyle# [  
���   �$��16(�(  "Syncfusion.UI.Xaml.Grid.SfGridBase   	RowHeight$ 35Q�$��0 40 0 5q�   
IsReadOnly$
 True��   AutoGenerateColumns$ False��   NavigationMode$	 Row=�   SelectionUnit$	 Row=�   AllowEditing$ False��   SelectionMode$ Single=�   
SourceType(   "SistemaControle_V3.ViewListCliente"     ItemsSource �� *ViewListCliente+   Columns ,  &Syncfusion.UI.Xaml.Grid.GridTextColumn  -   	IdCliente��,  &Syncfusion.UI.Xaml.Grid.GridColumnBase   MappingName$ 	IdCliente��   
HeaderText$  ��   Width$ 0Q�   AllowSorting$ False��  -	   Pesquisa��$ Pesquisa��$  ��$ 0Q�$ False��  -
   NomeCliente��$ NomeCliente��$
 NOME��   AllowEditing$ False��   Padding$ 5 0 0 0q�   MinimumWidth$	 350Q�0  *Syncfusion.UI.Xaml.Grid.GridTextColumnBase   TextWrapping$ NoWrap=�(	  "Syncfusion.UI.Xaml.Grid.GridColumn" 	  ImmediateUpdateColumnFilter$
 True��$
 True��  -   Cpf��$	 Cpf��$	 CPF��$	 115Q�   TextAlignment$ Center=�$	 130Q�$
 True��$
 True��  -   TelResidencial��$ TelResidencial��$ TEL. RESIDENCIAL��$	 150Q�$ Center=�$
 True��$
 True��$ False��  -   TelCelularzap��$ TelCelularzap��$ WHATSAPP��$	 150Q�$ Center=�$
 True��$
 True��$ False��  -   TelCelular2��$ TelCelular2��$ CELULAR��$	 150Q�$ Center=�$
 True��$
 True��$ False��0
  *Syncfusion.UI.Xaml.Grid.GridTemplateColumn
  $ CADASTRO��$	 100Q�$ False��  	  AllowFiltering$  False��!   CellTemplate! �� .R��� " ��Name$" bt_ClienteCadastro��-   $��CADASTRO��$��20��$��70��$��Center=�$��12(�$��0 0 0 0q�# � ToolTip$# Cadastro do Cliente��  	AllButton#���  
  $ FICHA��$ 80Q�$ False��$  False��! �� .R��� $" bt_ClienteFicha��-   $��FICHA��$��20��$��70��$��Center=�$��12(�$��0 0 0 0q�$# Ficha do Cliente��#���  $   SortColumnDescriptions$ 3  -Syncfusion.UI.Xaml.Grid.SortColumnDescription  %   
ColumnName$% NomeCliente��&   SortDirection$& 	Ascending=�