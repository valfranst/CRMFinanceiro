   M S B A M L   `   `   `  ����J  FSistemaControle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SistemaControle.ViewSistemaControle.View  5      =#clr-namespace:SistemaControle.ModelSistemaControle.Model  5      &     SistemaControle.View.ListasExtra   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:SistemaControle.View     5      6local2#clr-namespace:SistemaControle.Model     5      h dSyncfusion.SfSkinManager.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89l hSyncfusion.SfTextInputLayout.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89` \Syncfusion.Tools.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89f	 bSyncfusion.SfAccordion.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b
 ^Syncfusion.SfInput.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89m iSyncfusion.SfNavigationDrawer.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89@
syncfusion!http://schemas.syncfusion.com/wpf    	 
    5	      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
      -   5        $	��630��5      $
��1090��6/   .��5      �� -   5          ��Name$  	MainLista��5      $��0 0 0 50q�6&   .��5   
   ��  �� Orientation$ Vertical=�6   $��Center=�6,   .+�5      �� $ 
Horizontal=�6   $��Center=�62   .+�5      �� $��FERIADOS��6   $��18(�6,   $
��Bold"�6:   $��	0 0 200 0q�6L   $��40��6_   �� 5      -   5         ��Name$ 
btFeriados��5      $
{�True��6-   $	��150��6>   $��35��6J    � ToolTip$ Duplicar Feriados��6V   $��0 10 0 0q�5       � Cursor$
 Hand��6+      	AllButton#���   6S   .��5      �� $ 
Horizontal=�6!   .+�5      F� ������ا @f� 	= @f׀� ��� ��� �� р� ��- � 	= @B ��� �� � $� @B � $� ��- � 	= ��- � 	= ��� ��ا ��� ��ا @]� ����  $� ��ا ��!��ا @f���!@o@���!��j � z ��j � z @]� р�[ @]� р�[ ��j � z @KL ��� �� ���!@KL �@o@��j ��� �� �@o@@o@���!��^��� �� � z ��^׀�[ @o@��� �� р�[ ��!� z ��!� z @o@���!@o@	$��Center=�5   !   $��Center=�6>   $��30��6Y   $��30��6e    �� Stretch$
 Fill=�6p   ��5   !   ��  �� Path$ 
Foreground� �� RelativeSource ��  �� AncestorType" ��5   p   �� 5      $��DUPLICAR��6$   $��10,0,0,0q�64   $��16(�6F   $��Center=�6T   $��Black"�6o   5      5      5      (  "Syncfusion.UI.Xaml.Grid.SfDataGrid  5      -   5        	  Name$	 
DG_Feriado��5   $   $��14(�5   %   $��0 10 0 0q�63   
   ColumnSizer$

 Auto=�6E   $��Center=�6X   (  "Syncfusion.UI.Xaml.Grid.SfGridBase   	RowHeight$ 28Q�6u   $	��600��6�   $	��900��6�      AutoGenerateColumns$ False��5    %      NavigationMode$
 Cell=�5!   %      SelectionUnit$	 Row=�5"   %      SelectionMode$ Single=�5#   %      LiveDataUpdateMode$ AllowDataShaping=�5$   %      EditTrigger$ OnTap=�5%   %      AddNewRowPosition$	 Top=�5&   %      AddNewRowText$ Inserir um novo Feriado��5'   $      
SourceType#   SistemaControle.Model.Feriado"  5(   E      ItemsSource 6%   �� *	Feriado+   Columns 5,      ,  &Syncfusion.UI.Xaml.Grid.GridTextColumn  -   5        	IdFeriado��,  &Syncfusion.UI.Xaml.Grid.GridColumnBase   MappingName$ 	IdFeriado��5,   C      
HeaderText$  ��6[      Width$ 0Q�6i      AllowSorting$ False��6s     5-      -   5        NomeFeriado��$ NomeFeriado��5-   E   $ NOME FERIADO��6_      TextAlignment$
 Left=�6y      Padding$ 5 0 0 0q�6�      AllowEditing$
 True��6�      MinimumWidth$	 200Q�6�   0  *Syncfusion.UI.Xaml.Grid.GridDateTimeColumn  5.      -   5        DataFeriado��$ DataFeriado��5.   I   $
 DATA��6c   $	 110Q�6u   $ Center=�6�   $
 True��6�   0  *Syncfusion.UI.Xaml.Grid.GridCheckBoxColumn  5/      -   5        	Anual��$ Anual��5/   C   $ ANUAL��6W   $	 100Q�6j   $ Center=�6v   $
 True��6�     50      -	   5        DescricaoFeriado��$ 	Descricao��50   J   $ DESCRIÇÃO��6b   $ Center=�6y   $
 True��6�   $	 300Q�6�   0  *Syncfusion.UI.Xaml.Grid.GridTemplateColumn  52      -
   5        ExcluirFeriado��$ EXCLUIR��52   L   $ 80Q�6a      CellTemplate 53      �� 54      .R�55   "   �� $ btExcluirFeriado��6;   -   5        $��EXCLUIR��55   )   $��20��6U   $��70��6a   $��Center=�6m   #���   6�   $��12(�56   5   $��0 0 0 0q�6C   $ Excluir Feriado��6U   $��Center=�57   5   $��Center=�6R   58      5:        5<      -   5        SalvarFeriado��$ SALVAR��5<   K   $ 80Q�6_    5=      �� 5>      .R�5?   "   �� $ btSalvarFeriado��6:   -   5        $��SALVAR��5?   )   $��20��6S   $��70��6_   $��Center=�6k   #���   6�   $��12(�5@   5   $��0 0 0 0q�6C   $% Salvar alterações em feriados��6U   $��Center=�5A   5   $��Center=�6R   5B      5D      5G      �� 5J      $ 
Horizontal=�6   $��
0 20 10 20q�62   $��Center=�6F   .+�5L      �� $ Vertical=�6   $��Center=�64   .+�5M      �� $��
ATENDENTES��6   $��18(�62   $
��Bold"�6@   $��0 0 0 0q�6R   $��40��6c   $��Center=�6o     5N      -   5        $	 DG_Atendente��5N   ,   $
��Auto=�6B   $
��Auto=�6r   $��14(�5O   )   $��0 0 0 0q�67   $

 Auto=�6H   $��Center=�6[   $ 28Q�6x   $	��400��6�   $	��540��6�   $ False��5P   )   $
 Cell=�5Q   )   $
 Cell=�5R   )   $ Single=�5S   )   $ AllowDataShaping=�5T   )   $ OnTap=�5U   )   $	 Top=�5V   )   $ Inserir um novo Atendente��5W   ,   %	   SistemaControle.Model.Atendente" 	 5X   K    6)   �� *	Atendente+ 5\        -   5        IdAtendente��$ IdAtendente��5\   M   $  ��6g   $ 0Q�6u   $ False��6     5]      -   5        NomeAtendente��$ NomeAtendente��5]   O   $ 	ATENDENTE��6k   $
 Left=�6�   $ 5 0 0 0q�6�   $
 True��6�   $	 300Q�6�     5`      -   5        ExcluirAtendente��$ EXCLUIR��5`   V   $ 80Q�6k    5a   "   �� 5b   &   .R�5c   *   �� $ btExcluirAtendente��6C   -   5        $��EXCLUIR��5c   1   $��20��6_   $��70��6k   $��Center=�6w   #���   6�   $��12(�5d   5   $��0 0 0 0q�6C   $ Excluir Atendente��6U   $��Center=�5e   5   $��Center=�6R   5f   '   5h        5j      -   5        SalvarAtendente��$ SALVAR��5j   U   $ 80Q�6i    5k   "   �� 5l   &   .R�5m   *   �� $ btSalvarAtendente��6B   -   5        $��SALVAR��5m   1   $��20��6]   $��70��6i   $��Center=�6u   #���   6�   $��12(�5n   5   $��0 0 0 0q�6C   $' !Salvar alterações em Atendentes��6U   $��Center=�5o   5   $��Center=�6R   5p   '   5r      5u      5v      �� 5x      $ Vertical=�6   $��Center=�64   .+�5y      �� $��FORMA DE PAGAMENTO��6   $��18(�6:   $
��Bold"�6H   $��0 0 0 0q�6Z   $��40��6k   $��Center=�6w     5z      -   5        $	 DG_FPagamento��5z   ,   $
��Auto=�6C   $
��Auto=�6s   $��14(�5{   )   $��20 0 0 0q�67   $

 Auto=�6I   $��Center=�6\   $ 28Q�6y   $	��400��6�   $	��540��6�   $ False��5|   )   $
 Cell=�5}   )   $	 Row=�5~   )   $ Single=�5   )   $ AllowDataShaping=�5�   )   $ OnTap=�5�   )   $	 Top=�5�   )   $. (Inserir um novo Identificador de Despesa��5�   )   *
   $SistemaControle.Model.FormaPagamento" 
 5�   P    6)   �� *FormaPagamento+ 5�        -   5        IdFormaPagamento��$ IdFormaPagamento��5�   R   $  ��6q   $ 0Q�6   $ False��6�     5�      -   5        NomeFormaPagamento��$ NomeFormaPagamento��5�   T   $ DESPESA��6u   $
 Left=�6�   $ 5 0 0 0q�6�   $
 True��6�   $	 300Q�6�     5�      -   5        ExcluirFPagamento��$ EXCLUIR��5�   W   $ 80Q�6l    5�   "   �� 5�   &   .R�5�   *   �� $ btExcluirFPagamento��6C   -   5        $��EXCLUIR��5�   1   $��20��6`   $��70��6l   $��Center=�6x   #���   6�   $��12(�5�   5   $��0 0 0 0q�6C   $  Excluir Forma de Pagamento��6U   $��Center=�5�   5   $��Center=�6R   5�   '   5�        5�      -   5        SalvarFPagamento��$ SALVAR��5�   V   $ 80Q�6j    5�   "   �� 5�   &   .R�5�   *   �� $ btSalvarFPagamento��6B   -   5        $��SALVAR��5�   1   $��20��6^   $��70��6j   $��Center=�6v   #���   6�   $��12(�5�   5   $��0 0 0 0q�6C   $' !Salvar alterações em Atendentes��6U   $��Center=�5�   5   $��Center=�6R   5�   '   5�      5�      5�      5�      5�      5�      5�      