using System;
using System.Collections.Generic;
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
    /// Logika interakcji dla klasy FarmsAddWinow.xaml
    /// </summary>
    public partial class FarmsAddWinow : Window
    {
        public FarmsAddWinow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FarmsWindow wnd = new FarmsWindow();
            wnd.Show();
            this.Close();
            //zapis edycji
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FarmsWindow wnd = new FarmsWindow();
            wnd.Show();
            this.Close();
        }
    }
}
