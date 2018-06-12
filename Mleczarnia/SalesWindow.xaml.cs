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
    /// Logika interakcji dla klasy SalesWindow.xaml
    /// </summary>
    public partial class SalesWindow : Window
    {
        MleczarniaDBEntities2 db = new MleczarniaDBEntities2();
        List<Sale> Rows = new List<Sale>();

        public SalesWindow()
        {
            InitializeComponent();
            productionID.IsHitTestVisible = false;
            amount.Focusable = false;
            price.Focusable = false;
            var sale = db.Sale;
            var productions = db.Production;
            foreach (var item in sale)
            {
                item.production = productions.Find(item.productionID).Product.name;
                Rows.Add(item);
            }
           salesList.ItemsSource = Rows;
        }
        private ListCollectionView View
        {
            get
            {
                return (ListCollectionView)CollectionViewSource.GetDefaultView(Rows);
            }
        }

        private void TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            salesList.Items.Refresh();
        }

        private void ListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (productionID.IsHitTestVisible == false)
            {
                productionID.IsHitTestVisible = true;
                amount.Focusable = true;
                price.Focusable = true;
            }
        }

        private void Combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            db.SaveChanges();
            salesList.Items.Refresh();
        }

        private void TextBoxGotKeyboardFocus(object sender, System.Windows.Input.KeyboardFocusChangedEventArgs e)
        {
            TextBox box = (TextBox)sender;
            box.SelectAll();
            box.Focus();
        }


        private void Delete_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

            if (salesList.SelectedIndex != -1)
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

            Rows.RemoveAt(salesList.SelectedIndex);
            db.Sale.Remove((Sale)salesList.SelectedItem);
            salesList.Items.Refresh();
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
            Sale f = new Sale();
            f.amountToSell = 0;
            f.price = 0;
            f.productionID = 1;
            db.Sale.Add(f);
            db.SaveChanges();
            Rows.Add(f);
            salesList.Items.Refresh();

        }
        private void Filter(object sender, RoutedEventArgs e)
        {
            float minimuAmountOfProduct;
            if (float.TryParse(amountOfProduct.Text, out minimuAmountOfProduct))
            {
                View.Filter = delegate (object item)
                {
                    Sale product = item as Sale;
                    if (product != null)
                    {
                        return (product.amountToSell > minimuAmountOfProduct);
                    }
                    return false;
                };
            }
        }
        private void FilterNone(object sender, RoutedEventArgs e)
        {
            View.Filter = null;
        }
        private void GroupName(object sender, RoutedEventArgs e)
        {
            View.GroupDescriptions.Clear();
            View.GroupDescriptions.Add(new PropertyGroupDescription("Production.Product.name"));
        }
        private void GroupNone(object sender, RoutedEventArgs e)
        {
            View.GroupDescriptions.Clear();
        }
    }

    public class Productions : ObservableCollection<Production>
    {
        public Production sProduction { set; get; }
        public Production SProduction
        {
            get { return sProduction; }
            set { sProduction = value; }
        }


        public Productions()
        {
            MleczarniaDBEntities2 db = new MleczarniaDBEntities2();
            var production = db.Production;
            foreach (var item in production)
            {
                Add(item);
            }
        }
    }
}
