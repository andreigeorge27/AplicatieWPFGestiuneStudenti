using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatiePRC
{
    class SituatieStudenti
    {
        public String Nume { get; set; }
        public String Prenume { get; set; }
        public int nrCredite { get; set; }
        public double medie { get; set; }
        public bool integralist { get; set; }

        public SituatieStudenti(String Nume, String Prenume, int nrCredite, bool integralist)
        {
            this.Nume = Nume;
            this.Prenume = Prenume;
            this.nrCredite = nrCredite;
            this.integralist = integralist;
            if (integralist)
            {
                this.medie = nrCredite / 30;
            }
            else
            {
                medie = 0;
            }
           
        }
    }
}
