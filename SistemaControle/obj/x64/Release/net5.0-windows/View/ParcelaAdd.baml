   M S B A M L   `   `   `  ���� J  FSistemaControle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SistemaControle.ViewSistemaControle.View  %    SistemaControle.View.ParcelaAdd   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     4local"clr-namespace:SistemaControle.View     h dSyncfusion.SfSkinManager.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89l hSyncfusion.SfTextInputLayout.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89` \Syncfusion.Tools.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89f	 bSyncfusion.SfAccordion.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b
 ^Syncfusion.SfInput.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89m iSyncfusion.SfNavigationDrawer.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89@
syncfusion!http://schemas.syncfusion.com/wpf    	 
    b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$  ADICIONAR PARCELA��$	��120��$	��600�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=�$��3q�
����  � � 	Resources    	descricao �� 
TargetType �� Property �� Value��%�   &	        �� " ��.���  � ��$ 15(���  � ��$ Segoe UI)���  � ��$
 Bold"���  � �� �#515151��  � ��$ Center=���  � ��$ Center=�.����  �� Orientation$ 
Horizontal=�$��Center=�$��Center=�.+��� $ Vertical=�$��30 0 0 0q�$��Center=�$��Center=�.+��� $��
VENCIMENTO��#��[  ,  &Syncfusion.Windows.Shared.DateTimeEdit  -     Name$ DataVencimento��	 � 
InputScope$	 Number��,  &Syncfusion.Windows.Shared.DateTimeBase
   CustomPattern$
 d/M/yyyy��$��20(�$��50��$	��140��$
��Left=��� $ Vertical=�$��30 0 0 0q�$��Center=�$
��Left=�.+��� $��VALOR PARCELA��#��[  /  )Syncfusion.Windows.Shared.CurrencyTextBox  -     Name$ ValorParcela��$	��140��$��50��$��20(�*  $Syncfusion.Windows.Shared.EditorBase   CornerRadius$ 5��$��Center=��� -   $��
btCancelar��$	��100��$��60��$��20 0 0 0q�$
{�True�� � ToolTip$ Cancelar nova parcela�� � Cursor$
 Hand��.���� $ Vertical=�.+�F� ����� �  -1�p�s  -1 	= �e�  	=  � � 	= p�s p�s  	=  �  	= Ӑe�  	=  -1p�s  -1 � � -1�e� �e�  -1 �  -1� � �� �p�b �� �� p�b ��  � Ӏ� �|p�b ��O � ��OӐ|��O��O�|��O � Ӏ�Op�b �|��  � �� �0��  z � � 0�� �Е�  z � z Е� �0��  � � z 0�� �Е�  $� � � О� �0��  $� � $� 0�� �О�  � � $� Е� �0��  z 	$��Center=�$��Center=�$��40��$��50�� �� Stretch$
 Fill=�����  �� Path$ 
Foreground� �� RelativeSource ��  �� AncestorType" ���� $��CANCELAR��$��0,5,0,0q�$��12(�$��Center=��� -   $��	btInserir��$	��100��$��60��$��	10 0 20 0q�$
{�True��$ Inserir nova Parcela��$
 Hand��.���� $ Vertical=�.+�F� �����@f��- �@KL ��- �P[; ��- ��- `�; ��- @KL ���- ��!���- ��2P[; @o@@KL @o@���!@o@Ӡ�2@o@@o@��2@o@��!�@o@��j �@f��- ���!��!�@KL ��!�@KL @KL ��Q��+0@@KL ���!�yw ���!��!� �  � ӠƝ  � @T� `�� @T� ��� �@T�  6� �Ɲ �� � ���`o� �����  6� ��� ��� ���� `�� `o�  �  �  � ���[ ��[ ���� ��[ ���� ��� р�[ ��� р�[ ��[ 	$��Center=�$��Center=�$��40��$��50��$
 Fill=����� $ 
Foreground� �� " ���� $��SALVAR��$��0,5,0,0q�$��12(�$��Center=�