   M S B A M L   `   `   `  ����E  AMleczarnia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Mleczarnia
Mleczarnia  5   	   'clr-namespace:Mleczarnia
Mleczarnia  5   	       Mleczarnia.FarmsWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Mleczarnia     5   	   )cmdsclr-namespace:Mleczarnia     5   	     � Title$  Gospodarstwa��5	   	   $	��400��6   $	��800��6+   $	��400��67   $	��800��6G   ���	#FF83FF80 J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ cmds:Commands.Delete��5      6W     5   
   -   5        $ cmds:Commands.Return��5      68     5   
   -   5        $ cmds:Commands.Add��5      65    � 	Resources 5         ElementTemplate �� CornerRadius �� Orientation  GroupTemplate �� Padding �� Path��%P  &	        &	 �    �� 5   
   .R�5      �� ���	#FF76EDA6$��1q�6,   $��1q�6@   
���   �$ 6��6`   $��Stretch=�6q   $��Center=�6�   ._�5      �� $	��2pxq�6   $ 
Horizontal=�6,   $��Center=�6E   $��Center=�6b   .+�5      �� $��20(�66   $��Tw Cen MT Condensed)�6D   $
��Bold"�6e   $��Right=�6w   ��6   �� *name+6�   �� 5      $��20(�69   $��Tw Cen MT Condensed)�6G   $
��Bold"�6h   $
��Left=�6z   ��6   �� *	surname+6�   �� 5      $��20(�68   $��Tw Cen MT Condensed)�6F   ��6   �� *adress+6j   �� 5      $��20(�65   $��Tw Cen MT Condensed)�6C   ��6   �� *nip+6g   5      5      5      �� 5   
   .R�5      �� $
��Bold"�5      
�������
���"�"�$��0,5,0,0q�5      $ 3q�6*   ��5      �� $
 Name�5   *   5      5       .��5!      �  � RowDefinitions 5"   
   �� 5#      $
��auto �6   6,   �� 5$      $��* �6   6)   	 � ColumnDefinitions	 5&   
   �� 5'      $��2* �6   6,   �� 5(      $��* �6   6+   .+�5*   
   c� ���	#FFCBFFC9$��2��6)   .@�5+      �� $��cmds:Commands.Add��6   $	��Top=�61   .��5-      �� $ 
Horizontal=�6   .+�5.      �� $��20��6   $��appbar.add.png��6(   $
��Fill=�6@   $��20��6O   $��Center=�6Z   $��Center=�6w   �� 5/      $��Center=�6    $��Center=�6=   $��15(�6X   Dodaj6m   50      51      �� 52      
 �� SelectedIndex$
 0��6   .@�53      �� -   5        .��53   4   Bez grupowania6D   �� 54      -   5        .��54   7   &$Grupuj po pierwszej literze nazwiska6]   55      56      � 57   
   $��	5,5,2,5.4q�6   $��1��6"   .+�58      �� -   5        $��	farmsList��58   v   $��Stretch=�6   $��Stretch=�6:   ���	#FFCBFFC9$��4��6�   $��4��6�   #��[  6�    �� 
GroupStyle 59      (  "System.Windows.Controls.GroupStyle  5:         HeaderTemplate# [ 6!   5<      5=      � 5>   
   $��1��6   $��1��6   $��11,5,4.6,5.4q�6,    � DataContext 6C   ��  �� ElementName$ 	farmsList��$ SelectedItem� 5?      �� 5@      $��* �6    6-   �� 5A      $��* �6    6-   �� 5B      $��* �6    6-   �� 5C      $��* �6    6-   �� 5D      $
��0.7* �6    60   	 5F      �� 5G      $
��auto �6#   62   �� 5H      $��* �6#   6/   .+�5J      �� $��0��6   $��0��6!   $	��5pxq�61   $	��2pxq�6>   $��Tw Cen MT Condensed)�6L   $��24(�6m   $��Center=�6{   $��Center=�6�   .��6�   Imię:6�   �� 5K      -   5        $
��name��5K      $��0��6"   $��1��6/   $��24(�6?   $��Tw Cen MT Condensed)�6M   $��Center=�6n   .��6�   .��5L      �� $
 name�6    �� UpdateSourceTrigger$ PropertyChanged=�6&   5N      5O      �� 5P      $��1��6   $��0��6!   $	��5pxq�61   $	��2pxq�6>   $��Tw Cen MT Condensed)�6L   $��24(�6m   $��Center=�6{   $��Center=�6�   .��6�   	Nazwisko:6�   �� 5Q      -   5        $��surname��5Q      $��1��6&   $��1��63   $��24(�6C   $��Tw Cen MT Condensed)�6Q   $��Center=�6�   ��6r   �� $ surname�$ PropertyChanged=�6�   �� 5R      $��2��6   $��0��6!   $	��5pxq�61   $	��2pxq�6>   $��Tw Cen MT Condensed)�6L   $��24(�6m   $��Center=�6{   $��Center=�6�   .��6�   Adres:6�   �� 5S      -	   5        $��adress��5S      $��2��6$   $��1��61   $��24(�6A   $��Tw Cen MT Condensed)�6O   $��Center=�6�   ��6p   �� $ adress�$ PropertyChanged=�6�   �� 5T      $��3��6   $��0��6!   $	��5pxq�61   $	��2pxq�6>   $��Tw Cen MT Condensed)�6L   $��24(�6m   $��Center=�6{   $��Center=�6�   .��6�   NIP:6�   �� 5U      -
   5        $	��nip��5U      $��3��6!   $��1��6.   $��24(�6>   $��Tw Cen MT Condensed)�6L   $��Center=�6n   .��6�   .��5V      �� $	 nip�6   $ PropertyChanged=�6%    �� ValidationRules 5W        Mleczarnia.NIPRule  5X      5Z      5[      � 5\      $��2��6   $��5��6'   	 5]      �� 5^      $��* �6'   63   �� 5_      $��* �6'   63   .+�5a      ��   RoundedButtonStyle#��[ 6   $	��5pxq�6E   $	��2pxq�6R   $��Tw Cen MT Condensed)�6`   $��24(�6�   $��cmds:Commands.Delete��6�   ���	#FFCD7272��6�   �� $ 	farmslist��.��5c      �� $ 
Horizontal=�6!   .+�5d      �� $��30��6    $��appbar.delete.png��6,   $
��Fill=�6G   $��30��6V   $��Center=�6a   $��Center=�6~   �� 5e      $��Center=�6$   $��Center=�6A   $��19(�6\   Usuń6p   5f      5h      �� 5j      #��[ 6   $��1��6E   $	��5pxq�6U   $	��2pxq�6b   $��Tw Cen MT Condensed)�6p   $��24(�6�   $��cmds:Commands.Return��6�   ���	#FF78BACE.��5k      �� $ 
Horizontal=�6!   .+�5l      �� $��30��6    $��appbar.arrow.left.png��6,   $
��Fill=�6K   $��30��6Z   $��Center=�6e   $��Center=�6�   �� 5m      $��Center=�6$   $��Center=�6A   $��19(�6\   	Powrót6r   5n      5o      5p      5r      5s      5t      