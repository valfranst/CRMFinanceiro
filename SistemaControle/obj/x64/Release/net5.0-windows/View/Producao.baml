   M S B A M L   `   `   `  ���� J  FSistemaControle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SistemaControle.ViewSistemaControle.View  =#clr-namespace:SistemaControle.ModelSistemaControle.Model  #    SistemaControle.View.Producao   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:SistemaControle.View     6local2#clr-namespace:SistemaControle.Model     h dSyncfusion.SfSkinManager.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89l hSyncfusion.SfTextInputLayout.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89` \Syncfusion.Tools.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89f	 bSyncfusion.SfAccordion.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b
 ^Syncfusion.SfInput.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89m iSyncfusion.SfNavigationDrawer.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89@
syncfusion!http://schemas.syncfusion.com/wpf    	 
    b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $	��660��$
��1090��  � 	Resources  +  %SistemaControle.View.RowStyleProducao   rowStyle3  -Syncfusion.UI.Xaml.Grid.GridHeaderCellControl �� 
TargetType  headerStyle �� Property �� Value  	descricao��%�   &	        &	      &	 B       �� "  .���  � ��
 �   ���  � ��$
 Bold"��� " ��.���  � ��$ 15(���  � ��$ Segoe UI)���  � ��$
 Bold"���  � ��$ Center=���  � ��$ Center=�.��� -    �Name$ MainProducao��$
��1090��$	��620��$��0 0 0 0q�$��Center=�$	��Top=�.+���  �� Orientation$ 
Horizontal=�$	��Top=�$
��Left=�$��	10 10 0 0q�.+��� -   $��btMenos��$��30��$��30��$��	30 0 10 0q�$
{�True�� � ToolTip$ Ficha do Clientes�� � Cursor$
 Hand�� , (MaterialDesignFloatingActionAccentButton#��[ .���� $ Vertical=�.+�F� �������j  � � � ��j � � ��� � $� ��� � $� ��� � � ��� � � @f���j  � �@o@@KL �@o@��!���!@o@��� �� �@KL @o@���- ��!��� �� ���- @KL �@KL ��- ��� �� ���!��- �@o@@KL ��� �� ���!@KL �@KL @KL �@KL ��!���!��!���!@KL 	$��Center=�$��Center=�$��20��$��20�� �� Stretch$
 Fill=����� 	 �� Path$	 
Foreground�
 �� RelativeSource
 ��  �� AncestorType" ��.  (Syncfusion.Windows.Shared.IntegerTextBox  -     Name$ AnoTxt��$	��100��$��30��$��20(�*  $Syncfusion.Windows.Shared.EditorBase   CornerRadius$ 5��$��2q�$��Center=�   GroupSeperatorEnabled$ False��$��Center=�$��Center=�   MinValue$ 1��   MaxValue$
 9999��$ Digite o Ano desejado��${�False��   UseNullOption$
 True��   	NullValue Z� �� -   $��btMais��$��30��$��30��$��10 0 0 0q�$
{�True��$ Nova Aplicação��$
 Hand��#��[ .���� $ Vertical=�.+�F� �����@f � � � @f� � ��� � z ��� � z ��� � � ��� � � ��j �@f � ���- ��!���- @KL �@KL ��- ��� �� ���!��- �@o@@KL ��� �� �@o@��!���!@o@��� �� �@KL @o@���- ��!��� �� �@KL ��!���!��!���!@KL �@KL @KL �@KL ��!	$��Center=�$��Center=�$��20��$��20��$
 Fill=����� $	 
Foreground�
 �� " ���� -    ��Name$ Titulo��$��PRODUÇÃO MENSAL��$��22(�$
��Bold"�$��	200 0 0 0q�$��40���� -    ��Name$ MainScrollViewer��$��Disabled=�$��Visible=�$
��1100��$
��auto��$��0 50 10 110q�$	��Top=�$��Center=�$��0 0 10 0q�.���� $ Vertical=�$��Center=�.+�(  "Syncfusion.UI.Xaml.Grid.SfDataGrid  -     Name$$ view_ClienteEmprestimoDataGrid��$��Visible=�$��Visible=�(  "Syncfusion.UI.Xaml.Grid.SfGridBase   	RowHeight$ 40Q�   ColumnSizer$ SizeToCells=�$��10 15 10 10q�$��14(�$��0 0 5 5q�$��16)�   HeaderStyle# [    RowStyleSelector# [  $
��1000��$
��auto��$	��Top=�$
��Left=�$��Center=�   AllowEditing$ False��   FrozenColumnCount$ 1��   
IsReadOnly$
 True��   NavigationMode$	 Row=�   SelectionUnit$	 Row=�   SelectionMode$ Single=�    LiveDataUpdateMode$  AllowDataShaping=�!   EditTrigger$! OnTap=�"   AutoGenerateColumns$" False��#   
SourceType0   *SistemaControle.Model.ViewAplicacaoCliente"#  $   SelectedItem$ �� *SelectedItem+% �� Mode$% TwoWay=�& �� UpdateSourceTrigger$& PropertyChanged=�'   ItemsSource' �� *ViewAplicacaoCliente+(   Columns( ,  &Syncfusion.UI.Xaml.Grid.GridTextColumn  ,	  &Syncfusion.UI.Xaml.Grid.GridColumnBase) 	  MappingName$) IdEmprestimo��* 	  
HeaderText$*  ��+ 	  Width$+ 0Q�, 	  TextAlignment$, Center=�  $) CodEmprestimo��$* CÓDIGO��- 	  MinimumWidth$	- 110Q�$, Center=�0
  *Syncfusion.UI.Xaml.Grid.GridDateTimeColumn
  $) DataCadastro��$
* DATA��$	- 100Q�$, Center=�  $) NomeAtendente��$* 	ATENDENTE��$	- 110Q�$, Center=�0  *Syncfusion.UI.Xaml.Grid.GridCurrencyColumn  $) ValorComissao��$* 	COMISSÃO��$	- 100Q�$, Center=�.   CurrencyGroupSizes. �      /   CurrencyGroupSeparator$/ .��0   CurrencyDecimalSeparator$0 ,��  $) NomeCliente��$
* NOME��$
, Left=�1 	  Padding$1 5 0 2 0q�$	- 350Q�/  )Syncfusion.UI.Xaml.Grid.GridPercentColumn  $
) Taxa��$
* TAXA��2   PercentDecimalDigits$2 1��$, Center=�$	- 100Q�  $) Valor��$* APLICAÇÃO��$	- 100Q�. �      $/ .��$0 ,��$, Center=�  $) 
Vencimento��$* VENCIMENTOS��$
, Left=�'3 	   HorizontalHeaderContentAlignment$
3 Left=�$1 5 0 2 0q��� $ 
Horizontal=�$
��Auto��$��Center=�$��Center=�$��	150 0 0 0q�$ IBeam��.+��� $ 
Horizontal=�$��0 0 0 0q�$��Center=�$
��Left=�.+��� $��
COMISSÕES��$��0 0 0 0q�$��18(�$��Center=�$��Center=�$
��Bold"�
���  ���� -	   $ ComissoesTXT��$��30 0 0 0q�$��18(�$��Center=�$��Center=�$
��Bold"��� $ Vertical=�$��30 0 0 0q�$��Center=�$
��Left=�.+��� $��SOMA COMISSÃO��#��[ /  )Syncfusion.Windows.Shared.CurrencyTextBox  -
   4  Name$4 somaTaxaTextBox��$	��300��$��50��$��20(�$ 5��$��Center=�5 �� 
IsReadOnly$
5 True���� $ Vertical=�$��40 0 0 0q�$��Center=�$
��Left=�.+��� $��SOMA PRODUÇÃO��#��[   -   $4 somaProducaoTextBox��$	��300��$��50��$��20(�$ 5��$��Center=�$
5 True���� $��META MENSAL��$��18(�$��Center=�$	��Top=�$
��Bold"�$��	0 30 0 10q�
���  ���� $ 
Horizontal=�$��Center=�$��0 30 0 0q�.+��� $ Vertical=�$��0��$��2��$��40 0 0 0q�$��Bottom=�$
��Left=�.+��� $
��META��#��[   -   $4 MetaTxt��$	��150��$��50��$��20(�$ 5��$��Center=��� -   $��btCalcularRelatorio��$��40��$��40��$��10 0 0 7q�$
{�True��$ Nova Aplicação��$
 Hand��$��Bottom=�  	AllButton#���  .��F� �������!��- �@KL ��- �`�; ��- ��- `�; ��- @KL ���- ��!���- ��2`�; @o@@KL @o@���!@o@Ӡ�2@o@@o@��2@o@��!�@o@@KL �@o@`�; ��2��- ��!��- ���!��!�@KL ��!�@KL @KL ���!@KL ���!��!���^  ~u � �  ~u � � �a� ���^ �a� ���^  ~u �@]� �� р��� р� ��@]�  ��@]� �� �@]� �j� р��j� р��M� �@]� �M� �@]� �j� � z ���`�� ���`��  $� ��y�  $� ��y� �@� �`�� �@� �`��  �� � z  �� � z �@� р�[ �@� р�[  $� � z  $� � z ��� &�  R� ���� `�� Ѡ� R� р��� �������0@ �� р�`Vl Ѡ���[ ���� @�p � &� ��[ �@]� `Vl � ��  �� �@]� �� � &�  R� 	$��Center=�$��Center=�$��40��$��40��$
 Fill=����� $	 
Foreground�
 �� " ���� $ Vertical=�$��0��$��2��$��40 0 0 0q�$��Bottom=�$
��Left=�.+��� $��% PRODUÇÃO CONCLUÍDA��#��[ .  (Syncfusion.Windows.Shared.PercentTextBox  -   6  Name$6 metaPercentTextBox��$	��200��$��50��$��20(�$ 5��$��Center=�$
5 True���� $ Vertical=�$��0��$��2��$��40 0 0 0q�$��Bottom=�$
��Left=�.+��� $��PRODUÇÃO CONCLUÍDA��#��[   -   $4 naRuaTextBox��$	��200��$��50��$��20(�$ 5��$��Center=�$
5 True���� $ Vertical=�$��0��$��2��$��40 0 0 0q�$��Bottom=�$
��Left=�.+��� $��FALTA P/ META��#��[ 4 
 .Syncfusion.Windows.Controls.Input.SfTextBoxExt  -   7  Name$7 faltaTextBox��$	��350��$��50��$��20(�$��	INICIANDO��$��Center=�$
5 True��$��Center=��� $��REFINANCIAMENTO��$��18(�$��Center=�$	��Top=�$
��Bold"�$��	0 30 0 10q�
���  ���� $ 
Horizontal=�$��Center=�$��0 30 0 0q�.+��� $ Vertical=�$��10 0 0 0q�$��Bottom=�$
��Left=�.+��� $��A REFINANCIAR��#��[   -   $4 aRefiTextBox��$	��200��$��50��$��20(�$ 5��$��Center=�$
5 True���� $ Vertical=�$��10 0 0 0q�$��Bottom=�$
��Left=�.+��� $��REFINANCIADO��#��[   -   $4 refinanciadoTextBox��$	��200��$��50��$��20(�$ 5��$��Center=�$
5 True���� $ Vertical=�$��0��$��2��$��10 0 0 0q�$��Bottom=�$
��Left=�.+��� $��COMPLEMENTO��#��[   -   $4 complementoTextBox��$	��200��$��50��$��20(�$ 5��$��Center=�$
5 True���� $ Vertical=�$��0��$��2��$��10 0 0 0q�$��Bottom=�$
��Left=�.+��� $��ESTATÍSTICAS��#��[   -   $7 clientesRefiTextBox��$��xxxxx��$	��450��$��50��$��20(�$��Center=�$
5 True��$��Center=��� $��FLUXO DE CAIXA��$��18(�$��Center=�$	��Top=�$
��Bold"�$��	0 30 0 10q�
���  ���� $ 
Horizontal=�$��Center=�$��0 10 0 0q�.+��� $ Vertical=�$��0��$��2��$��10 0 0 0q�$��Bottom=�$
��Left=�.+��� $��RECEBIMENTO MENSAL��#��[   -   $4 entradaAplicacaoTextBox��$	��200��$��50��$��20(�$ 5��$��Center=�$
5 True���� $ Vertical=�$��0��$��2��$��10 0 0 0q�$��Bottom=�$
��Left=�.+��� $��SAIDAS APLICAÇÂO��#��[   -   $4 saidaAplicacaoTextBox��$	��200��$��50��$��20(�$ 5��$��Center=�$
5 True���� $ Vertical=�$��0��$��2��$��10 0 0 0q�$��Bottom=�$
��Left=�.+��� $��DESPESAS��#��[   -   $4 despesaTextBox��$	��200��$��50��$��20(�$ 5��$��Center=�
����  ��� $ Vertical=�$��0��$��2��$��10 0 0 0q�$��Bottom=�$
��Left=�.+��� $��A VENCER��#��[   -   $4 AVencerTextBox��$	��200��$��50��$��20(�$ 5��$��Center=�$
5 True���� $ Vertical=�$��0��$��2��$��10 0 0 0q�$��Bottom=�$
��Left=�.+��� $��	ATRAZADOS��#��[   -   $4 atrazadoTextBox��$	��200��$��50��$��20(�$ 5��$��Center=�$
5 True���� $ 
Horizontal=�$��Center=�$��100 10 0 20q�.+��� $ Vertical=�$��0��$��2��$��10 0 0 0q�$��Bottom=�$
��Left=�.+��� $��RESULTADO ESPERADO��#��[   -   $4 reEsperadoTextBox��$	��250��$��50��$��20(�$ 5��$��Center=�$
5 True���� $ Vertical=�$��0��$��2��$��30 0 0 0q�$��Bottom=�$
��Left=�.+��� $��RESULTADO ATUAL��#��[   -   $4 reAtualTextBox��$	��250��$��50��$��20(�$ 5��$��Center=�$
5 True���� -   8 ��Name$8 lstAnos��$��	0 10 0 60q�$��Bottom=�$��Center=� �� $��Selecione o Mês������ .R�$� 9 K� IsItemsHost$
9 True��: $� Orientation$: 
Horizontal=�.@��� $��10 2 0 2q�.��#  MaterialDesignThemes.Wpf.Chip  $	��JAN��${�False��  PrimaryHueDarkBrush;   IconBackground#; �   ! PrimaryHueDarkForegroundBrush<   IconForeground#< �  =   Icon= '  !MaterialDesignThemes.Wpf.PackIcon  >   Kind$> AlphabetJCircle=��� $��10 2 0 2q�.��  $	��FEV��${�False��#; �  #< �  =   $> AlphabetFCircle=��� $��10 2 0 2q�.��  $	��MAR��${�False��#; �  #< �  =   $> AlphabetMCircle=��� $��10 2 0 2q�.��  $	��ABR��${�False��#; �  #< �  =   $> AlphabetACircle=��� $��10 2 0 2q�.��  $	��MAI��${�False��#; �  #< �  =   $> AlphabetMCircle=��� $��10 2 0 2q�.��  $	��JUN��${�False��#; �  #< �  =   $> AlphabetJCircle=��� $��10 2 0 2q�.��  $	��JUL��${�False��#; �  #< �  =   $> AlphabetJCircle=��� $��10 2 0 2q�.��  $	��AGO��${�False��#; �  #< �  =   $> AlphabetACircle=��� $��10 2 0 2q�.��  $	��SET��${�False��#; �  #< �  =   $> AlphabetSCircle=��� $��10 2 0 2q�.��  $	��OUT��${�False��#; �  #< �  =   $> AlphabetOCircle=��� $��10 2 0 2q�.��  $	��NOV��${�False��#; �  #< �  =   $> AlphabetNCircle=��� $��10 2 0 2q�.��  $	��DEZ��${�False��#; �  #< �  =   $> AlphabetDCircle=�