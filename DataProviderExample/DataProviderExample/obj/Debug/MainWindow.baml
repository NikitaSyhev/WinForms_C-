   M S B A M L   `   `   `  ����N  JDataProviderExample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:DataProviderExampleDataProviderExample  5   	   $    DataProviderExample.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:DataProviderExample     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         hobbitsProvider S� 
ObjectType$   DataProviderExample.Detachment S� 
MethodName��%@   &	        S� 5   
   "  5      $ 
GetHobbits��5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5$   
   �� -   5         ��Name$ hobbitsList002��5$      $��0��5%      $��0��6#   $��5��60   $��2��6A   $��20(�5&      ��5$   +   ��  �� Source# [   �� View 5'      �� 5(      .P�5)      �� 	 �� DisplayMemberBinding	 6%   �� 
 �� Path$
 id�.��6N   
Номер6U   �� 5*       �� Width$	 100��6P   	 6%   �� $

 name�.��6\   Имя6a   �� 5+      	 6%   �� $

 role�.��6P   
Роль6V   5,      5.      �� 51   
   -   5         ��Name$ 
hobbitsBox��51       �� DisplayMemberPath$
 name��6'   $��2��52      $��0��6#   $��30(�60   ��51   @   �� # [  52   >   �� 54   
   -   5         ��Name$ tbEditedName��54      $��3��6(   $��0��68   $��30(�6E   �� 55   
   -   5         ��Name$ btnAdd��55      $��Добавить��6!   $��4��56      $��0��6!   $��30(�6.   58      59      