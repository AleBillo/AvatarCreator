using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINICICOMPITO
{
    public abstract class AbilitàGUI
    {
        public int Prezzo { get; set; }
       

        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class Terra : AbilitàGUI
    {
        public Terra()
        {
            Prezzo = 400;
        }
        public override string ToString()
        {
            return $"Prezzo={Prezzo}";
        }
    }

    public class Aria : AbilitàGUI
    {
        public Aria()
        {
            Prezzo = 500;
        }
        public override string ToString()
        {
            return $"Prezzo={Prezzo}";
        }
    }

    public class Mare : AbilitàGUI
    {
        public Mare()
        {
            Prezzo = 700;
        }
        public override string ToString()
        {
            return $"Prezzo={Prezzo}";
        }
    }
}
