using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace KlinikApp.ViewModel
{
    class MenuCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MainWindow mw = (MainWindow)Application.Current.MainWindow;

            switch (parameter.ToString())
            {
                case "miExams":
                    mw.contentctl.Children.Clear();
                    mw.contentctl.Children.Add(new ExamList());
                    break;
                case "miNewExam":
                    mw.contentctl.Children.Clear();
                    mw.contentctl.Children.Add(new NewExam());
                    break;
                case "miPatients":
                    mw.contentctl.Children.Clear();
                    mw.contentctl.Children.Add(new PatientList());
                    break;
                case "miPatientEdit":
                    mw.contentctl.Children.Clear();
                    mw.contentctl.Children.Add(new EditPatient());
                    break;
                case "miEmployees":
                    mw.contentctl.Children.Clear();
                    mw.contentctl.Children.Add(new EditEmployee());
                    break;
                case "miEmpStat":
                    mw.contentctl.Children.Clear();
                    mw.contentctl.Children.Add(new Chart());
                    break;
            }
        }
    }
}
