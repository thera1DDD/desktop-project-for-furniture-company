   M S B A M L   `   `   `  ����F  BSofaProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SofaProject.DirectorSofaProject.Director  5   	   &     SofaProject.Director.WindowPrice   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:SofaProject.Director     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � WindowState$ Normal=�5	   	    � Title$ Товары��5
   	   $	��700��6   $
��1100��6%   .��5      �  � 	Resources 5   
    �� Color��%U   (��       5      * SystemColors.HighlightBrushKey+)�� 6   $ DarkGray��6P   5      .+�5   
   �� $	��Top=�5       �� Orientation$ 
Horizontal=�5      $
��Left=�5      .+�5      �� $��Поиск: ��5      �� 5      -   5         ��Name$ 	TXtSearch��5      $	��300��5      5      5      �� 5   
   $��Bottom=�5      $
��Left=�5      .+�5      &   System.Windows.Controls.DataGrid  -   5        $��	GridPrice��5"      $
��10pt(�5      $	��620��5       $	��565��5!      "   VerticalScrollBarVisibility$
 Auto=�5#         AutoGenerateColumns .  	   Columns	 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Название��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Title+6U     5(      $
 Размеры��6)   $ * 6S    6:   �� *Size+6S     5)      $)
 #Время изготовления��6)   $ * 6c    6E   �� *	TimeCraft+6c     5*      $
 Цена��6)   $ * 6R    67   �� *Price1+6R     5+      $
 В наличии��6)   $ * 6X    6<   �� *	InStock+6X   5-      5.      �� 50   
   $��Bottom=�51      $��Right=�52      .+�53      �� -   5        $��PictureBoxPrice��54      $	��365��55      $��Bottom=�56      $	��510��57      �� 58      -   5        $��txtDescription��5:      $
��10pt(�59      $	��250��5;      $��Bottom=�5<      $	��510��5=      5>      5?      5@      