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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KlinikApp
{
    /// <summary>
    /// Interaction logic for Chart.xaml
    /// </summary>
    public partial class Chart : UserControl
    {
        public Chart()
        {
            InitializeComponent();

            var db = new KlinikDbEntities();

            UStat.ItemsSource =
               (from e in db.Employees
                orderby e.Examinations.Count() descending
                select new ExamStat
                {
                    ID = e.Emp_Id,
                    Name = e.Emp_Lastname + " " + e.Emp_Firstname,
                    Exams = e.Examinations.Count(),
                    Breite = e.Examinations.Count() * 20              // Breite als Hilfswert für die Balkendarstellung
                }) .ToList();
        }
    }

    // helper class for the return value
    public class ExamStat
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int Exams { get; set; }
        public int Breite { get; set; }
    }
}

