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

namespace ghhhh4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string avtoriza = "a";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void izmentest_Click(object sender, RoutedEventArgs e)
        {
            Text.IsEnabled = true;




            if (Text.Text == avtoriza)
            {


                avtorizovan second_window = new avtorizovan();
                second_window.redactor_testa.IsEnabled = true;
                second_window.Show();
                Close();
            }
            else
            {

                Text.Text = "";
            }


        }

        private void test_Click(object sender, RoutedEventArgs e)
        {




            avtorizovan second_window = new avtorizovan();
            second_window.redactor_testa.IsEnabled = false;
            second_window.Show();
            Close();








        }
    }
}
