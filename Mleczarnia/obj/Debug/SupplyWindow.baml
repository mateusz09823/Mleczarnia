   M S B A M L   `   `   `  ����E  AMleczarnia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Mleczarnia
Mleczarnia  5   	   'clr-namespace:Mleczarnia
Mleczarnia  5   	   'clr-namespace:Mleczarnia
Mleczarnia  5   	       Mleczarnia.SupplyWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Mleczarnia     5   	   (srcclr-namespace:Mleczarnia     5   	   )cmdsclr-namespace:Mleczarnia     5   	     � Title$  Dostawy��5
   	   $	��400��6   $	��800��6&   $	��400��62   $	��800��6B   ���	#FF83FF80 J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ cmds:Commands.Delete��5      6W     5   
   -   5        $ cmds:Commands.Return��5      68     5   
   -   5        $ cmds:Commands.Add��5      65    � 	Resources 5         ElementTemplate �� CornerRadius �� Orientation  GroupTemplate �� Padding �� Path��%_  &	        &	 �    �� 5   
   .R�5      �� ���	#FF76EDA6$��1q�6,   $��1q�6@   
���   �$ 6��6`   $��Stretch=�6q   $��Center=�6�   ._�5      �� $	��2pxq�6   $ 
Horizontal=�6,   $��Center=�6E   $��Center=�6b   .+�5      �� $��20(�6;   $��Tw Cen MT Condensed)�6I   $
��Bold"�6j   $��Right=�6|   ��6   �� *	Farm.name+6�   �� 5      $��20(�6>   $��Tw Cen MT Condensed)�6L   $
��Bold"�6m   $
��Left=�6   ��6   �� *Farm.surname+6�   �� 5      $��20(�66   $��Tw Cen MT Condensed)�6D   ��6   �� *date+6h   �� 5      $��20(�6<   $��Tw Cen MT Condensed)�6J   ��6   �� *
milkAmount+6n   5      5      5      �� 5   
   .R�5      �� $
��Bold"�5      
�������
���"�"�$��0,5,0,0q�5      $ 3q�6*   ��5      �� $
 Name�5   *   5      5       .��5!      �  � RowDefinitions 5"   
   �� 5#      $
��auto �6   6,   �� 5$      $��* �6   6)   	 � ColumnDefinitions	 5&   
   �� 5'      $��2* �6   6,   �� 5(      $��* �6   6+    5*   
      Mleczarnia.Farms 
 mFarms��%   &	         5+      6   5,      .+�5-   
   c� ���	#FFCBFFC9$��2��6)   .@�5.      �� $��cmds:Commands.Add��6   $	��Top=�61   .��5/      �� $ 
Horizontal=�6   .+�50      �� $��20��6   $��appbar.add.png��6(   $
��Fill=�6@   $��20��6O   $��Center=�6Z   $��Center=�6w   �� 51      $��Center=�6    $��Center=�6=   $��15(�6X   Dodaj6m   52      53      �� 54      
 �� SelectedIndex$
 0��6   .@�55      �� -   5        .��55   4   Bez grupowania6D   �� 56      -   5        .��56   7   Grupuj po nazwisku6K   57      �� 58      .��6   Ilość mleka od:6%   �� 59      -   5        $
��milk��59   $   $��50��6   6$   �� 5:      -   5        .��5:   $   	Filtruj6-   �� 5;      -   5        .��5;   (   Usuń Filtr64   5<      � 5=   
   $��	5,5,2,5.4q�6   $��1��6"   .+�5>      �� -	   5        $��deliveryList��5>   v   $��Stretch=�6   $��Stretch=�6:   ���	#FFCBFFC9$��4��6�   $��4��6�   #��[  6�    �� 
GroupStyle 5?      (  "System.Windows.Controls.GroupStyle  5@         HeaderTemplate# [ 6!   5B      5C      � 5D   
   $��1��6   $��1��6   $	��5pxq�6,    � DataContext 69   ��  �� ElementName$ deliveryList��$ SelectedItem� 5E      �� 5F      $��* �6    6-   �� 5G      $��* �6    6-   �� 5H      $��* �6    6-   �� 5I      $
��0.7* �6    60   	 5K      �� 5L      $
��auto �6#   63   �� 5M      $��* �6#   60   .+�5P      �� $��0��6   $��0��6!   $	��5pxq�61   $	��2pxq�6>   $��Tw Cen MT Condensed)�6L   $��24(�6m   $��Center=�6{   $��Center=�6�   .��6�   Gospodarstwo:6�   �� 5Q      -
   5        $��farmID��5Q      $��0��6%   $��1��62   $��18(�6B   $��Tw Cen MT Condensed)�6P   $��Center=�6q   $��Center=�6�   #��[ 5R       �� SelectedValuePath$ farmID��5T       �� SelectedItem$ sFarm��5V      $��62��5W   D   $��
0,0,-0.4,0q�6P   $��2��6d   $	��Top=�6u    �� SelectedValue 5U      �� *farmID+��5Y      �� 5Z      .R�5[      �� $ 
Horizontal=�6%   .+�5\      �� ��6(   �� *name+6@   �� 5]      $ 10,0,0,0q�6A   ��6(   �� *	surname+6V   5^      5_      5a      �� 5b      $��1��6   $��0��6!   $	��5pxq�61   $	��2pxq�6>   $��Tw Cen MT Condensed)�6L   $��24(�6m   $��Center=�6{   $��Center=�6�   .��6�   Data:6�   �� 5c      -   5        $
��date��5c      $��1��6#   $��1��60   $��24(�6@   $��Tw Cen MT Condensed)�6N   $��Center=�6�   ��6o   �� $
 date� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5d      $��2��6   $��0��6!   $	��5pxq�61   $	��2pxq�6>   $��Tw Cen MT Condensed)�6L   $��24(�6m   $��Center=�6{   $��Center=�6�   .��6�   Ilość mleka:6�   �� 5e      -   5        $��
milkAmount��5e      $��2��6(   $��1��65   $��24(�6E   $��Tw Cen MT Condensed)�6S   $��Center=�6t   .��6�   .��5f      �� $ 
milkAmount�6   $ PropertyChanged=�6-    �� StringFormat$ 	{0:#.000}��6S    �� ValidationRules 5g        Mleczarnia.MilkValidator  5h      5j      5k      � 5m      $��2��6   $��5��6'   	 5n      �� 5o      $��* �6'   63   �� 5p      $��* �6'   63   .+�5r      ��   RoundedButtonStyle#��[ 6   $	��5pxq�6F   $	��2pxq�6S   $��Tw Cen MT Condensed)�6a   $��24(�6�   $��cmds:Commands.Delete��6�   ���	#FFCD7272.��5s      �� $ 
Horizontal=�6!   .+�5t      �� $��30��6    $��appbar.delete.png��6,   $
��Fill=�6G   $��30��6V   $��Center=�6a   $��Center=�6~   �� 5u      $��Center=�6$   $��Center=�6A   $��19(�6\   Usuń6p   5v      5w      �� 5x      #��[ 6   $��1��6F   $	��5pxq�6V   $	��2pxq�6c   $��Tw Cen MT Condensed)�6q   $��24(�6�   $��cmds:Commands.Return��6�   ���	#FF78BACE.��5y      �� $ 
Horizontal=�6!   .+�5z      �� $��30��6    $��appbar.arrow.left.png��6,   $
��Fill=�6K   $��30��6Z   $��Center=�6e   $��Center=�6�   �� 5{      $��Center=�6$   $��Center=�6A   $��19(�6\   	Powrót6r   5|      5}      5~      5      5�      5�      