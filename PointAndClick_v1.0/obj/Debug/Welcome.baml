   M S B A M L   `   `   `  ����M  IPointAndClick_v1.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:PointAndClick_v1._0PointAndClick_v1._0  5      !    PointAndClick_v1._0.Welcome   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:PointAndClick_v1._0     5        N� Title$  Welcome��5	       N� 	KeepAlive . .��5      � ���	#FFF0F0F0$��0q�6"    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $	��100 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��2��6   $��0��6%   
���   �$��0,1,0,0q�6F   �� 5   
   $��2��6   $��2��6%   ���#a0a0a0$��0,1,0,0q�6H   �� 5   
   
�������$��2��6$   $��1��68   �� 5%   
   -   5         ��Name$ 	textBlock��5%      $
��Left=�6'   $��	10,10,0,0q�6B   $
��Wrap=�6U   $��Import Products Data��6i   $	��Top=�6�   ���	#FF0080C0$��18(�5&   +   $
��Bold"�69   $��0��6K   $��0��6[   (� 51   
   $��Stretch=�6   $��Stretch=�60   $��2��6L   $��1��6`    J� OpacityMask
 �   �.��52      � $��2��6   $��1��6'    53      �� 54      $��* �6$   �� 55      $��* �6$   �� 56      $��60 �6$   �� 57      $��* �6$    59      �� 5:      $	��100 �6'   �� 5;      $��* �6'   �� 5<      $	��100 �6'   .+�5?      �� -   5         ��Name$ 
csvTextBox��5?      $��0��6.   $��0��6>   $��Right=�6K   $��0,0,0,0q�6g   $��CSV Data��6x   $��Center=�6�   $��14(�5@      $��0q�6(    �� 
IsReadOnly . ��5?   �   Z� 5@   =   �� 5A      -   5         ��Name$ importImage��5A      $��1��6-   $��0��6=   $��Center=�6J   $��0,0,0,0q�6g   $��welcomeImage.png��6x   $��Center=�6�   �� 5B      -   5        $ databaseTextBox��5B      $��2��63   $��0��6C   $
��Left=�6P   $��	-10,0,0,0q�6k   $��PostalMate
Database��6~   $��Center=�6�   $
��Bold"�5C   1   $��0q�6C    . ��6   Z� 6W   �� 5F      -   5        $ welcomeField��5F      $��3��60   $��1��6D   $X��RThis utility is designed to import exported CSV data into the PostalMate database.��6Q   	 �� TextWrapping$
	 Wrap=�6�   
�������$��Center=�5G   -   $	��Top=�6J    . $��0q�6v   ��6�   Z� �� 5H      -   5        $ warningField��5H      $��3��60   $��2��6D   $b��\Please check the following to indicate that you have read the information and understand it:��6Q   $��0q�6�   $
	 Wrap=�5I      
�������$
��Bold"�6A   $��Center=�6S   $��Bottom=�6p   $��	-10,0,0,0q�6�    . ��6�   Z� �� 5K      -   5        
 ��Name$
 	checkBox1��5K      $����The very first row of your CSV export must contain all of the column header information and
it cannot contain any extraneous information.��6.   $
��Left=�5L      $��50,-40,10,0q�66   $��3��6K   $��3��6_   $��Center=�6l   6�   �� 5M      -   5        $
 	checkBox2��5M      $����This import utility is designed to be used one time only. After the specified import is completed
the utility should not be ran again.��6.   $
��Left=�5N      $��
50,30,10,0q�66   $��3��6J   $��3��6^   $��Center=�6k   6�   �� 5O      -	   5        $
 	checkBox3��5O      $b��\A backup copy of your exported CSV data should be made prior to running this import utility.��6.   $
��Left=�5P      $��50,100,10,20q�66   $��3��6L   $��3��6`   $��Center=�6m   6�   5Q      5R      �� 5U   
   -
   5         ��Name$ cancelButton��5U      $
��Left=�6'   $	��Top=�6B   $	��115��6Z   $��50��6f   $��14(�6r   $��	10,10,0,0q�6�   $��0��6�   $��2��6�   .��5V      ��  �� Orientation$ 
Horizontal=�6   .+�5W      �� -   5        $ Cancel��5W      $��
cancel.png��6(   $��24��6<   $��24��6G   �� 5X      $��Cancel��6    �� Padding$ 2,2,0,0q�6*   5Y      5Z      �� 5]   
   -   5        $ 
nextButton��5]      $��Right=�6%   $	��Top=�6A   $	��115��6Y   $��50��6e   $��14(�6q   $
��Bold"�6   $��	0,10,10,0q�6�   $��1��6�   $��2��6�   {�.  .��5^      �� $ 
Horizontal=�6   .+�5_      �� -   5        $
 Next��5_      $��next.png��6&   $��24��68   $��24��6C   �� 5`      $
��Next��6   $ 2,2,0,0q�6(   5a      5b      5e      5g      