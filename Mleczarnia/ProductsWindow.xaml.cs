using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for Produkty.xaml
    /// </summary>
    public partial class ProductsWindow : Window
    {
        public ProductsWindow()
        {
            InitializeComponent();
            List<Row> Rows = new List<Row>();
            for (int i = 0; i < ProductsList.GetSizeOfList(); i++)
            {
                string name = ProductsList.Get(i).GetName();
                string type = ProductsList.Get(i).GetType();
                string amountInPack = ProductsList.Get(i).GetAmountInPack();
                double amountMilk = ProductsList.Get(i).GetAmountMilk();
                int made = ProductsList.Get(i).GetMade();
                int sold = ProductsList.Get(i).GetSold();
                Rows.Add(new Row() { Name = name, Type = type, AmountInPack = amountInPack, AmountMilk = amountMilk, Made = made, Sold = sold });
            }
            lvProducts.ItemsSource = Rows;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wnd = new MainWindow();
            wnd.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ProductsAddWindow wnd = new ProductsAddWindow();
            wnd.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int id;
            if (lvProducts.SelectedIndex == -1)
            {
                id = 0;
            }
            else id = lvProducts.SelectedIndex;
            ProductsEditWindow wnd = new ProductsEditWindow(id);
            wnd.Show();
            this.Close();
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int id = lvProducts.SelectedIndex;
            ProductsList.Delete(id);
            ProductsWindow wnd = new ProductsWindow();
            wnd.Show();
            this.Close();
        }

        public class Row
        {
            public string Name { get; set; }

            public string Type { get; set; }

            public string AmountInPack { get; set; }

            public double AmountMilk { get; set; }

            public int Made { get; set; }

            public int Sold { get; set; }

        }
    }
}
