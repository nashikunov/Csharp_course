   M S B A M L   `   `   `  ����K  GStudentGrades.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:StudentGrades.UIStudentGrades.UI  5   	   +    %StudentGrades.UI.AddEditStudentWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:StudentGrades.UI     5   	     � Title$  AddEditStudentWindow��5   	   $	��360��6&   $	��400��63    � WindowStyle$ SingleBorderWindow=�6?    � WindowStartupLocation$ CenterOwner=�6`   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��Center=�6   Name65   �� 5   
   -   5        $��textBoxName��5      $��1��6%   $��20��65   $��5q�6A   6O   &   System.Windows.Controls.DataGrid  5   
   -   5        $��dataGridGrades��5      $��1��6)   $��2��66      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Course��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 1* 65   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6@   �� *Course.Name+  5      $ Credits��6%   
 66   �� *Course.Credits+  5      $ Grade��6%   
 64   �� *Value+5      �� 5    
   -   5        $��textBlockRating��5       $��5q�6+   $��2��66   Rating6K   �� 5$   
    �� Orientation$ 
Horizontal=�6   $��3��6.   $��2��6;   $��Center=�6O   $��Bottom=�6l   $��0 10 0 0q�6�   .+�5%      �� -   5        $	��100��5%      $��25��6!   $��5q�6-   .��6O   OK6S   �� 5&      -   5        $	��100��5&      $��25��6!   $��5q�6-   .��6S   Cancel6[   5(      5)      5*      