   M S B A M L   `   `   `  ����D  @KlinikApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:KlinikApp.ViewModelKlinikApp.ViewModel  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       KlinikApp.PatientDetails   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   3model!clr-namespace:KlinikApp.ViewModel     5   	   9system&clr-namespace:System;assembly=mscorlib     5   	     � Title$  Patient Details��5   	   $	��450��6!   $	��500��6.    � 	Resources 5         vm S� 
ObjectType'  !KlinikApp.ViewModel.VMPatientEdit��%"   &	        S� 5	   
   "  6(   5
      .��5      �� $��6q�6   .+�5   
   �� $��25(�66   
���i��$��Center=�6[   ��6   ��  �� Path$ 
HeaderText�6[   �� 5   
   $��
First Name��6   �� 5   
   -   5         ��Name$ TbFirstname��5      ��6'   �� $ P.P_Firstname��� 5   
   $��	Last Name��6   �� 5   
   -   5        $ 
TbLastname��5      ��6&   �� $ P.P_Lastname��� 5   
   $��Examinations��6   �� 5   
   ��6   �� $ P.Examinations.Count��� 5   
   $��Birthday��6   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
DpBirthday��5         SelectedDate 6)   �� $ P.P_Birthday��� 5   
   $��Address��6   �� 5   
   -   5        $ 	TbAddress��5      ��6%   �� $ P.P_Address��� 5   
   $��
Bundesland��6   �� 5   
   -   5         ��Name$ CbBundesland��5       �� DisplayMemberPath$ B_Name��5      	 �� SelectedValuePath$
	 B_Id��5      
 �� SelectedValue
 5      �� $ P.P_Bundesland���5      �� $ AllBundeslands�5      �� 5   
   $��Postal Code��6   �� 5   
   -   5        $ TbPlz��5      ��6!   �� $ P.P_Plz��� 5#   
    �� Orientation$ 
Horizontal=�6   $��Right=�6.   .+�5$      �� -   5         ��Name$
 Save��5$       �� 	IsDefault . $
��Save��65   $��4q�6E   6P   �� 5%      -   5        $ Cancel��5%       �� IsCancel . $��4q�66   $��Cancel��6A   5&      �� 5'   
   -	   5         ��Name$ Error��5'      $�� ��6#   
���  ��6+   5(      5)      