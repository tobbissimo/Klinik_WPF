   M S B A M L   `   `   `  ����D  @KlinikApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:KlinikApp.ViewModelKlinikApp.ViewModel  5          KlinikApp.PatientList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4localv!clr-namespace:KlinikApp.ViewModel     5        � 	Resources  5	         vm S� 
ObjectType'  !KlinikApp.ViewModel.VMPatientList��%"   &	        S� 5
   
   "  6(   5      .��5      �  � DataContext 6   ��  �� Source# [   � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Search:��6   $��0��6#   $��0��60   $��5q�6@   $��Right=�6K   �� 5   
   $��0��6   $��1��6   $��5q�6/   $��Stretch=�5      ��5   :   ��  �� Path$ SearchBoxText� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5      &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 patientDataGrid��5   4   $��1��6   $��2��6    
   
IsReadOnly
 .    AutoGenerateColumns .  ��6_   �� $ AllPatients� �� SelectedValue 5      �� $ SelectedPatient�$ OneWayToSource=� �� BindsDirectlyToSource .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� $ Pat_Id�  5      $ Lastname��6%    67   �� $ 
P_Lastname�  5       $ 
First Name��6%    69   �� $ P_Firstname�  5!      $ Birthday��6%    67   �� $ 
P_Birthday� �� StringFormat$ 
dd.MM.yyyy��  5"      $ Address��6%    66   �� $ 	P_Address�  5#      $	 PLZ��6%    62   �� $ P_Plz�  5$      $ 
Bundesland��6%    69   �� $ Bundesland.B_Name�  5%      $ Examinations��6%    6;   �� $ Examinations.Count�  5&      5(      �� 5)   
    �� Orientation$ 
Horizontal=�6   $��2��6.   $��Center=�6;   .+�5*      �� $��New Exam��6   $��10q�6(   ��64   �� $ NewExamCommand��� 5+      $��New Patient��6   $��10q�6+   ��67   �� $ NewPatientCommand��� 5,      $��Edit Patient��6   $��10q�6,   ��68   �� $ EditCommand��� 5-      $��Delete Patient��6   $��10q�6.   ��6:   �� $ DeleteCommand�5.      5/      50      