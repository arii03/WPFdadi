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

namespace LancioDado
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnLancia_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int numcasuale = random.Next(1, 6);
            string r = numcasuale.ToString();

            int n = int.Parse(txtInserisci.Text);
            if (n == numcasuale)
            {
                txtRisultato.Text = r + " Complimenti, hai vinto!";
            }
            else
            {
                txtRisultato.Text = r + " Ritenta, sarai più fortunato!";
            }
            if (n < 1 || n > 6)
            {
                MessageBox.Show("Devi inserire un numero compreso tra 1 e 6!!", "Attenzione!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnRicomincia_Click(object sender, RoutedEventArgs e)
        {
            txtRisultato.Clear();
            txtInserisci.Clear();
        }
    }
}
