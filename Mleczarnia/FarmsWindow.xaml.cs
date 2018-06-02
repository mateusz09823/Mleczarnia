using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Documents;


namespace Mleczarnia
{
    /// <summary>
    /// Interaction logic for FarmsWindow.xaml
    /// </summary>
    public partial class FarmsWindow : Window
    {
        public FarmsWindow()
        {
            InitializeComponent();
            List<Row> Rows = new List<Row>();
            for (int i = 0; i < FarmsList.GetSizeOfList(); i++)
            {
                string name = FarmsList.Get(i).GetName(); 
                string surname = FarmsList.Get(i).GetSurname();
                string address = FarmsList.Get(i).GetAddress();
                int nip = FarmsList.Get(i).GetNip();
                Rows.Add(new Row() { Name = name, Surname = surname, Address = address , Nip = nip });
            }
            lvFarms.ItemsSource = Rows;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wnd = new MainWindow();
            wnd.Show();
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
            if (lvFarms.SelectedIndex == -1)
            {
                id = 0;
            }
            else id = lvFarms.SelectedIndex;
            FarmsEditWindow wnd = new FarmsEditWindow(id);
            wnd.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int id = lvFarms.SelectedIndex;
            FarmsList.Delete(id);
            FarmsWindow wnd = new FarmsWindow();
            wnd.Show();
            this.Close();
        }
        public class Row
        {
            public string Name { get; set; }

            public string Surname { get; set; }
    
            public string Address { get; set; }

            public int Nip { get; set; }

        }
    }
}
