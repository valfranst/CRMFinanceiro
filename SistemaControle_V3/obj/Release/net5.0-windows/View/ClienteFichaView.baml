   M S B A M L   `   `   `  ���� M  ISistemaControle_V3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SistemaControle_V3SistemaControle_V3  )    #SistemaControle_V3.ClienteFichaView   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     2local clr-namespace:SistemaControle_V3     ` \Syncfusion.Tools.Wpf, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b	 ^Syncfusion.SfInput.Wpf, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c898
syncfusion!http://schemas.syncfusion.com/wpf    	 b
 ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 
 -   $	��700��$
��1200��  � 	Resources  3  -Syncfusion.UI.Xaml.Grid.GridHeaderCellControl �� 
TargetType   headerStyle2 �� Property �� Value  
TituloText  SubTituloText  InfoText  MsgText  headerStyle�� %e  &	        &	 =     &	 �     &	 
    &	 d    &	 �    �� "  .���  � ��
 �   ���  � ��$
 Bold"��� " ��.���  � ��$ 34(���  � ��$ Segoe UI)���  � ��$
 Bold"���  � �� �#515151�� " ��.���  � ��$ 24(���  � ��$ Segoe UI)���  � ��$ Regular"��� " ��.���  � ��$ 18(���  � ��$ Segoe UI)���  � ��$ Regular"��� " ��.���  � ��$ 12(���  � ��$ Segoe UI)���  � ��$ Regular"��� "  .���  � ��
 ��·���  � ��
 �   ���  � ��$
 Bold"���  � ��$ 12(�.���� -    ��Name$ SV_EmprestimoView��$��Visible=�$��Visible=�$��0 0 5 15q�$��	0 0 10 10q�$��Center=�$	��Top=�$
��Auto��$
��Auto��.����  �� Orientation$ Vertical=�$��Center=�$	��Top=�.+�]� $��Center=�$	��Top=�.+��� -    ��Name$ button��$
��Left=�$��	15 5 10 5q�$	��130��$	��130������ -   btImagem�� j� Stretch$
 None=� �� ImageSource$ /Resources/usuario.png���� $ Vertical=�$��Center=�.+��� -   	 ��Name$	 nomeClienteTxt��$"��Teste da Silva Santos Vieira��$��0 0 0 0q�$��16(�$
��Left=�$��Center=�$
��Bold"��� -   $	 cpfTxt��$��CPF: 000.000.000-00��$��0 0 0 0q�$��16(�$
��Left=�$��Center=�$
��Bold"��� -   $	 telefoneTxt��$��CEL. (21)9 9965-8965��$��0 0 0 0q�$��16(�$
��Left=�$��Center=�$
��Bold"��� -   $	 totalDividaTxt��$��Dívida: 2.500,00��$��0 0 0 0q�$��16(�$
��Left=�$��Center=�$
��Bold"��� $ Vertical=�$��Center=�.+��� $ 
Horizontal=�$��Center=�$��10 10 100 0q�.+��� -	   $��btVoltarClienteView��$	��180��$��45��$��	10 0 40 0q�$
{�True��
 � ToolTip$
 Ficha do Clientes�� � Cursor$
 Hand�� # MaterialDesignRaisedLightButton#��[ .���� $ Vertical=�.+�F� a���� -1��� � -1��� ��ا ��� Ѡ@� `рS� ��/� z?  � рS� �A> Ѡ@� �.c ��ا ��� � -1��� 	$��Center=�$��Center=�$��20��$��50�� �� Stretch$
 Fill=�����  �� Path$ 
Foreground� �� RelativeSource ��  �� AncestorType" ���� $��CADASTRO CLIENTE��$��10,0,0,0q�$��14(�$��Center=��� -
   $��btNovoEmprestimo��$	��170��$��45��$��0 0 0 0q�$
{�True��$
 Nova Aplicação��$
 Hand��#��[ .���� $ Vertical=�.+�F� a���� 	= ��� � 	= ��� �@]� ��� �`�� `р� ��/� �. � р� �A> �`�� �.c �@]� ��� � 	= ��� 	$��Center=�$��Center=�$��20��$��50��$
 Fill=����� $ 
Foreground� �� " ���� $��NOVA APLICAÇÃO��$��10,0,0,0q�$��14(�$��Center=�&   System.Windows.Controls.DataGrid  -     Name$ DG_EmprestimoView��   AutoGenerateColumns$ False��   RowDetailsVisibilityMode$ Visible=�$
��Auto��$
��Auto��$��	10 5 20 5q�$��Center=�$��Center=�$��16(�$
��1200��$	��700��$��Center=�$	��Top=�   CanUserAddRows$ False������   =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType J� SnapsToDevicePixels*  $System.Windows.Controls.DataGridCell �� Triggers P� Property P� Value��%�  '        7 '  �     '  J    '�� �    �� 8   "  .���  � ��
 ���� ��  � ��$
 Bold"���  � ��$ 0����  � ��$ Center=���  � ��$ Center=���  � �� �� "  .R�� .+��� 
���   �$��1q�._��� #��z��# z #��z���� "   P�  �@ 
IsSelected$
 True��. ���  � ��
 �������  � ��
 �   ��� "  .���  � ��
 ���� ��  � ��$ 2q��� " �� P�  �@J�	IsFocused$
 True��. ���  � ��
 �����   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  -   CodEmprestimoColumn��,  &System.Windows.Controls.DataGridColumn   Header$ CÓDIGO��   MinWidth$	 105Q�   Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto    
IsReadOnly$
 True��   CellTemplate �� .R��� $ Vertical=�$��Center=�$��Center=�.+��� $��CÓDIGO��
���   �$
��Bold"�$��Center=��� ���� *CodEmprestimo+  �� Mode$  TwoWay=�! �� UpdateSourceTrigger$! PropertyChanged=�  -   DataCadastroColumn��$
 DATA��$	 120Q�$	 100 $
 True��"   CanUserSort$
" True��#   SortDirection# 
Descending �� .R��� $ Vertical=�$��Center=�$��Center=�.+��� $
��DATA��
���   �$
��Bold"�$��Center=�$��Center=�,  &Syncfusion.Windows.Shared.DateTimeEdit  $ � 
InputScope$$ Number��,	  &Syncfusion.Windows.Shared.DateTimeBase% 	  CustomPattern$% d/M/yyyy��&   DateTime& �� *DataCadastro+$  TwoWay=�$! PropertyChanged=�  -   NomeAtendenteColumn��$ 	ATENDENTE��$	 110Q�$
 Auto $
 True�� �� .R��� $ Vertical=�$��Center=�$��Center=�.+��� $��	ATENDENTE��
���   �$
��Bold"��� $��Center=����� *NomeAtendente+$  TwoWay=�$! PropertyChanged=�  -   ValorColumn��$ APLICAÇÃO��$	 115Q�$
 Auto $ False�� �� .R��� $ Vertical=�$��Center=�$��Center=�.+��� $��APLICAÇÃO��
���   �$
��Bold"�/
  )Syncfusion.Windows.Shared.CurrencyTextBox
  ' �� 
IsReadOnly$' False��
���   �$��1q�$��2 0 2 2q�( 
  CurrencyGroupSizes( �      ) 
  CurrencyGroupSeparator$) .��* 
  CurrencyDecimalSeparator$* ,��+ 
  Value+ �� *Valor+$  TwoWay=�$! PropertyChanged=�  -   
TaxaColumn��$
 TAXA��$ 70Q�$
 Auto $
 True�� �� .R��� $ Vertical=�$��Center=�$��Center=�.+��� $
��TAXA��
���   �$
��Bold"�$��Center=�$��Center=�.  (Syncfusion.Windows.Shared.PercentTextBox  $
' True��*  $Syncfusion.Windows.Shared.EditorBase,   CornerRadius$, 5��
���   �$��1q�
���   �-   PercentDecimalDigits$- 1��.   PercentValue. �� *Taxa+$  TwoWay=�$! PropertyChanged=�  -   FormaPagamentoColumn��$ FORMA PAGAMENTO��$	 170Q�$
 Auto $ False�� �� .R��� $ Vertical=�$��Center=�$��Center=�.+��� $��F. PAGAMENTO��
���   �$
��Bold"�$��Center=�$��Center=��� $' False��
���   �$��1q�$��2 0 2 2q�$	��150��
������ ���� *FormaPagamento+$  TwoWay=�$! PropertyChanged=�  -   ValorTotalColumn��$ VALOR TOTAL��$	 120Q�$
 Auto $ false�� �� .R��� $ Vertical=�$��Center=�$��Center=�.+��� $��VALOR TOTAL��
���   �$
��Bold"�
  $' False��
���   �$��1q�$��2 0 2 2q�( �      $) .��$* ,��+ �� *
ValorTotal+  -   StatusEmprestimoColumn��$ 95 $
 True�� �� .R��� $��Center=�$��Center=�.+��� $ 
Horizontal=�$��Center=�$��Center=�.+��� $��STATUS��
���   �$
��Bold"��� $ 
Horizontal=�$��Center=�.+�d� $��80��$��12(�$
��Bold"�/ d� IsThreeState$/ False��$	��Top=�$��0 0 0 0q�0 d� 	IsChecked0 �� *StatusEmprestimo+$  TwoWay=�$! PropertyChanged=����� " d�.���  � ��
 �  ����  � ��$ 	EM ABERTO�� P�  �@d�	IsChecked$
 trueY�. ���  � ��
 ��ح���  � ��$
 PAGO��  -   TotalRefinanciadoColumn��$ REFINANCIADO��$	 130Q�$
 Auto $ False�� �� .R��� $ Vertical=�$��Center=�$��Center=�.+��� $��REFINANCIADO��
���   �$
��Bold"�
  $' False��
���   �$��1q�$��2 0 2 2q�$	��100��( �      $) .��$* ,��+ �� *TotalRefinanciado+$  TwoWay=�$! PropertyChanged=�  -   ComplementoColumn��$ COMPLEMENTO��$	 130Q�$
 Auto $ False�� �� .R��� $ Vertical=�$��Center=�$��Center=�.+��� $��COMPLEMENTO��
���   �$
��Bold"�
  $' False��
���   �$��1q�$��2 0 2 2q�$	��100��( �      $) .��$* ,��+ �� *Complemento+$  TwoWay=�$! PropertyChanged=�  $ SALVAR��$ 60  �� .R��� $��btAtualizarEmprestimo��-   $��40��$��30��$��3 0 0 0q�$4
 .Salvar Alterações na Aplicação selecionada��$
 Hand�� , (MaterialDesignFloatingActionAccentButton#��[ .��F� �����@f��- �@KL ��- �P[; ��- ��- `�; ��- @KL ���- ��!���- ��2P[; @o@@KL @o@���!@o@Ӡ�2@o@@o@��2@o@��!�@o@��j �@f��- ���!��!�@KL ��!�@KL @KL ��Q��+0@@KL ���!�yw ���!��!� �  � ӠƝ  � @T� `�� @T� ��� �@T�  6� �Ɲ �� � ���`o� �����  6� ��� ��� ���� `�� `o�  �  �  � ���[ ��[ ���� ��[ ���� ��� р�[ ��� р�[ ��[ 	$��20��$
 Fill=�$��25������ $ 
Foreground� �� " ��  $ EXCLUIR��$ 60  �� .R��� $��btExcluirEmprestimo��-   $��40��$��30��$��3 0 0 0q�$%
 Excluir Aplicação selecionada��$
 Hand��#��[ .��F� �����@T� ��- �@T�  	= � 	=  	= � 	= ��[ �@KL ��[ �@KL ��!���j @o@ �� �� �@f@o@���!��! �� �� ���!��[ � -1��[ � -1 	= ����  	= ���� ��- �@T� ��- ���j ��[ �@f��[ �@f��!���j ��!���j ��[ �@T�  z �@T� @f��ا @f��ا  z �@T�  z �@]�  z �@]� @f���� @f����  z �@]�  z 	$��20��$
 Fill=�$��25������ $ 
Foreground� �� " ��0  *System.Windows.Controls.DataGridTextColumn  -   IdEmprestimoColumn��$  ��$ 0 $
 True��1   
Foreground
1 ���� 1  +System.Windows.Controls.DataGridBoundColumn2   Binding2 �� *IdEmprestimo+3   RowDetailsTemplate3 �� .R�(  "Syncfusion.UI.Xaml.Grid.SfDataGrid  4  Name$4 	parcelaDG��-   $��Visible=�$��50 10 10 10q�$��14(�5   ColumnSizer$5 SizeToCells=�(  "Syncfusion.UI.Xaml.Grid.SfGridBase6   	RowHeight$6 35Q�7   HeaderStyle#7 [  8   NavigationMode$
8 Cell=�9   SelectionUnit$
9 Cell=�:   SelectionMode$: Single=�;   LiveDataUpdateMode$; AllowDataShaping=�<   
SourceType    SistemaControle_V3.Parcela"<  =   EditTrigger$= OnTap=�>   AutoGenerateColumns$> False��?   ItemsSource? �� *	Parcela+@   Columns@ ,  &Syncfusion.UI.Xaml.Grid.GridTextColumn  ObservacaoEmprestimo��,  &Syncfusion.UI.Xaml.Grid.GridColumnBaseA   MappingName$A ObservacaoEmprestimo��B   
HeaderText$B OBSERVAÇÃO EMPRESTIMO��C   AllowEditing$
C True��0  *Syncfusion.UI.Xaml.Grid.GridTextColumnBaseD   TextWrapping$
D Wrap=�E   Width$	E 200Q�F   Padding$F 3q�0  *Syncfusion.UI.Xaml.Grid.GridDateTimeColumn  
Vencimento��$A 
Vencimento��$B 
VENCIMENTO��$	E 110Q�G   TextAlignment$G Center=�$
C True��H   AllowSorting$
H True��  FormaPagamento��$A FormaPagamento��$B FORMA DE PAGAMENTO��$
C True��$
D Wrap=�$	E 200Q�0  *Syncfusion.UI.Xaml.Grid.GridCurrencyColumn  ValorParcela��$A ValorParcela��$B VALOR��$E 85Q�$G Center=�$
C True��I   CurrencyGroupSizesI �      J   CurrencyGroupSeparator$J .��K   CurrencyDecimalSeparator$K ,��0  *Syncfusion.UI.Xaml.Grid.GridTemplateColumn  $
A Paga��$
B PAGA��$E 80Q�L   CellTemplateL �� .R�d� $
��Auto��$��12(�$
��Bold"�$/ False��$��Center=�$��0 0 0 0q�0 �� *Paga+$  TwoWay=�$! PropertyChanged=����� " d�.���  � ��
 �  ����  � ��$ 	EM ABERTO�� P�  �@d�	IsChecked$
 trueY�. ���  � ��
 � � ���  � ��$
 PAGO��  $B 	ATUALIZAR��$E 90Q�L �� .R��� $��btAtualizarParcela��-   $��40��$��30��$��3 0 0 0q�$0
 *Salvar Alterações na Parcela selecionada��$
 Hand��#��[ .��F� �����@f��- �@KL ��- �P[; ��- ��- `�; ��- @KL ���- ��!���- ��2P[; @o@@KL @o@���!@o@Ӡ�2@o@@o@��2@o@��!�@o@��j �@f��- ���!��!�@KL ��!�@KL @KL ��Q��+0@@KL ���!�yw ���!��!� �  � ӠƝ  � @T� `�� @T� ��� �@T�  6� �Ɲ �� � ���`o� �����  6� ��� ��� ���� `�� `o�  �  �  � ���[ ��[ ���� ��[ ���� ��� р�[ ��� р�[ ��[ 	$��20��$
 Fill=�$��25������ $ 
Foreground� �� " ��  $B EXCLUIR��$E 70Q�L �� .R��� $��btExcluirParcela��-   $��40��$��30��$��3 0 0 0q�$!
 Excluir Parcela selecionada��$
 Hand��#��[ .��F� �����@T� ��- �@T�  	= � 	=  	= � 	= ��[ �@KL ��[ �@KL ��!���j @o@ �� �� �@f@o@���!��! �� �� ���!��[ � -1��[ � -1 	= ����  	= ���� ��- �@T� ��- ���j ��[ �@f��[ �@f��!���j ��!���j ��[ �@T�  z �@T� @f��ا @f��ا  z �@T�  z �@]�  z �@]� @f���� @f����  z �@]�  z 	$��20��$
 Fill=�$��25������ $ 
Foreground� �� " ��  $B 	ANTECIPAR��$E 90Q�L �� .R��� $ btAnteciparRefi��-   $��	ANTECIPAR��$��20��$��70��$��Center=�  	AllButton#���  $��12(�$��0 0 0 0q�$ 
 Refinanciamento Antecipado��$��Center=�$��Center=�  
Observacao��$A 
Observacao��$B OBSERVAÇÃO��$
C True��M   MinimumWidth$	M 400Q�$F 0 0 20 0q�  	IdParcela��$A 	IdParcela��$B  ��$E 0Q�  IdEmprestimo��$A IdEmprestimo��$B  ��$E 0Q�