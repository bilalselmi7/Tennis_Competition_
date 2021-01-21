using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_INFORMATIQUE_SELMI_BELBACHIR
{
    public abstract class Membre : Personne
    {
        protected bool cotisationPayer;
        protected int id;
        private static int cpt = 0;

        public Membre(string nom, string prenom, DateTime dateNaissance, string adresse, string ville, string sexe, bool cotisationPayer) : base(nom, prenom, dateNaissance, adresse, ville, sexe)
        {
            this.id = cpt++;
            this.cotisationPayer = cotisationPayer;
        }

        public int Id => id;

        public bool CotisationPayer
        {
            get => cotisationPayer;
        }

        public void payerCotisation()
        {
            cotisationPayer = true;
        }

    }
}