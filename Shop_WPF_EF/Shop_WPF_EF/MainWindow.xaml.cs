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


namespace Shop_WPF_EF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Products pr = new Products();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTN_ShowProdukte_Click(object sender, RoutedEventArgs e)
        {
           

            DG_Produkte.ItemsSource = pr.ShowProdukteTable();

           
        }

        private void BTN_ShowSearchedRecord_Click(object sender, RoutedEventArgs e)
        {
           
            int id = int.Parse(TBox_SeatchID.Text);
            DG_Produkte.ItemsSource = pr.ShowSearchedRecord(id);

        }
    }
}
