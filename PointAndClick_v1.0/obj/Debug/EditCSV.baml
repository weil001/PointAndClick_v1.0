   M S B A M L   `   `   `  ����M  IPointAndClick_v1.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:PointAndClick_v1._0PointAndClick_v1._0  5      !    PointAndClick_v1._0.EditCSV   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:PointAndClick_v1._0     5        N� Title$  EditCSV��5	      .��5      � ���	#FFF0F0F0$��0q�6"    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $	��100 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��2��6   $��0��6%   
���   �$��0,1,0,0q�6F   �� 5   
   $��2��6   $��2��6%   ���#a0a0a0$��0,1,0,0q�6H   �� 5$   
   -   5         ��Name$ 	textBlock��5$      $
��Left=�6'   $��	10,10,0,0q�6B   $
��Wrap=�6U   $��Edit CSV Data��6i   $	��Top=�6~   ���	#FF0080C0$��18(�5%   +   $
��Bold"�69   $��0��6K   $��0��6[   �� 5)   
   $
��Left=�6   $	��100��6/   $��	0,290,0,0q�6<   $	��Top=�6O   $	��708��6g   $��2��6s   &   System.Windows.Controls.DataGrid  5,   
   -   5        $��csvDataGrid��5,      $��2��6&   $��1��6:      AutoGenerateColumns .    CanUserSortColumns . $ �� IsSynchronizedWithCurrentItem$
 TrueY�5/         
IsReadOnly .     SelectionUnit$
 Cell=�51      	   CanUserResizeColumns	 .  
   CanUserResizeRows
 .  $��14(�53   ]   ��6k   Z� ��6�   Z� 54      �� 56   
   -   5        $ DepartmentID��56      $
��Left=�6*   $��
140,10,0,0q�6E   $
��Wrap=�6Y   $K��EDepartmentRef: 0 - Default | 1 - Packing Materials | 2 - Rubber Stamp��6m   $	��Top=�6�   ���	#FF0080C0$��10(�57   +   $��2��69   $��3��6M   �� 58   
   -   5        $ DepartmentID2��58      $
��Left=�6+   $��
140,25,0,0q�6F   $
��Wrap=�6Z   $8��23 - Shipping | 4 - Insurance | 5 - Office Supplies��6n   $	��Top=�6�   ���	#FF0080C0$��10(�59   +   $��2��69   $��3��6M   �� 5:   
   -   5        $ TaxCategoryID��5:      $
��Left=�6+   $��
140,40,0,0q�6F   $
��Wrap=�6Z   $?��9TaxCategoryRef: 1 - Non-Taxable | 2 - General Merchandise��6n   $	��Top=�6�   ���	#FF0080C0$��10(�5;   +   $��2��69   $��3��6M   �� 5>   
   -   5         ��Name$ cancelButton��5>      $
��Left=�6'   $	��Top=�6B   $	��115��6Z   $��50��6f   $��14(�6r   $��	10,10,0,0q�6�   $��0��6�   $��3��6�   .��5?      ��  �� Orientation$ 
Horizontal=�6   .+�5@      �� -   5         ��Name$ Cancel��5@      $��
cancel.png��6(   $��24��6<   $��24��6G   �� 5A      $��Cancel��6    �� Padding$ 2,2,0,0q�6*   5B      5C      �� 5F   
   -   5        $ 
backButton��5F      $��Right=�6%   $	��Top=�6A   $	��115��6Y   $��50��6e   $��14(�6q   $��10,10,150,0q�6   $��1��6�   $��3��6�   .��5G      �� $ 
Horizontal=�6   .+�5H      �� -	   5        $
 Back��5H      $��back.png��6&   $��24��68   $��24��6C   �� 5I      $
��Back��6   $ 2,2,0,0q�6(   5J      5K      �� 5N   
   -
   5        $ BackupButton��5N      $��Right=�6'   $	��Top=�6C   $	��130��6[   $��50��6g   $��14(�6s   $��	0,10,10,0q�6�   $��1��6�   $��3��6�   .��5O      �� $ 
Horizontal=�6   .+�5P      �� -   5        $
 Next��5P      $��
export.png��6&   $��24��6:   $��24��6E   �� 5Q      $��Create Backup��6   $ 2,2,0,0q�61   5R      5S      5U      5X      