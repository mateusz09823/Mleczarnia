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
    /// Logika interakcji dla klasy SupplyNewWindow.xaml
    /// </summary>
    public partial class SupplyNewWindow : Window
    {
        public SupplyNewWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SupplyWindow wnd = new SupplyWindow();
             wnd.Show();
            this.Close();
        //zapis dostawy
        }

    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
            SupplyWindow wnd = new SupplyWindow();
            wnd.Show();
            this.Close();
        }

        void Window_Closing(object sender, CancelEventArgs e)
        {
            FarmsList.SaveToFileFarms();

        }
    }
}
