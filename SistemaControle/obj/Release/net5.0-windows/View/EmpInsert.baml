   M S B A M L   `   `   `  ���� J  FSistemaControle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SistemaControle.ViewSistemaControle.View  $    SistemaControle.View.EmpInsert   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:SistemaControle.View     h dSyncfusion.SfSkinManager.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89l hSyncfusion.SfTextInputLayout.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89` \Syncfusion.Tools.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89f	 bSyncfusion.SfAccordion.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b
 ^Syncfusion.SfInput.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89m iSyncfusion.SfNavigationDrawer.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89@
syncfusion!http://schemas.syncfusion.com/wpf    	 
    b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $	��660��$
��1090��  � 	Resources     	descricao �� 
TargetType �� Property �� Value3  -Syncfusion.UI.Xaml.Grid.GridHeaderCellControl  headerStyle2�� %�   &	        &	 �     �� " ��.���  � ��$ 15(���  � ��$ Segoe UI)���  � ��$
 Bold"���  � �� �#515151��  � ��$ Center=���  � ��$ Center=��� "  .���  � ��
 �   ���  � ��$
 Bold"�.���� $
��Auto=�$
��Auto=�$��0 0 0 60q�$	��Top=�$��Center=�.����  �� Orientation$ Vertical=�$��Center=�
�������.+�]� $��Center=�$	��Top=�.+��� -    ��Name$ button��$
��Left=�$��
15 5 10 10q�$	��130��$	��130������ -   btImagem�� j� Stretch$
 None=� �� ImageSource$ /Resources/usuario.png���� $ Vertical=�$��Center=�.+��� -    ��Name$ nomeClienteTxt��$"��Teste da Silva Santos Vieira��$��0 0 0 0q�$��16(�$
��Left=�$��Center=�$
��Bold"��� -   $ cpfTxt��$��CPF: 000.000.000-00��$��0 0 0 0q�$��16(�$
��Left=�$��Center=�$
��Bold"��� -   $ telefoneTxt��$��CEL. (21)9 9965-8965��$��0 0 0 0q�$��16(�$
��Left=�$��Center=�$
��Bold"��� -   $ totalDividaTxt��$��Dívida: 2.500,00��$��0 0 0 0q�$��16(�$
��Left=�$��Center=�$
��Bold"��� $ Vertical=�$��Center=�.+��� $ 
Horizontal=�$��Center=�$��10 10 100 0q�.+��� -   $��btCadCliente��$	��150��$��50��$��	10 0 30 0q�$
{�True��	 � ToolTip$	 Ficha do Clientes��
 � Cursor$

 Hand�� # MaterialDesignRaisedLightButton#��[ .���� $ Vertical=�.+�F� a���� -1��� � -1��� ��ا ��� Ѡ@� `рS� ��/� z?  � рS� �A> Ѡ@� �.c ��ا ��� � -1��� 	$��Center=�$��Center=�$��20��$��50�� �� Stretch$
 Fill=�����  �� Path$ 
Foreground� �� RelativeSource ��  �� AncestorType" ���� $��CADATRO CLIENTE��$��10,0,0,0q�$��12(�$��Center=��� -	   $��btFichaCliente��$	��140��$��50��$��30 0 0 0q�$
{�True��$	 Nova Aplicação��$

 Hand��#��[ .���� $ Vertical=�.+�F� a���� 	= ��� � 	= ��� �@]� ��� �`�� `р� ��/� �. � р� �A> �`�� �.c �@]� ��� � 	= ��� 	$��Center=�$��Center=�$��20��$��50��$
 Fill=����� $ 
Foreground� �� " ���� $��FICHA CLIENTE��$��10,0,0,0q�$��12(�$��Center=�� $��0 20 0 0q� � RowDefinitions �� �� �� �� �� �� ��  � ColumnDefinitions �� �� �� �� �� �� �� .+��� $ Vertical=�$��0��$��0��$��	30 10 0 0q�$��Center=�$��Center=�.+��� $��DATA CADASTRO��#��[  ,  &Syncfusion.Windows.Shared.DateTimeEdit  -
     Name$ DataCadastro�� � 
InputScope$ Number��,  &Syncfusion.Windows.Shared.DateTimeBase   CustomPattern$ d/M/yyyy��$��20(�$��50��$	��140��$
��Left=��� $ Vertical=�$��0��$��1��$��10 0 0 0q�$��Bottom=�$
��Left=�.+��� $��CÓDIGO��#��[  4 
 .Syncfusion.Windows.Controls.Input.SfMaskedEdit  -     Name$ CodEmprestimo��$	��140��$��50��$��20(�   MaskType$ RegEx=�   Mask$% ([0-9])+/([0-9]{2})\/([0-9]{4})��$��Center=��� $ Vertical=�$��0��$��2��$��10 0 0 0q�$��Bottom=�$
��Left=�.+��� $��APLICAÇÃO��#��[  /  )Syncfusion.Windows.Shared.CurrencyTextBox  -     Name$ 	Aplicacao��$	��140��$��50��$��20(�*  $Syncfusion.Windows.Shared.EditorBase   CornerRadius$ 5��$��Center=�$
 IBeam���� $ Vertical=�$��0��$��3��$��10 0 0 0q�$��Bottom=�$
��Left=�.+��� $
��TAXA��#��[  .  (Syncfusion.Windows.Shared.PercentTextBox  -     Name$
 Taxa��$	��140��$��50��$��20(�$ 5��$��Center=�   PercentDecimalDigits$ 1��$
 IBeam���� $ Vertical=�$��0��$��4��$��10 0 0 0q�$��Bottom=�$
��Left=�.+��� $��QTD PARCELAS��#��[  .  (Syncfusion.Windows.Shared.IntegerTextBox  -     Name$ 
QtdParcela��$	��140��$��50��$��20(�$ 5��$��Center=��� $ Vertical=�$��0��$��5��$��10 0 0 0q�$��Bottom=�$
��Left=�.+��� $��VALOR PARCELAS��#��[    -   $ ValorParcela��$	��140��$��50��$��20(�$ 5��$��Center=��� $ Vertical=�$��0��$��6��$��10 0 0 0q�$��Bottom=�$
��Left=�.+��� $��VALOR TOTAL��#��[    -   $ 
ValorTotal��$	��140��$��50��$��20(�$ 5��$��Center=��� $ Vertical=�$��1��$��0��$��	30 30 0 0q�$��Center=�$��Center=�.+��� $��1° PARCELA��#��[    -   $ PrimeiraParcela��$ Number��$ d/M/yyyy��   IsEmptyDateEnabled$
 True��$��20(�$��50��$	��140��$
��Left=�   	NullValue Z� �� $ Vertical=�$��1��$��1��$��10 0 0 0q�$��Bottom=�$
��Left=�.+��� $��VALOR COMISSÃO��#��[    -   $ ValorComissao��$	��140��$��50��$��20(�$ 5��$��Center=��� $ Vertical=�$��1��$��2��$��2��$��10 0 0 0q�$��Bottom=�$��Center=�.+��� $��	ATENDENTE��#��[  �� -    ��Name$ cbAtendente��$��40��$	��220��$��0 10 0 0q�$��18(� �� 
IsEditable$
 True��$��Center=�)	  #MaterialDesignThemes.Wpf.HintAssist  	  Hint$  	Atendente��! 	  FloatingScale$! 0Q�-
  'MaterialDesignThemes.Wpf.ComboBoxAssist" 
  ClassicMode" �� # �� ElementName$# ClassicModeCheckBox��$ 	IsChecked��� -   $ ��Name$$ 
Observacao��$��Center=�$	��530��$��Center=�$��50��$��14(�$��1��$��4��$��3��$��	10 45 0 0q�$  Observação��.  (MaterialDesignThemes.Wpf.TextFieldAssist%   TextBoxViewMargin$% 1 0 1 0q�$
! 0.50Q� % !MaterialDesignFloatingHintTextBox#��[ ���� *
observacao+& �� Mode$& TwoWay=�' �� NotifyOnValidationError$
' true��( �� ValidatesOnExceptions$
( true���� -   ) ��Name$) lstUtil��$��
20 20 20 0q�$��Center=�$��2��$��0��$��4��$��55��	 �� $��Selecione o Dia Útil������ .R�$� * K� IsItemsHost$
* True��+ $� Orientation$+ 
Horizontal=�.@��� $��0 0 0 0q�$��0q�.��'  !MaterialDesignThemes.Wpf.PackIcon  ,   Kind$, NumericZeroCircle=�$��50��$��50���� $��5 0 0 0q�$��0q�.��  $, NumericOneCircle=�$��50��$��50���� $��5 0 0 0q�$��0q�.��  $, NumericTwoCircle=�$��50��$��50���� $��5 0 0 0q�$��0q�.��  $, NumericThreeCircle=�$��50��$��50���� $��5 0 0 0q�$��0q�.��  $, NumericFourCircle=�$��50��$��50���� $��5 0 0 0q�$��0q�.��  $, NumericFiveCircle=�$��50��$��50���� $��5 0 0 0q�$��0q�.��  $, NumericSixCircle=�$��50��$��50���� $��5 0 0 0q�$��0q�.��  $, NumericSevenCircle=�$��50��$��50���� $��5 0 0 0q�$��0q�.��  $, NumericEightCircle=�$��50��$��50���� $��5 0 0 0q�$��0q�.��  $, NumericNineCircle=�$��50��$��50���� $��5 0 0 0q�$��0q�.��  $, Numeric10Circle=�$��50��$��50���� -   $ 
FPagamento��$��2��$��4��$��2��$��4��$	��250��$��50��$��
20 20 20 0q�$��18(�$
 True��$	��Top=�$  Forma de Pagamento��$
! 0.50Q�$
��Left=�" �� $# ClassicModeCheckBox��$ 	IsChecked��� -   $ CodigosAntigo��$��Últimos Códigos��$��2��$��6��$��
20 20 20 0q�$��20(�$
��Left=�$	��Top=�$
��Bold"�(  "Syncfusion.UI.Xaml.Grid.SfDataGrid  -   -  Name$- parcelaDataGrid��$��3��$��0��$��4��$��
30 40 20 0q�$
��auto��$
��Auto��$��16(�(  "Syncfusion.UI.Xaml.Grid.SfGridBase.   	RowHeight$. 35Q�/   HeaderStyle#/ [ $
��Left=�$	��Top=�0   NavigationMode$
0 Cell=�1   SelectionUnit$
1 Cell=�2   SelectionMode$2 Single=�3   EditTrigger$3 OnTap=�4   AutoGenerateColumns$4 False��5   Columns5 0  *Syncfusion.UI.Xaml.Grid.GridDateTimeColumn  ,  &Syncfusion.UI.Xaml.Grid.GridColumnBase6   MappingName$6 
Vencimento��7   
HeaderText$7 
VENCIMENTO��8   Width$	8 120Q�9   TextAlignment$9 Center=�:   AllowEditing$
: True��;   AllowSorting$
; True��,  &Syncfusion.UI.Xaml.Grid.GridTextColumn  $6 FormaPagamento��$7 FORMA DE PAGAMENTO��$
: True��0  *Syncfusion.UI.Xaml.Grid.GridTextColumnBase<   TextWrapping$
< Wrap=�$	8 200Q�0  *Syncfusion.UI.Xaml.Grid.GridCurrencyColumn  $6 ValorParcela��$7 VALOR��$	8 120Q�$9 Center=�$
: True��=   CurrencyGroupSizes= �      >   CurrencyGroupSeparator$> .��?   CurrencyDecimalSeparator$? ,���� $ 
Horizontal=�$��3��$��4��$��3��$��30 40 20 10q�.+��� -   $ btGerarParcela��$��4��$��0��$	��230��$��40��$&	  Gerar as parcelas da Aplicação��$

 Hand��#��[ .���� $ 
Horizontal=�.+�F� ����Ѐ�  $� р��  $� р�� ��� р� ��� Ѐ���� р���� � $� ��� � $� ��� � � ��� � �  $� � $�  $� � $�  -1р� -1р� $� р�O $� р�O��� Ѐ�� ��[ р� ��[ р�  z р��  z ���� ��� р� ��� р�  � р��  � р�� ��� 	$��Center=�$��Center=�$��30��$��30��$
 Fill=����� $ 
Foreground� �� " ���� $��GERAR PARCELAS��$��10,0,0,0q�$��18(�$��Center=�$��Black"��� -   $ btInsert��$��4��$��0��${�False��$	��280��$��40��$ 	 Inserir a nova Aplicação��$��30 0 0 0q�$

 Hand��#��[ .���� $ 
Horizontal=�.+�F� �����@]� @f�@f@f�@f��� р�O�I�@f��^�@f -1�@]�  -1�@]� @fЀ��  P� �`�� �ջ ��  �  �  � ӠƝ  � @T� `�� @T� ��� S@T� ���(\O0@�%� Ч	�ا `��0� �� �9� @�� ���  P� �P8� ��!�@KL ��!�@KL @KL ��Q��+0@@KL ���!�yw ���!0r� �p\-�i� ��7@]� @o@��� �@o@��j �@f��- �@KL ��- �P[; ��- ��- `�; ��- @KL ���- ��!���- ��2P[; @o@@KL @o@��4� @o@Ӡݮ p 7� @�,P8� ��!���[ ��� ���� ��� ���� ��[ р�[ ��[ р�[ ��� 	$��Center=�$��Center=�$��30��$��30��$
 Fill=����� $ 
Foreground� �� " ���� $��CAD. APLICAÇÃO��$��10,0,0,0q�$��18(�$��Center=�$��Black"�