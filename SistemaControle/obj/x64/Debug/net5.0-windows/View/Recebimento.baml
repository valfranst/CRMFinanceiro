   M S B A M L   `   `   `  ����J  FSistemaControle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SistemaControle.ViewSistemaControle.View  5      =#clr-namespace:SistemaControle.ModelSistemaControle.Model  5      &     SistemaControle.View.Recebimento   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:SistemaControle.View     5      6local2#clr-namespace:SistemaControle.Model     5      h dSyncfusion.SfSkinManager.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89l hSyncfusion.SfTextInputLayout.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89` \Syncfusion.Tools.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89f	 bSyncfusion.SfAccordion.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b
 ^Syncfusion.SfInput.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89m iSyncfusion.SfNavigationDrawer.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89@
syncfusion!http://schemas.syncfusion.com/wpf    	 
    5	      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
      -   5        $	��660��5      $
��1090��6/     � 	Resources  5      .  (SistemaControle.View.RowStyleRecebimento   rowStyle3  -Syncfusion.UI.Xaml.Grid.GridHeaderCellControl �� 
TargetType  headerStyle �� Property �� Value  	descricao��%�  &	        &	      &	 �       5   
   6$   �� 5   
   "  6   .�5      ��  � ��
 �   �6+   �� 5       � ��$
 Bold"�6+   5      �� 5   
   " ��6"   .�5      ��  � ��$ 15(�6-   �� 5       � ��$ Segoe UI)�6/   �� 5       � ��$
 Bold"�6/   �� 5       � �� �#5151516/   �� 5       � ��$ Center=�66   �� 5       � ��$ Center=�68   5      5       .��5"      � -   5         �Name$ MainRecebimento��5"      $
��1090��6%   $	��620��65   $��0 0 0 0q�6E   $��Center=�6V   $	��Top=�6s   .+�5$   
   ��  �� Orientation$ 
Horizontal=�6   $	��Top=�6.   $
��Left=�6F   $��	10 10 0 0q�6a   .+�5&      �� -   5        $��btMenos��5&      $��30��6$   $��30��6/   $��	30 0 10 0q�6;   $
{�True��6N    � ToolTip$ Ficha do Clientes��6_    � Cursor$
 Hand��6{    , (MaterialDesignFloatingActionAccentButton#��[ 6�   .��5'      �� $ Vertical=�6   .+�5(      F� �������j  � � � ��j � � ��� � $� ��� � $� ��� � � ��� � � @f���j  � �@o@@KL �@o@��!���!@o@��� �� �@KL @o@���- ��!��� �� ���- @KL �@KL ��- ��� �� ���!��- �@o@@KL ��� �� ���!@KL �@KL @KL �@KL ��!���!��!���!@KL 	$��Center=�5*      $��Center=�6<   $��20��6W   $��20��6c    �� Stretch$
 Fill=�6n   ��5)      �� 	 �� Path$	 
Foreground�
 �� RelativeSource
 ��  �� AncestorType" ��5*   n   5+      5,      .  (Syncfusion.Windows.Shared.IntegerTextBox  5.      -   5          Name$ AnoTxt��5.   (   $	��100��68   $��30��6D   $��20(�6P   *  $Syncfusion.Windows.Shared.EditorBase   CornerRadius$ 5��6^   $��2q�6o   $��Center=�6�      GroupSeperatorEnabled$ False��6�   $��Center=�5/      $��Center=�63      MinValue$
 1999��6o      MaxValue$
 9999��6   $ Digite o Ano desejado��6�   ${�False��6�      UseNullOption$
 True��50         	NullValue 6'   Z� �� 52      -   5        $��btMais��52      $��30��6#   $��30��6.   $��10 0 0 0q�6:   $
{�True��6L   $ Nova Aplicação��6]   $
 Hand��6v   #��[ 6�   .��53      �� $ Vertical=�6   .+�54      F� �����@f � � � @f� � ��� � z ��� � z ��� � � ��� � � ��j �@f � ���- ��!���- @KL �@KL ��- ��� �� ���!��- �@o@@KL ��� �� �@o@��!���!@o@��� �� �@KL @o@���- ��!��� �� �@KL ��!���!��!���!@KL �@KL @KL �@KL ��!	$��Center=�56      $��Center=�6<   $��20��6W   $��20��6c   $
 Fill=�6n   ��55      �� $	 
Foreground�
 �� " ��56   n   57      58      �� 5:      -   5         ��Name$ Titulo��5:      $��PRODUÇÃO MENSAL��6$   $��22(�6>   $
��Bold"�6L   $��	200 0 0 0q�6^   $��40��6q   5<      �� 5>   
   $ Vertical=�6   $��	0 60 0 50q�6,   .+�5@      (  "Syncfusion.UI.Xaml.Grid.SfDataGrid  -   5          Name$ view_RecebimentoDataGrid��5@   $   $��16(�5A   !   $��	10 0 0 10q�6/   $��Center=�6B   (  "Syncfusion.UI.Xaml.Grid.SfGridBase   	RowHeight$ 35Q�6_      ColumnSizer$ SizeToCells=�6n   $��Visible=�6�   $��Visible=�6�      HeaderStyle# [ 5B   !      RowStyleSelector# [  5C   !      AutoGenerateColumns$ False��5D   !      NavigationMode$
 Cell=�5E   !      SelectionUnit$
 Cell=�5F   !      SelectionMode$ Single=�5G   !      LiveDataUpdateMode$ AllowDataShaping=�5H   !      EditTrigger$ OnTap=�5I   !      
SourceType+   %SistemaControle.Model.ViewRecebimento"  5J   I       ItemsSource  6!   �� *ViewRecebimento+!   Columns! 5O      ,  &Syncfusion.UI.Xaml.Grid.GridTextColumn  -   5        	IdCliente��,	  &Syncfusion.UI.Xaml.Grid.GridColumnBase" 	  MappingName$" 	IdCliente��5O   C   # 	  
HeaderText$#  ��6[   $ 	  Width$$ 0Q�6i   % 	  AllowSorting$% False��6s     5P      -	   5        	IdParcela��$" 	IdParcela��5P   C   $#  ��6[   $$ 0Q�6i   $% False��6s     5R      -
   5        CodEmprestimo��$" CodEmprestimo��5R   G   $# CÓDIGO��6c   $	$ 110Q�6w   & 	  TextAlignment$& Center=�6�   ' 	  AllowEditing$' False��6�   0
  *Syncfusion.UI.Xaml.Grid.GridDateTimeColumn
  5S      -   5        
Vencimento��$" 
Vencimento��5S   H   $# 
VENCIMENTO��6a   $	$ 120Q�6y   $& Center=�6�   $' False��6�     5T      -   5        NomeCliente��$" NomeCliente��5T   E   $
# NOME��6_   ( 	  MinimumWidth$	( 300Q�6q   $
& Left=�6�   ) 	  Padding$) 5 0 0 0q�6�   $' False��6�   0  *Syncfusion.UI.Xaml.Grid.GridCurrencyColumn  5U      -   5        ValorParcela��$" ValorParcela��5U   J   $# VALOR��6e   $	$ 100Q�6x   $& Center=�6�   $' False��6�   *   CurrencyGroupSizes* �      +   CurrencyGroupSeparator$+ .��5V   E   ,   CurrencyDecimalSeparator$, ,��6`   0  *Syncfusion.UI.Xaml.Grid.GridTemplateColumn  5Y      $
" Paga��64   $
# PAGA��6G   $$ 80Q�6Y   - 	  CellTemplate- 5Z      �� 5[      .R�5\   "   d� $
��Auto��6/   $��12(�6�   $
��Bold"�6�   . d� IsThreeState$. False��6�   $��Center=�6�   $��0 0 0 0q�6�   / d� 	IsChecked/ 6<   �� *Paga+0 �� Mode$0 TwoWay=�1 �� UpdateSourceTrigger$1 PropertyChanged=���5]   &   �� 5^   *   " d�60   .�5_   .   ��  � ��
 �  ��6K   �� 5`   .    � ��$ 	EM ABERTO��6H   2 �� Triggers2 5a   .   P� 5b   2   3 P� Property3 �@d�	IsChecked4 P� Value$
4 trueY�6O   . �5c   6   ��  � ��
 � � �6S   �� 5d   6    � ��$
 PAGO��6P   5e   3   5h   +   5j   #   5k      5m        5o      $# SALVAR��64   $$ 80Q�6H   - 5p      �� 5q      .R�5r   "   �� 5 ��Name$5 btPagarParcala��6:   -   5        $��SALVAR��5r   )   $��20��6R   $��70��6^   $��Center=�6j     	AllButton#���  6�   $��12(�5s   5   $��0 0 0 0q�6C   $' !Mudar STATUS da parcela para PAGA��6U   $��Center=�5t   5   $��Center=�6R   5u      5w        5y      -   5        
Observacao��$" 
Observacao��5y   D   $# OBSERVAÇÃO��6]   $	( 600Q�6u   $
& Left=�6�   $
' True��6�   $) 3 0 5 0q�6�   5~      �� 5�      $ 
Horizontal=�6   $��0��62   $��2��6?   $��0 0 30 0q�6O   $��Bottom=�6a   $��Right=�6|   .+�5�      �� $��TOTAL RECEBIMENTO��6   #��[ 64   /  )Syncfusion.Windows.Shared.CurrencyTextBox  5�      -   5        6  Name$6 totalRecebimentoTextBox��5�   -   $	��300��6N   $��30��6Z   $��20(�6f   $ 5��6t   $��Center=�6�   7 �� 
IsReadOnly$
7 True��6�   5�      5�      �� 5�   
   -   5        8 ��Name$8 lstAnos��5�      $��	0 20 0 10q�6#   $��Bottom=�66   $��Center=�6Q    5�      �� 5�      $��Selecione o Mês��6   ��5�      �� 5�      .R�5�      $� 9 K� IsItemsHost$
9 True��6-   : $� Orientation$: 
Horizontal=�6@   5�      .@�5�      �� $��10 2 0 2q�6   .��5�      #  MaterialDesignThemes.Wpf.Chip  $	��JAN��6'   ${�False��65     PrimaryHueDarkBrush;   IconBackground#; �  6G    ! PrimaryHueDarkForegroundBrush<   IconForeground#< �  6~   =   Icon= 5�      '  !MaterialDesignThemes.Wpf.PackIcon  5�      >   Kind$> AlphabetJCircle=�62   5�      5�      �� 5�      $��10 2 0 2q�6   .��5�        $	��FEV��6&   ${�False��64   #; �  6F   #< �  6}   = 5�        5�      $> AlphabetFCircle=�62   5�      5�      �� 5�      $��10 2 0 2q�6   .��5�        $	��MAR��6&   ${�False��64   #; �  6F   #< �  6}   = 5�        5�      $> AlphabetMCircle=�62   5�      5�      �� 5�      $��10 2 0 2q�6   .��5�        $	��ABR��6&   ${�False��64   #; �  6F   #< �  6}   = 5�        5�      $> AlphabetACircle=�62   5�      5�      �� 5�      $��10 2 0 2q�6   .��5�        $	��MAI��6&   ${�False��64   #; �  6F   #< �  6}   = 5�        5�      $> AlphabetMCircle=�62   5�      5�      �� 5�      $��10 2 0 2q�6   .��5�        $	��JUN��6&   ${�False��64   #; �  6F   #< �  6}   = 5�        5�      $> AlphabetJCircle=�62   5�      5�      �� 5�      $��10 2 0 2q�6   .��5�        $	��JUL��6&   ${�False��64   #; �  6F   #< �  6}   = 5�        5�      $> AlphabetJCircle=�62   5�      5�      �� 5�      $��10 2 0 2q�6   .��5�        $	��AGO��6&   ${�False��64   #; �  6F   #< �  6}   = 5�        5�      $> AlphabetACircle=�62   5�      5�      �� 5�      $��10 2 0 2q�6   .��5�        $	��SET��6&   ${�False��64   #; �  6F   #< �  6}   = 5�        5�      $> AlphabetSCircle=�62   5�      5�      �� 5�      $��10 2 0 2q�6   .��5�        $	��OUT��6&   ${�False��64   #; �  6F   #< �  6}   = 5�        5�      $> AlphabetOCircle=�62   5�      5�      �� 5�      $��10 2 0 2q�6   .��5�        $	��NOV��6&   ${�False��64   #; �  6F   #< �  6}   = 5�        5�      $> AlphabetNCircle=�62   5�      5�      �� 5�      $��10 2 0 2q�6   .��5�        $	��DEZ��6&   ${�False��64   #; �  6F   #< �  6}   = 5�        5�      $> AlphabetDCircle=�62   5�      5�      5�      5�      5�      