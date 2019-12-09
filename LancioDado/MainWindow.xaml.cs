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
            int puntata = int.Parse(txtPuntata.Text);
            int crediti = int.Parse(lblCrediti.Content.ToString());
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
            if (numcasuale == n)
            {
                crediti = crediti + puntata * 3;
                lblCrediti.Content = crediti;
            }
            else
            {
                crediti = crediti - puntata;
                lblCrediti.Content = crediti;

            }
            if (crediti == 0)
            {
                MessageBox.Show("Hai finito i crediti.", "GAME OVER", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                MessageBox.Show("Non puoi inserire una puntata maggiore dei tuoi crediti!!", "Attenzione!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            Uri resourceUri = new Uri($"/Images/dado{r}.png", UriKind.Relative);
            imgDadi.Source = new BitmapImage(resourceUri);
        }

        private void btnRicomincia_Click(object sender, RoutedEventArgs e)
        {
            txtRisultato.Clear();
            txtInserisci.Clear();
            lblCrediti.Content = 150;
            txtPuntata.Clear();
            imgDadi.Source = null;
        }
    }
}
