using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace KlinikApp
{
    /// <summary>
    /// Interaction logic for EmployeeDetails.xaml
    /// </summary>
    public partial class PatientDetails : Window
    {
        public PatientDetails()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (CbBundesland.SelectedItem != null && TbAddress.Text != null && TbFirstname.Text != null && DpBirthday.SelectedDate != null && 
                TbLastname.Text != null && TbPlz.Text != null)
            {
                DialogResult = true;
            }
            else
            {
                Error.Text = "Fields can't be empty";
            }
        }
    }
}
