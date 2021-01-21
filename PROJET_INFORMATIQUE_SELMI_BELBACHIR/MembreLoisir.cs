using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.Serialization;

namespace PROJET_INFORMATIQUE_SELMI_BELBACHIR
{
    public class MembreLoisir : Membre
    {
        public MembreLoisir(string nom, string prenom, DateTime dateNaissance, string adresse, string ville, string sexe, bool cotisationPayer) : base(nom, prenom, dateNaissance, adresse, ville, sexe, cotisationPayer)
        {
        }

        public string reserver(string date)
        {
            DateTime dt = DateTime.Parse(date);
            return "Vous avez été inscrit à ce cours à la Date du: " + dt.ToString();
        }


    }
}