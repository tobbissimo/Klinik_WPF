using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace KlinikApp.ViewModel
{
    class VMExam : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public IEnumerable<Patient> AllPatients
        {
            get
            {
                KlinikDbEntities db = new KlinikDbEntities();
                var erg = (from p in db.Patients
                           //orderby p.P_Lastname
                           select p).ToList();
                db.Dispose();
                return erg;
            }
        }

        private List<Examination> examinations = new List<Examination>();
        public IEnumerable<Examination> AllExams
        {
            get
            {
                KlinikDbEntities db = new KlinikDbEntities();
                if (searchboxText.Length == 0 && searchEmployee == 0)
                {
                    var erg = (from e in db.Examinations.Include("Patient").Include("Examtype")
                                   //orderby p.P_Lastname
                               select e).ToList();
                    examinations = erg;
                    examinations.ForEach(e => Console.WriteLine(e.Patient.P_Lastname + e.Ex_Employee + e.Examtype.Exty_Name));

                    db.Dispose();
                    return erg;
                }
                else
                {
                    Console.WriteLine(searchEmployee + " " + searchboxText);
                    var erg = (from e in examinations
                               where (e.Ex_Employee == searchEmployee || searchEmployee == 0) &&
                               (e.Patient.P_Firstname.ToLower().StartsWith(searchboxText.ToLower()) ||
                               e.Patient.P_Lastname.ToLower().StartsWith(searchboxText.ToLower()) ||
                               e.Examtype.Exty_Name.ToLower().StartsWith(searchboxText.ToLower()))
                               select e).ToList();
                    return erg;
                }
            }
        }

        private int selectedPatient;

        public int SelectedPatient
        {
            get { return selectedPatient; }
            set 
            { 
                selectedPatient = value;
                PropertyChanged(this, new PropertyChangedEventArgs("SelectedPatient"));
                PropertyChanged(this, new PropertyChangedEventArgs("PatientExams"));
            }
        }

        public IEnumerable<Examination> PatientExams
        {
            get
            {
                using (KlinikDbEntities db = new KlinikDbEntities())
                {
                    var erg = (from e in db.Examinations.Include("Examtype")
                               where e.Ex_Patient == SelectedPatient
                               select e).ToList();

                    SelectedExam = (from e in erg
                                    where e.Ex_Patient == SelectedExam?.Ex_Patient &&
                                    e.Ex_Id == SelectedExam?.Ex_Id
                                    select e).FirstOrDefault();
                    return erg;
                }
            }
        }

        private Examination selectedExam;
        public Examination SelectedExam
        {
            get { return selectedExam; }
            set
            {
                selectedExam = value;
                PropertyChanged(this, new PropertyChangedEventArgs("SelectedExam"));
            }
        }

        public IEnumerable<Employee> AllEmployees
        {
            get
            {
                using(KlinikDbEntities db = new KlinikDbEntities())
                {
                    var erg = (from e in db.Employees
                               select e).ToList();
                    Employee emp = new Employee();
                    emp.Emp_Id = 0;
                    emp.Emp_Lastname = "All";
                    erg.Add(emp);
                    return erg;
                }
            }
        }

        private string searchboxText = "";

        public string SearchBoxText
        {
            get { return searchboxText; }
            set
            {
                searchboxText = value;
                PropertyChanged(this, new PropertyChangedEventArgs("AllExams"));
            }
        }

        private int searchEmployee = 0;

        public int SearchEmployee
        {
            get { return searchEmployee; }
            set
            {
                searchEmployee = value;
                PropertyChanged(this, new PropertyChangedEventArgs("AllExams"));
            }
        }

        private ICommand editCommand;

        public ICommand EditCommand
        {
            get 
            {
                if (editCommand == null)
                    editCommand = new DelegateCommand(EditExecute, CanExecuteEdit);
                return editCommand; 
            }
        }

        public ICommand DeleteCommand { get { return new DelegateCommand(DeleteExecute, CanExecuteEdit); } }
        public ICommand NewCommand { get { return new DelegateCommand(NewExecute, CanExecuteNew); } }

        private bool CanExecuteEdit(object param)
        {
            if (SelectedExam != null) return true;
            return false;
        }

        private bool CanExecuteNew(object param)
        {
            if (SelectedPatient != 0) return true;
            return false;
        }

        public void EditExecute(Object param)
        {
            if(SelectedExam != null)
            {
                var v = new ExamView();
                //v.SelectedDate = SelectedExam.Ex_Date;
                var vm = new VMExamEdit();
                vm.Ex = SelectedExam;
                vm.IstInEditMode = true;
                v.DataContext = vm;
                v.ShowDialog();
                if(v.DialogResult == true)  //save
                {
                    using(KlinikDbEntities db = new KlinikDbEntities())
                    {
                        vm.Ex.Examtype = null; //wegen include
                        db.Entry(vm.Ex).State = EntityState.Modified;
                        db.SaveChanges();
                        PropertyChanged(this, new PropertyChangedEventArgs("PatientExams"));
                    }
                }
                else
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("PatientExams"));
                }
            }
        }

        public void DeleteExecute(object param)
        {
            //Delete button pressed
            if(SelectedExam != null)
            {
                MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    using (KlinikDbEntities db = new KlinikDbEntities())
                    {
                        db.Entry(SelectedExam).State = EntityState.Deleted;
                        db.SaveChanges();
                        PropertyChanged(this, new PropertyChangedEventArgs("PatientExams"));
                    }
                }
            }
        }

        public void NewExecute(object param)
        {
            // New Button was pressed
            if (SelectedPatient != 0)
            {
                var v = new ExamView();      // new View
                //v.SelectedDate = System.DateTime.Now;
                var vm = new VMExamEdit();   // new ViewModel
                vm.Ex = new Examination { Ex_Patient = SelectedPatient, Ex_Date = System.DateTime.Now };
                vm.IstInEditMode = false;
                v.DataContext = vm;             //  view.DataContext = ViewModel
                v.ShowDialog();
                if (v.DialogResult == true)  // Save in Dialogbox clicked and inputs valid
                {
                    using (KlinikDbEntities db = new KlinikDbEntities())
                    {        // die  stunden Instanz in den OR Mapper
                        db.Examinations.Add(vm.Ex);
                        db.SaveChanges();
                        PropertyChanged(this, new PropertyChangedEventArgs("PatientExams"));
                    }
                }
                else
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("PatientExams"));
                }

            }
        }
    }
}
