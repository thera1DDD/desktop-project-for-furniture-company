   M S B A M L   `   `   `  ����F  BSofaProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SofaProject.DirectorSofaProject.Director  5   	   &     SofaProject.Director.WindowOrder   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:SofaProject.Director     5   	     � Title$  Окно заказов��5   	    � WindowStartupLocation$ CenterScreen=�5	   	   $
��1200��5
   	   $	��600��5   	   .��5      �  � 	Resources 5   
    �� Color��%U   (��       5      * SystemColors.HighlightBrushKey+)�� 6   $ DarkGray��6P   5      .+�5      ��  �� Orientation$ 
Horizontal=�5      $
��Left=�5      $	��Top=�5      .+�5      o� -   5        $��MenuItemProg��5      
�������$��75��5      $��25��5      .@�5      m� $��Программа��6   .@�5      m� -   5        $��
Выход��5   #   6K   5      5      o� 5      -   5        $��MenuItemPrice��5"      
�������$��50��5       $��25��5!      .@�5$      m� -   5        $��
Прайс��5&      5'      5(      o� 5)      -   5        $��MenuSpravochnik��5-      
�������$��78��5+      $��25��5,      .@�5/      m� $��Справочник��6   $��75��6/   .@�50      m� -   5        $��MenuRekvizits��50   8   $#��Реквизиты фирмы��6   6l   m� 51      -   5        $��MenuClientItems��51   0   $��Клиенты��6   6g   m� 52      -   5        $��MenuDoljnostiItems��52   2   $��Должности��6   6o   53      55      o� 56      -	   5        $��	MenuAbout��59      
�������$	��100��58      $��25��5:      .@�5;      m� -
   5        $��MenuAboutItem��5;      $��О программе��6L   5<      5=      5>      �� 5?      .+�5@      &   System.Windows.Controls.DataGrid  -   5          Name$ GridOrderList��5C         
IsReadOnly .  $��	3,35,0,35q�5B      $	��482��5D      $��14(�5E         AutoGenerateColumns .  "   VerticalScrollBarVisibility$
 Auto=�5G      ��5I      �� 5J      	 �� 
TargetType)  #System.Windows.Controls.DataGridRow"	  6   .�5K      �� 
 �� Property
 � �� �� Value
 �����67    �� Triggers 5L      �� 5M       �� Binding 6*   �� *Status+ �� Value 
Готов6E   .a�5N   "   �� 
 � ��
 �   �6?   �� 5O   "   
 � ��
 ����6?   5P      �� 5Q       6*   �� *Status+ Не готов6E   .a�5R   "   �� 
 � ��
 �   �6?   �� 5S   "   
 � ��
 �\\��6?   5T      �� 5U       6*   �� *Status+ Отменен6E   .a�5V   "   �� 
 � ��
 �   �6?   �� 5W   "   
 � ��
 �iii�6?   5X      5Z         Columns 5\      0  *System.Windows.Controls.DataGridTextColumn  5]      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$ Номер заказа��6;      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6n   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6Q   �� *
ID_Order+6n     5^      $ Дата заказа��6)   $ * 6u    6>   �� *	DateStart+ �� StringFormat$ 
dd.MM.yyyy��6u     5_      $# Дата готовности��6)   $ * 6w    6B   �� *	DateEnd+$ 
dd.MM.yyyy��6w     5`      $ Стоимость��6)   $ * 6Z    6<   �� *	PriceFull+6Z     5a      $" С учётом скидки��6)   $ * 6d    6B   �� *PriceDiscount+6d     5b      $ Статус��6)   $ * 6T    69   �� *Status+6T     5c      $ Клиент��6)   $ * 6Z    69   �� *Client.Title+6Z     5d      $! Заказ принимал��6)   $ * 6c    6A   �� *Employee.Name+6c   5f      5g      �� 5h   
   $ 
Horizontal=�5i      $��Center=�5j      $��Bottom=�5k      .+�5l      �� -   5        $��BtnViewDetails��5m      $%��Просмотр деталей��5n      5o      �� 5p      -   5        $��BtnEditOrder��5s      $+��%Редактировать заказ��5r      5s      �� 5t      -   5        $��BtnNewOrder��5u      $��Новый заказ��5w      �� 5x      -   5        $��	BtnUpdate��5y      $��Обновить��5{      5|      �� 5}   
   $ 
Horizontal=�5~      $��Right=�5      $��Bottom=�5�      .+�5�      �� -   5        $��BtnExit��5�      $��
Выход��5�      5�      5�      �� 5�   
   $��Bottom=�5�      $ 
Horizontal=�5�      .+�5�      �� $/��)Текущий пользователь: ��5�      �� 5�      -   5        $��LabelCurrentUser��5�      $
��1040��5�      $��DemiBold"�5�      $��ФИО��5�      5�      5�      5�      5�      