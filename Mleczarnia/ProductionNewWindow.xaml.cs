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
    /// Logika interakcji dla klasy ProductionNewWindow.xaml
    /// </summary>
    public partial class ProductionNewWindow : Window
    {
        public ProductionNewWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ProductionWindow wnd = new ProductionWindow();
            wnd.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProductionWindow wnd = new ProductionWindow();
            wnd.Show();
            this.Close();
            //dodaj
        }
        void Window_Closing(object sender, CancelEventArgs e)
        {
            FarmsList.SaveToFileFarms();

        }
    }
}