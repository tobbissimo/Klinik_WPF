   M S B A M L   `   `   `  ����D  @KlinikApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:KlinikApp.ViewModelKlinikApp.ViewModel  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       KlinikApp.ExamView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   3model!clr-namespace:KlinikApp.ViewModel     5   	   9system&clr-namespace:System;assembly=mscorlib     5   	     � Title$
  Exam��5   	   $	��500��6   $	��300��6#    � 	Resources 5         vm S� 
ObjectType$  KlinikApp.ViewModel.VMExamEdit��%"   &	        S� 5	   
   "  6(   5
      .��5      �� .+�5   
   �� $��25(�66   
���i��$��Center=�6[   ��6   ��  �� Path$ 
HeaderText�6[   �� 5   
   ��6   �� $ Ex.Exty_Name��� 5   
   $��Patient��6   �� 5   
   $
��Bold"�68   ��6   �� $ Ex.Ex_Patient�68   �� 5   
   $��Examination��6   �� 5   
   -   5         ��Name$ CbExam��5       �� DisplayMemberPath$ 	Exty_Name��5       �� SelectedValuePath$ Exty_Id��5       �� SelectedValue 5      �� $ 
Ex.Ex_Exam���5      �� *
AllExams+5      �� 5   
   $��Klinik��6   �� 5   
   -   5        $ CbKlinik��5      $
 K_Id��5      $
 K_Id��5       5      �� $ Ex.Ex_Klinik���5      �� *
AllKliniks+5      �� 5   
   $��Employee��6   �� 5    
   -   5        $ CbEmp��5       $ Emp_Id��5#      $ Emp_Id��5$       5!      �� $ Ex.Ex_Employee���5"      ��  �� ElementName$ CbKlinik��$ SelectedItem.Employees�5$      �� 5%   
   $
��Date��6   (  "System.Windows.Controls.DatePicker  5&   
   -   5        	  Name$	 DpDate��5&      
   SelectedDate
 6%   �� $ 
Ex.Ex_Date��� 5(   
    �� Orientation$ 
Horizontal=�6   $��Right=�6.   .+�5)      �� -   5         ��Name$
 Save��5)       �� 	IsDefault . $��	Speichern��65   $��4q�6J   6U   �� 5*      -   5        $ Cancel��5*       �� IsCancel . $��4q�66   $��Abbruch��6A   5+      �� 5,   
   -   5         ��Name$ Error��5,      $�� ��6#   
���  ��6+   5-      5.      