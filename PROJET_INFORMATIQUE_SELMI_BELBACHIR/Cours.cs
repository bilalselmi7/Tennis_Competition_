using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_INFORMATIQUE_SELMI_BELBACHIR
{
    public class Cours
    {
        private DateTime date;
        private List<MembreLoisir> participants;
        private string lieu;

        public Cours(DateTime date, List<MembreLoisir> participants, string lieu)
        {
            this.date = date;
            this.participants = participants;
            this.lieu = lieu;
        }

        public override string ToString()
        {
            return "Le cours a lieu à: " + lieu + "à partir de" + date.ToString();
        }
    }
}