   M S B A M L   `   `   `  ����D  @KlinikApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:KlinikApp.ViewModelKlinikApp.ViewModel  5      %clr-namespace:KlinikApp	KlinikApp  5          KlinikApp.ExamList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4localv!clr-namespace:KlinikApp.ViewModel     5      )localclr-namespace:KlinikApp     5        � 	Resources  5
         vm S� 
ObjectType   KlinikApp.ViewModel.VMExam��%"   &	        S� 5   
   "  6(   5      .��5      �  � DataContext 6   ��  �� Source# [   � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� $$��Filter by Patient or Examtype:��6   $��5q�6>   �� 5      $��5q�6n   $	��100��6y   ��6   ��  �� Path$ SearchBoxText� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6y   �� 5      $��Filter by Employee:��6   $��5q�63   �� 5      $��5q�6   	 �� DisplayMemberPath$	 Emp_Lastname��5      
 �� SelectedValuePath$
 Emp_Id��5      $	��100��5   E   ��5   "   �� $ AllEmployees�$ OneWay=� �� SelectedValue 5      �� $ SearchEmployee�6E   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ ExamGrid��5       $��1��6      
IsReadOnly .    AutoGenerateColumns .  ��6E   �� $ AllExams� 5      �� $ SelectedExam�$ OneWayToSource=� �� BindsDirectlyToSource .    Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ Exam Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� $ Ex_Id�  5"      $ Lastname��6%    67   �� $ Patient.P_Lastname�  5#      $ 
First Name��6%    69   �� $ Patient.P_Firstname�  5$      $ Examination��6%    6:   �� $ Examtype.Exty_Name�  5%      $
 Date��6%    63   �� $ Ex_Date� �� StringFormat$ 
dd.MM.yyyy��  5&      $ Klinik��6%    65   �� $ 	Ex_Klinik�  5'      $ Employee��6%    67   �� $ Ex_Employee�5)      �� 5*   
   $��2��6   $ 
Horizontal=�6"   $��Center=�6;   .+�5+      �� $��10q�6   ��6!   �� $ EditCommand�.��6F   Edit6L   �� 5,      $��10q�6   ��6!   �� $ DeleteCommand�.��6H   Delete6P   5-      5.      5/      