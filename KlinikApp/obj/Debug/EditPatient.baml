   M S B A M L   `   `   `  ����D  @KlinikApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:KlinikApp	KlinikApp  5      9!clr-namespace:KlinikApp.ViewModelKlinikApp.ViewModel  5          KlinikApp.EditPatient   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:KlinikApp     5      4localv!clr-namespace:KlinikApp.ViewModel     5        � 	Resources  5	         vm S� 
ObjectType'  !KlinikApp.ViewModel.VMPatientList��%"   &	        S� 5
   
   "  6(   5      .��5      �  � DataContext 6   ��  �� Source# [   � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6!   $��Patients��61   �� 5   
   $��0��6   $��1��6!   $��Patient details��61   �� 5   
   $��1��6   $��0��6   ��5      ��  �� Path$ AllPatients� �� SelectedItem 5      �� $ SelectedPatient� �� Mode$ OneWayToSource=�	 �� BindsDirectlyToSource	 . ��5      �� 5      .R�5      �� �� 5      $
��Bold"�6?   �6   �� $ 
P_Lastname�6?    �� 5      �6   �� $ P_Firstname�5       5!      5#      �� 5$   
   $��1��6   $��1��6"   .+�5%      ��  6   �� $ SelectedPatient�.+�5&      �� $��Lastname��6   $��3q�6,   �� 5'      $
��Bold"�6=   $��3q�6O   ��6   �� $ 
P_Lastname�6O   �� 5(      $��	Firstname��6   $��3q�6-   �� 5)      $
��Bold"�6>   $��3q�6P   ��6   �� $ P_Firstname�6P   �� 5*      $��Birthday��6   $��3q�6,   �� 5+      $
��Bold"�6V   $��3q�6h   ��6   �� $ 
P_Birthday�
 �� StringFormat$
 
dd.MM.yyyy��6h   �� 5,      $��Address��6   $��3q�6+   �� 5-      $
��Bold"�6<   $��3q�6N   ��6   �� $ 	P_Address�6N   �� 5.      $��
Postalcode��6   $��3q�6.   �� 5/      $
��Bold"�68   $��3q�6J   ��6   �� $ P_Plz�6J   �� 50      $��
Bundesland��6   $��3q�6.   �� 51      $
��Bold"�6D   $��3q�6V   ��6   �� $ Bundesland.B_Name�6V   52      �� 53      $��4q�6   ��6    �� $ NewPatientCommand�.��6K   New6P   �� 54      $��4q�6   ��6    �� $ EditCommand�.��6E   Edit6K   �� 55      $��4q�6   ��6    �� $ DeleteCommand�.��6G   Delete6O   �� 56      -   5         ��Name$
 info��56      
���  ��6&   57      58      59      