using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace PROJET_INFORMATIQUE_SELMI_BELBACHIR
{
    public abstract class Personne
    {
        protected string nom;
        protected string prenom;
        protected string sexe;
        protected DateTime dateNaissance;
        protected string adresse;
        protected string ville;
        protected string telephone;


        public Personne(string nom, string prenom, DateTime dateNaissance, string adresse, string ville, string sexe)
        {
            this.nom = nom.ToUpper();
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.adresse = adresse;
            this.ville = ville;
            this.sexe = sexe;
        }

        public string Sexe => sexe;

        //public string Sexe { get; set; }

        public string Ville => ville;

        //public string Ville { get; set; }

        public string Nom => nom;

        //public string Nom { get; set; }

        public string Prenom => prenom;

        //public string Prenom { get; set; }

        public DateTime DateNaissance => dateNaissance;

        //public DateTime DateNaissance { get; set; }

        public string Adresse
        {
            get => adresse;
            //get { return this.adresse; }
            set => adresse = value;
            //set { this.adresse = value; }
        }

        public string Telephone
        {
            get => telephone;
            //get { return this.adresse; }
            set => telephone = value;
            //set { this.adresse = value ; }
        }

        public int Age()
        {
            return DateTime.Now.Year - this.dateNaissance.Year;
        }


    }
}