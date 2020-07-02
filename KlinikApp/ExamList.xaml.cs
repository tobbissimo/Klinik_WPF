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
    /// Interaction logic for ExamList.xaml
    /// </summary>

    public partial class ExamList : UserControl
    {
        public ExamList()
        {
            InitializeComponent();
        }

        private void ExamGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (!e.PropertyName.Contains("_"))
            {
                e.Cancel = true;
            }
            
            e.Column.Header = e.PropertyName.Substring(4);
        }

        //private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    var binding = ((TextBox)sender).GetBindingExpression(TextBox.TextProperty);
        //    binding.UpdateSource();
        //}
    }
}
