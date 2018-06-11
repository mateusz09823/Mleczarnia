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
            name.Focusable = false;
            type.Focusable = false;
            amountInPack.Focusable = false;
            made.Focusable = false;
            var products = db.Product;
            foreach (var item in products)
            {
                Rows.Add(item);
            }
            productsList.ItemsSource = Rows;
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

        private void ListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (name.Focusable == false)
            {
                name.Focusable = true;
                type.Focusable = true;
                amountInPack.Focusable = true;
                made.Focusable = true;
            }
        }

        private void Delete_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

            if (productsList.SelectedIndex != -1)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        private void Delete_Executed(object sender, ExecutedRoutedEventArgs e)
        {

            Rows.RemoveAt(productsList.SelectedIndex);
            db.Product.Remove((Product)productsList.SelectedItem);
            productsList.Items.Refresh();
            db.SaveChanges();
        }

        private void Return_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MainWindow wnd = new MainWindow();
            wnd.Show();
            db.SaveChanges();
            this.Close();
        }

        private void Add_Executed(object sender, ExecutedRoutedEventArgs e)
        {

            Product f = new Product();
            f.name = "Nowy";
            db.Product.Add(f);
            db.SaveChanges();
            Rows.Add(f);
            productsList.Items.Refresh();
        }

        private void productsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
