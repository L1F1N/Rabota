﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpfishka
{
    /// <summary>
    /// Логика взаимодействия для Stranica.xaml
    /// </summary>
    public partial class Stranica : Page
    {
        public Stranica()
        {
            InitializeComponent();
            DGridHotels.ItemsSource = TourEntities.GetContext().Hotel.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage());
        }
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
