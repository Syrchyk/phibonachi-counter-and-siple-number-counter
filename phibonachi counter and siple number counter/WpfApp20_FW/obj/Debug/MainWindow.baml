   M S B A M L   `   `   `  ����F  BWpfApp20_FW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfApp20_FWWpfApp20_FW  5   	       WpfApp20_FW.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfApp20_FW     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � 
������� � ColumnDefinitions 5
   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� -   5        $��tbStart��5      $��0��6!   $��0��6.   $��20q�6>   6M   �� 5   
   -   5        $��tbStop��5      $��0��6    $��1��6-   $��20q�6=   6K   �� 5   
   -   5        $��1��5      $��0��6   $��20q�6.   .��6O   Start6V   �� 5   
   -   5        $��1��5      $��1��6   $��20q�6.   .��6Q   Stop6W   �� 5   
   -   5        $��2��5      $��1��6   $��20q�6.   .��6Q   Pause/Resume6_   �� 5   
   $��2��6   $��0��6!   $��20q�61   $��Center=�6=   $��Center=�6Z   Phibonachi numbers6�   �� 5   
   -   5        $��3��5      $��0��6   $��20q�6.   .��6Q   Start6X   �� 5   
   -   5        $��3��5      $��1��6   $��20q�6.   .��6Q   Stop6W   �� 5   
   -   5        $��4��5      $��1��6   $��20q�6.   .��6Q   Pause/Resume6_   �� 5   
   -	   5        $��4��5      $��0��6   $��20q�6.   .��6Q   	Reset All6\   5       5!      