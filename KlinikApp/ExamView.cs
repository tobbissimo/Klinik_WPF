using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Interaction logic for pruefung.xaml
    /// </summary>
    public partial class ExamView : Window
    {
        public ExamView()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // dies ist leider notwenig um die DialogBox mit OK zu schliessen
            if (CbEmp.SelectedItem != null && CbExam.SelectedItem != null && CbKlinik.SelectedItem != null && DpDate.SelectedDate != null)
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
