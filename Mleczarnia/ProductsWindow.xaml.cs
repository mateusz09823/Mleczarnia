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
        MleczarniaDBEntities2 db = new MleczarniaDBEntities2();
        List<Product> Rows = new List<Product>();
        public ProductsWindow()
         {
            
            InitializeComponent();
            var products = db.Product;
            foreach (var item in products)
            {
                Rows.Add(item);
            }
            productsList.ItemsSource = Rows;
        }

         private void Button_Click(object sender, RoutedEventArgs e)
         {
             MainWindow wnd = new MainWindow();
             wnd.Show();
            db.SaveChanges();
            this.Close();
         }

        

         
         private void Button_Click_3(object sender, RoutedEventArgs e)
         {
            Rows.RemoveAt(productsList.SelectedIndex);
            db.Product.Remove((Product)productsList.SelectedItem);
            productsList.Items.Refresh();
            db.SaveChanges();
        }

        private void AddProduct(object sender, RoutedEventArgs e)
        {
            Product f = new Product();
            f.name = "Nowy";
            db.Product.Add(f);
            db.SaveChanges();
            Rows.Add(f);
            productsList.Items.Refresh();
        }

        private void TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            productsList.Items.Refresh();
        }

        private void TextBoxGotKeyboardFocus(object sender, System.Windows.Input.KeyboardFocusChangedEventArgs e)
        {
            TextBox box = (TextBox)sender;
            box.SelectAll();
            box.Focus();
        }
    }
}
