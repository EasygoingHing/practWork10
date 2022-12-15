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
using Пример_таблицы_WPF;

namespace WpfApp10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<float> expensesArray, //затраты
                    pricesArray;   //цены          

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tbResult.Clear();
                int numberOfProducts = int.Parse(tbСountProducts.Text);

                expensesArray = new List<float>(numberOfProducts);   //затраты на производство
                pricesArray = new List<float>(numberOfProducts);     //цена продукта

                Random rnd = new Random();

                for (int i = 0; i < numberOfProducts; i++)
                {
                    expensesArray.Add(rnd.Next(1000));
                    pricesArray.Add(rnd.Next(1000));

                    if (expensesArray[i] > pricesArray[i] && tbResult.Text == "")
                    {
                        tbResult.Text = (i + 1).ToString();
                    }
                }
                dataGrid.ItemsSource = VisualArray.ToDataTable(expensesArray, pricesArray).DefaultView;
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный формат данных");
            }            
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Крутолапов Валерий Исп-31 В-1");
        }
    }
}
