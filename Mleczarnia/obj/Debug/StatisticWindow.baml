   M S B A M L   `   `   `  ����E  AMleczarnia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Mleczarnia
Mleczarnia  5   	   'clr-namespace:Mleczarnia
Mleczarnia  5   	        Mleczarnia.StatisticWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Mleczarnia     5   	   )cmdsclr-namespace:Mleczarnia     5   	     � Title$  StatisticWindow��5	   	   $	��540��6!   $	��500��6.   $	��540��6:   $	��500��6J   ���	#FF83FF80
���   �$��Center=�6�   $��Center=�6�    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ cmds:Commands.Print��5      67     5   
   -   5        $ cmds:Commands.Return��5      68   .��5      � $	��5pxq�6    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� $��0��6   $��0��6   $��Tw Cen MT Condensed)�6-   $��24(�6N   $��Right=�6\   $��Center=�6x   .��6�   Ilość gospodarzy:6�   �� 5    
   -   5        $��farmers��5       $��0��6   $��1��6,   $��Tw Cen MT Condensed)�6<   $��24(�6]   $
��Left=�6k   $��Center=�6�   6�   �� 5!   
   $��1��6   $��0��6   $��Tw Cen MT Condensed)�6-   $��24(�6N   $��Right=�6\   $��Center=�6x   .��6�   Ilość dostaw:6�   �� 5"   
   -   5        $��
deliveries��5"      $��1��6#   $��1��60   $��Tw Cen MT Condensed)�6@   $��24(�6a   $
��Left=�6o   $��Center=�6�   6�   �� 5#   
   $��2��6   $��0��6   $��Tw Cen MT Condensed)�6-   $��24(�6N   $��Right=�6\   $��Center=�6x   .��6�   Ilość produktów:6�   �� 5$   
   -   5        $��products��5$      $��2��6    $��1��6-   $��Tw Cen MT Condensed)�6=   $��24(�6^   $
��Left=�6l   $��Center=�6�   6�   �� 5%   
   $��3��6   $��0��6   $��Tw Cen MT Condensed)�6-   $��24(�6N   $��Right=�6\   $��Center=�6x   .��6�   Ilość produkcji:6�   �� 5&   
   -   5        $��productions��5&      $��3��6#   $��1��60   $��Tw Cen MT Condensed)�6@   $��24(�6a   $
��Left=�6o   $��Center=�6�   6�   �� 5'   
   $��4��6   $��0��6   $��Tw Cen MT Condensed)�6-   $��24(�6N   $��Right=�6\   $��Center=�6x   .��6�   Ilość sprzedaży:6�   �� 5(   
   -   5        $��sales��5(      $��4��6   $��1��6*   $��Tw Cen MT Condensed)�6:   $��24(�6[   $
��Left=�6i   $��Center=�6�   6�   �� 5)   
   $��5��6   $��0��6   $��Tw Cen MT Condensed)�6-   $��24(�6N   $��Right=�6\   $��Center=�6x   .��6�   	Obrót:6�   �� 5*   
   -   5        $
��cash��5*      $��5��6   $��1��6)   $��Tw Cen MT Condensed)�69   $��24(�6Z   $
��Left=�6h   $��Center=�6�   6�   �� 5+   
   $��6��6   $��2��6   $��Tw Cen MT Condensed)�61   $��24(�6R   $��Center=�6`   $��Center=�6}   .��6�   Wykorzystanie zbiornika6�   � 5,   
   -	   5        $��tankProgressBar��5,      $��7��6.   $��2��6<   ���	#FFCBFFC9$	��5pxq�6g   6v   �� 5-   
   $��9��6   $��0��6   $	��5pxq�6.   $	��2pxq�6;   $��36(�6I   $��Tw Cen MT Condensed)�6W   ���	#FFCBFFC9$��cmds:Commands.Print��6�      RoundedButtonStyle#��[  6�   .��5/      ��  �� Orientation$ 
Horizontal=�6   .+�50      �� $��50��6   $��appbar.printer.text.png��6$   $
��Fill=�6E   $��50��6T   $��Center=�6_   $��Center=�6|   �� 51      $��30(�6   $��Center=�6*   $��Center=�6G   �� 6c   $�Drukuj��6g   6x   52      53      �� 54   
   -
   5        $��tankFilling��54      $��8��6$   $��0��61   $��Tw Cen MT Condensed)�6A   $��20(�6b   $��Right=�6p   $��Center=�6�   6�   �� 55   
   -   5        $��maximumCapacity��55      $��8��6'   $��1��64   $��Tw Cen MT Condensed)�6D   $��20(�6e   $
��Left=�6s   $��Center=�6�   6�   �� 56   
   $��9��6   $��1��6   $	��5pxq�6.   $	��2pxq�6;   $��36(�6I   $��Tw Cen MT Condensed)�6W   $��cmds:Commands.Return��6x   ���	#FFCBFFC9#��[  6�   .��57      �� $ 
Horizontal=�6   .+�58      �� $��50��6   $��appbar.arrow.left.png��6$   $
��Fill=�6C   $��50��6R   $��Center=�6]   $��Center=�6z   �� 59      $��Center=�6   $��Center=�69   $��30(�6T   	Powrót6k   5:      5;      5<      5=      