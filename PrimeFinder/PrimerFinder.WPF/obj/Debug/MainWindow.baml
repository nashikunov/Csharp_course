   M S B A M L   `   `   `  ����K  GPrimerFinder.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PrimerFinder.WPFPrimerFinder.WPF  5   	   !    PrimerFinder.WPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:PrimerFinder.WPF     5   	     � Title$  Prime finder��5   	   $	��350��6   $	��525��6+   $��14(�67   .��5	      � $��5q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��5q�6   
Enter n:6)   �� 5   
   -   5        $��textBoxNumber��5      $��25��6   $��1��63   6E   �� 5   
   -   5        $��
buttonFind��5      $��2��6#   $	��5 0q�63   $	��100��6@   .��6e   Find!6l   �� 5   
   -   5        $��buttonCancel��5      $��3��6%   $	��5 0q�65   $	��100��6B   .��6N   	Cancel!6W   �� 5   
   -   5        $��listBoxPrimes��5      $��1��6'   $��4��64   $��0 5 0 0q�6H   5      5      