   M S B A M L   `   `   `  ����E  ASport_Lend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Sport_Lend
Sport_Lend  5          Sport_Lend.Zakaz   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Sport_Lend     5        � Title$  Zakaz��5      $	��600��6   $	��900��6"    � WindowStartupLocation$ CenterScreen=�6.    � WindowStyle$
 None=�6S    � 
ResizeMode$ NoResize=�6f    � 	Resources 5
      &   System.Windows.Controls.DataGrid �� 
TargetType �� Property �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader*  $System.Windows.Controls.DataGridCell��%�  '        '  �    '  �    �� 5   
   "  6   .�5      ��  � ��$ Disabled=�6K   �� 5       � ��$ Hidden=�6I   �� 5       � �� �	#FFB799746+   �� 5       �@ RowBackground
 ���� 6.   �� 5       �@ RowHeaderWidth$ 0Q�6/   �� 5       �@ 	RowHeight$ 30Q�6*   �� 5       � ��$ 25(�6)   �� 5       � �� �#3333336+   �� 5       � ��
 ���� 6,   �� 5       � ��$ 1q�60   �� 5       �@ HeadersVisibility$ Column=�62   �� 5       �@ CanUserAddRows .  6/   �� 5       �@ CanUserDeleteRows .  62   �� 5       �@ GridLinesVisibility$
 None=�64   �� 5       �@ SelectionMode$ Single=�6.   5      �� 5   
   "  6   .�5      ��  � �� �	#FFB799746+   �� 5       � �� �	#FF0606086+   �� 5        � ��
 ���� 6,   �� 5!       � ��$ 0,1,1,1q�60   5"      �� 5$   
   "  6   .�5%      ��  � �� �	#FFB799746+   �� 5&       � �� �	#FF0606086+   �� 5'       � ��
 ���� 6,   �� 5(       � ��$ 0q�60   5)      5*      .��5-      � ���	#FFB79974 � RowDefinitions 5.   
   �� 5/      $��50 �6   �� 50      $	��550 �6   .+�53   
   � $��0��6   .+�54      �� -   5        $��43��54      $
��Left=�6   $��
10,10,0,15q�6:   $��/Photo/крест.png��6N   	 J� RenderTransformOrigin$	 0.645,1.234&�6   �� 55      $'��!Оформление заказа��6   $��25(�60   $��385,0,255,0q�6>   $	 
0.138,0.72&�6S   56        5>   
   -   5        
  Name$
 dataGrid��5>      $��1��6%   $��15,35,149,300q�62   ��.     AutoGenerateColumns .     Columns 5?      0  *System.Windows.Controls.DataGridTextColumn  5@      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 300 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *
Id_Bascket+   ElementStyle 5A      �� 5B      " ��6    .�5C      ��  � ��$ 0,0,5,0q�67   5D      5F        5G      $' !Название продукта��6%   $	 350 6a    6@   �� *Name_Product+ 5H      �� 5I      " ��6    .�5J      ��  � ��$ -5,0,5,0q�67   5K      5M        5N      $ Цена��6%    63   �� *Price+5P      �� 5R   
   -   5         ��Name$ sum_TextBlock��5R      $��37,423,636,77q�6+   $��1��6B   $��30(�6O   �� 5S   
   -   5        $ discount_TextBlock��5S      $��37,490,380,10q�60   $��1��6G   $��30(�6T   �� 5T   
   -   5        $��1��5T      $��821,35,17,477q�6   $��/Photo/delete.png��64   6O   �� 5U   
   -   5         ��Name$ 
OrderLabel��5U      $��Заказать��6$   $��1��67   $��713,423,48,77q�6D   $��30(�6[    � Cursor$
 Hand��6i   6w   5V      5W      