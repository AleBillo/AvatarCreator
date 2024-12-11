using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINICICOMPITO
{
    public abstract class Personaggio
    {
        public string Razza { get; set; }
        public int Anni { get; set; }
        public string Nome { get; set; }
        public int Altezza { get; set; }
        public int Peso { get; set; }
        public int abilita { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }


    #region Umano

    public class Umano : Personaggio
    {

        public Umano(int anni, string nome, int altezza, int peso)
        {
            Anni = anni;
            Nome = nome;
            Altezza = altezza;
            Peso = peso;
            abilita = 1;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nAnni={Anni}\nNome={Nome}\nAltezza={Altezza}cm\nPeso={Peso}Kg\nAbilità=Terra";
        }
    }
    #endregion


    #region IbridoAnimale

    public class IbridoAnimale : Personaggio
    {
        
        public IbridoAnimale(int anni, string nome, int altezza, int peso, string razza)
        {
            Anni = anni;
            Nome = nome;
            Altezza = altezza;
            Peso = peso;
            Razza = razza;

            if (Razza == "Marino")
            {
                abilita = 3;
            }
            else if (Razza == "Volante")
            {
                abilita = 2;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"\nAnni={Anni}\nNome={Nome}\nAltezza={Altezza}cm\nPeso={Peso}Kg\nAbilità={Razza}";
        }


    }

    #endregion

    #region Mutante
    public class Mutante : Personaggio
    {
       
        public Mutante(int anni, string nome, int altezza, int peso, string razza)
        {
            Anni = anni;
            Nome = nome;
            Altezza = altezza;
            Peso = peso;
            Razza = razza;

            if (Razza == "Marino")
            {
                abilita = 3;
            }
            else if (Razza == "Volante")
            {
                abilita = 2;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"\nAnni={Anni}\nNome={Nome}\nAltezza={Altezza}cm\nPeso={Peso}Kg\nAbilità={Razza}";
        }
    }

    #endregion

    #region Orco
    public class Orco : Personaggio
    {
        public Orco(int anni, string nome, int altezza, int peso)
        {
            Anni = anni;
            Nome = nome;
            Altezza = altezza;
            Peso = peso;
            abilita = 1;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nAnni={Anni}\nNome={Nome}\nAltezza={Altezza}cm\nPeso={Peso}Kg\nAbilità=Terra";
        }
    }

    #endregion

    #region SuperUmano
    public class SuperUmano : Personaggio
    {
       
        public SuperUmano(int anni, string nome, int altezza, int peso, string razza)
        {
            Anni = anni;
            Nome = nome;
            Altezza = altezza;
            Peso = peso;
            Razza = razza;

            if (Razza == "Marino")
            {
                abilita = 3;
            }
            else if (Razza == "Volante")
            {
                abilita = 2;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"\nAnni={Anni}\nNome={Nome}\nAltezza={Altezza}cm\nPeso={Peso}Kg\nAbilità={Razza}";
        }
    }

    #endregion


}
