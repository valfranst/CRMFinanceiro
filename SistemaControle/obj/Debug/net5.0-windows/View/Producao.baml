   M S B A M L   `   `   `  ����J  FSistemaControle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SistemaControle.ViewSistemaControle.View  5      =#clr-namespace:SistemaControle.ModelSistemaControle.Model  5      #    SistemaControle.View.Producao   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:SistemaControle.View     5      6local2#clr-namespace:SistemaControle.Model     5      h dSyncfusion.SfSkinManager.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89l hSyncfusion.SfTextInputLayout.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89` \Syncfusion.Tools.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89f	 bSyncfusion.SfAccordion.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b
 ^Syncfusion.SfInput.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89m iSyncfusion.SfNavigationDrawer.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89@
syncfusion!http://schemas.syncfusion.com/wpf    	 
    5
      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        $	��660��5      $
��1090��6/     � 	Resources  5      +  %SistemaControle.View.RowStyleProducao   rowStyle3  -Syncfusion.UI.Xaml.Grid.GridHeaderCellControl �� 
TargetType  headerStyle �� Property �� Value  	descricao��%�  &	        &	      &	 �       5   
   6!   �� 5   
   "  6   .�5      ��  � ��
 �   �6+   �� 5       � ��$
 Bold"�6+   5      �� 5   
   " ��6"   .�5      ��  � ��$ 15(�6)   �� 5       � ��$ Segoe UI)�6+   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ Center=�62   �� 5       � ��$ Center=�64   5      5       .��5"      � -   5         �Name$ MainProducao��5"      $
��1090��6"   $	��620��62   $��0 0 0 0q�6B   $��Center=�6S   $	��Top=�6p   .+�5$   
   ��  �� Orientation$ 
Horizontal=�6   $	��Top=�6.   $
��Left=�6F   $��	10 10 0 0q�6a   .+�5'      �� -   5        $��btMenos��5'      $��30��6$   $��30��6/   $��	30 0 10 0q�6;   $
{�True��6N    � ToolTip$ Ficha do Clientes��6_    � Cursor$
 Hand��6{    , (MaterialDesignFloatingActionAccentButton#��[ 6�   .��5(      �� $ Vertical=�6   .+�5)      F� �������j  � � � ��j � � ��� � $� ��� � $� ��� � � ��� � � @f���j  � �@o@@KL �@o@��!���!@o@��� �� �@KL @o@���- ��!��� �� ���- @KL �@KL ��- ��� �� ���!��- �@o@@KL ��� �� ���!@KL �@KL @KL �@KL ��!���!��!���!@KL 	$��Center=�5+      $��Center=�6<   $��20��6W   $��20��6c    �� Stretch$
 Fill=�6n   ��5*      �� 	 �� Path$	 
Foreground�
 �� RelativeSource
 ��  �� AncestorType" ��5+   n   5,      5-      .  (Syncfusion.Windows.Shared.IntegerTextBox  5/      -   5          Name$ AnoTxt��5/   (   $	��100��68   $��30��6D   $��20(�6P   *  $Syncfusion.Windows.Shared.EditorBase   CornerRadius$ 5��6^   $��2q�6o   $��Center=�6�      GroupSeperatorEnabled$ False��6�   $��Center=�50      $��Center=�63      MinValue$ 1��6o      MaxValue$
 9999��6|   $ Digite o Ano desejado��6�   ${�False��6�      UseNullOption$
 True��51         	NullValue 6'   Z� �� 53      -   5        $��btMais��53      $��30��6#   $��30��6.   $��10 0 0 0q�6:   $
{�True��6L   $ Nova Aplicação��6]   $
 Hand��6v   #��[ 6�   .��54      �� $ Vertical=�6   .+�55      F� �����@f � � � @f� � ��� � z ��� � z ��� � � ��� � � ��j �@f � ���- ��!���- @KL �@KL ��- ��� �� ���!��- �@o@@KL ��� �� �@o@��!���!@o@��� �� �@KL @o@���- ��!��� �� �@KL ��!���!��!���!@KL �@KL @KL �@KL ��!	$��Center=�57      $��Center=�6<   $��20��6W   $��20��6c   $
 Fill=�6n   ��56      �� $	 
Foreground�
 �� " ��57   n   58      59      �� 5;      -   5         ��Name$ Titulo��5;      $��PRODUÇÃO MENSAL��6$   $��22(�6>   $
��Bold"�6L   $��	200 0 0 0q�6^   $��40��6q   5=      �� 5@   
   -   5         ��Name$ MainScrollViewer��5@      $��Disabled=�61   $��Visible=�6Z   $
��1100��6�   $
��auto��6�   $��0 50 10 110q�6�   $	��Top=�6�   $��Center=�6�   $��0 0 10 0q�6�   .��5A      �� $ Vertical=�6   $��Center=�61   .+�5D      (  "Syncfusion.UI.Xaml.Grid.SfDataGrid  -   5          Name$$ view_ClienteEmprestimoDataGrid��5D   (   $��Visible=�6P   $��Visible=�6�   (  "Syncfusion.UI.Xaml.Grid.SfGridBase   	RowHeight$ 40Q�5E   (      ColumnSizer$ SizeToCells=�67   $��10 15 10 10q�6Q   $��14(�6f   $��0 0 5 5q�6t   $��16)�6�      HeaderStyle# [ 5F   !      RowStyleSelector# [  5G   !   $
��1000��5H   !   $
��auto��61   $	��Top=�6?   $
��Left=�6W   $��Center=�5I   !      AllowEditing$ False��6C      FrozenColumnCount$ 1��5J   !      
IsReadOnly$
 True��5K   !      NavigationMode$	 Row=�5L   !      SelectionUnit$	 Row=�5M   !      SelectionMode$ Single=�5N   !       LiveDataUpdateMode$  AllowDataShaping=�5O   !   !   EditTrigger$! OnTap=�5Q   !   "   AutoGenerateColumns$" False��5R   !   #   
SourceType0   *SistemaControle.Model.ViewAplicacaoCliente"#  5T   N   $   SelectedItem$ 5S   !   �� *SelectedItem+% �� Mode$% TwoWay=�& �� UpdateSourceTrigger$& PropertyChanged=�'   ItemsSource' 5T   !   �� *ViewAplicacaoCliente+(   Columns( 5Y      ,  &Syncfusion.UI.Xaml.Grid.GridTextColumn  ,	  &Syncfusion.UI.Xaml.Grid.GridColumnBase) 	  MappingName$) IdEmprestimo��64   * 	  
HeaderText$*  ��6O   + 	  Width$+ 0Q�6]   , 	  TextAlignment$, Center=�6g     5Z      $) CodEmprestimo��64   $* CÓDIGO��6P   - 	  MinimumWidth$	- 110Q�6d   $, Center=�6w   0
  *Syncfusion.UI.Xaml.Grid.GridDateTimeColumn
  5[      $) DataCadastro��68   $
* DATA��6S   $	- 100Q�6e   $, Center=�6x     5\      $) NomeAtendente��64   $* 	ATENDENTE��6P   $	- 110Q�6g   $, Center=�6z   0  *Syncfusion.UI.Xaml.Grid.GridCurrencyColumn  5]      $) ValorComissao��69   $* 	COMISSÃO��6U   $	- 100Q�6k   $, Center=�6~   .   CurrencyGroupSizes. �      /   CurrencyGroupSeparator$/ .��6�   0   CurrencyDecimalSeparator$0 ,��6�     5^      $) NomeCliente��64   $
* NOME��6N   $
, Left=�6`   1 	  Padding$1 5 0 2 0q�6u   $	- 350Q�6�   /  )Syncfusion.UI.Xaml.Grid.GridPercentColumn  5_      $
) Taxa��68   $
* TAXA��6K   2   PercentDecimalDigits$2 1��6]   $, Center=�6v   $	- 100Q�6�     5`      $) Valor��69   $* APLICAÇÃO��6M   $	- 100Q�6e   . �      $/ .��6�   $0 ,��6�   $, Center=�6�     5a      $) 
Vencimento��64   $* VENCIMENTOS��6M   $
, Left=�6f   '3 	   HorizontalHeaderContentAlignment$
3 Left=�6{   $1 5 0 2 0q�6�   5e      �� 5h      $ 
Horizontal=�6   $
��Auto��66   $��Center=�6D   $��Center=�6a   $��	150 0 0 0q�6|   $ IBeam��6�   .+�5k      �� $ 
Horizontal=�6!   $��0 0 0 0q�6;   $��Center=�6L   $
��Left=�6g   .+�5l      �� $��
COMISSÕES��6    $��0 0 0 0q�64   $��18(�6E   $��Center=�6S   $��Center=�6p   $
��Bold"�6�   
���  ��6�   �� 5m      -	   5        $ ComissoesTXT��5m       $��30 0 0 0q�66   $��18(�6H   $��Center=�6V   $��Center=�6s   $
��Bold"�6�   5n      �� 5q      $ Vertical=�6!   $��30 0 0 0q�69   $��Center=�6K   $
��Left=�6f   .+�5r      �� $��SOMA COMISSÃO��6    #��[ 68   /  )Syncfusion.Windows.Shared.CurrencyTextBox  5s      -
   5        4  Name$4 somaTaxaTextBox��5s   5   $	��300��6N   $��50��6Z   $��20(�6f   $ 5��6t   $��Center=�6�   5 �� 
IsReadOnly$
5 True��6�   5t      �� 5w      $ Vertical=�6!   $��40 0 0 0q�69   $��Center=�6K   $
��Left=�6f   .+�5x      �� $��SOMA PRODUÇÃO��6    #��[ 68     5y      -   5        $4 somaProducaoTextBox��5y   5   $	��300��6R   $��50��6^   $��20(�6j   $ 5��6x   $��Center=�6�   $
5 True��6�   5z      5{      �� 5      $��META MENSAL��6   $��18(�6.   $��Center=�6<   $	��Top=�6Y   $
��Bold"�6q   $��	0 30 0 10q�6�   
���  ��6�   �� 5�      $ 
Horizontal=�6   $��Center=�66   $��0 30 0 0q�6S   .+�5�      �� $ Vertical=�6!   $��0��68   $��2��6E   $��40 0 0 0q�6U   $��Bottom=�6g   $
��Left=�6�   .+�5�      �� $
��META��6    #��[ 6/     5�      -   5        $4 MetaTxt��5�   5   $	��150��6F   $��50��6R   $��20(�6^   $ 5��6l   $��Center=�6~   5�      �� 5�      -   5        $��btCalcularRelatorio��5�      $��40��68   $��40��6C   $��10 0 0 7q�6O   $
{�True��6a   $ Nova Aplicação��6r   $
 Hand��6�   $��Bottom=�6�     	AllButton#���  6�   .��5�      F� �������!��- �@KL ��- �`�; ��- ��- `�; ��- @KL ���- ��!���- ��2`�; @o@@KL @o@���!@o@Ӡ�2@o@@o@��2@o@��!�@o@@KL �@o@`�; ��2��- ��!��- ���!��!�@KL ��!�@KL @KL ���!@KL ���!��!���^  ~u � �  ~u � � �a� ���^ �a� ���^  ~u �@]� �� р��� р� ��@]�  ��@]� �� �@]� �j� р��j� р��M� �@]� �M� �@]� �j� � z ���`�� ���`��  $� ��y�  $� ��y� �@� �`�� �@� �`��  �� � z  �� � z �@� р�[ �@� р�[  $� � z  $� � z ��� &�  R� ���� `�� Ѡ� R� р��� �������0@ �� р�`Vl Ѡ���[ ���� @�p � &� ��[ �@]� `Vl � ��  �� �@]� �� � &�  R� 	$��Center=�5�      $��Center=�6<   $��40��6W   $��40��6c   $
 Fill=�6n   ��5�      �� $	 
Foreground�
 �� " ��5�   n   5�      �� 5�      $ Vertical=�6!   $��0��68   $��2��6E   $��40 0 0 0q�6U   $��Bottom=�6g   $
��Left=�6�   .+�5�      �� $��% PRODUÇÃO CONCLUÍDA��6    #��[ 6?   .  (Syncfusion.Windows.Shared.PercentTextBox  5�      -   5        6  Name$6 metaPercentTextBox��5�   4   $	��200��6P   $��50��6\   $��20(�6h   $ 5��6v   $��Center=�6�   $
5 True��6�   5�      �� 5�      $ Vertical=�6!   $��0��68   $��2��6E   $��40 0 0 0q�6U   $��Bottom=�6g   $
��Left=�6�   .+�5�      �� $��PRODUÇÃO CONCLUÍDA��6    #��[ 6=     5�      -   5        $4 naRuaTextBox��5�   5   $	��200��6K   $��50��6W   $��20(�6c   $ 5��6q   $��Center=�6�   $
5 True��6�   5�      �� 5�      $ Vertical=�6!   $��0��68   $��2��6E   $��40 0 0 0q�6U   $��Bottom=�6g   $
��Left=�6�   .+�5�      �� $��FALTA P/ META��6    #��[ 68   4 
 .Syncfusion.Windows.Controls.Input.SfTextBoxExt  5�      -   5        7  Name$7 faltaTextBox��5�   2   $	��350��6H   $��50��6T   $��20(�6`   $��	INICIANDO��6n   $��Center=�6   $
5 True��6�   $��Center=�6�   5�      5�      �� 5�      $��REFINANCIAMENTO��6   $��18(�62   $��Center=�6@   $	��Top=�6]   $
��Bold"�6u   $��	0 30 0 10q�6�   
���  ��6�   �� 5�      $ 
Horizontal=�6   $��Center=�66   $��0 30 0 0q�6S   .+�5�      �� $ Vertical=�6!   $��10 0 0 0q�68   $��Bottom=�6J   $
��Left=�6e   .+�5�      �� $��A REFINANCIAR��6    #��[ 68     5�      -   5        $4 aRefiTextBox��5�   5   $	��200��6K   $��50��6W   $��20(�6c   $ 5��6q   $��Center=�6�   $
5 True��6�   5�      �� 5�      $ Vertical=�6!   $��10 0 0 0q�68   $��Bottom=�6J   $
��Left=�6e   .+�5�      �� $��REFINANCIADO��6    #��[ 67     5�      -   5        $4 refinanciadoTextBox��5�   5   $	��200��6R   $��50��6^   $��20(�6j   $ 5��6x   $��Center=�6�   $
5 True��6�   5�      �� 5�      $ Vertical=�6!   $��0��68   $��2��6E   $��10 0 0 0q�6U   $��Bottom=�6g   $
��Left=�6�   .+�5�      �� $��COMPLEMENTO��6    #��[ 66     5�      -   5        $4 complementoTextBox��5�   5   $	��200��6Q   $��50��6]   $��20(�6i   $ 5��6w   $��Center=�6�   $
5 True��6�   5�      �� 5�      $ Vertical=�6!   $��0��68   $��2��6E   $��10 0 0 0q�6U   $��Bottom=�6g   $
��Left=�6�   .+�5�      �� $��ESTATÍSTICAS��6    #��[ 67     5�      -   5        $7 clientesRefiTextBox��5�   2   $��xxxxx��6O   $	��450��6\   $��50��6h   $��20(�6t   $��Center=�6�   $
5 True��6�   $��Center=�6�   5�      5�      �� 5�      $��FLUXO DE CAIXA��6   $��18(�61   $��Center=�6?   $	��Top=�6\   $
��Bold"�6t   $��	0 30 0 10q�6�   
���  ��6�   �� 5�      $ 
Horizontal=�6   $��Center=�66   $��0 10 0 0q�6S   .+�5�      �� $ Vertical=�6!   $��0��68   $��2��6E   $��10 0 0 0q�6U   $��Bottom=�6g   $
��Left=�6�   .+�5�      �� $��RECEBIMENTO MENSAL��6    #��[ 6=     5�      -   5        $4 entradaAplicacaoTextBox��5�   5   $	��200��6V   $��50��6b   $��20(�6n   $ 5��6|   $��Center=�6�   $
5 True��6�   5�      �� 5�      $ Vertical=�6!   $��0��68   $��2��6E   $��10 0 0 0q�6U   $��Bottom=�6g   $
��Left=�6�   .+�5�      �� $��SAIDAS APLICAÇÂO��6    #��[ 6;     5�      -   5        $4 saidaAplicacaoTextBox��5�   5   $	��200��6T   $��50��6`   $��20(�6l   $ 5��6z   $��Center=�6�   $
5 True��6�   5�      �� 5�      $ Vertical=�6!   $��0��68   $��2��6E   $��10 0 0 0q�6U   $��Bottom=�6g   $
��Left=�6�   .+�5�      �� $��DESPESAS��6    #��[ 63     5�      -   5        $4 despesaTextBox��5�   5   $	��200��6M   $��50��6Y   $��20(�6e   $ 5��6s   $��Center=�6�   
����  �6�   5�      �� 5�      $ Vertical=�6!   $��0��68   $��2��6E   $��10 0 0 0q�6U   $��Bottom=�6g   $
��Left=�6�   .+�5�      �� $��A VENCER��6    #��[ 63     5�      -   5        $4 AVencerTextBox��5�   5   $	��200��6M   $��50��6Y   $��20(�6e   $ 5��6s   $��Center=�6�   $
5 True��6�   5�      �� 5�      $ Vertical=�6!   $��0��68   $��2��6E   $��10 0 0 0q�6U   $��Bottom=�6g   $
��Left=�6�   .+�5�      �� $��	ATRAZADOS��6    #��[ 64     5�      -   5        $4 atrazadoTextBox��5�   5   $	��200��6N   $��50��6Z   $��20(�6f   $ 5��6t   $��Center=�6�   $
5 True��6�   5�      5�      �� 5�      $ 
Horizontal=�6   $��Center=�66   $��100 10 0 20q�6S   .+�5�      �� $ Vertical=�6!   $��0��68   $��2��6E   $��10 0 0 0q�6U   $��Bottom=�6g   $
��Left=�6�   .+�5�      �� $��RESULTADO ESPERADO��6    #��[ 6=     5�      -   5        $4 reEsperadoTextBox��5�   5   $	��250��6P   $��50��6\   $��20(�6h   $ 5��6v   $��Center=�6�   $
5 True��6�   5�      �� 5�      $ Vertical=�6!   $��0��68   $��2��6E   $��30 0 0 0q�6U   $��Bottom=�6g   $
��Left=�6�   .+�5�      �� $��RESULTADO ATUAL��6    #��[ 6:     5�      -   5        $4 reAtualTextBox��5�   5   $	��250��6M   $��50��6Y   $��20(�6e   $ 5��6s   $��Center=�6�   $
5 True��6�   5�      5�      5�      5�      �� 5   
   -   5        8 ��Name$8 lstAnos��5      $��	0 10 0 60q�6#   $��Bottom=�66   $��Center=�6Q    5     �� 5     $��Selecione o Mês��6   ��5     �� 5     .R�5     $� 9 K� IsItemsHost$
9 True��6-   : $� Orientation$: 
Horizontal=�6@   5     .@�5
     �� $��10 2 0 2q�6   .��5     #  MaterialDesignThemes.Wpf.Chip  $	��JAN��6'   ${�False��65     PrimaryHueDarkBrush;   IconBackground#; �  6G    ! PrimaryHueDarkForegroundBrush<   IconForeground#< �  6~   =   Icon= 5     '  !MaterialDesignThemes.Wpf.PackIcon  5     >   Kind$> AlphabetJCircle=�62   5     5     �� 5     $��10 2 0 2q�6   .��5       $	��FEV��6&   ${�False��64   #; �  6F   #< �  6}   = 5       5     $> AlphabetFCircle=�62   5     5     �� 5     $��10 2 0 2q�6   .��5       $	��MAR��6&   ${�False��64   #; �  6F   #< �  6}   = 5       5     $> AlphabetMCircle=�62   5     5     �� 5     $��10 2 0 2q�6   .��5        $	��ABR��6&   ${�False��64   #; �  6F   #< �  6}   = 5!       5"     $> AlphabetACircle=�62   5$     5%     �� 5&     $��10 2 0 2q�6   .��5'       $	��MAI��6&   ${�False��64   #; �  6F   #< �  6}   = 5(       5)     $> AlphabetMCircle=�62   5+     5,     �� 5-     $��10 2 0 2q�6   .��5.       $	��JUN��6&   ${�False��64   #; �  6F   #< �  6}   = 5/       50     $> AlphabetJCircle=�62   52     53     �� 54     $��10 2 0 2q�6   .��55       $	��JUL��6&   ${�False��64   #; �  6F   #< �  6}   = 56       57     $> AlphabetJCircle=�62   59     5:     �� 5;     $��10 2 0 2q�6   .��5<       $	��AGO��6&   ${�False��64   #; �  6F   #< �  6}   = 5=       5>     $> AlphabetACircle=�62   5@     5A     �� 5B     $��10 2 0 2q�6   .��5C       $	��SET��6&   ${�False��64   #; �  6F   #< �  6}   = 5D       5E     $> AlphabetSCircle=�62   5G     5H     �� 5I     $��10 2 0 2q�6   .��5J       $	��OUT��6&   ${�False��64   #; �  6F   #< �  6}   = 5K       5L     $> AlphabetOCircle=�62   5N     5O     �� 5P     $��10 2 0 2q�6   .��5Q       $	��NOV��6&   ${�False��64   #; �  6F   #< �  6}   = 5R       5S     $> AlphabetNCircle=�62   5U     5V     �� 5W     $��10 2 0 2q�6   .��5X       $	��DEZ��6&   ${�False��64   #; �  6F   #< �  6}   = 5Y       5Z     $> AlphabetDCircle=�62   5\     5]     5_     5b     5c     