   M S B A M L   `   `   `  ���� F  BSofaProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SofaProject.DirectorSofaProject.Director  )    #SofaProject.Director.WindowNewOrder   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     4local"clr-namespace:SofaProject.Director     -     � WindowStartupLocation$  CenterScreen=� � Title$ Новый заказ��$	��615��$��668.5��.��� .+��� $	��Top=�$
��Left=�$��	10,65,0,0q�$	��480��.+���  �� Orientation$ 
Horizontal=�$	��Top=�$
��Left=�.+��� $	��120��$"��Принимал заказ:���� -   $��CmbPrinimal���� $ 
Horizontal=�$	��Top=�$
��Left=�.+��� $	��120��$��Клиент:���� -   $��
CmbClients���� $ 
Horizontal=�$	��Top=�$
��Left=�.+��� $	��120��$"��Скидка клиента:���� -   $��TxtDiscount���� $ 
Horizontal=�$	��Top=�$
��Left=�.+��� $	��120��$"��Группа изделий:���� -   $��CmbMebelGroup���� $ 
Horizontal=�$	��Top=�$
��Left=�.+��� $	��120��$��Изделие:���� -   $��CmbMebelTitle���� $ 
Horizontal=�$	��Top=�$
��Left=�.+��� $	��120��$��Количество:���� -   $��TxtCoutMebel���� $ 
Horizontal=�$	��Top=�$
��Left=�.+��� $	��120��$��Исполнитель:���� -   $��	CmbMaster���� $ Vertical=�$��Bottom=�$
��Left=�.+��� -	    ��Name$ BtnEnterOrder��$	��110��$��К заказу���� -
   $ BtnAddOrder��$��Добавить��$	��109���� -   $ BtnPrint��$��Печать��$	��109���� -   $��DataContextPrint��$	��Top=�$��Right=�.+��� $ 
Horizontal=�$��Center=�.+��� $��
Итог: ��$��15(��� .+��� $,��&Наименование товара:��$��28���� -   $��TxtNameIzdelie��$��35��$	��340���� .+��� $��Количество:��$��29���� -   $��TxtCountItog��$��35��$	��340���� .+��� $3��-Дата выполнения позиции:��$��29���� -   $��TxtDataEndItog��$��35��$	��340���� .+��� $(��"Стоимость позиции:��$��29���� -   $��TxtSummaItog��$��35��$	��340���� .+��� $��Дата заказа:��$��35���� -   $��TxtDateStartOrderItog��$��35��$	��340���� .+��� $.��(Стоимость  со скидкой:��$��28���� -   $��TxtDiscountPriceItog��$��35��$	��340��