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
    class VMPatientList : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private List<Patient> patients = new List<Patient>();
        

        public IEnumerable<Patient> AllPatients
        {
            get
            {
                
                if (searchboxText.Length == 0)
                {
                    Console.WriteLine("I am here!");
                    KlinikDbEntities db = new KlinikDbEntities();
                    var erg = (from p in db.Patients.Include("Examinations")
                                   //orderby p.P_Lastname
                               select p).ToList();
                    patients = erg;

                    SelectedPatient = (from p in erg
                                       where p.Pat_Id == SelectedPatient?.Pat_Id
                                       select p).FirstOrDefault();

                    bundeslands = (from b in db.Bundeslands
                                  select b).ToList();
                    db.Dispose();
                    return erg;

                }
                else 
                {
                    var erg = (from p in patients
                               where p.P_Lastname.ToLower().StartsWith(searchboxText.ToLower()) || 
                               p.P_Firstname.ToLower().StartsWith(searchboxText.ToLower())
                               select p).ToList();
                    return erg;
                }
                
            }
        }

        //public IEnumerable<Patient> AllPatientsListBox
        //{
        //    get
        //    {
        //        KlinikDbEntities db = new KlinikDbEntities();
        //        var erg = (from p in db.Patients.Include("Examinations")
        //                       //orderby p.P_Lastname
        //                   select p).ToList();

        //        SelectedPatient = (from p in erg
        //                           where p.Pat_Id == SelectedPatient?.Pat_Id
        //                           select p).FirstOrDefault();
                
        //        bundeslands = (from b in db.Bundeslands
        //                       select b).ToList();
        //        db.Dispose();
        //        return erg;
        //    }
        //}

        private Patient selectedPatient;

        public Patient SelectedPatient
        {
            get { return selectedPatient; }
            set
            {
                selectedPatient = value;
                PropertyChanged(this, new PropertyChangedEventArgs("SelectedPatient"));
            }
        }

        private string searchboxText = "";

        public string SearchBoxText
        {
            get { return searchboxText; }
            set 
            {
                searchboxText = value;
                PropertyChanged(this, new PropertyChangedEventArgs("AllPatients"));
            }
        }

        private List<Bundesland> bundeslands = new List<Bundesland>();
        public Bundesland Bundesland
        {
            get 
            {
                var erg = from b in bundeslands
                          where SelectedPatient.Bundesland == b
                          select b;
                return (Bundesland) erg;
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

        public ICommand DeleteCommand { get { return new DelegateCommand(DeleteExecute, CanExecuteDelete); } }
        public ICommand NewExamCommand { get { return new DelegateCommand(NewExamExecute, CanExecuteNewExam); } }
        public ICommand NewPatientCommand { get { return new DelegateCommand(NewPatientExecute, CanExecuteNewPatient); } }

        private bool CanExecuteEdit(object param)
        {
            if (SelectedPatient != null) return true;
            return false;
        }

        private bool CanExecuteNewExam(object param)
        {
            if (SelectedPatient != null) return true;
            return false;
        }

        private bool CanExecuteNewPatient(object param)
        {
            return true;
        }

        private bool CanExecuteDelete(object param)
        {
            if (SelectedPatient != null)
            {
                //Patients with Saved Examinations can't be Deleted 
                if (SelectedPatient.Examinations.Count() > 0) return false;
                return true;
            }
            return false;
        }

        public void EditExecute(Object param)
        {
            if (SelectedPatient != null)
            {
                SearchBoxText = "";
                var v = new PatientDetails();
                //v.SelectedDate = SelectedExam.Ex_Date;
                var vm = new VMPatientEdit();
                vm.P = SelectedPatient;
                vm.IstInEditMode = true;
                v.DataContext = vm;
                v.ShowDialog();
                if (v.DialogResult == true)  //save
                {
                    using (KlinikDbEntities db = new KlinikDbEntities())
                    {
                        //vm.P.Examinations = null; //wegen include
                        db.Entry(vm.P).State = EntityState.Modified;
                        db.SaveChanges();
                        PropertyChanged(this, new PropertyChangedEventArgs("AllPatients"));
                    }
                }
                else
                {
                    SearchBoxText = "";
                    PropertyChanged(this, new PropertyChangedEventArgs("AllPatients"));
                }
            }
        }

        public void DeleteExecute(object param)
        {
            SelectedPatient = (Patient)param;
            //Delete button pressed
            if (SelectedPatient != null)
            {
                if (SelectedPatient.Examinations.Count == 0)
                {
                    MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
                    if (messageBoxResult == MessageBoxResult.Yes)
                    {
                        SearchBoxText = "";
                        using (KlinikDbEntities db = new KlinikDbEntities())
                        {
                            db.Entry(SelectedPatient).State = EntityState.Deleted;
                            db.SaveChanges();
                            PropertyChanged(this, new PropertyChangedEventArgs("AllPatients"));
                        }
                    }
                }
            }
        }

        public void NewExamExecute(object param)
        {
            // New Button was pressed
            if (SelectedPatient != null)
            {
                SearchBoxText = "";
                var v = new ExamView();      // new View
                //v.SelectedDate = System.DateTime.Now;
                var vm = new VMExamEdit();   // new ViewModel
                vm.Ex = new Examination { Ex_Patient = SelectedPatient.Pat_Id, Ex_Date = System.DateTime.Now };
                vm.IstInEditMode = false;
                v.DataContext = vm;             //  view.DataContext = ViewModel
                v.ShowDialog();
                if (v.DialogResult == true)  // Save in Dialogbox clicked and inputs valid
                {
                    using (KlinikDbEntities db = new KlinikDbEntities())
                    {       
                        db.Examinations.Add(vm.Ex);
                        db.SaveChanges();
                        PropertyChanged(this, new PropertyChangedEventArgs("AllPatients"));
                    }
                }
                else
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("AllPatients"));
                }

            }
        }

        public void NewPatientExecute(object param)
        {
            // New Button pressed
            var v = new PatientDetails();      // new View
            var vm = new VMPatientEdit();   // new ViewModel
            vm.P = new Patient();
            vm.IstInEditMode = false;
            v.DataContext = vm;             //  view.DataContext = ViewModel
            v.ShowDialog();
            if (v.DialogResult == true)  // Save in Dialogbox clicked and inputs valid
            {
                SearchBoxText = "";
                using (KlinikDbEntities db = new KlinikDbEntities())
                {       
                    db.Patients.Add(vm.P);
                    db.SaveChanges();
                    PropertyChanged(this, new PropertyChangedEventArgs("AllPatients"));
                }
            }
            else
            {
                PropertyChanged(this, new PropertyChangedEventArgs("AllPatients"));
            }
        }
    }
}
