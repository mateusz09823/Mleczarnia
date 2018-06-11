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
            var sale = db.Sale;
            var productions = db.Production;
            foreach (var item in sale)
            {
                item.production = productions.Find(item.productionID).Product.name;
                Rows.Add(item);
            }
           salesList.ItemsSource = Rows;
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
            Rows.RemoveAt(salesList.SelectedIndex);
            db.Sale.Remove((Sale)salesList.SelectedItem);
            salesList.Items.Refresh();
            db.SaveChanges();
        }

        private void AddSale(object sender, RoutedEventArgs e)
        {
            Sale f = new Sale();
            f.amountToSell = 0;
            f.price = 0;
            db.Sale.Add(f);
            db.SaveChanges();
            Rows.Add(f);
            salesList.Items.Refresh();
        }

        private void TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            salesList.Items.Refresh();
        }

        private void SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
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
