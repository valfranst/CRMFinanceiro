   M S B A M L   `   `   `  ���� J  FSistemaControle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SistemaControle.ViewSistemaControle.View  =#clr-namespace:SistemaControle.ModelSistemaControle.Model  &     SistemaControle.View.Recebimento   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:SistemaControle.View     6local2#clr-namespace:SistemaControle.Model     h dSyncfusion.SfSkinManager.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89l hSyncfusion.SfTextInputLayout.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89` \Syncfusion.Tools.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89f	 bSyncfusion.SfAccordion.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b
 ^Syncfusion.SfInput.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89m iSyncfusion.SfNavigationDrawer.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89@
syncfusion!http://schemas.syncfusion.com/wpf    	 
    b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $	��660��$
��1090��  � 	Resources  .  (SistemaControle.View.RowStyleRecebimento   rowStyle3  -Syncfusion.UI.Xaml.Grid.GridHeaderCellControl �� 
TargetType  headerStyle �� Property �� Value  	descricao��%  &	        &	      &	 B       �� "  .���  � ��
 �   ���  � ��$
 Bold"��� " ��.���  � ��$ 15(���  � ��$ Segoe UI)���  � ��$
 Bold"���  � �� �#515151��  � ��$ Center=���  � ��$ Center=�.��� -    �Name$ MainRecebimento��$
��1090��$	��620��$��0 0 0 0q�$��Center=�$	��Top=�.+���  �� Orientation$ 
Horizontal=�$	��Top=�$
��Left=�$��	10 10 0 0q�.+��� -   $��btMenos��$��30��$��30��$��	30 0 10 0q�$
{�True�� � ToolTip$ Ficha do Clientes�� � Cursor$
 Hand�� , (MaterialDesignFloatingActionAccentButton#��[ .���� $ Vertical=�.+�F� �������j  � � � ��j � � ��� � $� ��� � $� ��� � � ��� � � @f���j  � �@o@@KL �@o@��!���!@o@��� �� �@KL @o@���- ��!��� �� ���- @KL �@KL ��- ��� �� ���!��- �@o@@KL ��� �� ���!@KL �@KL @KL �@KL ��!���!��!���!@KL 	$��Center=�$��Center=�$��20��$��20�� �� Stretch$
 Fill=����� 	 �� Path$	 
Foreground�
 �� RelativeSource
 ��  �� AncestorType" ��.  (Syncfusion.Windows.Shared.IntegerTextBox  -     Name$ AnoTxt��$	��100��$��30��$��20(�*  $Syncfusion.Windows.Shared.EditorBase   CornerRadius$ 5��$��2q�$��Center=�   GroupSeperatorEnabled$ False��$��Center=�$��Center=�   MinValue$
 1999��   MaxValue$
 9999��$ Digite o Ano desejado��${�False��   UseNullOption$
 True��   	NullValue Z� �� -   $��btMais��$��30��$��30��$��10 0 0 0q�$
{�True��$ Nova Aplicação��$
 Hand��#��[ .���� $ Vertical=�.+�F� �����@f � � � @f� � ��� � z ��� � z ��� � � ��� � � ��j �@f � ���- ��!���- @KL �@KL ��- ��� �� ���!��- �@o@@KL ��� �� �@o@��!���!@o@��� �� �@KL @o@���- ��!��� �� �@KL ��!���!��!���!@KL �@KL @KL �@KL ��!	$��Center=�$��Center=�$��20��$��20��$
 Fill=����� $	 
Foreground�
 �� " ���� -    ��Name$ Titulo��$��PRODUÇÃO MENSAL��$��22(�$
��Bold"�$��	200 0 0 0q�$��40���� $ Vertical=�$��	0 60 0 50q�.+�(  "Syncfusion.UI.Xaml.Grid.SfDataGrid  -     Name$ view_RecebimentoDataGrid��$��16(�$��	10 0 0 10q�$��Center=�(  "Syncfusion.UI.Xaml.Grid.SfGridBase   	RowHeight$ 35Q�   ColumnSizer$ SizeToCells=�$��Visible=�$��Visible=�   HeaderStyle# [    RowStyleSelector# [     AutoGenerateColumns$ False��   NavigationMode$
 Cell=�   SelectionUnit$
 Cell=�   SelectionMode$ Single=�   LiveDataUpdateMode$ AllowDataShaping=�   EditTrigger$ OnTap=�   
SourceType+   %SistemaControle.Model.ViewRecebimento"      ItemsSource  �� *ViewRecebimento+!   Columns! ,  &Syncfusion.UI.Xaml.Grid.GridTextColumn  -   	IdCliente��,	  &Syncfusion.UI.Xaml.Grid.GridColumnBase" 	  MappingName$" 	IdCliente��# 	  
HeaderText$#  ��$ 	  Width$$ 0Q�% 	  AllowSorting$% False��  -	   	IdParcela��$" 	IdParcela��$#  ��$$ 0Q�$% False��  -
   CodEmprestimo��$" CodEmprestimo��$# CÓDIGO��$	$ 110Q�& 	  TextAlignment$& Center=�' 	  AllowEditing$' False��0
  *Syncfusion.UI.Xaml.Grid.GridDateTimeColumn
  -   
Vencimento��$" 
Vencimento��$# 
VENCIMENTO��$	$ 120Q�$& Center=�$' False��  -   NomeCliente��$" NomeCliente��$
# NOME��( 	  MinimumWidth$	( 300Q�$
& Left=�) 	  Padding$) 5 0 0 0q�$' False��0  *Syncfusion.UI.Xaml.Grid.GridCurrencyColumn  -   ValorParcela��$" ValorParcela��$# VALOR��$	$ 100Q�$& Center=�$' False��*   CurrencyGroupSizes* �      +   CurrencyGroupSeparator$+ .��,   CurrencyDecimalSeparator$, ,��0  *Syncfusion.UI.Xaml.Grid.GridTemplateColumn  $
" Paga��$
# PAGA��$$ 80Q�- 	  CellTemplate- �� .R�d� $
��Auto��$��12(�$
��Bold"�. d� IsThreeState$. False��$��Center=�$��0 0 0 0q�/ d� 	IsChecked/ �� *Paga+0 �� Mode$0 TwoWay=�1 �� UpdateSourceTrigger$1 PropertyChanged=����� " d�.���  � ��
 �  ����  � ��$ 	EM ABERTO��2 �� Triggers2 P� 3 P� Property3 �@d�	IsChecked4 P� Value$
4 trueY�. ���  � ��
 � � ���  � ��$
 PAGO��  $# SALVAR��$$ 80Q�- �� .R��� 5 ��Name$5 btPagarParcala��-   $��SALVAR��$��20��$��70��$��Center=�  	AllButton#���  $��12(�$��0 0 0 0q�$' !Mudar STATUS da parcela para PAGA��$��Center=�$��Center=�  -   
Observacao��$" 
Observacao��$# OBSERVAÇÃO��$	( 600Q�$
& Left=�$
' True��$) 3 0 5 0q��� $ 
Horizontal=�$��0��$��2��$��0 0 30 0q�$��Bottom=�$��Right=�.+��� $��TOTAL RECEBIMENTO��#��[ /  )Syncfusion.Windows.Shared.CurrencyTextBox  -   6  Name$6 totalRecebimentoTextBox��$	��300��$��30��$��20(�$ 5��$��Center=�7 �� 
IsReadOnly$
7 True���� -   8 ��Name$8 lstAnos��$��	0 20 0 10q�$��Bottom=�$��Center=� �� $��Selecione o Mês������ .R�$� 9 K� IsItemsHost$
9 True��: $� Orientation$: 
Horizontal=�.@��� $��10 2 0 2q�.��#  MaterialDesignThemes.Wpf.Chip  $	��JAN��${�False��  PrimaryHueDarkBrush;   IconBackground#; �   ! PrimaryHueDarkForegroundBrush<   IconForeground#< �  =   Icon= '  !MaterialDesignThemes.Wpf.PackIcon  >   Kind$> AlphabetJCircle=��� $��10 2 0 2q�.��  $	��FEV��${�False��#; �  #< �  =   $> AlphabetFCircle=��� $��10 2 0 2q�.��  $	��MAR��${�False��#; �  #< �  =   $> AlphabetMCircle=��� $��10 2 0 2q�.��  $	��ABR��${�False��#; �  #< �  =   $> AlphabetACircle=��� $��10 2 0 2q�.��  $	��MAI��${�False��#; �  #< �  =   $> AlphabetMCircle=��� $��10 2 0 2q�.��  $	��JUN��${�False��#; �  #< �  =   $> AlphabetJCircle=��� $��10 2 0 2q�.��  $	��JUL��${�False��#; �  #< �  =   $> AlphabetJCircle=��� $��10 2 0 2q�.��  $	��AGO��${�False��#; �  #< �  =   $> AlphabetACircle=��� $��10 2 0 2q�.��  $	��SET��${�False��#; �  #< �  =   $> AlphabetSCircle=��� $��10 2 0 2q�.��  $	��OUT��${�False��#; �  #< �  =   $> AlphabetOCircle=��� $��10 2 0 2q�.��  $	��NOV��${�False��#; �  #< �  =   $> AlphabetNCircle=��� $��10 2 0 2q�.��  $	��DEZ��${�False��#; �  #< �  =   $> AlphabetDCircle=�