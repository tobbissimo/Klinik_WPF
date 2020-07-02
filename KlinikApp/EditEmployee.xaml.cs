using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;

namespace KlinikApp
{
    /// <summary>
    /// Interaction logic for EditEmployee.xaml
    /// </summary>
    public partial class EditEmployee : UserControl
    {
        KlinikDbEntities db = new KlinikDbEntities();
        public EditEmployee()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var erg = db.Employees;
            erg.Load();
            employeeGrid.ItemsSource = erg.Local;//.OrderBy(emp => emp.Emp_Lastname);
        }

        private void EmployeeGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if(!e.PropertyName.Contains("_"))
            {
                e.Cancel = true;
            }
            if(e.PropertyName == "Emp_Id")
            {
                e.Column.IsReadOnly = true;
            }
            e.Column.Header = e.PropertyName.Substring(4);

        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            int anz = db.SaveChanges();
            info.Text = anz + " Rows affected!";
        }

        private void employeeGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            PatientDetails ed = new PatientDetails();
            ed.Show();
        }
    }
}
