﻿using System;
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
    /// Logika interakcji dla klasy StatisticsProductsWindow.xaml
    /// </summary>
    public partial class StatisticsProductsWindow : Window
    {
        public StatisticsProductsWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wnd = new MainWindow();
            wnd.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //ekprot do pliku
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {//gospodarze
            StatisticsFarmsWindow wnd = new StatisticsFarmsWindow();
            wnd.Show();
            this.Close();
        }
   

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        void Window_Closing(object sender, CancelEventArgs e)
        {
            FarmsList.SaveToFileFarms();

        }
    }
}