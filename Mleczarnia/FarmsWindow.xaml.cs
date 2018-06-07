using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;


namespace Mleczarnia
{
    /// <summary>
    /// Interaction logic for FarmsWindow.xaml
    /// </summary>
    public partial class FarmsWindow : Window
    {
        MleczarniaDBEntities2 db = new MleczarniaDBEntities2();
        List<Farm> Rows = new List<Farm>();
        public FarmsWindow()
        {
            InitializeComponent();
            var farms = db.Farm;
            foreach (var item in farms)
            {
               Rows.Add(item);
            }
            farmsList.ItemsSource = Rows;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wnd = new MainWindow();
            wnd.Show();
            db.SaveChanges();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           FarmsAddWinow wnd = new FarmsAddWinow();
            wnd.Show();
            this.Close();
        }
    
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int id;
            if (farmsList.SelectedIndex == -1)
            {
                id = 0;
            }
            else id = farmsList.SelectedIndex;
            FarmsEditWindow wnd = new FarmsEditWindow(id);
            wnd.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
           Rows.RemoveAt(farmsList.SelectedIndex);
            db.Farm.Remove((Farm)farmsList.SelectedItem);
            farmsList.Items.Refresh();
            db.SaveChanges();
        }
       
        private void AddPerson(object sender, RoutedEventArgs e)
        {
            Farm f = new Farm();
            f.name = "Nowa";
            f.surname = "Osoba";
            db.Farm.Add(f);
            db.SaveChanges();
            Rows.Add(f);
            farmsList.Items.Refresh();
        }

        private void TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            farmsList.Items.Refresh();
        }

        private void TextBoxGotKeyboardFocus(object sender, System.Windows.Input.KeyboardFocusChangedEventArgs e)
        {
            TextBox box = (TextBox)sender;
            box.SelectAll();
            box.Focus();
        }
        
       
    }
}
