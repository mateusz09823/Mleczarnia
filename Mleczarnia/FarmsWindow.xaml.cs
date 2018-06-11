using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;

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
            name.Focusable = false;
            surname.Focusable = false;
            adress.Focusable = false;
            nip.Focusable = false;
            var farms = db.Farm;
            foreach (var item in farms)
            {
               Rows.Add(item);
            }
            farmsList.ItemsSource = Rows;
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


        private void Delete_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            
            if (farmsList.SelectedIndex != -1)
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
            Rows.RemoveAt(farmsList.SelectedIndex);
            db.Farm.Remove((Farm)farmsList.SelectedItem);
            farmsList.Items.Refresh();
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
            Farm f = new Farm();
            f.name = "Nowa";
            f.surname = "Osoba";
            db.Farm.Add(f);
            db.SaveChanges();
            Rows.Add(f);
            farmsList.Items.Refresh();
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(name.Focusable == false)
            {
                name.Focusable = true;
                surname.Focusable = true;
                adress.Focusable = true;
                nip.Focusable = true;
            }
        }
    }
}
