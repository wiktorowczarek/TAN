   M S B A M L   `   `   `  ????E  AWpfExample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfExample
WpfExample  5   	       WpfExample.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WpfExample     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $
??Auto ?6   .+?5   
   &   System.Windows.Controls.DataGrid  $??0??64   $??0??6A   $??15(?6Q      AutoGenerateColumns$ False??5      ??5      ?? *
Students+   RowStyle 5      ?? 5       ?? 
TargetType)  #System.Windows.Controls.DataGridRow"  6    ?? Triggers 5      ?? 5       ?? Binding 6&   ?? *Status+ ?? Value 
Skreślony6A   .a?5      ?? 	 ?? Property	 ? ??
 ?? Value

 ? ???6L   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Index number??6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   ?? *IndexNumber+  5      $ 
First name??6%    69   ?? *	FirstName+  5       $ 	Last name??6%    68   ?? *
LastName+4  .System.Windows.Controls.DataGridTemplateColumn  5!      $ Photo??6)      CellTemplate 5"      ?? 5#      .R?5$      ?? $	??100??6A   ??6$   ?? *	PhotoPath+6A   5%      5'        5(      $ 
Birth date??6)    5)      ?? 5*      .R?5+      (  "System.Windows.Controls.DatePicker  $??0q?6L      SelectedDate 6)   ?? *	BirthDate+6L   5,      5.        5/      $
 City??6%    63   ?? *City+51      ?? 52   
   $??1??6   $??0??6"   $??20q?62   .+?53      ?? -   5        $??Dodaj studenta??53      $
??Left=?6P   $??10q?6k   54      55      56      