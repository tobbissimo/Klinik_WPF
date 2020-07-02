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
    public partial class EditPatient : UserControl
    {
        KlinikDbEntities db = new KlinikDbEntities();
        public EditPatient()
        {
            InitializeComponent();
        }

        //private void Save_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        int anz = db.SaveChanges();
        //        info.Text = anz + " Rows affected";
        //    }
        //    catch(Exception e1)
        //    {
        //        info.Text = e1.Message;
        //    }
        //}

        //private void btnnew_Click(object sender, RoutedEventArgs e)
        //{
        //        Patient p = new Patient();
        //        p.P_Firstname = "New";
        //        p.P_Lastname = "Patient";
        //        db.Patients.Add(p);
        //        db.SaveChanges();
        //        //lbPatients.Items.Refresh();
        //        lbPatients.ItemsSource = db.Patients.ToList();
        //        lbPatients.SelectedItem = p;
        //}

        //private void btndelete_Click(object sender, RoutedEventArgs e)
        //{
        //    Patient p = lbPatients.SelectedItem as Patient;

        //    if(p != null)
        //    {
        //        if(p.Examinations.Count == 0)
        //        {
        //            db.Patients.Remove(p);
        //            db.SaveChanges();
        //            //lbPatients.Items.Refresh();
        //            lbPatients.ItemsSource = db.Patients.ToList();
        //        }
        //        else
        //        {
        //            info.Text = "Patient has Examinations, Delete not possible!";
        //        }
        //    }
        //}
    }
}
