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

namespace DOMINICICOMPITO
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        Abilità win2;

        public MainWindow()
        {
            InitializeComponent();

            #region GUI
            Vai_Avanti.IsEnabled = false;
            rect2.Width = 0;
            rect3.Width = 0;
            rect4.Width = 0;
            #endregion
        }

        #region Pulsanti
        private void inserisci_Click(object sender, RoutedEventArgs e)
        {
            

            Vai_Avanti.IsEnabled = true;
            int anniI, altezzaI, pesoI;
            string nomeI = nome.Text; ;
            anniI = int.Parse(anni.Text);
            altezzaI = int.Parse(altezza.Text);
            pesoI = int.Parse(peso.Text);
            string razzaI = "";

            if (umano.IsChecked == true)
            {
                Personaggio Umano = new Umano(anniI, nomeI, altezzaI, pesoI);
                sintesi.Items.Add(Umano);
                win2 = new Abilità(Umano);
            }
            else if (orco.IsChecked == true)
            {
                Personaggio Orco = new Orco(anniI, nomeI, altezzaI, pesoI);
                sintesi.Items.Add(Orco);
                win2 = new Abilità(Orco);
            }
            else if (superumano.IsChecked == true)
            {
                rectangle.Width = 0;
                if (volante1.IsChecked == true)
                {
                    razzaI = "Volante";
                }
                else if (Marino.IsChecked == true)
                {
                    razzaI = "Marino";
                }
                else
                {
                    MessageBox.Show("Errore\nSelezioni un tipo!");
                }
                Personaggio Super = new SuperUmano(anniI, nomeI, altezzaI, pesoI, razzaI);
                sintesi.Items.Add(Super);
                win2 = new Abilità(Super);
            }
            else if (IbridoAnimale.IsChecked == true)
            {
                rectangle.Width = 0;
                if (volante1.IsChecked == true)
                {
                    razzaI = "Volante";
                }
                else if (Marino.IsChecked == true)
                {
                    razzaI = "Marino";
                }
                else
                {
                    MessageBox.Show("Errore\nSelezioni un tipo!");
                }
                Personaggio Ibrido = new IbridoAnimale(anniI, nomeI, altezzaI, pesoI, razzaI);
                sintesi.Items.Add(Ibrido);
                win2 = new Abilità(Ibrido);
            }
            else if (mutante.IsChecked == true)
            {
                rectangle.Width = 0;
                if (volante1.IsChecked == true)
                {
                    razzaI = "Volante";
                }
                else if (Marino.IsChecked == true)
                {
                    razzaI = "Marino";
                }
                else
                {
                    MessageBox.Show("Errore\nSelezioni un tipo!");
                }
                Personaggio Mutante = new Mutante(anniI, nomeI, altezzaI, pesoI, razzaI);
                sintesi.Items.Add(Mutante);
                 win2 = new Abilità(Mutante);

            }
            else
            {
                MessageBox.Show("Errore\nSelezioni una Razza!");
            }

            inserisci.IsEnabled = false;
            rect2.Width = 431;
            rect3.Width = 413;
            rect4.Width = 352;
        }

        private void Vai_Avanti_Click(object sender, RoutedEventArgs e)
        {
            
            inserisci.IsEnabled = false;
            win2.Show();
            
        }

        #endregion

        #region Checked
        private void mutante_Checked(object sender, RoutedEventArgs e)
        {
            rectangle.Width = 0;
        }

        private void superumano_Checked(object sender, RoutedEventArgs e)
        {
            rectangle.Width = 0;
        }

        private void IbridoAnimale_Checked(object sender, RoutedEventArgs e)
        {
            rectangle.Width = 0;
        }

        private void orco_Checked(object sender, RoutedEventArgs e)
        {
            rectangle.Width = 130;
        }

        private void umano_Checked(object sender, RoutedEventArgs e)
        {
            rectangle.Width = 130;
        }
        #endregion
    }


}

