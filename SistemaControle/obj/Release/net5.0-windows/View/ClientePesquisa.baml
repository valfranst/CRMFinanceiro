   M S B A M L   `   `   `  ���� J  FSistemaControle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SistemaControle.ViewSistemaControle.View  *    $SistemaControle.View.ClientePesquisa   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     h dSyncfusion.SfSkinManager.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89l hSyncfusion.SfTextInputLayout.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89` \Syncfusion.Tools.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89f	 bSyncfusion.SfAccordion.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b
 ^Syncfusion.SfInput.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89m iSyncfusion.SfNavigationDrawer.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89@
syncfusion!http://schemas.syncfusion.com/wpf    	 
    <local"clr-namespace:SistemaControle.View    	 
    -   $	��660��$
��1090��  � 	Resources  3  -Syncfusion.UI.Xaml.Grid.GridHeaderCellControl �� 
TargetType   headerStyle �� Property �� Value��%G   &	        �� "  .���  � ��
 �   ���  � ��$
 Bold"�.��� $��Center=�$	��Top=�$��0 5 0 50q�.+�(  "Syncfusion.UI.Xaml.Grid.SfDataGrid  -     Name$ DG_ClienteView��   HeaderStyle# [  
���   �$��16(�(  "Syncfusion.UI.Xaml.Grid.SfGridBase   	RowHeight$ 35Q�$��0 0 0 10q�   
IsReadOnly$
 True��   AutoGenerateColumns$ False��	   NavigationMode$		 Row=�
   SelectionUnit$	
 Row=�   AllowEditing$ False��   SelectionMode$ Single=�   Columns ,  &Syncfusion.UI.Xaml.Grid.GridTextColumn  -   	IdCliente��,  &Syncfusion.UI.Xaml.Grid.GridColumnBase   MappingName$ 	IdCliente��   
HeaderText$  ��   Width$ 0Q�   AllowSorting$ False��  -   Pesquisa��$ Pesquisa��$  ��$ 0Q�$ False��  -   NomeCliente��$ NomeCliente��$
 NOME��   AllowEditing$ False��   Padding$ 5 0 0 0q�   MinimumWidth$	 350Q�0  *Syncfusion.UI.Xaml.Grid.GridTextColumnBase   TextWrapping$ NoWrap=�(  "Syncfusion.UI.Xaml.Grid.GridColumn"   ImmediateUpdateColumnFilter$
 True��$
 True��  -   Cpf��$	 Cpf��$	 CPF��$	 115Q�   TextAlignment$ Center=�$	 130Q�$
 True��$
 True��  -   TelResidencial��$ TelResidencial��$ TEL. RESIDENCIAL��$	 150Q�$ Center=�$
 True��$
 True��$ False��  -   TelCelularzap��$ TelCelularzap��$ WHATSAPP��$	 150Q�$ Center=�$
 True��$
 True��$ False��  -	   TelCelular2��$ TelCelular2��$ CELULAR��$	 150Q�$ Center=�$
 True��$
 True��$ False��0  *Syncfusion.UI.Xaml.Grid.GridTemplateColumn  $ CADASTRO��$	 100Q�$ False��   AllowFiltering$ False��   CellTemplate �� .R���  ��Name$ bt_ClienteCadastro��-
   $��CADASTRO��$��20��$��70��$��Center=�$��12(�$��0 0 0 0q� � ToolTip$0 *Salvar Alterações na Parcela selecionada��  	AllButton#���    $ FICHA��$ 80Q�$ False��$ False�� �� .R��� $ bt_ClienteFicha��-   $��FICHA��$��20��$��70��$��Center=�$��12(�$��0 0 0 0q�$! Excluir Parcela selecionada��#���     SortColumnDescriptions 3	  -Syncfusion.UI.Xaml.Grid.SortColumnDescription	   	  
ColumnName$ NomeCliente�� 	  SortDirection$ 	Ascending=�