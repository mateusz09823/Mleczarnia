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
            farmID.IsHitTestVisible = false;
            date.Focusable = false;
            milkAmount.Focusable = false;
            var delivery = db.Delivery;
            var farms = db.Farm;
            foreach (var item in delivery)
            {
                item.farm = farms.Find(item.farmID).name + " " + farms.Find(item.farmID).surname;
                item.milkEntrenceValue = item.milkAmount;
                Rows.Add(item);
            }
            deliveryList.ItemsSource = Rows;
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
            deliveryList.Items.Refresh();
        }

        private void ListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (farmID.IsHitTestVisible == false)
            {
                farmID.IsHitTestVisible = true;
                date.Focusable = true;
                milkAmount.Focusable = true;
            }
        }

        private void Combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
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

        private void Delete_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

            if (deliveryList.SelectedIndex != -1)
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
            Rows.RemoveAt(deliveryList.SelectedIndex);
            db.Delivery.Remove((Delivery)deliveryList.SelectedItem);
            deliveryList.Items.Refresh();
            db.SaveChanges();

        }

        private void Return_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var tanks = db.Tank;
            var tank = db.Tank.Single(a => a.tankID == 1);
            foreach (var item in Rows)
            {
                if(item.milkAmount!=item.milkEntrenceValue)
                {
                    float milk=0;
                    milk = (float)item.milkAmount - (float)item.milkEntrenceValue;
                    tank.tankFilling += milk;
                    db.SaveChanges();
                }
            }
            MainWindow wnd = new MainWindow();
            wnd.Show();
            db.SaveChanges();
            this.Close();
        }

        private void Add_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Delivery f = new Delivery();
            f.farmID = 1;
            f.date = DateTime.Now;
            f.milkEntrenceValue = 0;
            f.milkAmount = 0;
            db.Delivery.Add(f);
            db.SaveChanges();
            Rows.Add(f);
            deliveryList.Items.Refresh();

        }
        private void Filter(object sender, RoutedEventArgs e)
        {
            float minimuAmountOfMilk;
            if (float.TryParse(milk.Text, out minimuAmountOfMilk))
            {
                View.Filter = delegate (object item)
                {
                    Delivery product = item as Delivery;
                    if (product != null)
                    {
                        return (product.milkAmount > minimuAmountOfMilk);
                    }
                    return false;
                };
            }
        }
        private void FilterNone(object sender, RoutedEventArgs e)
        {
            View.Filter = null;
        }
        private void GroupSurname(object sender, RoutedEventArgs e)
        {
            View.GroupDescriptions.Clear();
            View.GroupDescriptions.Add(new PropertyGroupDescription("Farm.surname"));
        }
        private void GroupNone(object sender, RoutedEventArgs e)
        {
            View.GroupDescriptions.Clear();
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
