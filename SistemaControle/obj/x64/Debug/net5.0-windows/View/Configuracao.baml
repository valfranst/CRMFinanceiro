   M S B A M L   `   `   `  ����J  FSistemaControle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SistemaControle.ViewSistemaControle.View  5	      h dSyncfusion.SfSkinManager.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89iLclr-namespace:Syncfusion.SfSkinManager;assembly=Syncfusion.SfSkinManager.WPFSyncfusion.SfSkinManager 5      '    !SistemaControle.View.Configuracao   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      l hSyncfusion.SfTextInputLayout.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89` \Syncfusion.Tools.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89f	 bSyncfusion.SfAccordion.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b
 ^Syncfusion.SfInput.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89m iSyncfusion.SfNavigationDrawer.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89@
syncfusion!http://schemas.syncfusion.com/wpf    	 
    5      <local"clr-namespace:SistemaControle.View    	 
    5	      lskinManagerLclr-namespace:Syncfusion.SfSkinManager;assembly=Syncfusion.SfSkinManager.WPF    	 
    5      -   5        $	��660��5
      $
��1090��6/   ,  &Syncfusion.SfSkinManager.SfSkinManager    VisualStyle  5      ��  �� ElementName$ stylesComboBox�� �� Path$ SelectedValue� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� � 	Resources 5         
TituloText �� 
TargetType �� Property �� Value  SubTituloText  InfoText  MsgText��%�  &	        &	 �     &	 ]    &	 �    �� 5   
   " ��6#   .�5      ��  � ��$ 34(�6)   �� 5       � ��$ Segoe UI)�6+   �� 5       � ��$
 Bold"�6+   �� 5       � �� �#5151516+   5      �� 5   
   " ��6&   .�5      ��  � ��$ 24(�6)   �� 5       � ��$ Segoe UI)�6+   �� 5       � ��$ Regular"�6+   5      �� 5   
   " ��6!   .�5      ��  � ��$ 18(�6)   �� 5       � ��$ Segoe UI)�6+   �� 5       � ��$ Regular"�6+   5       �� 5!   
   " ��6    .�5"      ��  � ��$ 12(�6)   �� 5#       � ��$ Segoe UI)�6+   �� 5$       � ��$ Regular"�6+   5%      5&      .��5(      �� $��0 0 0 70q�6   .��5)      � 	 � RowDefinitions	 5*   
   �� 5+      $
��Auto �6   �� 5,      $
��Auto �6   �� 5-      $
��Auto �6   �� 5.      $
��Auto �6   �� 5/      $
��Auto �6   �� 50      $
��Auto �6   
 � ColumnDefinitions
 52   
   �� 53      $��3* �6   �� 54      $��2* �6   .+�57   
   6  0Syncfusion.Windows.Tools.Controls.LabelTextBlock  $��CONFIGURAÇÕES��6$   $��0��69   $��0��6I   $��2��6V   #��[  6j   $��Center=�58      $��Center=�6(   $��0 5 0 10q�6E   �� 5:   
   $��0��6   $��1��6"   ���#B2B2B2$��2q�6E   $��0 0 0 0q�6Y   ._�5;      �� $��Center=�6   $��Center=�6:    �� Orientation$ Vertical=�6U   .+�5<      �� -   5         ��Name$ 	txtSOInfo��5<       $��Center=�63   $��Center=�6P   
��� � �#��[ 6~   $��
WINDOWS 10��6�   �� 5=      -   5        $ txtSOStatus��5=       $��Center=�65   $��Center=�6R   #��[ 6m   $��Sucesso��6�   �� 5>      -   5        $ txtSOMsg��5>      $��Center=�6.   $��Center=�6K   #��[ 6f   $,��&Versão do Windows adequada  programa.��6�   5?      5@      �� 5B   
   $��0��6   $��2��6"   ���#B2B2B2$��2q�6E   $��0 10 0 0q�6Y   ._�5C      �� $��Center=�6   $��Center=�66   $ Vertical=�6Q   .+�5D      �� -   5        $ 
txtSQLInfo��5D      $��Center=�60   $��Center=�6M   
��� � �#��[ 6{   $��
LocalDB 14��6�   �� 5E      -   5        $ txtSQLStatus��5E      $��Center=�62   $��Center=�6O   #��[ 6j   $��Sucesso��6�   �� 5F      -   5        $ 	txtSQLMsg��5F      $��Center=�6/   $��Center=�6L   #��[ 6g   $C��=A versão do SQLLocalDB é adequado a utilização do Progama��6�   5G      5H      �� 5I   
   $��0��6   $��3��6"   ���#B2B2B2$��2q�6E   $��0 10 0 0q�6Y   ._�5J      �� $��Center=�6   $��Center=�66   $ Vertical=�6Q   .+�5K      �� -   5        $ 
txtNETInfo��5K      $��Center=�60   $��Center=�6M   
��� � �#��[ 6{   $��.NET Framework 4.5��6�   �� 5L      -	   5        $ txtNETStatus��5L      $��Center=�62   $��Center=�6O   #��[ 6j   $��Sucesso��6�   �� 5M      -
   5        $ 	txtNETMsg��5M      $��Center=�6/   $��Center=�6L   #��[ 6g   $F��@A versão do .Net Frameork é adequada a utilização do Progama��6�   5N      5O      �� 5Q   
   $��0��6   $��4��6"   ���#B2B2B2$��2q�6E   $��0 10 0 0q�6Y   ._�5R      �� $��Center=�6   $��Center=�66   $ Vertical=�6Q   .+�5S      �� -   5        $ txtRESOLUCAOInfo��5S      $��Center=�66   $��Center=�6S   
��� � �#��[ 6�   $��Resolução da Tela��6�   �� 5T      -   5        $ txtRESOLUCAOStatus��5T      $��Center=�68   $��Center=�6U   #��[ 6p   $��Sucesso��6�   �� 5U      -   5        $ txtRESOLUCAOMsg��5U      $��Center=�65   $��Center=�6R   #��[ 6m   $2��,A Resolução da tela é adequada ao Sistema��6�   5V      5W      �� 5Y   
   $��0��6   $��5��6"   ���#B2B2B2$��2q�6E   $��0 10 0 0q�6Y   ._�5Z      �� $
��Left=�6   $��Center=�64   $ Vertical=�6O   .+�5[      �� -   5        $ txtLocal��5[      #��[ 65   
��� � �$��RAIZ: G:\Aplicativo��6k   �� 5\      -   5        $ txtLocalBanco��5\      #��[ 65   
��� � �$ ��BANCO: G:\Aplicativo\Banco��6j   �� 5]      -   5        $ txtLocalImagem��5]      #��[ 65   
��� � �$$��IMAGEMS: G:\Aplicativo\Imagens��6j   �� 5^      -   5        $ txtLocalImagemTemp��5^      #��[ 69   
��� � �$)��#IMAGEMS TEMP: G:\Aplicativo\Imagens��6n   �� 5_      -   5        $ txtDBConexao��5_      $
��Wrap=�62   $��	0 10 0 10q�6F   #��[ 6Y   
��� � �$����Connection: Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Aplicativo\Banco\Represa03.mdf;Integrated Security=True;Connect Timeout=30��6�   �� 5`      -   5        $ txtDBTamanho��5`      #��[ 65   
��� � �$+��%Tamanho arquivo Banco de Dados:  8 MB��6i   �� 5a      -   5        $ txtLOGTamanho��5a      #��[ 66   
��� � �$/��)Tamanho arquivo LOG Banco de Dados:  8 MB��6j   �� 5b      -   5        $ txtPastaTamanho��5b      #��[ 68   
��� � �$(��"Tamanho da Pasta do SISTEMA: 60 MB��6l   �� 5c      -   5        $ txtImagemTamanho��5c      #��[ 69   
��� � �$(��"Quantidade de imagem salvas:   651��6m   5d      5e      �� 5m   
   $��1��6   $��2��6"   ���#B2B2B2$��2q�6E   $��	10 10 0 0q�6Y    �� Padding$ 5q�6l   $��3��6x   $��Center=�6�   $��Center=�6�   ._�5n      �� $ Vertical=�6   .+�5o      �� #��[ 6   
��� � �$
��Wrap=�6W   $��ÚLTIMAS ATUALIZAÇÕES��6k   �� 5q      -   5        $ 
txtCliente��5q      #��[ 60   $��0 15 0 0q�6R   $
��Wrap=�6d   
��� � �$��CLIENTES =>��6�   �� 5s      -   5        $ txtEmprestimo��5s      #��[ 63   $��0 15 0 0q�6U   $
��Wrap=�6g   
��� � �$��APLICAÇÕES =>��6�   �� 5u      -   5        $ txtClienteCount��5u      #��[ 65   $��0 15 0 0q�6W   $
��Wrap=�6i   
��� � �$��CLIENTES CADASTRADOS:��6�   5v      5w      5|      5}      5      