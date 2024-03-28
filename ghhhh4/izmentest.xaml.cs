using Newtonsoft.Json;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ghhhh4
{
    /// <summary>
    /// Логика взаимодействия для izmentest.xaml
    /// </summary>
    public partial class izmentest : Page
    {
         List<Testtt> list = new List<Testtt>();
        public izmentest()
        {
            InitializeComponent();
            datagrid.ItemsSource = list;


















        }


        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (list.Count > 3)
            {
                list = list.Take(3).ToList();
            }
            string json = JsonConvert.SerializeObject(list);
            File.WriteAllText("D:\\Рабочий стол\\ffff.json", json);

        }
    }
}

