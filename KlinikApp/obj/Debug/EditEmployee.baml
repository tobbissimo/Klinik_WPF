   M S B A M L   `   `   `  ����  	KlinikApp    KlinikApp.EditEmployee   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5        .��5      �   � RowDefinitions  5	   
   �� 5
      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ employeeGrid��5       $��0��6      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Exams��6%      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   ��  �� Path$ Examinations.Count�6a   5      �� 5   
   -   5         ��Name$
 save��5       $��1��6   $��4q�6.   .��6L   Save6R   �� 5   
   -   5         ��Name$
 info��5   !   $��2��6   
���  ��$
��Wrap=�6@   5      5      