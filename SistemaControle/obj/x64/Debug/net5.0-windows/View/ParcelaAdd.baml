   M S B A M L   `   `   `  ����J  FSistemaControle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SistemaControle.ViewSistemaControle.View  5   	   %    SistemaControle.View.ParcelaAdd   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:SistemaControle.View     5   	   h dSyncfusion.SfSkinManager.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89l hSyncfusion.SfTextInputLayout.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89` \Syncfusion.Tools.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89f	 bSyncfusion.SfAccordion.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b
 ^Syncfusion.SfInput.Wpf, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89m iSyncfusion.SfNavigationDrawer.WPF, Version=18.4500.0.30, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89@
syncfusion!http://schemas.syncfusion.com/wpf    	 
    5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � Title$  ADICIONAR PARCELA��5   	   $	��120��6#   $	��600��60    � WindowStartupLocation$ CenterScreen=�6<    � WindowStyle$
 None=�6a   $��3q�6t   
����  � � 	Resources 5         	descricao �� 
TargetType �� Property �� Value��%  &	        �� 5   
   " ��6"   .�5      ��  � ��$ 15(�6)   �� 5       � ��$ Segoe UI)�6+   �� 5       � ��$
 Bold"�6+   �� 5       � �� �#5151516+   �� 5       � ��$ Center=�62   �� 5       � ��$ Center=�64   5      5      .��5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�6*   $��Center=�6E   .+�5   
   �� $ Vertical=�6   $��30 0 0 0q�6,   $��Center=�6>   $��Center=�6Y   .+�5      �� $��
VENCIMENTO��6   #��[  6)   ,  &Syncfusion.Windows.Shared.DateTimeEdit  5       -   5          Name$ DataVencimento��5    &   	 � 
InputScope$	 Number��6>   ,  &Syncfusion.Windows.Shared.DateTimeBase
   CustomPattern$
 d/M/yyyy��6R   $��20(�5!      $��50��6'   $	��140��63   $
��Left=�6?   5"      �� 5%   
   $ Vertical=�6   $��30 0 0 0q�6,   $��Center=�6>   $
��Left=�6Y   .+�5&      �� $��VALOR PARCELA��6   #��[  6,   /  )Syncfusion.Windows.Shared.CurrencyTextBox  5'      -   5          Name$ ValorParcela��5'   )   $	��140��6?   $��50��6K   $��20(�6W   *  $Syncfusion.Windows.Shared.EditorBase   CornerRadius$ 5��6e   $��Center=�6w   5(      �� 5+   
   -   5        $��
btCancelar��5+      $	��100��6#   $��60��6/   $��20 0 0 0q�6;   $
{�True��6M    � ToolTip$ Cancelar nova parcela��6^    � Cursor$
 Hand��6~   .��5,      �� $ Vertical=�6   .+�5-      F� ����� �  -1�p�s  -1 	= �e�  	=  � � 	= p�s p�s  	=  �  	= Ӑe�  	=  -1p�s  -1 � � -1�e� �e�  -1 �  -1� � �� �p�b �� �� p�b ��  � Ӏ� �|p�b ��O � ��OӐ|��O��O�|��O � Ӏ�Op�b �|��  � �� �0��  z � � 0�� �Е�  z � z Е� �0��  � � z 0�� �Е�  $� � � О� �0��  $� � $� 0�� �О�  � � $� Е� �0��  z 	$��Center=�5/      $��Center=�66   $��40��6Q   $��50��6]    �� Stretch$
 Fill=�6h   ��5.      ��  �� Path$ 
Foreground� �� RelativeSource ��  �� AncestorType" ��5/   h   �� 50      $��CANCELAR��6   $��0,5,0,0q�6,   $��12(�6=   $��Center=�6K   51      52      �� 55   
   -   5        $��	btInserir��55      $	��100��6"   $��60��6.   $��	10 0 20 0q�6:   $
{�True��6M   $ Inserir nova Parcela��6^   $
 Hand��6}   .��56      �� $ Vertical=�6   .+�57      F� �����@f��- �@KL ��- �P[; ��- ��- `�; ��- @KL ���- ��!���- ��2P[; @o@@KL @o@���!@o@Ӡ�2@o@@o@��2@o@��!�@o@��j �@f��- ���!��!�@KL ��!�@KL @KL ��Q��+0@@KL ���!�yw ���!��!� �  � ӠƝ  � @T� `�� @T� ��� �@T�  6� �Ɲ �� � ���`o� �����  6� ��� ��� ���� `�� `o�  �  �  � ���[ ��[ ���� ��[ ���� ��� р�[ ��� р�[ ��[ 	$��Center=�59      $��Center=�66   $��40��6Q   $��50��6]   $
 Fill=�6h   ��58      �� $ 
Foreground� �� " ��59   h   �� 5:      $��SALVAR��6   $��0,5,0,0q�6*   $��12(�6;   $��Center=�6I   5;      5<      5>      5@      