   M S B A M L   `   `   `  ����=  9HW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:HWHW  5   	       HW.TableWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:HW     5   	     � Title$  TableWindow��5   	   $	��600��6   $	��700��6*    � WindowStartupLocation$ CenterScreen=�66    � 
ResizeMode$ NoResize=�6[   ���	#FFE4DDD3.��5	      �  � RowDefinitions 5
   
   �� 5      $��50 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5        $
��Exit��5      $��40��6    $��38��6+   $��	0,6,297,6q�67   $��Right=�6J    � Cursor$
 Hand��6   �� 5   
   -   5        $��	FavButton��5      $	��200��6"   $��1��6.   $��Center=�6>   $	��0 6q�6[   $��	Favourite��6h   $��20(�6|   $
 Hand��6�   {�.  6�   �� 5   
   -   5        $
��Edit��5      $��1��6    $��38��60   $��40��6<   $��278.5,6,0,6q�6G   $��14(�6\   $
��Left=�6�   $
 Hand��6�   �� 5   
   $��Select the route number��6   $��1��63   $��2��6@   $��20(�6T   $
��Bold"�6}    �� TextAlignment$ Center=�6�   ��6b   Z� 6�   �� 5   
   $��Select the right station��6   $��2��64   $��2��6A   $��20(�6U   $
��Bold"�6~   $ Center=�6�   ��6c   Z� 6�   �� 5   
   -   5        $��comboBoxRoutes��5      $��1��6)   $��2��67   $��40��6K   $	��400��6W   $��Center=�6c   $��3q�6~   $
 Hand��6�   ��5      �� 5      .R�5       �� ��6    �� 5!      5#      �� 5%   
   -   5        $��OkRouteButton��5%      $��OK��6&   $��1��63   $��1��6@   $��50��6P   $��40��6[   $��204.5,30,0,30q�6g   $
��Left=�6�   �� 5'   
   -   5        $��OkStopButton��5'      $��OK��6%   $��2��62   $��1��6?   $��40��6O   $��50��6[   $��204.5,30,0,30q�6�   $
��Left=�6�   $
 Hand��6�   {�.  6�   �� 5)   
   -   5        $��Reset��5)      $��2��6!   $��1��6.   $��40��6>   $��70��6J   $��267.5,30,0,30q�6U   $
��Left=�6�   $
 Hand��6�   �� 5+   
   -   5        $��comboBoxStops��5+      $��2��6(   $��2��66   $��40��6J   $	��400��6V   $��Center=�6b   {�.  $��3q�6�   $
 Hand��6�   ��5,      �� 5-      .R�5.      �� ��6    �� 5/      51      &   System.Windows.Controls.DataGrid  53   
   -	   5        $��dataGridTable��53      $��3��6(   $��2��65      AutoGenerateColumns .     
IsReadOnly . 	   Columns	 54      0  *System.Windows.Controls.DataGridTextColumn  55      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 1* 6%      Header$ 
Bus number��60   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *
Route.Name+  56      $
 1* 6%   $ Station��60    6A   �� *SelectedStation+  57      $
 1* 6%   $ Destination��60    6E   �� *LastStation+  58      $
 1* 6%   $ Minutes��60    6A   �� *Minute+5;      5@      5A      