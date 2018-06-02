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
    /// Logika interakcji dla klasy ProductsEditWindow.xaml
    /// </summary>
    public partial class ProductsEditWindow : Window
    {
        public ProductsEditWindow(int id)
        {
            InitializeComponent();
            string name = ProductsList.Get(id).GetName();
            string type = ProductsList.Get(id).GetType();
            string amountInPack = ProductsList.Get(id).GetAmountInPack();
            double amountMilk = ProductsList.Get(id).GetAmountMilk();
            Name.Text = name;
            Type.Text = type;
            AmountInPack.Text = amountInPack;
            AmountMilk.Text = amountMilk.ToString();
            Id = id;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ProductsWindow wnd = new ProductsWindow();
            wnd.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProductsList.Set(Id, Name.Text.ToString(), Type.Text.ToString(), AmountInPack.Text.ToString(), double.Parse(AmountMilk.Text.ToString()));
            ProductsWindow wnd = new ProductsWindow();
            wnd.Show();
            this.Close();
        }

        public int Id { get; set; }
    }
}
