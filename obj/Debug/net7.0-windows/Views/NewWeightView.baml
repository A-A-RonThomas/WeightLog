   M S B A M L   `   `   `  ����D  @WeightLog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WeightLog.ViewsWeightLog.Views  5   	   #    WeightLog.Views.NewWeightView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WeightLog.Views     5   	     � Title$  NewWeightView��5   	   $	��300��6   $	��400��6,    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�5
   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��8* �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��8* �6   �� 5      $��2* �6   .+�5   
   (  "System.Windows.Controls.DatePicker  $��1��6   $��2��5      $��Right=�5      $��Center=�5      $��0q�5         IsTodayHighlighted$
 True��5         SelectedDate 5      �� *SelectedDate+5      � 5!   
   $��1��6   $��1��6    5"      �� 5#      $
��2.2* �6#   �� 5$      $��8* �6#   �� 5%      $
��2.2* �6#    5(      �� 5)      $��2* �6    �� 5*      $��5* �6    �� 5+      $
��1.5* �6    .+�5.      �� $��1��5/      $��25(�50      $��Center=�51      $��Center=�52      ��5.      �� *Date+52      �� 54      $��1��6   $��1��55      $��Center=�56      $��Center=�57      $��0 0 0 60q�58      �� 5:      -   5         ��Name$ 	WeightNum��5:      $��1��5;      $��1��5<      $	��100��5>      $��20(�5?      $��Center=�5@      $��Center=�5A      ��5=      �� *	WeightNum+ �� UpdateSourceTrigger$ PropertyChanged=�5A      � 5C      $��2��6   $��1��6     5D      �� 5E      $��1* �6'   �� 5F      $��1* �6'   .+�5I      �� $	��Add��6   $��0��5J      $
��Auto��5K      ��5L      �� *Add+��5M      �� 	 �� RelativeSource	 �� 
 �� Mode$
 FindAncestor=� �� AncestorType" ��� 5O      $��Cancel��6   $��1��5P      $
��Auto��5Q      ��5R      �� *Cancel+��5S      �� 	 �� $
 FindAncestor=�" �5T      5U      5V      5W      