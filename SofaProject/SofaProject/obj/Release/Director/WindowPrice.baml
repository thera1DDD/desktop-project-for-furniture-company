   M S B A M L   `   `   `  ���� F  BSofaProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SofaProject.DirectorSofaProject.Director  &     SofaProject.Director.WindowPrice   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     4local"clr-namespace:SofaProject.Director     -     � WindowStartupLocation$  CenterScreen=� � WindowState$ Normal=� � Title$ Товары��$	��700��$
��1100��.���  � 	Resources  �� Color��%B   (��       * SystemColors.HighlightBrushKey+)�� $ DarkGray��.+��� $	��Top=� �� Orientation$ 
Horizontal=�$
��Left=�.+��� $��Поиск: ���� -    ��Name$ 	TXtSearch��$	��300���� $��Bottom=�$
��Left=�.+�&   System.Windows.Controls.DataGrid  -   $��	GridPrice��$
��10pt(�$	��620��$	��565��"   VerticalScrollBarVisibility$
 Auto=�   AutoGenerateColumns .  	   Columns	 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn
   Header$
 Название��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Title+  $
 Размеры��$ *  �� *Size+  $)
 #Время изготовления��$ *  �� *	TimeCraft+  $
 Цена��$ *  �� *Price1+  $
 В наличии��$ *  �� *	InStock+�� $��Bottom=�$��Right=�.+��� -   $��PictureBoxPrice��$	��365��$��Bottom=�$	��510���� -   $��txtDescription��$
��10pt(�$	��250��$��Bottom=�$	��510��