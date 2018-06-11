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

namespace Mleczarnia
{
    /// <summary>
    /// Interaction logic for StatisticWindow.xaml
    /// </summary>
    public partial class StatisticWindow : Window
    {
        MleczarniaDBEntities2 db = new MleczarniaDBEntities2();
        public StatisticWindow()
        {
            InitializeComponent();
            farmers.Content = db.Farm.Count(); //ilość gospodarzy
            deliveries.Content= db.Delivery.Count();//ilość dostaw
            products.Content = db.Product.Count();//ilość produktów
            productions.Content = db.Production.Count();//ilość produkcji
            sales.Content = db.Sale.Count();//ilość sprzedaży
            float money = 0;//obrot
            var sale = db.Sale;

            foreach (var item in sale)
            {
                money += (float)item.price;
            }
            cash.Content = money.ToString()+" zł";
            var tanks = db.Tank;
            float capacity = 0; ;
            float filling = 0;
            foreach (var item in tanks)
            {
                capacity = (float)item.tankCapacity;
                filling = (float)item.tankFilling;
                break;
            }
            tankProgressBar.Minimum = 0;
            tankProgressBar.Maximum = capacity;
            tankProgressBar.Value = filling;
            tankFilling.Content = filling.ToString()+"  /";
            maximumCapacity.Content = capacity.ToString();
        }

        private void BackButtonCLick(object sender, RoutedEventArgs e)
        {
            MainWindow wnd = new MainWindow();
            wnd.Show();
            this.Close();
        }

        private void Print_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            //Kiedy moze drukowac ,jak nie potrzebujesz usun metode i w 11 lini w xaml "CanExecute="Print_CanExecute""
        }

        private void Print_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // drukowanie czynnosc
        }

        private void Return_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MainWindow wnd = new MainWindow();
            wnd.Show();
            this.Close();
        }
    }
}
