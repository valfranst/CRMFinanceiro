   M S B A M L   `   `   `  ����M  ISistemaControle_V3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SistemaControle_V3SistemaControle_V3  5      -    'SistemaControle_V3.ClienteAplicacaoView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:SistemaControle_V3     5      ` \Syncfusion.Tools.Wpf, Version=19.1310.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=19.1310.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=19.1310.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b	 ^Syncfusion.SfInput.Wpf, Version=19.1310.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c898
syncfusion!http://schemas.syncfusion.com/wpf    	 5      b
 ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 
 5	      -   5        $	��660��5      $
��1090��6/     � 	Resources  5         	descricao �� 
TargetType �� Property �� Value3  -Syncfusion.UI.Xaml.Grid.GridHeaderCellControl  headerStyle2�� 5   
   %�  &	        &	     �� 5      " ��6&   .�5      ��  � ��$ 15(�6-   �� 5       � ��$ Segoe UI)�6/   �� 5       � ��$
 Bold"�6/   �� 5       � �� �#5151516/   �� 5       � ��$ Center=�66   �� 5       � ��$ Center=�68   5      �� 5      "  6   .�5      ��  � ��
 �   �6/   �� 5       � ��$
 Bold"�6/   5      5      .��5#      �� $
��Auto=�6   $
��Auto=�66   $��0 0 0 60q�6[   $	��Top=�6m   $��Center=�6�   .��5$   
   ��  �� Orientation$ Vertical=�6   $��Center=�6,   
�������.+�5&      ]� $��Center=�6   $	��Top=�66   .+�5(      �� -   5         ��Name$ button��5(      $
��Left=�6)   $��
15 5 10 10q�6D   $	��130��6Y   $	��130��6e   ��5)      �� 5*      -   5        btImagem�� j� Stretch$
 None=�5*   8    �� ImageSource$ /Resources/usuario.png��6G   5,      �� 5.      $ Vertical=�6   $��Center=�64   .+�5/      �� -   5         ��Name$ nomeClienteTxt��5/      $"��Teste da Silva Santos Vieira��64   $��0 0 0 0q�6[   $��16(�6l   $
��Left=�6{   $��Center=�6�   $
��Bold"�6�   �� 50      -   5        $ cpfTxt��50      $��CPF: 000.000.000-00��6,   $��0 0 0 0q�6J   $��16(�6[   $
��Left=�6j   $��Center=�6�   $
��Bold"�6�   �� 51      -   5        $ telefoneTxt��51      $��CEL. (21)9 9965-8965��61   $��0 0 0 0q�6P   $��16(�6a   $
��Left=�6p   $��Center=�6�   $
��Bold"�6�   �� 52      -   5        $ totalDividaTxt��52      $��Dívida: 2.500,00��64   $��0 0 0 0q�6O   $��16(�6`   $
��Left=�6o   $��Center=�6�   $
��Bold"�6�   53      �� 55      $ Vertical=�6   $��Center=�64   .+�56      �� $ 
Horizontal=�6!   $��Center=�6:   $��10 10 100 0q�6W   .+�58      �� -   5        $��btCadCliente��58   !   $	��150��65   $��50��6A   $��	10 0 30 0q�6M   $
{�True��6`   	 � ToolTip$	 Ficha do Clientes��6q   
 � Cursor$

 Hand��6�    # MaterialDesignRaisedLightButton#��[ 6�   .��59      �� $ Vertical=�6)   .+�5:   "   F� a���� -1��� � -1��� ��ا ��� Ѡ@� `рS� ��/� z?  � рS� �A> Ѡ@� �.c ��ا ��� � -1��� 	$��Center=�5<      $��Center=�6<   $��20��6W   $��50��6c    �� Stretch$
 Fill=�6n   ��5;      ��  �� Path$ 
Foreground� �� RelativeSource ��  �� AncestorType" ��5<   n   �� 5=   "   $��CADATRO CLIENTE��6,   $��10,0,0,0q�6C   $��12(�6U   $��Center=�6c   5>      5?      �� 5A      -	   5        $��btFichaCliente��5A   !   $	��140��67   $��50��6C   $��30 0 0 0q�6O   $
{�True��6a   $	 Nova Aplicação��6r   $

 Hand��6�   #��[ 6�   .��5B      �� $ Vertical=�6)   .+�5C   "   F� a���� 	= ��� � 	= ��� �@]� ��� �`�� `р� ��/� �. � р� �A> �`�� �.c �@]� ��� � 	= ��� 	$��Center=�5E      $��Center=�6<   $��20��6W   $��50��6c   $
 Fill=�6n   ��5D      �� $ 
Foreground� �� " ��5E   n   �� 5F   "   $��FICHA CLIENTE��6,   $��10,0,0,0q�6A   $��12(�6S   $��Center=�6a   5G      5H      5I      5L      5N      � 5P      $��0 20 0 0q�6    � RowDefinitions 5Q      �� 5R      �� 5S      �� 5T      �� 5U      �� 5V      �� 5W      �� 5X       � ColumnDefinitions 5Z      �� 5[      �� 5\      �� 5]      �� 5^      �� 5_      �� 5`      �� 5a      .+�5e      �� $ Vertical=�6   $��0��64   $��0��6A   $��	30 10 0 0q�6Q   $��Center=�6d   $��Center=�6   .+�5f      �� $��DATA CADASTRO��6   #��[  64   ,  &Syncfusion.Windows.Shared.DateTimeEdit  5g      -
   5          Name$ DataCadastro��5g   .    � 
InputScope$ Number��6D   ,  &Syncfusion.Windows.Shared.DateTimeBase   CustomPattern$ d/M/yyyy��6X   $��20(�5h      $��50��6'   $	��140��63   $
��Left=�6?   6~   5i      �� 5l      $ Vertical=�6   $��0��64   $��1��6A   $��10 0 0 0q�6Q   $��Bottom=�6c   $
��Left=�6~   .+�5m      �� $��CÓDIGO��6   #��[  6-   4 	 .Syncfusion.Windows.Controls.Input.SfMaskedEdit  5n      -   5          Name$ CodEmprestimo��5n   .   $	��140��6E   $��50��6Q   $��20(�6]      MaskType$ RegEx=�5o         Mask$% ([0-9])+/([0-9]{2})\/([0-9]{4})��6*   $��Center=�6R   5p      �� 5s      $ Vertical=�6   $��0��64   $��2��6A   $��10 0 0 0q�6Q   $��Bottom=�6c   $
��Left=�6~   .+�5t      �� $��APLICAÇÃO��6   #��[  60   /  )Syncfusion.Windows.Shared.CurrencyTextBox  5u      -   5          Name$ 	Aplicacao��5u   1   $	��140��6D   $��50��6P   $��20(�6\   *  $Syncfusion.Windows.Shared.EditorBase   CornerRadius$ 5��6j   $��Center=�6|   $
 IBeam��6�   5v      �� 5y      $ Vertical=�6   $��0��64   $��3��6A   $��10 0 0 0q�6Q   $��Bottom=�6c   $
��Left=�6~   .+�5z      �� $
��TAXA��6   #��[  6+   .  (Syncfusion.Windows.Shared.PercentTextBox  5{      -   5          Name$
 Taxa��5{   0   $	��140��6>   $��50��6J   $��20(�6V   $ 5��6d   $��Center=�6v      PercentDecimalDigits$ 1��5|      $
 IBeam��62   6A   5}      �� 5�      $ Vertical=�6   $��0��64   $��4��6A   $��10 0 0 0q�6Q   $��Bottom=�6c   $
��Left=�6~   .+�5�      �� $��QTD PARCELAS��6   #��[  63   .  (Syncfusion.Windows.Shared.IntegerTextBox  5�      -   5          Name$ 
QtdParcela��5�   0   $	��140��6D   $��50��6P   $��20(�6\   $ 5��6j   $��Center=�6{   6�   5�      �� 5�      $ Vertical=�6   $��0��64   $��5��6A   $��10 0 0 0q�6Q   $��Bottom=�6c   $
��Left=�6~   .+�5�      �� $��VALOR PARCELAS��6   #��[  65     5�      -   5        $ ValorParcela��5�   1   $	��140��6G   $��50��6S   $��20(�6_   $ 5��6m   $��Center=�6   6�   5�      �� 5�      $ Vertical=�6   $��0��64   $��6��6A   $��10 0 0 0q�6Q   $��Bottom=�6c   $
��Left=�6~   .+�5�      �� $��VALOR TOTAL��6   #��[  62     5�      -   5        $ 
ValorTotal��5�   1   $	��140��6E   $��50��6Q   $��20(�6]   $ 5��6k   $��Center=�6}   5�      �� 5�      $ Vertical=�6   $��1��64   $��0��6A   $��	30 30 0 0q�6Q   $��Center=�6d   $��Center=�6   .+�5�      �� $��1° PARCELA��6   #��[  61     5�      -   5        $ PrimeiraParcela��5�   .   $ Number��6G   $ d/M/yyyy��6[      IsEmptyDateEnabled$
 True��6t   $��20(�5�      $��50��6'   $	��140��63   $
��Left=�6?      	NullValue 5�   �   Z� 5�   a   5�      �� 5�      $ Vertical=�6   $��1��64   $��1��6A   $��10 0 0 0q�6Q   $��Bottom=�6c   $
��Left=�6~   .+�5�      �� $��VALOR COMISSÃO��6   #��[  65     5�      -   5        $ ValorComissao��5�   1   $	��140��6H   $��50��6T   $��20(�6`   $ 5��6n   $��Center=�6�   5�      �� 5�      $ Vertical=�6   $��1��64   $��2��6A   $��2��6Q   $��10 0 0 0q�6e   $��Bottom=�6w   $��Center=�6�   .+�5�      �� $��	ATENDENTE��6   #��[  60   �� 5�      -   5         ��Name$ cbAtendente��5�      $��40��64   $	��220��6@   $��0 10 0 0q�6L   $��18(�6^    �� 
IsEditable$
 True��6l   $��Center=�6~   )	 
 #MaterialDesignThemes.Wpf.HintAssist  	  Hint$  	Atendente��5�      ! 	  FloatingScale$! 0Q�6@   -
 
 'MaterialDesignThemes.Wpf.ComboBoxAssist" 
  ClassicMode" 5�      �� # �� ElementName$# ClassicModeCheckBox��$ 	IsChecked�5�      �� 5�      -   5        $ ��Name$$ 
Observacao��5�      $��Center=�6.   $	��530��6K   $��Center=�5�      $��50��63   $��14(�6?   $��1��6M   $��4��6Z   $��3��6j   $��	10 45 0 0q�6~   $  Observação��5�      . 
 (MaterialDesignThemes.Wpf.TextFieldAssist%   TextBoxViewMargin$% 1 0 1 0q�6C   $
! 0.50Q�6~    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��5�   W   �� *
observacao+& �� Mode$& TwoWay=�' �� NotifyOnValidationError$
' true��( �� ValidatesOnExceptions$
( true��5�   �   �� 5�      -   5        ) ��Name$) lstUtil��5�      $��
20 20 20 0q�6+   $��Center=�6?   $��2��6�   $��0��6�   $��4��6�   $��55��5�      	 5�      �� 5�      $��Selecione o Dia Útil��6$   ��5�      �� 5�      .R�5�      $� * K� IsItemsHost$
* True��65   + $� Orientation$+ 
Horizontal=�6H   5�      .@�5�      �� $��0 0 0 0q�6"   $��0q�63   .��5�      ' 
 !MaterialDesignThemes.Wpf.PackIcon  ,   Kind$, NumericZeroCircle=�62   $��50��6K   $��50��6V   5�      �� 5�      $��5 0 0 0q�6"   $��0q�63   .��5�        $, NumericOneCircle=�62   $��50��6J   $��50��6U   5�      �� 5�      $��5 0 0 0q�6"   $��0q�63   .��5�        $, NumericTwoCircle=�62   $��50��6J   $��50��6U   5�      �� 5�      $��5 0 0 0q�6"   $��0q�63   .��5�        $, NumericThreeCircle=�62   $��50��6L   $��50��6W   5�      �� 5�      $��5 0 0 0q�6"   $��0q�63   .��5�        $, NumericFourCircle=�62   $��50��6K   $��50��6V   5�      �� 5�      $��5 0 0 0q�6"   $��0q�63   .��5�        $, NumericFiveCircle=�62   $��50��6K   $��50��6V   5�      �� 5�      $��5 0 0 0q�6"   $��0q�63   .��5�        $, NumericSixCircle=�62   $��50��6J   $��50��6U   5�      �� 5�      $��5 0 0 0q�6"   $��0q�63   .��5�        $, NumericSevenCircle=�62   $��50��6L   $��50��6W   5�      �� 5�      $��5 0 0 0q�6"   $��0q�63   .��5�        $, NumericEightCircle=�62   $��50��6L   $��50��6W   5�      �� 5�      $��5 0 0 0q�6"   $��0q�63   .��5�        $, NumericNineCircle=�62   $��50��6K   $��50��6V   5�      �� 5�      $��5 0 0 0q�6"   $��0q�63   .��5�        $, Numeric10Circle=�62   $��50��6I   $��50��6T   5�      5�      �� 5�      -   5        $ 
FPagamento��5�      $��2��6/   $��4��6<   $��2��6L   $��4��6`   $	��250��6q   $��50��6}   $��
20 20 20 0q�6�   $��18(�6�   $
 True��6�   $	��Top=�6�   $  Forma de Pagamento��5�      $
! 0.50Q�6J   $
��Left=�5�   }   " 6   �� $# ClassicModeCheckBox��$ 	IsChecked�6}   �� 5�      -   5        $ CodigosAntigo��5�      $��Últimos Códigos��6/   $��2��6I   $��6��6V   $��
20 20 20 0q�5�      $��20(�6(   $
��Left=�66   $	��Top=�6Q   $
��Bold"�6i   (  "Syncfusion.UI.Xaml.Grid.SfDataGrid  5�      -   5        -  Name$- parcelaDataGrid��5�   (   $��3��6A   $��0��6N   $��4��6^   $��
30 40 20 0q�6r   $
��auto��6�   $
��Auto��6�   $��16(�6�   (  "Syncfusion.UI.Xaml.Grid.SfGridBase.   	RowHeight$. 35Q�6�   /   HeaderStyle#/ [ 5�      $
��Left=�5�      $	��Top=�5�      0   NavigationMode$
0 Cell=�5�      1   SelectionUnit$
1 Cell=�5�      2   SelectionMode$2 Single=�5�      3   EditTrigger$3 OnTap=�5�      4   AutoGenerateColumns$4 False��5�      5   Columns5 5�      0  *Syncfusion.UI.Xaml.Grid.GridDateTimeColumn  ,  &Syncfusion.UI.Xaml.Grid.GridColumnBase6   MappingName$6 
Vencimento��68   7   
HeaderText$7 
VENCIMENTO��6Q   8   Width$	8 120Q�6i   9   TextAlignment$9 Center=�6u   :   AllowEditing$
: True��6�   ;   AllowSorting$
; True��6�   ,  &Syncfusion.UI.Xaml.Grid.GridTextColumn  5�      $6 FormaPagamento��64   $7 FORMA DE PAGAMENTO��6Q   $
: True��6q   0  *Syncfusion.UI.Xaml.Grid.GridTextColumnBase<   TextWrapping$
< Wrap=�6�   $	8 200Q�6�   0  *Syncfusion.UI.Xaml.Grid.GridCurrencyColumn  5�      $6 ValorParcela��69   $7 VALOR��6T   $	8 120Q�6g   $9 Center=�6s   $
: True��6�   =   CurrencyGroupSizes= �      >   CurrencyGroupSeparator$> .��5�   E   ?   CurrencyDecimalSeparator$? ,��6`   5     �� 5     $ 
Horizontal=�6   $��3��66   $��4��6C   $��3��6S   $��30 40 20 10q�6g   .+�5     �� -   5        $ btGerarParcela��5     $��4��65   $��0��6B   $	��230��6R   $��40��6^   $&	  Gerar as parcelas da Aplicação��6j   $

 Hand��6�   #��[ 5  7   .��5     �� $ 
Horizontal=�6%   .+�5	     F� ����Ѐ�  $� р��  $� р�� ��� р� ��� Ѐ���� р���� � $� ��� � $� ��� � � ��� � �  $� � $�  $� � $�  -1р� -1р� $� р�O $� р�O��� Ѐ�� ��[ р� ��[ р�  z р��  z ���� ��� р� ��� р�  � р��  � р�� ��� 	$��Center=�5     $��Center=�6<   $��30��6W   $��30��6c   $
 Fill=�6n   ��5
     �� $ 
Foreground� �� " ��5  n   �� 5     $��GERAR PARCELAS��6(   $��10,0,0,0q�6>   $��18(�6P   $��Center=�6^   $��Black"�6y   5     5     �� 5     -   5        $ btInsert��5     $��4��6/   $��0��6<   ${�False��6L   $	��280��6^   $��40��6j   $ 	 Inserir a nova Aplicação��6v   $��30 0 0 0q�5     $

 Hand��6+   #��[ 6P   .��5     �� $ 
Horizontal=�6%   .+�5     F� �����@]� @f�@f@f�@f��� р�O�I�@f��^�@f -1�@]�  -1�@]� @fЀ��  P� �`�� �ջ ��  �  �  � ӠƝ  � @T� `�� @T� ��� S@T� ���(\O0@�%� Ч	�ا `��0� �� �9� @�� ���  P� �P8� ��!�@KL ��!�@KL @KL ��Q��+0@@KL ���!�yw ���!0r� �p\-�i� ��7@]� @o@��� �@o@��j �@f��- �@KL ��- �P[; ��- ��- `�; ��- @KL ���- ��!���- ��2P[; @o@@KL @o@��4� @o@Ӡݮ p 7� @�,P8� ��!���[ ��� ���� ��� ���� ��[ р�[ ��[ р�[ ��� 	$��Center=�5     $��Center=�6<   $��30��6W   $��30��6c   $
 Fill=�6n   ��5     �� $ 
Foreground� �� " ��5  n   �� 5     $��CAD. APLICAÇÃO��6(   $��10,0,0,0q�6>   $��18(�6P   $��Center=�6^   $��Black"�6y   5     5     5     5#     5%     5&     5'     