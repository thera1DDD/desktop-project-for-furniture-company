   M S B A M L   `   `   `  ���� F  BSofaProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SofaProject.DirectorSofaProject.Director  &     SofaProject.Director.WindowOrder   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     4local"clr-namespace:SofaProject.Director       � Title$  Окно заказов�� � WindowStartupLocation$ CenterScreen=�$
��1200��$	��600��.���  � 	Resources  �� Color��%B   (��       * SystemColors.HighlightBrushKey+)�� $ DarkGray��.+���  �� Orientation$ 
Horizontal=�$
��Left=�$	��Top=�.+�o� -   $��MenuItemProg��
�������$��75��$��25��.@�m� $��Программа��.@�m� -   $��
Выход��o� -   $��MenuItemPrice��
�������$��50��$��25��.@�m� -   $��
Прайс��o� -   $��MenuSpravochnik��
�������$��78��$��25��.@�m� $��Справочник��$��75��.@�m� -   $��MenuRekvizits��$#��Реквизиты фирмы��m� -   $��MenuClientItems��$��Клиенты��m� -   $��MenuDoljnostiItems��$��Должности��o� -	   $��	MenuAbout��
�������$	��100��$��25��.@�m� -
   $��MenuAboutItem��$��О программе���� .+�&   System.Windows.Controls.DataGrid  -     Name$ GridOrderList��   
IsReadOnly .  $��	3,35,0,35q�$	��482��$��14(�   AutoGenerateColumns .  "   VerticalScrollBarVisibility$
 Auto=����� 	 �� 
TargetType)  #System.Windows.Controls.DataGridRow"	  .��� 
 �� Property
 � �� �� Value
 ����� �� Triggers ��  �� Binding �� *Status+ �� Value 
Готов.a��� 
 � ��
 �   ��� 
 � ��
 ������  �� *Status+ Не готов.a��� 
 � ��
 �   ��� 
 � ��
 �\\����  �� *Status+ Отменен.a��� 
 � ��
 �   ��� 
 � ��
 �iii�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$ Номер заказа��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
ID_Order+  $ Дата заказа��$ *  �� *	DateStart+ �� StringFormat$ 
dd.MM.yyyy��  $# Дата готовности��$ *  �� *	DateEnd+$ 
dd.MM.yyyy��  $ Стоимость��$ *  �� *	PriceFull+  $" С учётом скидки��$ *  �� *PriceDiscount+  $ Статус��$ *  �� *Status+  $ Клиент��$ *  �� *Client.Title+  $! Заказ принимал��$ *  �� *Employee.Name+�� $ 
Horizontal=�$��Center=�$��Bottom=�.+��� -   $��BtnViewDetails��$%��Просмотр деталей���� -   $��BtnEditOrder��$+��%Редактировать заказ���� -   $��BtnNewOrder��$��Новый заказ���� -   $��	BtnUpdate��$��Обновить���� -   $��	BtnDelete��$��Удалить���� $ 
Horizontal=�$��Right=�$��Bottom=�.+��� -   $��BtnExit��$��
Выход���� $��Bottom=�$ 
Horizontal=�.+��� $/��)Текущий пользователь: ���� -   $��LabelCurrentUser��$
��1040��$��DemiBold"�$��ФИО��