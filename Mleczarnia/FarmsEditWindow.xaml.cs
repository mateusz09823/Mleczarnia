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
    /// Logika interakcji dla klasy FarmsEditWindow.xaml
    /// </summary>
    public partial class FarmsEditWindow : Window
    {
        public FarmsEditWindow(int id)
        {
            InitializeComponent();
            string name = FarmsList.Get(id).GetName(); 
            string surname = FarmsList.Get(id).GetSurname();
            string address = FarmsList.Get(id).GetAddress();
            int nip = FarmsList.Get(id).GetNip();
            Name.Text = name;
            Surname.Text = surname;
            Address.Text = address;
            NIP.Text = nip.ToString();
            Id = id;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FarmsList.Set(Id, Name.Text.ToString(), Surname.Text.ToString(), Address.Text.ToString(), int.Parse(NIP.Text.ToString()));
            FarmsWindow wnd = new FarmsWindow();
            wnd.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FarmsWindow wnd = new FarmsWindow();
            wnd.Show();
            this.Close();
        }

        public int Id { get; set; }

        void Window_Closing(object sender, CancelEventArgs e)
        {
            FarmsList.SaveToFileFarms();

        }
    }
}
