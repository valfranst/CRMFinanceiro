   M S B A M L   `   `   `  ����A  =Backup, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BackupBackup  5   	       Backup.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Backup     5   	   -   5          � Title$  BACKUP��5   	   $	��550��6   $	��800��6%   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $	��100 �6   �� 5      $	��260 �6   �� 5      $	��100 �6   .+�5   
   �� -   5         ��Name$ Titulo��5      $��0��6    $��0��6-   $��2��6=   $��BACKUP DE DADOS��6Q   $��22(�6k   $
��Bold"�6y   $��40��6�   $��Center=�6�   $��Center=�6�   �� 5   
   -   5        $��	Remetente��5      $��1��6"   $��0��6/   $	��180��6?   $	��100��6K   
������ $��0q�6r   
������ .��5      �� .+�5      �� $��Uniform=�6   $1��+pack://application:,,,/Resources/folder.png��6*   $	��150��6_   $��70��6k   �� 5      $��DADOS DO SISTEMA��6   $��16(�64   $
��Bold"�6B   5      5      �� 5   
   -   5        $��Destinatario��5      $��1��6%   $��1��62   $	��180��6B   $	��100��6N   
������ $��0q�6t   
������ .��5      �� .+�5       �� $��Uniform=�6   $8��2pack://application:,,,/Resources/folder_backup.png��6*   $	��150��6f   $��70��6r   �� 5!      $��ENDEREÇO DO BACKUP��6   $��16(�66   $
��Bold"�6D   5"      5#      �� 5&   
   -   5        $��txtRemetente��5&      $��Dados Sistema....��6(   $��2��6A   $��0��6N   $��10 0 0 0q�6^   �� 5(   
   -   5        $��txtDestinatario��5(      $��Endereço do Backup....��6+   $��2��6I   $��1��6V   $��10 0 0 0q�6f   �� 5+   
   -   5        $��Iniciar��5+      $��3��6    $��0��6-   $��2��6=   $	��135��6Q   $	��100��6]   
������ $��0q�6�   
������ .��5,      �� .+�5-      �� $��Uniform=�6   $/��)pack://application:,,,/Resources/play.png��6*   $	��150��6]   $��70��6i   �� 5.      $��INICIAR BACKUP��6   $��16(�62   $
��Bold"�6@   5/      50      52      53      