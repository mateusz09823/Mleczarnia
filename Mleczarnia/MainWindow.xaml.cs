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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mleczarnia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MleczarniaDBEntities2 db = new MleczarniaDBEntities2();
            // FarmsList.LoadFromFileFarms();
            // ProductsList.LoadFromFileProducts();

            // FarmsList.Add(new Farm("Mateusz", "Graczyk", "Rżaniec 72", 123456789));
            // ProductsList.Add(new Product("Ser Chedar", "Krojony", "120g", 1,1));
            DoubleAnimation anim = new DoubleAnimation();
            anim.From = 50;
            anim.To = 240;
            anim.FillBehavior = FillBehavior.Stop;
            gospodarstwa.BeginAnimation(WidthProperty, anim);
            dostawy.BeginAnimation(WidthProperty, anim);
            produkty.BeginAnimation(WidthProperty, anim);
            produkcja.BeginAnimation(WidthProperty, anim);
            statystyki.BeginAnimation(WidthProperty, anim);
            sprzedaz.BeginAnimation(WidthProperty, anim);
            DoubleAnimation wanim = new DoubleAnimation();
            wanim.From = 50;
            wanim.To = 490;
            wanim.FillBehavior = FillBehavior.Stop;
            wyjscie.BeginAnimation(WidthProperty, wanim);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {//gospodarstwa
            
            FarmsWindow wnd = new FarmsWindow();
            wnd.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {//produkty
            ProductsWindow wnd = new ProductsWindow();
            wnd.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {//produkcja
            ProductionWindow wnd = new ProductionWindow();
            wnd.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {//sprzedaż
            SalesWindow wnd = new SalesWindow();
            wnd.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {//statystyki
            StatisticWindow wnd = new StatisticWindow();
            wnd.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {//wyjście
            this.Close();
            //FarmsList.SaveToFileFarms();
            //ProductsList.SaveToFileProducts();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {//dostawy
            SupplyWindow wnd = new SupplyWindow();
            wnd.Show();
            this.Close();
        }
    }
}
