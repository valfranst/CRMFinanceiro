   M S B A M L   `   `   `  ����M  ISistemaControle_V3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SistemaControle_V3SistemaControle_V3  5      )    #SistemaControle_V3.ClienteFichaView   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:SistemaControle_V3     5      ` \Syncfusion.Tools.Wpf, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b	 ^Syncfusion.SfInput.Wpf, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c898
syncfusion!http://schemas.syncfusion.com/wpf    	 5      b
 ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 
 5	      -   5        $	��700��5      $
��1200��6/     � 	Resources  5      3  -Syncfusion.UI.Xaml.Grid.GridHeaderCellControl �� 
TargetType   headerStyle2 �� Property �� Value  
TituloText  SubTituloText  InfoText  MsgText  headerStyle�� 5   
   %�  &	        &	 p     &	 2    &	 �    &	 h    &	     �� 5      "  6   .�5      ��  � ��
 �   �6/   �� 5       � ��$
 Bold"�6/   5      �� 5      " ��6'   .�5      ��  � ��$ 34(�6-   �� 5       � ��$ Segoe UI)�6/   �� 5       � ��$
 Bold"�6/   �� 5       � �� �#5151516/   5      �� 5      " ��6*   .�5      ��  � ��$ 24(�6-   �� 5       � ��$ Segoe UI)�6/   �� 5       � ��$ Regular"�6/   5      �� 5       " ��6%   .�5!      ��  � ��$ 18(�6-   �� 5"       � ��$ Segoe UI)�6/   �� 5#       � ��$ Regular"�6/   5$      �� 5%      " ��6$   .�5&      ��  � ��$ 12(�6-   �� 5'       � ��$ Segoe UI)�6/   �� 5(       � ��$ Regular"�6/   5)      �� 5-      "  6   .�5.      ��  � ��
 ��·�6/   �� 5/       � ��
 �   �6/   �� 50       � ��$
 Bold"�6/   �� 51       � ��$ 12(�6-   52      54      .��57      �� -   5         ��Name$ SV_EmprestimoView��57      $��Visible=�6.   $��Visible=�6V   $��0 0 5 15q�58      $��	0 0 10 10q�6   $��Center=�63   $	��Top=�6P   $
��Auto��6h   $
��Auto��6v   .��5:   
   ��  �� Orientation$ Vertical=�6   $��Center=�6-   $	��Top=�6K   .+�5<      ]� $��Center=�6   $	��Top=�66   .+�5>      �� -   5         ��Name$ button��5>      $
��Left=�6)   $��	15 5 10 5q�6D   $	��130��6X   $	��130��6d   ��5?      �� 5@      -   5        btImagem�� j� Stretch$
 None=�5@   8    �� ImageSource$ /Resources/usuario.png��6G   5B      �� 5D      $ Vertical=�6   $��Center=�64   .+�5E      �� -   5        	 ��Name$	 nomeClienteTxt��5E      $"��Teste da Silva Santos Vieira��64   $��0 0 0 0q�6[   $��16(�6l   $
��Left=�6{   $��Center=�6�   $
��Bold"�6�   �� 5F      -   5        $	 cpfTxt��5F      $��CPF: 000.000.000-00��6,   $��0 0 0 0q�6J   $��16(�6[   $
��Left=�6j   $��Center=�6�   $
��Bold"�6�   �� 5G      -   5        $	 telefoneTxt��5G      $��CEL. (21)9 9965-8965��61   $��0 0 0 0q�6P   $��16(�6a   $
��Left=�6p   $��Center=�6�   $
��Bold"�6�   �� 5H      -   5        $	 totalDividaTxt��5H      $��Dívida: 2.500,00��64   $��0 0 0 0q�6O   $��16(�6`   $
��Left=�6o   $��Center=�6�   $
��Bold"�6�   5I      �� 5K      $ Vertical=�6   $��Center=�64   .+�5e      �� $ 
Horizontal=�6!   $��Center=�6:   $��10 10 100 0q�6W   .+�5g      �� -	   5        $��btVoltarClienteView��5g   !   $	��180��6<   $��45��6H   $��	10 0 40 0q�6T   $
{�True��6g   
 � ToolTip$
 Ficha do Clientes��6x    � Cursor$
 Hand��6�    # MaterialDesignRaisedLightButton#��[ 6�   .��5h      �� $ Vertical=�6)   .+�5i   "   F� a���� -1��� � -1��� ��ا ��� Ѡ@� `рS� ��/� z?  � рS� �A> Ѡ@� �.c ��ا ��� � -1��� 	$��Center=�5k      $��Center=�6<   $��20��6W   $��50��6c    �� Stretch$
 Fill=�6n   ��5j      ��  �� Path$ 
Foreground� �� RelativeSource ��  �� AncestorType" ��5k   n   �� 5l   "   $��CADASTRO CLIENTE��6,   $��10,0,0,0q�6D   $��14(�6V   $��Center=�6d   5m      5n      �� 5p      -
   5        $��btNovoEmprestimo��5p   !   $	��170��69   $��45��6E   $��0 0 0 0q�6Q   $
{�True��6b   $
 Nova Aplicação��6s   $
 Hand��6�   #��[ 6�   .��5q      �� $ Vertical=�6)   .+�5r   "   F� a���� 	= ��� � 	= ��� �@]� ��� �`�� `р� ��/� �. � р� �A> �`�� �.c �@]� ��� � 	= ��� 	$��Center=�5t      $��Center=�6<   $��20��6W   $��50��6c   $
 Fill=�6n   ��5s      �� $ 
Foreground� �� " ��5t   n   �� 5u   "   $��NOVA APLICAÇÃO��6,   $��10,0,0,0q�6B   $��14(�6T   $��Center=�6b   5v      5w      5x      5{      5}      &   System.Windows.Controls.DataGrid  5�      -   5          Name$ DG_EmprestimoView��5�         AutoGenerateColumns$ False��62      RowDetailsVisibilityMode$ Visible=�6N   $
��Auto��6q   $
��Auto��6   $��	10 5 20 5q�5�      $��Center=�6%   $��Center=�6G   $��16(�6k   $
��1200��6y   $	��700��6�   $��Center=�5�      $	��Top=�6.      CanUserAddRows$ False��5�      ��5�   ~   ��   5�      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType J� SnapsToDevicePixels*  $System.Windows.Controls.DataGridCell �� Triggers P� Property P� Value��%�  '        7 '  �    '  m    '�� �    �� 5�      8   "  6U   .�5�      ��  � ��
 ���� 67   �� 5�       � ��$
 Bold"�67   �� 5�       � ��$ 0��63   �� 5�       � ��$ Center=�6E   �� 5�       � ��$ Center=�6G   �� 5�       � �� 5�      �� 5�   "   "  62   .R�5�   &   � .+�5�   *   �� 
���   �$��1q�6E   ._�5�   .   �� #��z��6?   # z 6�   #��z��6�   5�   +   5�   '   5�   #   5�      5�      �� 5�      "  6    5�      P� 5�       �@ 
IsSelected$
 True��6I   . �5�   "   ��  � ��
 �����6?   �� 5�   "    � ��
 �   �6?   5�      5�      �� 5�      "  6   .�5�      ��  � ��
 ���� 67   �� 5�       � ��$ 2q�6<   5�      �� 5�      " ��6    5�      P� 5�       �@J�	IsFocused$
 True��6;   . �5�   "   ��  � ��
 �����6?   5�      5�      5�         Columns 5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�      -   5        CodEmprestimoColumn��,  &System.Windows.Controls.DataGridColumn   Header$ CÓDIGO��5�   J      MinWidth$	 105Q�6Z      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6i      
IsReadOnly$
 True��6v      CellTemplate 5�      �� 5�      .R�5�   "   �� $ Vertical=�6.   $��Center=�6E   $��Center=�6b   .+�5�   &   �� $��CÓDIGO��60   
���   �$
��Bold"�6Q   $��Center=�6c   �� 5�   &   ��60   �� *CodEmprestimo+  �� Mode$  TwoWay=�! �� UpdateSourceTrigger$! PropertyChanged=�5�   #   5�      5�        5�      -   5        DataCadastroColumn��$
 DATA��5�   I   $	 120Q�6W   $	 100 6f   $
 True��6r   "   CanUserSort$
" True��6�   #   SortDirection# 
Descending6�    5�      �� 5�      .R�5�   "   �� $ Vertical=�6-   $��Center=�6D   $��Center=�6a   .+�5�   &   �� $
��DATA��60   
���   �$
��Bold"�6O   $��Center=�6b   $��Center=�6   ,  &Syncfusion.Windows.Shared.DateTimeEdit  5�   &   $ � 
InputScope$$ Number��6�   ,	  &Syncfusion.Windows.Shared.DateTimeBase% 	  CustomPattern$% d/M/yyyy��6�   &   DateTime& 6>   �� *DataCadastro+$  TwoWay=�$! PropertyChanged=�6�   5�   #   5�      5�        5�      -   5        NomeAtendenteColumn��$ 	ATENDENTE��5�   J   $	 110Q�6]   $
 Auto 6l   $
 True��6y    5�      �� 5�      .R�5�   "   �� $ Vertical=�6-   $��Center=�6D   $��Center=�6a   .+�5�   *   �� $��	ATENDENTE��64   
���   �$
��Bold"�6X   �� 5�   &   $��Center=�6�   ��61   �� *NomeAtendente+$  TwoWay=�$! PropertyChanged=�6�   5�   #   5�      5�        5�      -   5        ValorColumn��$ APLICAÇÃO��5�   C   $	 115Q�6V   $
 Auto 6e   $ False��6r    5�      �� 5�      .R�5�   "   �� $ Vertical=�6-   $��Center=�6D   $��Center=�6a   .+�5�   *   �� $��APLICAÇÃO��64   
���   �$
��Bold"�6X   /
  )Syncfusion.Windows.Shared.CurrencyTextBox
  5�   *   ' �� 
IsReadOnly$' False��5�   2   
���   �$��1q�6Y   $��2 0 2 2q�6m   ( 
  CurrencyGroupSizes( �      ) 
  CurrencyGroupSeparator$) .��5�   2   * 
  CurrencyDecimalSeparator$* ,��6M   + 
  Value+ 5�   E   �� *Valor+$  TwoWay=�$! PropertyChanged=�5�   M   5�   #   5�      5�        5�      -   5        
TaxaColumn��$
 TAXA��5�   A   $ 70Q�6O   $
 Auto 6]   $
 True��6j    5�      �� 5�      .R�5�   "   �� $ Vertical=�6-   $��Center=�6E   $��Center=�6b   .+�5�   &   �� $
��TAXA��60   
���   �$
��Bold"�6O   $��Center=�6a   $��Center=�6~   .  (Syncfusion.Windows.Shared.PercentTextBox  5�   *   $
' True��6�   *  $Syncfusion.Windows.Shared.EditorBase,   CornerRadius$, 5��5�   4   
���   �$��1q�6X   
���   �-   PercentDecimalDigits$- 1��6�   .   PercentValue. 5�   D   �� *Taxa+$  TwoWay=�$! PropertyChanged=�5�   �   5�   #   5�      5�        5�      -   5        FormaPagamentoColumn��$ FORMA PAGAMENTO��5�   K   $	 170Q�6d   $
 Auto 6s   $ False��6�    5�      �� 5�      .R�5�   "   �� $ Vertical=�6-   $��Center=�6D   $��Center=�6a   .+�5�   &   �� $��F. PAGAMENTO��60   
���   �$
��Bold"�6W   $��Center=�6i   $��Center=�6�   �� 5�   *   $' False��6�   
���   �$��1q�5�   A   $��2 0 2 2q�6U   $	��150��6f   
������ ��5�   2   �� *FormaPagamento+$  TwoWay=�$! PropertyChanged=�5�   u   5�   #   5�      5�        5�      -   5        ValorTotalColumn��$ VALOR TOTAL��5�   G   $	 120Q�6\   $
 Auto 6k   $ false��6x    5�      �� 5�      .R�5�   "   �� $ Vertical=�6-   $��Center=�6D   $��Center=�6a   .+�5�   *   �� $��VALOR TOTAL��64   
���   �$
��Bold"�6Z   
  5�   *   $' False��5�   1   
���   �$��1q�6X   $��2 0 2 2q�6l   ( �      $) .��5   I   $* ,��6d   + 5�   E   �� *
ValorTotal+5   d   5  #   5     5       5     -   5        StatusEmprestimoColumn��$ 95 5  M   $
 True��6X    5     �� 5     .R�5	  "   �� $��Center=�6-   $��Center=�6J   .+�5
  &   �� $ 
Horizontal=�61   $��Center=�6K   $��Center=�6h   .+�5  *   �� $��STATUS��64   
���   �$
��Bold"�6U   5  '   �� 5  &   $ 
Horizontal=�61   $��Center=�6K   .+�5  *   d� $��80��67   $��12(�6�   $
��Bold"�6�   / d� IsThreeState$/ False��6�   $	��Top=�6�   $��0 0 0 0q�6�   0 d� 	IsChecked0 6B   �� *StatusEmprestimo+$  TwoWay=�$! PropertyChanged=���5  .   �� 5  2   " d�68   .�5  6   ��  � ��
 �  ��6S   �� 5  6    � ��$ 	EM ABERTO��6P    5  6   P� 5  :    �@d�	IsChecked$
 trueY�6W   . �5  >   ��  � ��
 ��ح�6[   �� 5  >    � ��$
 PAGO��6X   5  ;   5  3   5  +   5  '   5  #   5     5        5"     -   5        TotalRefinanciadoColumn��$ REFINANCIADO��5"  N   $	 130Q�6d   $
 Auto 6s   $ False��6�    5#     �� 5$     .R�5%  "   �� $ Vertical=�6-   $��Center=�6D   $��Center=�6a   .+�5&  *   �� $��REFINANCIADO��64   
���   �$
��Bold"�6[   
  5'  *   $' False��5(  1   
���   �$��1q�6X   $��2 0 2 2q�6l   $	��100��6}   ( �      $) .��5)  I   $* ,��6d   + 5'  E   �� *TotalRefinanciado+$  TwoWay=�$! PropertyChanged=�5)  d   5*  #   5+     5-       5/     -   5        ComplementoColumn��$ COMPLEMENTO��5/  H   $	 130Q�6]   $
 Auto 6l   $ False��6y    50     �� 51     .R�52  "   �� $ Vertical=�6-   $��Center=�6D   $��Center=�6a   .+�53  *   �� $��COMPLEMENTO��64   
���   �$
��Bold"�6Z   
  54  *   $' False��55  5   
���   �$��1q�6\   $��2 0 2 2q�6p   $	��100��6�   ( �      $) .��56  M   $* ,��6h   + 54  E   �� *Complemento+$  TwoWay=�$! PropertyChanged=�56  h   57  #   58     5:       5<     $ SALVAR��6-   $ 60 6=    5=     �� 5>     .R�5?  "   �� $��btAtualizarEmprestimo��6)   -   5        $��40��5?  F   $��30��6R   $��3 0 0 0q�6^   $4
 .Salvar Alterações na Aplicação selecionada��6o   $
 Hand��6�    , (MaterialDesignFloatingActionAccentButton#��[ 6�   .��5@  &   F� �����@f��- �@KL ��- �P[; ��- ��- `�; ��- @KL ���- ��!���- ��2P[; @o@@KL @o@���!@o@Ӡ�2@o@@o@��2@o@��!�@o@��j �@f��- ���!��!�@KL ��!�@KL @KL ��Q��+0@@KL ���!�yw ���!��!� �  � ӠƝ  � @T� `�� @T� ��� �@T�  6� �Ɲ �� � ���`o� �����  6� ��� ��� ���� `�� `o�  �  �  � ���[ ��[ ���� ��[ ���� ��� р�[ ��� р�[ ��[ 	$��20��5B  %   $
 Fill=�61   $��25��6@   ��5A  %   �� $ 
Foreground� �� " ��5B  @   5C  #   5D     5F       5H     $ EXCLUIR��6-   $ 60 6>    5I     �� 5J     .R�5K  "   �� $��btExcluirEmprestimo��6)   -   5        $��40��5K  D   $��30��6P   $��3 0 0 0q�6\   $%
 Excluir Aplicação selecionada��6m   $
 Hand��6�   #��[ 6�   .��5L  &   F� �����@T� ��- �@T�  	= � 	=  	= � 	= ��[ �@KL ��[ �@KL ��!���j @o@ �� �� �@f@o@���!��! �� �� ���!��[ � -1��[ � -1 	= ����  	= ���� ��- �@T� ��- ���j ��[ �@f��[ �@f��!���j ��!���j ��[ �@T�  z �@T� @f��ا @f��ا  z �@T�  z �@]�  z �@]� @f���� @f����  z �@]�  z 	$��20��5N  %   $
 Fill=�61   $��25��6@   ��5M  %   �� $ 
Foreground� �� " ��5N  @   5O  #   5P     5R     0  *System.Windows.Controls.DataGridTextColumn  5T     -   5        IdEmprestimoColumn��$  ��5T  f   $ 0 6p   $
 True��6z   1   
Foreground
1 ���� 1  +System.Windows.Controls.DataGridBoundColumn2   Binding2 6E   �� *IdEmprestimo+6�   3   RowDetailsTemplate3 5Y     �� 5Z     .R�5[     (  "Syncfusion.UI.Xaml.Grid.SfDataGrid  4  Name$4 	parcelaDG��60   -   5        $��Visible=�5[  D   $��50 10 10 10q�5\  !   $��14(�66   5   ColumnSizer$5 SizeToCells=�6D   (  "Syncfusion.UI.Xaml.Grid.SfGridBase6   	RowHeight$6 35Q�6^   7   HeaderStyle#7 [  5]  !   8   NavigationMode$
8 Cell=�5^  !   9   SelectionUnit$
9 Cell=�5_  !   :   SelectionMode$: Single=�5`  !   ;   LiveDataUpdateMode$; AllowDataShaping=�5a  !   <   
SourceType    SistemaControle_V3.Parcela"<  5d  A   =   EditTrigger$= OnTap=�5e  !   >   AutoGenerateColumns$> False��5f  !   ?   ItemsSource? 5d  !   �� *	Parcela+@   Columns@ 5j  "   ,  &Syncfusion.UI.Xaml.Grid.GridTextColumn  ObservacaoEmprestimo��,  &Syncfusion.UI.Xaml.Grid.GridColumnBaseA   MappingName$A ObservacaoEmprestimo��6Z   B   
HeaderText$B OBSERVAÇÃO EMPRESTIMO��6}   C   AllowEditing$
C True��6�   0  *Syncfusion.UI.Xaml.Grid.GridTextColumnBaseD   TextWrapping$
D Wrap=�6�   E   Width$	E 200Q�6�   F   Padding$F 3q�6�   0  *Syncfusion.UI.Xaml.Grid.GridDateTimeColumn  5k  "   
Vencimento��$A 
Vencimento��6T   $B 
VENCIMENTO��6m   $	E 110Q�6�   G   TextAlignment$G Center=�6�   $
C True��6�   H   AllowSorting$
H True��6�     5l  "   FormaPagamento��$A FormaPagamento��6T   $B FORMA DE PAGAMENTO��6q   $
C True��6�   $
D Wrap=�6�   $	E 200Q�6�   0  *Syncfusion.UI.Xaml.Grid.GridCurrencyColumn  5m  "   ValorParcela��$A ValorParcela��6W   $B VALOR��6r   $E 85Q�6�   $G Center=�6�   $
C True��6�   I   CurrencyGroupSizesI �      J   CurrencyGroupSeparator$J .��5n  E   K   CurrencyDecimalSeparator$K ,��6`   0  *Syncfusion.UI.Xaml.Grid.GridTemplateColumn  5p  "   $
A Paga��6@   $
B PAGA��6S   $E 80Q�6e   L   CellTemplateL 5q  &   �� 5r  *   .R�5s  .   d� $
��Auto��6;   $��12(�6�   $
��Bold"�6�   $/ False��6�   $��Center=�6�   $��0 0 0 0q�6�   0 6H   �� *Paga+$  TwoWay=�$! PropertyChanged=���5t  2   �� 5u  6   " d�6<   .�5v  :   ��  � ��
 �  ��6W   �� 5w  :    � ��$ 	EM ABERTO��6T    5x  :   P� 5y  >    �@d�	IsChecked$
 trueY�6[   . �5z  B   ��  � ��
 � � �6_   �� 5{  B    � ��$
 PAGO��6\   5|  ?   5  7   5�  /   5�  +   5�  #     5�  "   $B 	ATUALIZAR��6@   $E 90Q�6W   L 5�  &   �� 5�  *   .R�5�  .   �� $��btAtualizarParcela��65   -   5        $��40��5�  O   $��30��6[   $��3 0 0 0q�6g   $0
 *Salvar Alterações na Parcela selecionada��6x   $
 Hand��6�   #��[ 6�   .��5�  2   F� �����@f��- �@KL ��- �P[; ��- ��- `�; ��- @KL ���- ��!���- ��2P[; @o@@KL @o@���!@o@Ӡ�2@o@@o@��2@o@��!�@o@��j �@f��- ���!��!�@KL ��!�@KL @KL ��Q��+0@@KL ���!�yw ���!��!� �  � ӠƝ  � @T� `�� @T� ��� �@T�  6� �Ɲ �� � ���`o� �����  6� ��� ��� ���� `�� `o�  �  �  � ���[ ��[ ���� ��[ ���� ��� р�[ ��� р�[ ��[ 	$��20��5�  1   $
 Fill=�6=   $��25��6L   ��5�  1   �� $ 
Foreground� �� " ��5�  L   5�  /   5�  +   5�  #     5�  "   $B EXCLUIR��6@   $E 70Q�6U   L 5�  &   �� 5�  *   .R�5�  .   �� $��btExcluirParcela��65   -   5        $��40��5�  M   $��30��6Y   $��3 0 0 0q�6e   $!
 Excluir Parcela selecionada��6v   $
 Hand��6�   #��[ 6�   .��5�  2   F� �����@T� ��- �@T�  	= � 	=  	= � 	= ��[ �@KL ��[ �@KL ��!���j @o@ �� �� �@f@o@���!��! �� �� ���!��[ � -1��[ � -1 	= ����  	= ���� ��- �@T� ��- ���j ��[ �@f��[ �@f��!���j ��!���j ��[ �@T�  z �@T� @f��ا @f��ا  z �@T�  z �@]�  z �@]� @f���� @f����  z �@]�  z 	$��20��5�  1   $
 Fill=�6=   $��25��6L   ��5�  1   �� $ 
Foreground� �� " ��5�  L   5�  /   5�  +   5�  #     5�  "   $B 	ANTECIPAR��6@   $E 90Q�6W   L 5�  &   �� 5�  *   .R�5�  .   �� $ btAnteciparRefi��6I   -   5        $��	ANTECIPAR��5�  5   $��20��6b   $��70��6n   $��Center=�6z     	AllButton#���  6�   $��12(�5�  5   $��0 0 0 0q�6C   $ 
 Refinanciamento Antecipado��6U   $��Center=�5�  5   $��Center=�6R   5�  +   5�  #     5�  "   
Observacao��$A 
Observacao��6P   $B OBSERVAÇÃO��6i   $
C True��6�   M   MinimumWidth$	M 400Q�6�   $F 0 0 20 0q�6�     5�  "   	IdParcela��$A 	IdParcela��6O   $B  ��6g   $E 0Q�6u     5�  "   IdEmprestimo��$A IdEmprestimo��6R   $B  ��6m   $E 0Q�6{   5�     5�     5�     5�     5�     5�     