   M S B A M L   `   `   `  ????C  ?MvvmDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MvvmDemo.ViewsMvvmDemo.Views  5      !    MvvmDemo.Views.EMployeeView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:MvvmDemo.Views     5      
???????.??5	      ?   ? RowDefinitions  5
   
   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6    ? ColumnDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $??* ?6   .+?5   
   ?? $??0??6   $??0??6    $??2??6-   $??33(?6A   .??6O   Employee Management6d   ?? 5   
   $??0??6   $??1??6    $??20(?6-   .??6;   	Enter Id:6F   ?? 5   
   $??0??6   $??2??6    $??20(?6-   .??6;   Enter Name:6H   ?? 5   
   $??0??6   $??3??6    $??20(?6-   .??6;   
Enter Age:6G   ?? 5   
   -   5        $??txtId??5      $??1??6   $??1??6/   ??6<   ??  ?? Path$ CurrentEmployee.Id? ?? Mode$ TwoWay=?6s   ?? 5   
   -   5        $??txtName??5      $??1??6!   $??2??61   ??6>   ?? $ CurrentEmployee.Name?$ TwoWay=?6w   ?? 5   
   -   5        $??txtAge??5      $??1??6    $??3??60   ??6=   ?? $ CurrentEmployee.Age?$ TwoWay=?6u   ? 5   
   $??1??6   $??4??6    5       ?? 5!      $??* ?6#   ?? 5"      $??* ?6#   ?? 5#      $??* ?6#   ?? 5$      $??* ?6#   .+?5&      ?? -   5        $
??btn1??5&      $??0??6!   ??61   ?? $ SaveCommand?.??6V   ADD6[   ?? 5'      -   5        $
??btn2??5'      $??1??6!   ??61   ?? $ SearchCommand?.??6X   SEARCH6`   ?? 5(      -   5        $
??btn3??5(      $??2??6!   ??61   ?? $ UpdateCommand?.??6X   UPDATE6`   ?? 5)      -   5        $
??btn4??5)      $??3??6!   ??61   ?? $ DeleteCommand?.??6X   DELETE6`   5*      ?? 5+   
   -   5        $??TextBlockMessage??5+      $??5??6,   $??1??69   ??6I   ?? $ Message?$ TwoWay=?5,      &   System.Windows.Controls.DataGrid  5-   
   -	   5        $??
dgEmployee??5-         AutoGenerateColumns .  $??6??6A   $??1??6N   $??2??6^   ??6o   ?? $ EmployeeList?   Columns 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn   Header$ Employee Id??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6:   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6G   ?? $ Id?$ TwoWay=?  50      $ Employee Name??6%   $
 auto 6<    6I   ?? $
 Name?$ TwoWay=?  51      $ Employee Age??6%   $
 auto 6;    6H   ?? $	 Age?$ TwoWay=?53      55      56      