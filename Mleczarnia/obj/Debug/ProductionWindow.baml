   M S B A M L   `   `   `  ����E  AMleczarnia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Mleczarnia
Mleczarnia  5   
   'clr-namespace:Mleczarnia
Mleczarnia  5   
   'clr-namespace:Mleczarnia
Mleczarnia  5   	   !    Mleczarnia.ProductionWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Mleczarnia     5   
   (srcclr-namespace:Mleczarnia     5   
   )cmdsclr-namespace:Mleczarnia     5   	     � Title$  	Produkcja��5
   	   $	��400��6   $	��700��6(   $	��400��64   $	��700��6D   ���	#FF83FF80 J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ cmds:Commands.Delete��5      6W     5   
   -   5        $ cmds:Commands.Return��5      68     5   
   -   5        $ cmds:Commands.Add��5      65    � 	Resources 5         ElementTemplate �� CornerRadius �� Orientation  GroupTemplate �� Padding �� Path��%�  &	        &	 O    �� 5   
   .R�5      �� ���	#FF76EDA6$��1q�6,   $��1q�6@   
���   �$ 6��6`   $��Stretch=�6q   $��Center=�6�   ._�5      �� $	��2pxq�6   $ 
Horizontal=�6,   $��Center=�6E   $��Center=�6b   .+�5      �� $��20(�6>   $��Tw Cen MT Condensed)�6L   $
��Bold"�6m   $��Right=�6   ��6   �� *Product.name+6�   �� 5      $��20(�68   $��Tw Cen MT Condensed)�6F   $
��Bold"�6g   $
��Left=�6y   ��6   �� *amount+6�   �� 5      $��20(�66   $��Tw Cen MT Condensed)�6D   ��6   �� *date+6h   5      5      5      �� 5   
   .R�5      �� $
��Bold"�5      
�������
���"�"�$��0,5,0,0q�5      $ 3q�6*   ��5      �� $
 Name�5   *   5      5      .��5       �  � RowDefinitions 5!   
   �� 5"      $
��auto �6   6,   �� 5#      $��* �6   6)   	 � ColumnDefinitions	 5%   
   �� 5&      $��2* �6   6,   �� 5'      $��* �6   6+    5)   
      Mleczarnia.Products  	mProducts��%   &	         5*      6   5+      .+�5,   
   c� ���	#FFCBFFC9$��2��6)   .@�5-      �� $��cmds:Commands.Add��6   $	��Top=�61   .��5.      �� $ 
Horizontal=�6   .+�5/      �� $��20��6   $��appbar.add.png��6(   $
��Fill=�6@   $��20��6O   $��Center=�6Z   $��Center=�6w   �� 50      $��Center=�6    $��Center=�6=   $��15(�6X   Dodaj6m   51      52      �� 53      
 �� SelectedIndex$
 0��6   .@�54      �� -   5        .��54   4   Bez grupowania6D   �� 55      -   5        .��55   4   Grupuj po nazwie produktu6O   56      �� 57      .��6   Ilość produktu od:6(   �� 58      -   5        $��amountOfProduct��58   $   $��50��6   6$   �� 59      -   5        .��59   $   	Filtruj6-   �� 5:      -   5        .��5:   (   Usuń Filtr64   5;      � 5<   
   $��	5,5,2,5.4q�6   $��1��6"   .+�5=      �� -	   5        $��productionList��5=   v   $��Stretch=�6   $��Stretch=�6:   ���	#FFCBFFC9$��4��6�   $��4��6�   #��[  6�    �� 
GroupStyle 5>      (  "System.Windows.Controls.GroupStyle  5?         HeaderTemplate# [ 6!   5A      5B      � 5C   
   $��1��6   $��1��6   $	��5pxq�6,    � DataContext 69   ��  �� ElementName$ productionList��$ SelectedItem� 5D      �� 5E      $��* �6    6-   �� 5F      $��* �6    6-   �� 5G      $��* �6    6-   �� 5H      $��* �6    6-   	 5K      �� 5L      $
��auto �6#   63   �� 5M      $��* �6#   60   .+�5P      �� $��0��6   $��0��6!   $	��5pxq�61   $	��2pxq�6>   $��Tw Cen MT Condensed)�6L   $��24(�6m   $��Center=�6{   $��Center=�6�   .��6�   
Produkt:6�   �� 5Q      -
   5        $��	productID��5Q      $��0��6(   $��1��65   $��18(�6E   $��Tw Cen MT Condensed)�6S   $��Center=�6t   $��Center=�6�   #��[ 5R       �� SelectedValuePath$ 	productID��5T       �� SelectedItem$ sProduct��5V      $��62��5W   D   $��
0,0,-0.4,0q�6P   $��2��6d   $	��Top=�6u    �� SelectedValue 5U      �� *	productID+��5Y      �� 5Z      .R�5[      �� $ 
Horizontal=�6%   .+�5\      �� ��6(   �� *name+6@   5]      5^      5`      �� 5a      $��1��6   $��0��6!   $	��5pxq�61   $	��2pxq�6>   $��Tw Cen MT Condensed)�6L   $��24(�6m   $��Center=�6{   $��Center=�6�   .��6�   
Ilość:6�   �� 5b      -   5        $��amount��5b      $��1��6%   $��1��62   $��24(�6B   $��Tw Cen MT Condensed)�6P   $��Center=�6�   ��6q   �� $ amount� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5c      $��2��6   $��0��6!   $	��5pxq�61   $	��2pxq�6>   $��Tw Cen MT Condensed)�6L   $��24(�6m   $��Center=�6{   $��Center=�6�   .��6�   Data:6�   �� 5d      -   5        $
��date��5d      $��2��6"   $��1��6/   $��24(�6?   $��Tw Cen MT Condensed)�6M   $��Center=�6�   ��6n   �� $
 date�$ PropertyChanged=�6�   � 5f      $��2��6   $��5��6'   	 5g      �� 5h      $��* �6'   63   �� 5i      $��* �6'   63   .+�5k      ��   RoundedButtonStyle#��[ 6   $	��5pxq�6E   $	��2pxq�6R   $��Tw Cen MT Condensed)�6`   $��24(�6�   $��cmds:Commands.Delete��6�   ���	#FFCD7272.��5l      �� $ 
Horizontal=�6!   .+�5m      �� $��30��6    $��appbar.delete.png��6,   $
��Fill=�6G   $��30��6V   $��Center=�6a   $��Center=�6~   �� 5n      $��Center=�6$   $��Center=�6A   $��19(�6\   Usuń6p   5o      5q      �� 5r      #��[ 6   $��1��6E   $	��5pxq�6U   $	��2pxq�6b   $��Tw Cen MT Condensed)�6p   $��24(�6�   $��cmds:Commands.Return��6�   ���	#FF78BACE.��5s      �� $ 
Horizontal=�6!   .+�5t      �� $��30��6    $��appbar.arrow.left.png��6,   $
��Fill=�6K   $��30��6Z   $��Center=�6e   $��Center=�6�   �� 5u      $��Center=�6$   $��Center=�6A   $��19(�6\   	Powrót6r   5v      5w      5x      5y      5z      5{      