   M S B A M L   `   `   `  ���� J  FSistemaControle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SistemaControle.ViewSistemaControle.View  h dSyncfusion.SfSkinManager.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89iLclr-namespace:Syncfusion.SfSkinManager;assembly=Syncfusion.SfSkinManager.WPFSyncfusion.SfSkinManager '    !SistemaControle.View.Configuracao   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     l hSyncfusion.SfTextInputLayout.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89` \Syncfusion.Tools.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89f	 bSyncfusion.SfAccordion.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b
 ^Syncfusion.SfInput.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89m iSyncfusion.SfNavigationDrawer.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89@
syncfusion!http://schemas.syncfusion.com/wpf    	 
    <local"clr-namespace:SistemaControle.View    	 
    lskinManagerLclr-namespace:Syncfusion.SfSkinManager;assembly=Syncfusion.SfSkinManager.WPF    	 
    -   $	��660��$
��1090��,  &Syncfusion.SfSkinManager.SfSkinManager    VisualStyle  ��  �� ElementName$ stylesComboBox�� �� Path$ SelectedValue� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� � 	Resources    
TituloText �� 
TargetType �� Property �� Value  SubTituloText  InfoText  MsgText��%�  &	        &	 s     &	 �     &	 '    �� " ��.���  � ��$ 34(���  � ��$ Segoe UI)���  � ��$
 Bold"���  � �� �#515151�� " ��.���  � ��$ 24(���  � ��$ Segoe UI)���  � ��$ Regular"��� " ��.���  � ��$ 18(���  � ��$ Segoe UI)���  � ��$ Regular"��� " ��.���  � ��$ 12(���  � ��$ Segoe UI)���  � ��$ Regular"�.���� $��0 0 0 70q�.��� 	 � RowDefinitions	 �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �
 � ColumnDefinitions
 �� $��3* ��� $��2* �.+�6  0Syncfusion.Windows.Tools.Controls.LabelTextBlock  $��CONFIGURAÇÕES��$��0��$��0��$��2��#��[  $��Center=�$��Center=�$��0 5 0 10q��� $��0��$��1�����#B2B2B2$��2q�$��0 0 0 0q�._��� $��Center=�$��Center=� �� Orientation$ Vertical=�.+��� -    ��Name$ 	txtSOInfo��$��Center=�$��Center=�
��� � �#��[ $��
WINDOWS 10���� -   $ txtSOStatus��$��Center=�$��Center=�#��[ $��Sucesso���� -   $ txtSOMsg��$��Center=�$��Center=�#��[ $,��&Versão do Windows adequada  programa.���� $��0��$��2�����#B2B2B2$��2q�$��0 10 0 0q�._��� $��Center=�$��Center=�$ Vertical=�.+��� -   $ 
txtSQLInfo��$��Center=�$��Center=�
��� � �#��[ $��
LocalDB 14���� -   $ txtSQLStatus��$��Center=�$��Center=�#��[ $��Sucesso���� -   $ 	txtSQLMsg��$��Center=�$��Center=�#��[ $C��=A versão do SQLLocalDB é adequado a utilização do Progama���� $��0��$��3�����#B2B2B2$��2q�$��0 10 0 0q�._��� $��Center=�$��Center=�$ Vertical=�.+��� -   $ 
txtNETInfo��$��Center=�$��Center=�
��� � �#��[ $��.NET Framework 4.5���� -	   $ txtNETStatus��$��Center=�$��Center=�#��[ $��Sucesso���� -
   $ 	txtNETMsg��$��Center=�$��Center=�#��[ $F��@A versão do .Net Frameork é adequada a utilização do Progama���� $��0��$��4�����#B2B2B2$��2q�$��0 10 0 0q�._��� $��Center=�$��Center=�$ Vertical=�.+��� -   $ txtRESOLUCAOInfo��$��Center=�$��Center=�
��� � �#��[ $��Resolução da Tela���� -   $ txtRESOLUCAOStatus��$��Center=�$��Center=�#��[ $��Sucesso���� -   $ txtRESOLUCAOMsg��$��Center=�$��Center=�#��[ $2��,A Resolução da tela é adequada ao Sistema���� $��0��$��5�����#B2B2B2$��2q�$��0 10 0 0q�._��� $
��Left=�$��Center=�$ Vertical=�.+��� -   $ txtLocal��#��[ 
��� � �$��RAIZ: G:\Aplicativo���� -   $ txtLocalBanco��#��[ 
��� � �$ ��BANCO: G:\Aplicativo\Banco���� -   $ txtLocalImagem��#��[ 
��� � �$$��IMAGEMS: G:\Aplicativo\Imagens���� -   $ txtLocalImagemTemp��#��[ 
��� � �$)��#IMAGEMS TEMP: G:\Aplicativo\Imagens���� -   $ txtDBConexao��$
��Wrap=�$��	0 10 0 10q�#��[ 
��� � �$����Connection: Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Aplicativo\Banco\Represa03.mdf;Integrated Security=True;Connect Timeout=30���� -   $ txtDBTamanho��#��[ 
��� � �$+��%Tamanho arquivo Banco de Dados:  8 MB���� -   $ txtLOGTamanho��#��[ 
��� � �$/��)Tamanho arquivo LOG Banco de Dados:  8 MB���� -   $ txtPastaTamanho��#��[ 
��� � �$(��"Tamanho da Pasta do SISTEMA: 60 MB���� -   $ txtImagemTamanho��#��[ 
��� � �$(��"Quantidade de imagem salvas:   651���� $��1��$��2�����#B2B2B2$��2q�$��	10 10 0 0q� �� Padding$ 5q�$��3��$��Center=�$��Center=�._��� $ Vertical=�.+��� #��[ 
��� � �$
��Wrap=�$��ÚLTIMAS ATUALIZAÇÕES���� -   $ 
txtCliente��#��[ $��0 15 0 0q�$
��Wrap=�
��� � �$��CLIENTES =>���� -   $ txtEmprestimo��#��[ $��0 15 0 0q�$
��Wrap=�
��� � �$��APLICAÇÕES =>���� -   $ txtClienteCount��#��[ $��0 15 0 0q�$
��Wrap=�
��� � �$��CLIENTES CADASTRADOS:��