using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_INFORMATIQUE_SELMI_BELBACHIR
{
    public class Entraîneur : Personnel
    {
        private string statut;

        public Entraîneur(string nom, string prenom, DateTime dateNaissance, string adresse, string ville, string sexe, string rib, float salaire, DateTime dateEmbauche, string statut) : base(nom, prenom, dateNaissance, adresse, ville, sexe, rib, salaire, dateEmbauche)
        {
            this.statut = statut;
        }
    }
}