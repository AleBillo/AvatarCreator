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

namespace DOMINICICOMPITO
{
    /// <summary>
    /// Logica di interazione per Abilità.xaml
    /// </summary>
    public partial class Abilità : Window
    {
        AbilitàGUI A = new Aria();
        AbilitàGUI T = new Terra();
        AbilitàGUI M = new Mare();

        public Abilità(Personaggio p)
        {
            InitializeComponent();

            #region assegnazione
            acquista.IsEnabled = false;
            livello.Text = 1.ToString();
            esperienza.Text = 500.ToString();
            nomeVisualizzatoCornice.Text = p.Nome.ToUpper();
            
            statistiche.Items.Add(p);
            statistiche.Items.Add($"\nAbilità Base=HIT\nDanno=5HP");
            #endregion

            #region img
            if (p is Umano)
            {
                Copri.Width = 0;
                Copri2.Width = 0;
                Orco.Width = 0;
                Copri3.Width = 0;
                Mare.Width = 0;
                Copri4.Width = 0;
                aria.Width = 0;
                Ibrido.Width = 0;
            }
            else if(p is Orco)
            {

                Copri.Width = 0;
                Copri2.Width = 0;
                UMano.Width = 0;
                Copri3.Width = 0;
                Mare.Width = 0;
                Copri4.Width = 0;
                aria.Width = 0;
                Ibrido.Width = 0;
            }
            else if(p is Mutante)
            {
                if (p.Razza == "Volante")
                {
                    Copri.Width = 0;
                    Copri2.Width = 0;
                    UMano.Width = 0;
                    Copri3.Width = 0;
                    Mare.Width = 0;
                    Copri4.Width = 0;
                    Orco.Width = 0;
                    Ibrido.Width = 0;
                }
                else if (p.Razza == "Marino")
                {
                    Copri.Width = 0;
                    Copri2.Width = 0;
                    UMano.Width = 0;
                    Copri3.Width = 0;
                    aria.Width = 0;
                    Copri4.Width = 0;
                    Orco.Width = 0;
                    Ibrido.Width = 0;
                }
            }
            else if (p is SuperUmano)
            {
                if (p.Razza == "Volante")
                {
                    Copri.Width = 0;
                    Copri2.Width = 0;
                    UMano.Width = 0;
                    Copri3.Width = 0;
                    Mare.Width = 0;
                    Copri4.Width = 0;
                    Orco.Width = 0;
                    Ibrido.Width = 0;
                }
                else if (p.Razza == "Marino")
                {
                    Copri.Width = 0;
                    Copri2.Width = 0;
                    UMano.Width = 0;
                    Copri3.Width = 0;
                    aria.Width = 0;
                    Copri4.Width = 0;
                    Orco.Width = 0;
                    Ibrido.Width = 0;
                }
            }
            else if(p is IbridoAnimale)
            {
                Copri.Width = 0;
                Copri2.Width = 0;
                UMano.Width = 0;
                Copri3.Width = 0;
                aria.Width = 0;
                Copri4.Width = 0;
                Orco.Width = 0;
                Mare.Width = 0;
            }

            #endregion

            #region ablt
            switch (p.abilita)
            {
                case 1:
                    //abilità terra +prezzo+tipo+danno es:
                    abilitàvisualizzate.Items.Add($"\nNome Abilità=Dirting Slash\n{T}\nTipo=Terra\nDanno=20HP");
                    abilitàvisualizzate.Items.Add($"\nNome Abilità=Terraformer\n{T}\nTipo=Terra\nDanno=50HP");
                    abilitàvisualizzate.Items.Add($"\nNome Abilità=Rock Punch\n{T}\nTipo=Terra\nDanno=40HP");
                    abilitàvisualizzate.Items.Add($"\nNome Abilità=Mineral Shield\n{T}\nTipo=Terra\nDanno=0HP");

                    break;
                case 2:
                    //abilità cielo+terra +prezzo+tipo+danno
                    abilitàvisualizzate.Items.Add($"\nNome Abilità=Dirting Slash\n{T}\nTipo=Terra\nDanno=20HP");
                    abilitàvisualizzate.Items.Add($"\nNome Abilità=Terraformer\n{T}\nTipo=Terra\nDanno=50HP");
                    abilitàvisualizzate.Items.Add($"\nNome Abilità=Air Pump\n{A}\nTipo=Aria\nDanno=20HP");
                    abilitàvisualizzate.Items.Add($"\nNome Abilità=Sky Punch\n{A}\nTipo=Aria\nDanno=50HP");
                    break;
                case 3:
                    //abilità mare+terra +prezzo+tipo+danno
                    abilitàvisualizzate.Items.Add($"\nNome Abilità=Dirting Slash\n{T}\nTipo=Terra\nDanno=20HP");
                    abilitàvisualizzate.Items.Add($"\nNome Abilità=Terraformer\n{T}\nTipo=Terra\nDanno=50HP");
                    abilitàvisualizzate.Items.Add($"\nNome Abilità=Shock Wave\n{M}\nTipo=Acqua\nDanno=60HP");
                    abilitàvisualizzate.Items.Add($"\nNome Abilità=Watering Kick\n{M}\nTipo=Terra\nDanno=70HP");
                    break;
            }

            #endregion
        }


        private void abilitàvisualizzate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            acquista.IsEnabled = true;
        }

        private void acquista_Click(object sender, RoutedEventArgs e)
        {
            int exp1 = int.Parse(esperienza.Text);
            if (exp1>=T.Prezzo)
            {

                statistiche.Items.Add(abilitàvisualizzate.SelectedItem);

                //if (abilitàvisualizzate.SelectedItem==T)
                //{
                //    exp1 = exp1 - 200;
                //    esperienza.Text = exp1.ToString();
                //}
                //else if (abilitàvisualizzate.SelectedItem == A)
                //{
                //    exp1 = exp1 - 500;
                //    esperienza.Text = exp1.ToString();
                //}
                //else if (abilitàvisualizzate.SelectedItem == M )
                //{
                //    exp1 = exp1 - 700;
                //    esperienza.Text = exp1.ToString();
                //}

                exp1 = exp1 - T.Prezzo; //soluzione temporanea
                esperienza.Text = exp1.ToString();
                abilitàvisualizzate.Items.Remove(abilitàvisualizzate.SelectedItem);

            }
            else
            {
                MessageBox.Show("Exp insufficiente\nSali di livello!");
            }
           
         
        }

        private void salidilivello_Click(object sender, RoutedEventArgs e)
        {
            int lvl = 0;
            lvl = int.Parse(livello.Text);
            lvl = lvl + 1;
            livello.Text = lvl.ToString();
            int exp = 0;
            exp = int.Parse(esperienza.Text);
            exp = exp + lvl * 2;
            esperienza.Text = exp.ToString();
        }
    }
}
