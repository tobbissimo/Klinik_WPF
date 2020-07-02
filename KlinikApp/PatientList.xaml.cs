using KlinikApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KlinikApp
{
    /// <summary>
    /// Interaction logic for EditPatient.xaml
    /// </summary>
    public partial class PatientList : UserControl
    {
        public PatientList()
        {
            InitializeComponent();
        }

        //private void Searchbox_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    var binding = ((TextBox)sender).GetBindingExpression(TextBox.TextProperty);
        //    binding.UpdateSource();
        //}

        private void PatientDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (patientDataGrid.SelectedItem != null)
            {
                var v = new PatientDetails();
                var vm = new VMPatientEdit();
                vm.P = (Patient)patientDataGrid.SelectedItem;
                vm.IstInEditMode = true;
                v.DataContext = vm;
                v.ShowDialog();
                if (v.DialogResult == true)  // Save in Dialogbox clicked and inputs valid
                {
                    using (KlinikDbEntities db = new KlinikDbEntities())
                    {        
                        db.Entry(vm.P).State = EntityState.Modified;
                        db.SaveChanges();
                        //PropertyChanged(this, new PropertyChangedEventArgs("PatientExams"));
                    }
                }
                else
                {
                    //PropertyChanged(this, new PropertyChangedEventArgs("PatientExams"));
                }
            }
        }
    }
}
