   M S B A M L   `   `   `  ����E  ASport_Lend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Sport_Lend
Sport_Lend  5          Sport_Lend.Admin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Sport_Lend     5        � Title$  Admin��5      $	��700��6   $	��800��6"    � WindowStartupLocation$ CenterScreen=�6.    � WindowStyle$
 None=�6S    � 
ResizeMode$ NoResize=�6f    � 	Resources 5
      &   System.Windows.Controls.DataGrid �� 
TargetType �� Property �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader*  $System.Windows.Controls.DataGridCell��%�  '        '  	    '  �    �� 5   
   "  6   .�5      ��  � ��$ Disabled=�6K   �� 5       � ��$ Hidden=�6I   �� 5       � �� �	#FFB799746+   �� 5       �@ RowBackground
 ���� 6.   �� 5       �@ RowHeaderWidth$ 0Q�6/   �� 5       �@ 	RowHeight$ 30Q�6*   �� 5       � ��$ 25(�6)   �� 5       � �� �#3333336+   �� 5       � ��
 ���� 6,   �� 5       � ��$ 1q�60   �� 5       �@ HeadersVisibility$ Column=�62   �� 5       �@ CanUserAddRows .  6/   �� 5       �@ CanUserDeleteRows .  62   �� 5       �@ GridLinesVisibility$
 None=�64   �� 5       �@ SelectionMode$ Single=�6.   �� 5       �@ 
IsReadOnly .  6+   5      �� 5   
   "  6   .�5      ��  � �� �	#FFB799746+   �� 5        � �� �	#FF0606086+   �� 5!       � ��
 ���� 6,   �� 5"       � ��$ 0,1,1,1q�60   5#      �� 5%   
   "  6   .�5&      ��  � �� �	#FFB799746+   �� 5'       � �� �	#FF0606086+   �� 5(       � ��
 ���� 6,   �� 5)       � ��$ 0q�60   5*      5+      .��5.      � ���	#FFB79974 � RowDefinitions 5/   
   �� 50      $��50 �6   �� 51      $	��550 �6   .+�54   
   � $��0��6   .+�55      �� -   5        $��45��55      $
��Left=�6   $��
10,10,0,15q�6:   $��/Photo/крест.png��6N   	 J� RenderTransformOrigin$	 0.757,1.485&�6   �� 56      $+��%Окно администратора��6   $��25(�62   $��307,0,175,0q�6@   57        59   
   -   5        
  Name$
 dataGrid��59   !    � Cursor$
 Hand��6   $��1��63   $��15,35,29,101q�6@   ��.     AutoGenerateColumns .     Columns 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 300 6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *
Id_Price+   ElementStyle 5<      �� 5=      " ��6    .�5>      ��  � ��$ 0,0,5,0q�67   5?      5A        5B      $' !Название продукта��6%   $	 350 6Y    6@   �� *Name+ 5C      �� 5D      " ��6    .�5E      ��  � ��$ 0,0,5,0q�67   5F      5H        5I      $ Цена��6%    63   �� *Prices+5K      �� 5L   
   -   5        $
 Hand��5L      $��423,583,277,-83q�6   $��1��67   $��/Photo/refresh.png��6D   6`   �� 5M   
   -   5        $��Удалить��5M      $��558,583,113,-83q�6>   $��1��6W   �� 5N   
   -   5         ��Name$
 suma��5N      $��37,513,614,-13q�6    $��1��68   $��20(�6E   �� 5O   
   -   5        $
 name��5O      $��37,449,407,51q�6    $��1��67   $��20(�6D   �� 5P   
   -   5        $
 Hand��5P      $��Добавить��6   $��37,583,634,-83q�6J   $��1��6b   5Q      5R      