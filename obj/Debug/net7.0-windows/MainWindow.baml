   M S B A M L   `   `   `  ����D  @WeightLog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WeightLog	WeightLog  5   	   1clr-namespace:WeightLog.ViewsWeightLog.Views  5   	       WeightLog.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WeightLog     5   	   /viewsclr-namespace:WeightLog.Views     5   	     � Title$  	WeightLog��5	   	   $	��450��6   $	��800��6(    � WindowStyle$
 None=�5
   	    � AllowsTransparency$
 True��6   
������ .��5      �  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��1* �6   .+�5   
   � $��0��6   
������� � ColumnDefinitions 5      �� 5      $��1* �6#   �� 5       $��60 �6#   .+�5#      � $��1��6   .+�5$      �  5%      �� 5&      $��1* �6+   �� 5'      $��1* �6+   .+�5*      �� -   5         ��Name$ Minimize��5*      $��0��5+      $��_��5,      
������ 
������ ��5/      �� *
Minimize+��50      ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" ��� 52      -   5        $ Close��52      $��1��53      $��X��54      
������ 
������ ��57      �� *Close+��58      ��  �� $ FindAncestor=�" �5:      5;      5<          WeightLog.Views.WeightView  5?   
   $��1��6   	 � DataContext	 5@      �� *CurrentViewModel+5A      5B      