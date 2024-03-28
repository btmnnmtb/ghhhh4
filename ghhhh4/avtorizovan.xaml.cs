using System;
using System.Collections.Generic;
using System.IO;
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

namespace ghhhh4
{
    /// <summary>
    /// Логика взаимодействия для avtorizovan.xaml
    /// </summary>
    public partial class avtorizovan : Window
    {
        public avtorizovan()
        {
            InitializeComponent();

            if (izmen.Content == new proxodtesta())
            {
                Content = null;
                izmen.Content = new proxodtesta();

            }
            else if (izmen.Content == new izmentest())
            {
                Content = null;
                izmen.Content = new izmentest();

            }


        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            {
                MainWindow wid = new MainWindow();
                wid.Show();
                Close();
            }
        }

        private void redactor_testa_Click(object sender, RoutedEventArgs e)
        {

            izmen.Content = new izmentest();








        }

        private void proti_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists("D:\\Рабочий стол\\ffff.json"))
            {
                izmen.Content = new proxodtesta();

            }
            else
            {
                izmen.Content = new testanet();

            }
        }
    }
}

