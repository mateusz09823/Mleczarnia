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
    /// Logika interakcji dla klasy SalesNewWindow.xaml
    /// </summary>
    public partial class SalesNewWindow : Window
    {
        public SalesNewWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SalesWindow wnd = new SalesWindow();
            wnd.Show();
            this.Close();
            //zapis sprzedaży
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SalesWindow wnd = new SalesWindow();
            wnd.Show();
            this.Close();
        }
        void Window_Closing(object sender, CancelEventArgs e)
        {
            FarmsList.SaveToFileFarms();

        }

    }
}
