   M S B A M L   `   `   `  ����J  FSistemaControle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SistemaControle.ViewSistemaControle.View  5      *    $SistemaControle.View.ClientePesquisa   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      h dSyncfusion.SfSkinManager.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89l hSyncfusion.SfTextInputLayout.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89` \Syncfusion.Tools.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89f	 bSyncfusion.SfAccordion.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b
 ^Syncfusion.SfInput.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89m iSyncfusion.SfNavigationDrawer.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89@
syncfusion!http://schemas.syncfusion.com/wpf    	 
    5      <local"clr-namespace:SistemaControle.View    	 
    5      -   5        $	��660��5
      $
��1090��6/     � 	Resources  5      3  -Syncfusion.UI.Xaml.Grid.GridHeaderCellControl �� 
TargetType   headerStyle �� Property �� Value��%z   &	        �� 5   
   "  6   .�5      ��  � ��
 �   �6+   �� 5       � ��$
 Bold"�6+   5      5      .��5      � $��Center=�6   $	��Top=�6(   $��0 5 0 50q�6@   .+�5   
   (  "Syncfusion.UI.Xaml.Grid.SfDataGrid  -   5          Name$ DG_ClienteView��5          HeaderStyle# [  5   !   
���   �$��16(�5   !   (  "Syncfusion.UI.Xaml.Grid.SfGridBase   	RowHeight$ 35Q�6/   $��0 0 0 10q�6>      
IsReadOnly$
 True��5   !      AutoGenerateColumns$ False��63   	   NavigationMode$		 Row=�5   !   
   SelectionUnit$	
 Row=�67      AllowEditing$ False��6K      SelectionMode$ Single=�5   !      Columns 5      ,  &Syncfusion.UI.Xaml.Grid.GridTextColumn  -   5        	IdCliente��,  &Syncfusion.UI.Xaml.Grid.GridColumnBase   MappingName$ 	IdCliente��5   ?      
HeaderText$  ��6W      Width$ 0Q�6e      AllowSorting$ False��6o     5       -   5        Pesquisa��$ Pesquisa��5    >   $  ��6U   $ 0Q�6c   $ False��6m     5"      -   5        NomeCliente��$ NomeCliente��5"   A   $
 NOME��6[      AllowEditing$ False��6m      Padding$ 5 0 0 0q�6�      MinimumWidth$	 350Q�6�   0  *Syncfusion.UI.Xaml.Grid.GridTextColumnBase   TextWrapping$ NoWrap=�6�   (  "Syncfusion.UI.Xaml.Grid.GridColumn"   ImmediateUpdateColumnFilter$
 True��6�   $
 True��6�     5#      -   5        Cpf��$	 Cpf��5#   9   $	 CPF��6K   $	 115Q�6\      TextAlignment$ Center=�6h   $	 130Q�6   $
 True��6�   $
 True��6�     5$      -   5        TelResidencial��$ TelResidencial��5$   D   $ TEL. RESIDENCIAL��6a   $	 150Q�6   $ Center=�6�   $
 True��6�   $
 True��6�   $ False��6�     5%      -   5        TelCelularzap��$ TelCelularzap��5%   C   $ WHATSAPP��6_   $	 150Q�6u   $ Center=�6�   $
 True��6�   $
 True��6�   $ False��6�     5&      -	   5        TelCelular2��$ TelCelular2��5&   A   $ CELULAR��6[   $	 150Q�6p   $ Center=�6�   $
 True��6�   $
 True��6�   $ False��6�   0  *Syncfusion.UI.Xaml.Grid.GridTemplateColumn  5)      $ CADASTRO��60   $	 100Q�6F   $ False��6Y      AllowFiltering$ False��6o      CellTemplate 5*      �� 5+      .R�5,      ��  ��Name$ bt_ClienteCadastro��68   -
   5        $��CADASTRO��5,   %   $��20��6T   $��70��6`   $��Center=�6l   $��12(�5-   %   $��0 0 0 0q�63    � ToolTip$0 *Salvar Alterações na Parcela selecionada��6E     	AllButton#���  6�   5.      50        52      $ FICHA��60   $ 80Q�6C   $ False��6U   $ False��6j    53      �� 54      .R�55      �� $ bt_ClienteFicha��65   -   5        $��FICHA��55   %   $��20��6N   $��70��6Z   $��Center=�6f   $��12(�56   %   $��0 0 0 0q�63   $! Excluir Parcela selecionada��6E   #���  6�   57      59         SortColumnDescriptions 5?      3	  -Syncfusion.UI.Xaml.Grid.SortColumnDescription	   	  
ColumnName$ NomeCliente��63    	  SortDirection$ 	Ascending=�6L   5B      5D      5E      