   M S B A M L   `   `   `  ����D  @KlinikApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:KlinikApp	KlinikApp  5      9!clr-namespace:KlinikApp.ViewModelKlinikApp.ViewModel  5          KlinikApp.NewExam   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:KlinikApp     5      4localv!clr-namespace:KlinikApp.ViewModel     5        � 	Resources  5
         vm S� 
ObjectType   KlinikApp.ViewModel.VMExam��%"   &	        S� 5   
   "  6(   5      .��5      �  � DataContext 6   ��  �� Source# [   � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6!   $��Patients��61   �� 5   
   $��0��6   $��1��6!   $��Untersuchung��61   �� 5   
   $��1��6   $��0��5       �� SelectedValuePath$ Pat_Id��5      ��5      ��  �� Path$ AllPatients� �� SelectedValue 5      �� $ SelectedPatient�	 �� Mode$	 OneWayToSource=�
 �� BindsDirectlyToSource
 . ��5      �� 5      .R�5       �� �� 5!      $
��Bold"�66   �6   �� *Pat_Id+66    �� 5"      �6   �� *
P_Lastname+ �� 5#      �6   �� *P_Firstname+5$      5%      5'      �� 5)   
   $��1��6   $��1��6   ��5*      �� $ PatientExams� �� SelectedItem 5+      �� $ SelectedExam�$	 OneWayToSource=�
 . ��5,      �� 5-      .R�5.      �� �� 5/      $
��Bold"�65   �6   �� *Ex_Id+65    �� 50      �6   �� *Examtype.Exty_Name+51      52      54      �� 56   
   $��1��6   $��2��6"   $��4q�62   .+�57      ��  6   �� $ SelectedExam�.+�58      �� $��Selected Patient��6   �� 59      $
��Bold"�68   $��4q�6J   ��6   �� *
Ex_Patient+6J   �� 5:      $��Examination��6   �� 5;      $��4q�6@   $
��Bold"�6K   ��6   �� *Examtype.Exty_Name+6K   �� 5<      $��Klinik��6   �� 5=      $��4q�67   $
��Bold"�6B   ��6   �� *	Ex_Klinik+6B   �� 5>      $��Employee��6   �� 5?      $��4q�69   $
��Bold"�6D   ��6   �� *Ex_Employee+6D   �� 5@      $
��Date��6   �� 5A      $��4q�6S   $
��Bold"�6^   ��6   �� $ Ex_Date� �� StringFormat$ 
dd-MM-yyyy��6^   5B      �� 5C      -   5         ��Name$ BtnNew��5C      $��5q�6%   ��60   �� $ 
NewCommand�.��6T   New6Y   �� 5D      -   5        $ BtnEdit��5D      $��5q�6&   ��61   �� $ EditCommand�.��6W   Edit6]   �� 5E      -   5        $ 	BtnDelete��5E      $��5q�6(   ��63   �� $ DeleteCommand�.��6Z   Delete6b   �� 5F      -   5         ��Name$
 info��5F      
���  ��6&   5G      5H      5I      