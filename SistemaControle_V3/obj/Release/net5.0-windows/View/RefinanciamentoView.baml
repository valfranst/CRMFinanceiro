   M S B A M L   `   `   `  ���� M  ISistemaControle_V3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SistemaControle_V3SistemaControle_V3  ,    &SistemaControle_V3.RefinanciamentoView   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ` \Syncfusion.Tools.Wpf, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b	 ^Syncfusion.SfInput.Wpf, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c898
syncfusion!http://schemas.syncfusion.com/wpf    	 b
 ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 
 ,local clr-namespace:SistemaControle_V3 
 -   $	��660��$
��1090��  � 	Resources  0  *SistemaControle_V3.RowStyleRefinanciamento   rowStyle3  -Syncfusion.UI.Xaml.Grid.GridHeaderCellControl �� 
TargetType  headerStyle �� Property �� Value  	descricao��%  &	        &	      &	 B       �� "  .���  � ��
 �   ���  � ��$
 Bold"��� " ��.���  � ��$ 15(���  � ��$ Segoe UI)���  � ��$
 Bold"���  � �� �#515151��  � ��$ Center=���  � ��$ Center=�.��� -    �Name$ MainRefinanciamento��$
��1090��$	��620��$��	0 0 10 20q�$��Center=�$	��Top=�.+���  �� Orientation$ 
Horizontal=�$	��Top=�$
��Left=�$��	10 10 0 0q�.+��� -   $��btMenos��$��30��$��30��$��	30 0 10 0q�$
{�True�� � ToolTip$ Ficha do Clientes�� � Cursor$
 Hand�� , (MaterialDesignFloatingActionAccentButton#��[ .���� $ Vertical=�.+�F� �������j  � � � ��j � � ��� � $� ��� � $� ��� � � ��� � � @f���j  � �@o@@KL �@o@��!���!@o@��� �� �@KL @o@���- ��!��� �� ���- @KL �@KL ��- ��� �� ���!��- �@o@@KL ��� �� ���!@KL �@KL @KL �@KL ��!���!��!���!@KL 	$��Center=�$��Center=�$��20��$��20�� �� Stretch$
 Fill=����� 	 �� Path$	 
Foreground�
 �� RelativeSource
 ��  �� AncestorType" ��.  (Syncfusion.Windows.Shared.IntegerTextBox  -     Name$ AnoTxt��$	��100��$��30��$��20(�*  $Syncfusion.Windows.Shared.EditorBase   CornerRadius$ 5��$��2q�$��Center=�   GroupSeperatorEnabled$ False��$��Center=�$��Center=�   MinValue$
 1999��   MaxValue$
 9999��$ Digite o Ano desejado��${�False��   UseNullOption$
 True��   	NullValue Z� �� -   $��btMais��$��30��$��30��$��10 0 0 0q�$
{�True��$ Nova Aplicação��$
 Hand��#��[ .���� $ Vertical=�.+�F� �����@f � � � @f� � ��� � z ��� � z ��� � � ��� � � ��j �@f � ���- ��!���- @KL �@KL ��- ��� �� ���!��- �@o@@KL ��� �� �@o@��!���!@o@��� �� �@KL @o@���- ��!��� �� �@KL ��!���!��!���!@KL �@KL @KL �@KL ��!	$��Center=�$��Center=�$��20��$��20��$
 Fill=����� $	 
Foreground�
 �� " ��d� -    d�Name$ btAlternarDados��$��50��$��30��$��30 0 0 0q�$��Center=�$
��Left=� $  MaterialDesignSwitchToggleButton#���  �� -    ��Name$ Titulo��$��PRODUÇÃO MENSAL��$��22(�$
��Bold"�$��	200 0 0 0q�$��40���� $ Vertical=�$��	0 60 0 50q�.+�(  "Syncfusion.UI.Xaml.Grid.SfDataGrid  -     Name$ view_RefinanciarDataGrid��$��16(�$��	10 0 0 10q�$��Center=�$��Visible=�$��Visible=�(  "Syncfusion.UI.Xaml.Grid.SfGridBase   	RowHeight$ 35Q�   ColumnSizer$ SizeToCells=�   HeaderStyle# [    RowStyleSelector# [     
SourceType,   &SistemaControle_V3.ViewRefinanciamento"     AutoGenerateColumns$ False��   NavigationMode$
 Cell=�   SelectionUnit$
 Cell=�   SelectionMode$ Single=�   LiveDataUpdateMode$ AllowDataShaping=�    EditTrigger$  OnTap=�!   ItemsSource! �� *ViewRefinanciamento+"   Columns" ,  &Syncfusion.UI.Xaml.Grid.GridTextColumn  -	   	IdCliente��,	  &Syncfusion.UI.Xaml.Grid.GridColumnBase# 	  MappingName$# 	IdCliente��$ 	  
HeaderText$$  ��% 	  Width$% 0Q�& 	  AllowSorting$& False��  -
   IdEmprestimo��$# IdEmprestimo��$$  ��$% 0Q�$& False��  -   CodEmprestimo��$# CodEmprestimo��$$ CÓDIGO��$	% 100Q�' 	  TextAlignment$' Center=�( 	  AllowEditing$( False��0
  *Syncfusion.UI.Xaml.Grid.GridDateTimeColumn
  -   UltimaParcela��$# UltimaParcela��$
$ DATA��$	% 100Q�$' Center=�$( False��  -   NomeCliente��$# NomeCliente��$
$ NOME��) 	  MinimumWidth$	) 300Q�$
' Left=�* 	  Padding$* 5 0 0 0q�$( False��0  *Syncfusion.UI.Xaml.Grid.GridCurrencyColumn  -   ValorParcela��$# ValorParcela��$$ A REFINANCIAR��$	) 120Q�$' Center=�$( False��+   CurrencyGroupSizes+ �      ,   CurrencyGroupSeparator$, .��-   CurrencyDecimalSeparator$- ,��  -   Complemento��$# Complemento��$$ COMPLEMENTO��$	) 120Q�$' Center=�$
( True��+ �      $, .��$- ,��  -   TotalRefinanciado��$# TotalRefinanciado��$$ REFINANCIADO��$	) 120Q�$' Center=�$
( True��+ �      $, .��$- ,��0  *Syncfusion.UI.Xaml.Grid.GridTemplateColumn  -   Excluir��$$ EXCLUIR��$% 80Q�. 	  CellTemplate. �� .R��� / ��Name$/ btExcluirRefinanciamento��-   $��EXCLUIR��$��20��$��70��$��Center=�  	AllButton#���  $��12(�$��0 0 0 0q�$3 -Excluir Aplicação da tabela Refinanciamento��$��Center=�$��Center=�  -   Incluir��$$ INCLUIR��$% 80Q�. �� .R��� $/ btIncluirRefinanciamento��-   $��INCLUIR��$��20��$��70��$��Center=�#���  $��12(�$��0 0 0 0q�$3 -Incluir Aplicação na tabela Refinanciamento��$��Center=�$��Center=�  $# Refinanciado��$$ SIM/NÃO��$% 80Q�. �� .R��� $ / btAtualizarRefinanciamento��-   $��SALVAR��$��20��$��70��$��Center=�#���  $��12(�$��0 0 0 0q�$3 -Incluir Aplicação na tabela Refinanciamento��$��Center=�$��Center=�  -   
Observacao��$# 
Observacao��$$ OBSERVAÇÃO��$	) 600Q�$
' Left=�$
( True��$* 5 0 5 0q��� $ 
Horizontal=�$��0��$��2��$��	0 0 150 0q�$��Bottom=�$��Right=�.+��� $��A REFINANCIAR��#��[ /  )Syncfusion.Windows.Shared.CurrencyTextBox  -   0  Name$0 aRefinanciarTextBox��$	��200��$��30��$��20(�$ 5��$��Center=�1 �� 
IsReadOnly$
1 True���� $��COMPLEMENTO��#��[ $��20 0 0 0q�  -   $0 complementoTextBox��$	��200��$��30��$��20(�$ 5��$��Center=�$
1 True���� $��REFINANCIADO��#��[ $��20 0 0 0q�  -   $0 refinanciadoTextBox��$	��200��$��30��$��20(�$ 5��$��Center=�$
1 True���� -   2 ��Name$2 lstAnos��$��	0 10 0 10q�$��Bottom=�$��Center=� �� $��Selecione o Mês������ .R�$� 3 K� IsItemsHost$
3 True��4 $� Orientation$4 
Horizontal=�.@��� $��10 2 0 2q�.��# 
 MaterialDesignThemes.Wpf.Chip  $	��JAN��${�False��  PrimaryHueDarkBrush5   IconBackground#5 �   ! PrimaryHueDarkForegroundBrush6   IconForeground#6 �  7   Icon7 ' 
 !MaterialDesignThemes.Wpf.PackIcon  8   Kind$8 AlphabetJCircle=��� $��10 2 0 2q�.��  $	��FEV��${�False��#5 �  #6 �  7   $8 AlphabetFCircle=��� $��10 2 0 2q�.��  $	��MAR��${�False��#5 �  #6 �  7   $8 AlphabetMCircle=��� $��10 2 0 2q�.��  $	��ABR��${�False��#5 �  #6 �  7   $8 AlphabetACircle=��� $��10 2 0 2q�.��  $	��MAI��${�False��#5 �  #6 �  7   $8 AlphabetMCircle=��� $��10 2 0 2q�.��  $	��JUN��${�False��#5 �  #6 �  7   $8 AlphabetJCircle=��� $��10 2 0 2q�.��  $	��JUL��${�False��#5 �  #6 �  7   $8 AlphabetJCircle=��� $��10 2 0 2q�.��  $	��AGO��${�False��#5 �  #6 �  7   $8 AlphabetACircle=��� $��10 2 0 2q�.��  $	��SET��${�False��#5 �  #6 �  7   $8 AlphabetSCircle=��� $��10 2 0 2q�.��  $	��OUT��${�False��#5 �  #6 �  7   $8 AlphabetOCircle=��� $��10 2 0 2q�.��  $	��NOV��${�False��#5 �  #6 �  7   $8 AlphabetNCircle=��� $��10 2 0 2q�.��  $	��DEZ��${�False��#5 �  #6 �  7   $8 AlphabetDCircle=�