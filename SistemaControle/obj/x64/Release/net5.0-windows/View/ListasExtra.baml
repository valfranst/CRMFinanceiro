   M S B A M L   `   `   `  ���� J  FSistemaControle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SistemaControle.ViewSistemaControle.View  =#clr-namespace:SistemaControle.ModelSistemaControle.Model  &     SistemaControle.View.ListasExtra   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:SistemaControle.View     6local2#clr-namespace:SistemaControle.Model     h dSyncfusion.SfSkinManager.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89l hSyncfusion.SfTextInputLayout.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89` \Syncfusion.Tools.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89f	 bSyncfusion.SfAccordion.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b
 ^Syncfusion.SfInput.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89m iSyncfusion.SfNavigationDrawer.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89@
syncfusion!http://schemas.syncfusion.com/wpf    	 
    b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $	��630��$
��1090��.���� -     ��Name$  	MainLista��$��0 0 0 50q�.����  �� Orientation$ Vertical=�$��Center=�.+��� $ 
Horizontal=�$��Center=�.+��� $��FERIADOS��$��18(�$
��Bold"�$��	0 0 200 0q�$��40���� -    ��Name$ 
btFeriados��$
{�True��$	��150��$��35�� � ToolTip$ Duplicar Feriados��$��0 10 0 0q� � Cursor$
 Hand��   	AllButton#���   .���� $ 
Horizontal=�.+�F� ������ا @f� 	= @f׀� ��� ��� �� р� ��- � 	= @B ��� �� � $� @B � $� ��- � 	= ��- � 	= ��� ��ا ��� ��ا @]� ����  $� ��ا ��!��ا @f���!@o@���!��j � z ��j � z @]� р�[ @]� р�[ ��j � z @KL ��� �� ���!@KL �@o@��j ��� �� �@o@@o@���!��^��� �� � z ��^׀�[ @o@��� �� р�[ ��!� z ��!� z @o@���!@o@	$��Center=�$��Center=�$��30��$��30�� �� Stretch$
 Fill=�����  �� Path$ 
Foreground� �� RelativeSource ��  �� AncestorType" ���� $��DUPLICAR��$��10,0,0,0q�$��16(�$��Center=�$��Black"�(  "Syncfusion.UI.Xaml.Grid.SfDataGrid  -   	  Name$	 
DG_Feriado��$��14(�$��0 10 0 0q�
   ColumnSizer$

 Auto=�$��Center=�(  "Syncfusion.UI.Xaml.Grid.SfGridBase   	RowHeight$ 28Q�$	��600��$	��900��   AutoGenerateColumns$ False��   NavigationMode$
 Cell=�   SelectionUnit$	 Row=�   SelectionMode$ Single=�   LiveDataUpdateMode$ AllowDataShaping=�   EditTrigger$ OnTap=�   AddNewRowPosition$	 Top=�   AddNewRowText$ Inserir um novo Feriado��   
SourceType#   SistemaControle.Model.Feriado"     ItemsSource �� *	Feriado+   Columns ,  &Syncfusion.UI.Xaml.Grid.GridTextColumn  -   	IdFeriado��,  &Syncfusion.UI.Xaml.Grid.GridColumnBase   MappingName$ 	IdFeriado��   
HeaderText$  ��   Width$ 0Q�   AllowSorting$ False��  -   NomeFeriado��$ NomeFeriado��$ NOME FERIADO��   TextAlignment$
 Left=�   Padding$ 5 0 0 0q�   AllowEditing$
 True��   MinimumWidth$	 200Q�0  *Syncfusion.UI.Xaml.Grid.GridDateTimeColumn  -   DataFeriado��$ DataFeriado��$
 DATA��$	 110Q�$ Center=�$
 True��0  *Syncfusion.UI.Xaml.Grid.GridCheckBoxColumn  -   	Anual��$ Anual��$ ANUAL��$	 100Q�$ Center=�$
 True��  -	   DescricaoFeriado��$ 	Descricao��$ DESCRIÇÃO��$ Center=�$
 True��$	 300Q�0  *Syncfusion.UI.Xaml.Grid.GridTemplateColumn  -
   ExcluirFeriado��$ EXCLUIR��$ 80Q�   CellTemplate �� .R��� $ btExcluirFeriado��-   $��EXCLUIR��$��20��$��70��$��Center=�#���   $��12(�$��0 0 0 0q�$ Excluir Feriado��$��Center=�$��Center=�  -   SalvarFeriado��$ SALVAR��$ 80Q� �� .R��� $ btSalvarFeriado��-   $��SALVAR��$��20��$��70��$��Center=�#���   $��12(�$��0 0 0 0q�$% Salvar alterações em feriados��$��Center=�$��Center=��� $ 
Horizontal=�$��
0 20 10 20q�$��Center=�.+��� $ Vertical=�$��Center=�.+��� $��
ATENDENTES��$��18(�$
��Bold"�$��0 0 0 0q�$��40��$��Center=�  -   $	 DG_Atendente��$
��Auto=�$
��Auto=�$��14(�$��0 0 0 0q�$

 Auto=�$��Center=�$ 28Q�$	��400��$	��540��$ False��$
 Cell=�$
 Cell=�$ Single=�$ AllowDataShaping=�$ OnTap=�$	 Top=�$ Inserir um novo Atendente��%	   SistemaControle.Model.Atendente" 	  �� *	Atendente+   -   IdAtendente��$ IdAtendente��$  ��$ 0Q�$ False��  -   NomeAtendente��$ NomeAtendente��$ 	ATENDENTE��$
 Left=�$ 5 0 0 0q�$
 True��$	 300Q�  -   ExcluirAtendente��$ EXCLUIR��$ 80Q� �� .R��� $ btExcluirAtendente��-   $��EXCLUIR��$��20��$��70��$��Center=�#���   $��12(�$��0 0 0 0q�$ Excluir Atendente��$��Center=�$��Center=�  -   SalvarAtendente��$ SALVAR��$ 80Q� �� .R��� $ btSalvarAtendente��-   $��SALVAR��$��20��$��70��$��Center=�#���   $��12(�$��0 0 0 0q�$' !Salvar alterações em Atendentes��$��Center=�$��Center=��� $ Vertical=�$��Center=�.+��� $��FORMA DE PAGAMENTO��$��18(�$
��Bold"�$��0 0 0 0q�$��40��$��Center=�  -   $	 DG_FPagamento��$
��Auto=�$
��Auto=�$��14(�$��20 0 0 0q�$

 Auto=�$��Center=�$ 28Q�$	��400��$	��540��$ False��$
 Cell=�$	 Row=�$ Single=�$ AllowDataShaping=�$ OnTap=�$	 Top=�$. (Inserir um novo Identificador de Despesa��*
   $SistemaControle.Model.FormaPagamento" 
  �� *FormaPagamento+   -   IdFormaPagamento��$ IdFormaPagamento��$  ��$ 0Q�$ False��  -   NomeFormaPagamento��$ NomeFormaPagamento��$ DESPESA��$
 Left=�$ 5 0 0 0q�$
 True��$	 300Q�  -   ExcluirFPagamento��$ EXCLUIR��$ 80Q� �� .R��� $ btExcluirFPagamento��-   $��EXCLUIR��$��20��$��70��$��Center=�#���   $��12(�$��0 0 0 0q�$  Excluir Forma de Pagamento��$��Center=�$��Center=�  -   SalvarFPagamento��$ SALVAR��$ 80Q� �� .R��� $ btSalvarFPagamento��-   $��SALVAR��$��20��$��70��$��Center=�#���   $��12(�$��0 0 0 0q�$' !Salvar alterações em Atendentes��$��Center=�$��Center=�