   M S B A M L   `   `   `  ����M  ISistemaControle_V3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SistemaControle_V3SistemaControle_V3  5      (    "SistemaControle_V3.RecebimentoView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:SistemaControle_V3     5      ` \Syncfusion.Tools.Wpf, Version=19.1310.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=19.1310.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=19.1310.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b	 ^Syncfusion.SfInput.Wpf, Version=19.1310.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c898
syncfusion!http://schemas.syncfusion.com/wpf    	 5      b
 ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 
 5	      -   5        $	��660��5      $
��1090��6/     � 	Resources  5      ,  &SistemaControle_V3.RowStyleRecebimento   rowStyle3  -Syncfusion.UI.Xaml.Grid.GridHeaderCellControl �� 
TargetType  headerStyle �� Property �� Value  	descricao��%�  &	        &	      &	 �       5   
   6$   �� 5   
   "  6   .�5      ��  � ��
 �   �6+   �� 5       � ��$
 Bold"�6+   5      �� 5   
   " ��6"   .�5      ��  � ��$ 15(�6-   �� 5       � ��$ Segoe UI)�6/   �� 5       � ��$
 Bold"�6/   �� 5       � �� �#5151516/   �� 5       � ��$ Center=�66   �� 5       � ��$ Center=�68   5      5      .��5!      � -   5         �Name$ MainRecebimento��5!      $
��1090��6%   $	��620��65   $��0 0 0 0q�6E   $��Center=�6V   $	��Top=�6s   .+�5#   
   ��  �� Orientation$ 
Horizontal=�6   $	��Top=�6.   $
��Left=�6F   $��	10 10 0 0q�6a   .+�5%      �� -   5        $��btMenos��5%      $��30��6$   $��30��6/   $��	30 0 10 0q�6;   $
{�True��6N    � ToolTip$ Ficha do Clientes��6_    � Cursor$
 Hand��6{    , (MaterialDesignFloatingActionAccentButton#��[ 6�   .��5&      �� $ Vertical=�6   .+�5'      F� �������j  � � � ��j � � ��� � $� ��� � $� ��� � � ��� � � @f���j  � �@o@@KL �@o@��!���!@o@��� �� �@KL @o@���- ��!��� �� ���- @KL �@KL ��- ��� �� ���!��- �@o@@KL ��� �� ���!@KL �@KL @KL �@KL ��!���!��!���!@KL 	$��Center=�5)      $��Center=�6<   $��20��6W   $��20��6c    �� Stretch$
 Fill=�6n   ��5(      �� 	 �� Path$	 
Foreground�
 �� RelativeSource
 ��  �� AncestorType" ��5)   n   5*      5+      .  (Syncfusion.Windows.Shared.IntegerTextBox  5-      -   5          Name$ AnoTxt��5-   (   $	��100��68   $��30��6D   $��20(�6P   *  $Syncfusion.Windows.Shared.EditorBase   CornerRadius$ 5��6^   $��2q�6o   $��Center=�6�      GroupSeperatorEnabled$ False��6�   $��Center=�5.      $��Center=�63      MinValue$
 1999��6o      MaxValue$
 9999��6   $ Digite o Ano desejado��6�   ${�False��6�      UseNullOption$
 True��5/         	NullValue 6'   Z� �� 51      -   5        $��btMais��51      $��30��6#   $��30��6.   $��10 0 0 0q�6:   $
{�True��6L   $ Nova Aplicação��6]   $
 Hand��6v   #��[ 6�   .��52      �� $ Vertical=�6   .+�53      F� �����@f � � � @f� � ��� � z ��� � z ��� � � ��� � � ��j �@f � ���- ��!���- @KL �@KL ��- ��� �� ���!��- �@o@@KL ��� �� �@o@��!���!@o@��� �� �@KL @o@���- ��!��� �� �@KL ��!���!��!���!@KL �@KL @KL �@KL ��!	$��Center=�55      $��Center=�6<   $��20��6W   $��20��6c   $
 Fill=�6n   ��54      �� $	 
Foreground�
 �� " ��55   n   56      57      �� 59      -   5         ��Name$ Titulo��59      $��PRODUÇÃO MENSAL��6$   $��22(�6>   $
��Bold"�6L   $��	200 0 0 0q�6^   $��40��6q   5;      �� 5=   
   $ Vertical=�6   $��	0 60 0 50q�6,   .+�5?      (  "Syncfusion.UI.Xaml.Grid.SfDataGrid  -   5          Name$ view_RecebimentoDataGrid��5?   $   $��16(�5@   !   $��	10 0 0 10q�6/   $��Center=�6B   (  "Syncfusion.UI.Xaml.Grid.SfGridBase   	RowHeight$ 35Q�6_      ColumnSizer$ SizeToCells=�6n   $��Visible=�6�   $��Visible=�6�      HeaderStyle# [ 5A   !      RowStyleSelector# [  5B   !      AutoGenerateColumns$ False��5C   !      NavigationMode$
 Cell=�5D   !      SelectionUnit$
 Cell=�5E   !      SelectionMode$ Single=�5F   !      LiveDataUpdateMode$ AllowDataShaping=�5G   !      EditTrigger$ OnTap=�5H   !      
SourceType(   "SistemaControle_V3.ViewRecebimento"  5I   I       ItemsSource  6!   �� *ViewRecebimento+!   Columns! 5N      ,  &Syncfusion.UI.Xaml.Grid.GridTextColumn  -   5        	IdCliente��,	  &Syncfusion.UI.Xaml.Grid.GridColumnBase" 	  MappingName$" 	IdCliente��5N   C   # 	  
HeaderText$#  ��6[   $ 	  Width$$ 0Q�6i   % 	  AllowSorting$% False��6s     5O      -	   5        	IdParcela��$" 	IdParcela��5O   C   $#  ��6[   $$ 0Q�6i   $% False��6s     5Q      -
   5        CodEmprestimo��$" CodEmprestimo��5Q   G   $# CÓDIGO��6c   $	$ 110Q�6w   & 	  TextAlignment$& Center=�6�   ' 	  AllowEditing$' False��6�   0
  *Syncfusion.UI.Xaml.Grid.GridDateTimeColumn
  5R      -   5        
Vencimento��$" 
Vencimento��5R   H   $# 
VENCIMENTO��6a   $	$ 120Q�6y   $& Center=�6�   $' False��6�     5S      -   5        NomeCliente��$" NomeCliente��5S   E   $
# NOME��6_   ( 	  MinimumWidth$	( 300Q�6q   $
& Left=�6�   ) 	  Padding$) 5 0 0 0q�6�   $' False��6�   0  *Syncfusion.UI.Xaml.Grid.GridCurrencyColumn  5T      -   5        ValorParcela��$" ValorParcela��5T   J   $# VALOR��6e   $	$ 100Q�6x   $& Center=�6�   $' False��6�   *   CurrencyGroupSizes* �      +   CurrencyGroupSeparator$+ .��5U   E   ,   CurrencyDecimalSeparator$, ,��6`   0  *Syncfusion.UI.Xaml.Grid.GridTemplateColumn  5X      $
" Paga��64   $
# PAGA��6G   $$ 80Q�6Y   - 	  CellTemplate- 5Y      �� 5Z      .R�5[   "   d� $
��Auto��6/   $��12(�6�   $
��Bold"�6�   . d� IsThreeState$. False��6�   $��Center=�6�   $��0 0 0 0q�6�   / d� 	IsChecked/ 6<   �� *Paga+0 �� Mode$0 TwoWay=�1 �� UpdateSourceTrigger$1 PropertyChanged=���5\   &   �� 5]   *   " d�60   .�5^   .   ��  � ��
 �  ��6K   �� 5_   .    � ��$ 	EM ABERTO��6H   2 �� Triggers2 5`   .   P� 5a   2   3 P� Property3 �@d�	IsChecked4 P� Value$
4 trueY�6O   . �5b   6   ��  � ��
 � � �6S   �� 5c   6    � ��$
 PAGO��6P   5d   3   5g   +   5i   #   5j      5l        5n      $# SALVAR��64   $$ 80Q�6H   - 5o      �� 5p      .R�5q   "   �� 5 ��Name$5 btPagarParcala��6:   -   5        $��SALVAR��5q   )   $��20��6R   $��70��6^   $��Center=�6j     	AllButton#���  6�   $��12(�5r   5   $��0 0 0 0q�6C   $' !Mudar STATUS da parcela para PAGA��6U   $��Center=�5s   5   $��Center=�6R   5t      5v        5x      -   5        
Observacao��$" 
Observacao��5x   D   $# OBSERVAÇÃO��6]   $	( 600Q�6u   $
& Left=�6�   $
' True��6�   $) 3 0 5 0q�6�   5}      �� 5      $ 
Horizontal=�6   $��0��62   $��2��6?   $��0 0 30 0q�6O   $��Bottom=�6a   $��Right=�6|   .+�5�      �� $��TOTAL RECEBIMENTO��6   #��[ 64   /  )Syncfusion.Windows.Shared.CurrencyTextBox  5�      -   5        6  Name$6 totalRecebimentoTextBox��5�   -   $	��300��6N   $��30��6Z   $��20(�6f   $ 5��6t   $��Center=�6�   7 �� 
IsReadOnly$
7 True��6�   5�      5�      �� 5�   
   -   5        8 ��Name$8 lstAnos��5�      $��	0 20 0 10q�6#   $��Bottom=�66   $��Center=�6Q    5�      �� 5�      $��Selecione o Mês��6   ��5�      �� 5�      .R�5�      $� 9 K� IsItemsHost$
9 True��6-   : $� Orientation$: 
Horizontal=�6@   5�      .@�5�      �� $��10 2 0 2q�6   .��5�      # 
 MaterialDesignThemes.Wpf.Chip  $	��JAN��6'   ${�False��65     PrimaryHueDarkBrush;   IconBackground#; �  6G    ! PrimaryHueDarkForegroundBrush<   IconForeground#< �  6~   =   Icon= 5�      ' 
 !MaterialDesignThemes.Wpf.PackIcon  5�      >   Kind$> AlphabetJCircle=�62   5�      5�      �� 5�      $��10 2 0 2q�6   .��5�        $	��FEV��6&   ${�False��64   #; �  6F   #< �  6}   = 5�        5�      $> AlphabetFCircle=�62   5�      5�      �� 5�      $��10 2 0 2q�6   .��5�        $	��MAR��6&   ${�False��64   #; �  6F   #< �  6}   = 5�        5�      $> AlphabetMCircle=�62   5�      5�      �� 5�      $��10 2 0 2q�6   .��5�        $	��ABR��6&   ${�False��64   #; �  6F   #< �  6}   = 5�        5�      $> AlphabetACircle=�62   5�      5�      �� 5�      $��10 2 0 2q�6   .��5�        $	��MAI��6&   ${�False��64   #; �  6F   #< �  6}   = 5�        5�      $> AlphabetMCircle=�62   5�      5�      �� 5�      $��10 2 0 2q�6   .��5�        $	��JUN��6&   ${�False��64   #; �  6F   #< �  6}   = 5�        5�      $> AlphabetJCircle=�62   5�      5�      �� 5�      $��10 2 0 2q�6   .��5�        $	��JUL��6&   ${�False��64   #; �  6F   #< �  6}   = 5�        5�      $> AlphabetJCircle=�62   5�      5�      �� 5�      $��10 2 0 2q�6   .��5�        $	��AGO��6&   ${�False��64   #; �  6F   #< �  6}   = 5�        5�      $> AlphabetACircle=�62   5�      5�      �� 5�      $��10 2 0 2q�6   .��5�        $	��SET��6&   ${�False��64   #; �  6F   #< �  6}   = 5�        5�      $> AlphabetSCircle=�62   5�      5�      �� 5�      $��10 2 0 2q�6   .��5�        $	��OUT��6&   ${�False��64   #; �  6F   #< �  6}   = 5�        5�      $> AlphabetOCircle=�62   5�      5�      �� 5�      $��10 2 0 2q�6   .��5�        $	��NOV��6&   ${�False��64   #; �  6F   #< �  6}   = 5�        5�      $> AlphabetNCircle=�62   5�      5�      �� 5�      $��10 2 0 2q�6   .��5�        $	��DEZ��6&   ${�False��64   #; �  6F   #< �  6}   = 5�        5�      $> AlphabetDCircle=�62   5�      5�      5�      5�      5�      