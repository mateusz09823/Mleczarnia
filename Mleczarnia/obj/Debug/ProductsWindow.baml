   M S B A M L   `   `   `  ����E  AMleczarnia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Mleczarnia
Mleczarnia  5   	   'clr-namespace:Mleczarnia
Mleczarnia  5   	       Mleczarnia.ProductsWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Mleczarnia     5   	   )cmdsclr-namespace:Mleczarnia     5   	     � Title$  Produkty��5	   	   $	��400��6   $	��800��6'   $	��400��63   $	��800��6C   ���	#FF83FF80 J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ cmds:Commands.Delete��5      6W     5   
   -   5        $ cmds:Commands.Return��5      68     5   
   -   5        $ cmds:Commands.Add��5      65    � 	Resources 5         ElementTemplate �� CornerRadius �� Orientation  GroupTemplate �� Padding �� Path��%\  &	        &	 �    �� 5   
   .R�5      �� ���	#FF76EDA6$��1q�6,   $��1q�6@   
���   �$ 6��6`   $��Stretch=�6q   $��Center=�6�   ._�5      �� $	��2pxq�6   $ 
Horizontal=�6,   $��Center=�6E   $��Center=�6b   .+�5      �� $��20(�66   $��Tw Cen MT Condensed)�6D   $
��Bold"�6e   $��Right=�6w   ��6   �� *name+6�   �� 5      $��20(�66   $��Tw Cen MT Condensed)�6D   $
��Bold"�6e   $
��Left=�6w   ��6   �� *type+6�   �� 5      $��20(�6>   $��Tw Cen MT Condensed)�6L   ��6   �� *amountInPack+6p   �� 5      $��20(�6>   $��Tw Cen MT Condensed)�6L   ��6   �� *amountOfMilk+6p   5      5      5      �� 5   
   .R�5      �� $
��Bold"�5      
�������
���"�"�$��0,5,0,0q�5      $ 3q�6*   ��5      �� $
 Name�5   *   5      5       .��5!      �  � RowDefinitions 5"   
   �� 5#      $
��auto �6   6,   �� 5$      $��* �6   6)   	 � ColumnDefinitions	 5&   
   �� 5'      $
��438* �6   6.   �� 5(      $
��269* �6   6.   .+�5*   
   c� ���	#FFCBFFC9$��2��6)   $��0,0,0.2,0.4q�6=   .@�5+      �� $��cmds:Commands.Add��6   $	��Top=�61   .��5,      �� $ 
Horizontal=�6   .+�5-      �� $��20��6   $��appbar.add.png��6(   $
��Fill=�6@   $��20��6O   $��Center=�6Z   $��Center=�6w   �� 5.      $��Center=�6    $��Center=�6=   $��15(�6X   Dodaj6m   5/      50      �� 51      
 �� SelectedIndex$
 0��6   .@�52      �� -   5        .��52   4   Bez grupowania6D   �� 53      -   5        .��53   4   Grupuj po nazwie6F   �� 54      -   5        .��54   4   Grupuj po typie6E   55      �� 56      .��6   Ilość mleka od:6%   �� 57      -   5        $
��milk��57   $   $��50��6   6$   �� 58      -   5        .��58   $   	Filtruj6-   �� 59      -	   5        .��59   (   Usuń Filtr64   5;      � 5<   
   $��5,4.6,4.4,5q�6   $��1��6$   .+�5=      �� -
   5        $��productsList��5=   v   $��Stretch=�6   $��Stretch=�6:   ���	#FFCBFFC9$��4��6�   $��4��6�   #��[  6�    �� 
GroupStyle 5>      (  "System.Windows.Controls.GroupStyle  5?         HeaderTemplate# [ 6!   5A      5B      � 5C   
   $��1��6   $��1��6   $��8.6,4.6,4.2,5q�6,    � DataContext 6D   ��  �� ElementName$ productsList��$ SelectedItem� 5D      �� 5E      $��* �6    6-   �� 5F      $��* �6    6-   �� 5G      $��* �6    6-   �� 5H      $��* �6    6-   �� 5I      $��* �6    6-   	 5K      �� 5L      $
��auto �6#   62   �� 5M      $��* �6#   6/   .+�5O      �� $��0��6   $��0��6!   $	��5pxq�61   $	��2pxq�6>   $��Tw Cen MT Condensed)�6L   $��24(�6m   $��Center=�6{   $��Center=�6�   .��6�   Nazwa:6�   �� 5P      -   5        $
��name��5P      $��0��6"   $��1��6/   $��24(�6?   $��Tw Cen MT Condensed)�6M   $��Center=�6�   ��6n   �� $
 name� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5Q      $��1��6   $��0��6!   $	��5pxq�61   $	��2pxq�6>   $��Tw Cen MT Condensed)�6L   $��24(�6m   $��Center=�6{   $��Center=�6�   .��6�   Typ:6�   �� 5R      -   5        $
��type��5R      $��1��6#   $��1��60   $��24(�6@   $��Tw Cen MT Condensed)�6N   $��Center=�6�   ��6o   �� $
 type�$ PropertyChanged=�6�   �� 5S      $��2��6   $��0��6!   $	��5pxq�61   $	��2pxq�6>   $��Tw Cen MT Condensed)�6L   $��24(�6m   $��Center=�6{   $��Center=�6�   .��6�   Ilość w paczce:6�   �� 5T      -   5        $��amountInPack��5T      $��2��6*   $��1��67   $��24(�6G   $��Tw Cen MT Condensed)�6U   $��Center=�6�   ��6v   �� $ amountInPack�$ PropertyChanged=�6�   �� 5U      $��3��6   $��0��6!   $	��5pxq�61   $	��2pxq�6>   $��Tw Cen MT Condensed)�6L   $��24(�6m   $��Center=�6{   $��Center=�6�   .��6�   Ilosć mleka:6�   �� 5V      -   5        $
��made��5V      $��3��6"   $��1��6/   $��24(�6?   $��Tw Cen MT Condensed)�6M   $��Center=�6�   ��6n   �� $ amountOfMilk�$ PropertyChanged=� �� StringFormat$ N2��6�   � 5W      $��2��6   $��5��6'   	 5X      �� 5Y      $��* �6'   63   �� 5Z      $��* �6'   63   .+�5\      ��   RoundedButtonStyle#��[ 6   $	��5pxq�6G   $	��2pxq�6T   $��Tw Cen MT Condensed)�6b   $��24(�6�   $��cmds:Commands.Delete��6�   ���	#FFCD7272.��5]      �� $ 
Horizontal=�6!   .+�5^      �� $��30��6    $��appbar.delete.png��6,   $
��Fill=�6G   $��30��6V   $��Center=�6a   $��Center=�6~   �� 5_      $��Center=�6$   $��Center=�6A   $��19(�6\   Usuń6p   5`      5a      �� 5b      #��[ 6   $��1��6F   $	��5pxq�6V   $	��2pxq�6c   $��Tw Cen MT Condensed)�6q   $��24(�6�   $��cmds:Commands.Return��6�   ���	#FF78BACE.��5c      �� $ 
Horizontal=�6!   .+�5d      �� $��30��6    $��appbar.arrow.left.png��6,   $
��Fill=�6K   $��30��6Z   $��Center=�6e   $��Center=�6�   �� 5e      $��Center=�6$   $��Center=�6A   $��19(�6\   	Powrót6r   5f      5g      5h      5i      5j      5k      