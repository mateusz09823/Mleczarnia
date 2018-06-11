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
    /// Logika interakcji dla klasy SupplyWindow.xaml
    /// </summary>
    public partial class SupplyWindow : Window
    {
        MleczarniaDBEntities2 db = new MleczarniaDBEntities2();
        List<Delivery> Rows = new List<Delivery>();

        public SupplyWindow()
        {
            InitializeComponent();
            var delivery = db.Delivery;
            var farms = db.Farm;
            foreach (var item in delivery)
            {
                item.farm = farms.Find(item.farmID).name + " " + farms.Find(item.farmID).surname;
                Rows.Add(item);
            }
            deliveryList.ItemsSource = Rows;
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wnd = new MainWindow();
            wnd.Show();
            db.SaveChanges();
            this.Close();
        }

        

        /*private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int id;
            if (deliveryList.SelectedIndex == -1)
            {
                id = 0;
            }
            else id = deliveryList.SelectedIndex;
            SupplyNewWindow wnd = new SupplyNewWindow(id);
            wnd.Show();
            this.Close();
        }*/

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Rows.RemoveAt(deliveryList.SelectedIndex);
            db.Delivery.Remove((Delivery)deliveryList.SelectedItem);
            deliveryList.Items.Refresh();
            db.SaveChanges();
        }

        private void AddDelivery(object sender, RoutedEventArgs e)
        {
            Delivery f = new Delivery();
            f.farmID = 1;
            f.date = DateTime.Now;
            db.Delivery.Add(f);
            db.SaveChanges();
            Rows.Add(f);
            deliveryList.Items.Refresh();
        }

        private void TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            deliveryList.Items.Refresh();
        }

        private void SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            db.SaveChanges();
            deliveryList.Items.Refresh();
        }

        private void TextBoxGotKeyboardFocus(object sender, System.Windows.Input.KeyboardFocusChangedEventArgs e)
        {
            TextBox box = (TextBox)sender;
            box.SelectAll();
            box.Focus();
        }
    }

    public class Farms : ObservableCollection<Farm>
    {
        public Farm sFarm { set; get; }
        public Farm SFarm
        {
            get { return sFarm; }
            set { sFarm = value; }
        }


        public Farms()
        {
            MleczarniaDBEntities2 db = new MleczarniaDBEntities2();
            var farms = db.Farm;
            foreach (var item in farms)
            {
                Add(item);
            }
        }
    }
}
