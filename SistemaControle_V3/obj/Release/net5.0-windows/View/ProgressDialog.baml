   M S B A M L   `   `   `  ���� M  ISistemaControle_V3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SistemaControle_V3SistemaControle_V3  '    !SistemaControle_V3.ProgressDialog   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:SistemaControle_V3     ` \Syncfusion.Tools.Wpf, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b	 ^Syncfusion.SfInput.Wpf, Version=19.1500.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c898
syncfusion!http://schemas.syncfusion.com/wpf    	 -   $	��140��$	��340��$	��200��$	��500��  � Title$  CARREGANDO DADOS��$��Segoe UI)� � 
ResizeMode$ 	CanResize=� � WindowStyle$ SingleBorderWindow=� � WindowStartupLocation$ CenterScreen=� � 	Resources  �� 
TargetType �� Property �� Value �� 
TargetType	 J� SnapsToDevicePixels
 {�Name �� Triggers P� Property P� Value �� 
TargetName N� EnterActions �� 
TargetName �� TargetProperty t� From	 t� To g� Duration g� AutoReverse g� RepeatBehavior�� %�  '�       �� " �.���  � �� �#54bdcd��  � �� �#000000��  � ��$ 0q���  � �� �� " �.R�� $��TemplateRoot��$
	 true��.+��� #��z���� $��
PART_Track��$��0q�{� $
 PART_Indicator��$
��Left=�$��0q�._�� $��
Foreground��.+��� $��	Indicator��#��z��� $��	Animation��$
}�True��.+��� $��PART_GlowRect��$��0,0,0,0q�$
��Left=�#��z��� $��Overlay���� #��z��#��z�� P�  �@�IsIndeterminate$
 true��. ��� $ 	Indicator�� � ��
 ���� �� $ PART_GlowRect�� � ��$	 100�� �� .���� .��t� $ PART_GlowRect��$ Margin� 	-50,0,0,0 	400,0,0,0$ 0:0:2D�$
 True��$ Forever��.��]� $��10q�.+�� $��Bottom=� � ColumnDefinitions �� $��* ��� $
��Auto �.+�� -    �Name$ pbStatus��$��0�� � IsIndeterminate$
 True��$��30���� -    ��Name$ CancelButton��$��1��$��10,0,0,0q�$��90��$��30��$��Cancelar��$y�Visible=�$��Right=�$��Bottom=��� -    ��Name$ 	TextLabel��$%��Atualizando ...................��$��CharacterEllipsis=�$	��Top=�$��20(�