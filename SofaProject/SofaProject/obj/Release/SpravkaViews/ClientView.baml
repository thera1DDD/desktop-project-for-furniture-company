   M S B A M L   `   `   `  ���� F  BSofaProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SofaProject.SpravkaViewsSofaProject.SpravkaViews  )    #SofaProject.SpravkaViews.ClientView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     8local&clr-namespace:SofaProject.SpravkaViews     -     � WindowStartupLocation$  CenterScreen=� � Title$ Клиенты��$	��585��$	��800��.��� .+���  �� Orientation$ 
Horizontal=�$	��Top=�.+��� $��Поиск: ���� -   $��TxtSearchClients��$	��355���� $��Bottom=�$ 
Horizontal=�.+�&   System.Windows.Controls.DataGrid  -   $��GridClients��   AutoGenerateColumns .  "   VerticalScrollBarVisibility$
 Auto=�$	��400��$	��500��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$- 'Название организации��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Title+  $$ Контактное лицо ��$ *  �� *ContactPerson+�� $
��Left=�.+��� $.��(Название организации:���� -   	 ��Name$	 TxtTitleOrg��$	��300���� $$��Контактное лицо:���� -   $	 TxtContactPerson��$	��300���� $��Адрес:���� -   $	 
TxtAddress��$	��300���� $��Телефон:���� -   $	 TxtPhone��$	��300���� $��Заметки:���� -   $	 
TxtZametki��$	��300���� $��Скидка:���� -	   $	 TxtDiscount��$	��300���� $��Код ИНН:���� -
   $	 
TxtCodeINN��$	��300���� $��Код КПП:���� -   $	 
TxtCodeKPP��$	��300���� $
��Left=�.+��� -   
 ��Name$
 BtnAdd��$��Добавить���� -   $
 BtnSave��$��Сохранить���� -   $
 BtnDel��$��Удалить��