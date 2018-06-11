using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for ProductionWindow.xaml
    /// </summary>
    public partial class ProductionWindow : Window
    {
        MleczarniaDBEntities2 db = new MleczarniaDBEntities2();
        List<Production> Rows = new List<Production>();

        public ProductionWindow()
        {
            InitializeComponent();
            var production = db.Production;
            var products = db.Product;
            foreach (var item in production)
            {
                item.product = products.Find(item.productID).name;
                Rows.Add(item);
            }
           productionList.ItemsSource = Rows;
        }

        
        private void TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            productionList.Items.Refresh();
        }

        private void SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            db.SaveChanges();
            productionList.Items.Refresh();
        }

        private void TextBoxGotKeyboardFocus(object sender, System.Windows.Input.KeyboardFocusChangedEventArgs e)
        {
            TextBox box = (TextBox)sender;
            box.SelectAll();
            box.Focus();
        }

        private void Delete_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

            if (productionList.SelectedIndex != -1)
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

            Rows.RemoveAt(productionList.SelectedIndex);
            db.Production.Remove((Production)productionList.SelectedItem);
            productionList.Items.Refresh();
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
            Production f = new Production();
            f.productID = 1;
            f.date = DateTime.Now;
            f.amount=0;
            db.Production.Add(f);
            db.SaveChanges();
            Rows.Add(f);
            productionList.Items.Refresh();
        }
    }

    public class Products : ObservableCollection<Product>
    {
        public Product sProduct { set; get; }
        public Product SProduct
        {
            get { return sProduct; }
            set { sProduct = value; }
        }


        public Products()
        {
            MleczarniaDBEntities2 db = new MleczarniaDBEntities2();
            var products = db.Product;
            foreach (var item in products)
            {
                Add(item);
            }
        }
    }
}
