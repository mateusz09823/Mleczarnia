   M S B A M L   `   `   `  ����E  AMleczarnia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Mleczarnia
Mleczarnia  5      'clr-namespace:Mleczarnia
Mleczarnia  5   	   'clr-namespace:Mleczarnia
Mleczarnia  5   	       Mleczarnia.SalesWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Mleczarnia     5      (srcclr-namespace:Mleczarnia     5   	   )cmdsclr-namespace:Mleczarnia     5   	     � Title$  	Sprzedaż��5
   	   $	��400��6   $	��700��6'   $	��400��63   $	��600��6C   ���	#FF83FF80 J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ cmds:Commands.Delete��5      6W     5   
   -   5        $ cmds:Commands.Return��5      68     5   
   -   5        $ cmds:Commands.Add��5      65    � 	Resources 5         ElementTemplate �� CornerRadius �� Orientation  GroupTemplate �� Padding �� Path��%  &	        &	 a    �� 5   
   .R�5      �� ���	#FF76EDA6$��1q�6,   $��1q�6@   
���   �$ 6��6`   $��Stretch=�6q   $��Center=�6�   ._�5      �� $	��2pxq�6   $ 
Horizontal=�6,   $��Center=�6E   $��Center=�6b   .+�5      �� $��20(�6I   $��Tw Cen MT Condensed)�6W   $
��Bold"�6x   $��Right=�6�   ��6   �� *Production.Product.name+6�   �� 5      $��20(�6>   $��Tw Cen MT Condensed)�6L   $
��Bold"�6m   $
��Left=�6   ��6   �� *amountToSell+6�   �� 5      $��20(�67   $��Tw Cen MT Condensed)�6E   ��6   �� *price+6i   5      5      5      �� 5   
   .R�5      �� $
��Bold"�5      
�������
���"�"�$��0,5,0,0q�5      $ 3q�6*   ��5      �� $
 Name�5   *   5      5      .��5"      �  � RowDefinitions 5#   
   �� 5$      $
��auto �6   6,   �� 5%      $��* �6   6)   	 � ColumnDefinitions	 5'   
   �� 5(      $��2* �6   6,   �� 5)      $��* �6   6+    5+   
      Mleczarnia.Productions  mProduction��%   &	         5,      6   5-      .+�5.   
   c� ���	#FFCBFFC9$��2��6)   .@�5/      �� 
 �� SelectedIndex$
 0��6   .@�50      �� -   5        .��50   4   Bez grupowania6D   �� 51      -   5        .��51   4   Grupuj po nazwie produktu6O   52      �� 53      .��6   Ilość produktu od:6(   �� 54      -   5        $��amountOfProduct��54   $   $��50��6   6$   �� 55      -   5        .��55   $   	Filtruj6-   �� 56      -   5        .��56   (   Usuń Filtr64   57      � 58   
   $��	5,5,2,5.4q�6   $��1��6"   .+�59      �� -	   5        $��	salesList��59   v   $��Stretch=�6   $��Stretch=�6:   ���	#FFCBFFC9$��4��6�   $��4��6�   #��[  6�    �� 
GroupStyle 5:      (  "System.Windows.Controls.GroupStyle  5;         HeaderTemplate# [ 6!   5=      5>      � 5?   
   $��1��6   $��1��6   $	��5pxq�6,    � DataContext 69   ��  �� ElementName$ 	salesList��$ SelectedItem� 5@      �� 5A      $��* �6    6-   �� 5B      $��* �6    6-   �� 5C      $��* �6    6-   �� 5D      $��* �6    6-   �� 5E      $
��0.7* �6    60   	 5G      �� 5H      $
��auto �6#   63   �� 5I      $��* �6#   60   .+�5L      �� $��0��6   $��0��6!   $	��5pxq�61   $	��2pxq�6>   $��Tw Cen MT Condensed)�6L   $��24(�6m   $��Center=�6{   $��Center=�6�   .��6�   
Produkt:6�   �� 5M      -
   5        $��productionID��5M      $��0��6+   $��1��68   $
��10pxq�6H   $��18(�6V   $��Tw Cen MT Condensed)�6d   $��Center=�6�   $��Center=�6�   #��[ 5N       �� SelectedValuePath$ productionID��5P       �� SelectedItem$ sProduction��5R      $��62��5S   D   $��2��6Q   $	��Top=�6b    �� SelectedValue 5Q      �� *productionID+��5U      �� 5V      .R�5W      �� $ 
Horizontal=�6%   .+�5X      �� ��6(   �� *Product.name+6H   �� 5Y      $�� ��6(   �� 5Z      ��6(   �� *date+6@   5[      5\      5^      �� 5_      $��1��6   $��0��6!   $	��5pxq�61   $	��2pxq�6>   $��Tw Cen MT Condensed)�6L   $��24(�6m   $��Center=�6{   $��Center=�6�   .��6�   
Ilość:6�   �� 5`      -   5        $��amount��5`      $��1��6%   $��1��62   $��24(�6B   $��Tw Cen MT Condensed)�6P   $��Center=�6�   ��6q   �� $ amountToSell� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5a      $��2��6   $��0��6!   $	��5pxq�61   $	��2pxq�6>   $��Tw Cen MT Condensed)�6L   $��24(�6m   $��Center=�6{   $��Center=�6�   .��6�   Koszt:6�   �� 5b      -   5        $��price��5b      $��2��6#   $��1��60   $��24(�6@   $��Tw Cen MT Condensed)�6N   $��Center=�6�   ��6o   �� $ price�$ PropertyChanged=� �� StringFormat$ N2��6�   �� 5c      $��2��6   $��3��6*   $	��8pxq�68   $	��2pxq�6E   $��Tw Cen MT Condensed)�6S   $��36(�6t   ���	#FF60E4A9  RoundedButtonStyle#��[ 6�   $��cmds:Commands.Add��6�   .��5d      �� $ 
Horizontal=�6   $��Center=�66   $��Center=�6S   .+�5e      �� $��55��6   $ ��appbar.currency.dollar.png��6(   $
��Fill=�6L   $��55��6[   $��Center=�6f   $��Center=�6�   �� 5f      $��Center=�6    $��Center=�6=   $��30(�6X   
Sprzedaj6p   5g      5h      � 5i      $��2��6   $��5��6'   	 5j      �� 5k      $��* �6'   63   �� 5l      $��* �6'   63   .+�5n      �� $	��5pxq�6   $	��2pxq�6'   $��Tw Cen MT Condensed)�65   $��24(�6V   $��cmds:Commands.Delete��6d   #��[ 6�   ���	#FFCD7272.��5o      �� $ 
Horizontal=�6!   .+�5p      �� $��30��6    $��appbar.delete.png��6,   $
��Fill=�6G   $��30��6V   $��Center=�6a   $��Center=�6~   �� 5q      $��Center=�6$   $��Center=�6A   $��19(�6\   Usuń6p   5r      5s      �� 5t      #��[ 6   $��1��6F   $	��5pxq�6V   $	��2pxq�6c   $��Tw Cen MT Condensed)�6q   $��24(�6�   $��cmds:Commands.Return��6�   ���	#FF78BACE.��5u      �� $ 
Horizontal=�6!   .+�5v      �� $��30��6    $��appbar.arrow.left.png��6,   $
��Fill=�6K   $��30��6Z   $��Center=�6e   $��Center=�6�   �� 5w      $��Center=�6$   $��Center=�6A   $��19(�6\   	Powrót6r   5x      5y      5z      5{      5|      5}      