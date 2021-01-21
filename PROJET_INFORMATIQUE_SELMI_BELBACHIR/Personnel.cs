using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_INFORMATIQUE_SELMI_BELBACHIR
{
    /// <summary>
    /// Classe Personnel qui hérite de Personne
    /// </summary>
    public class Personnel : Personne
    {
        #region Attributs

        /// <summary>
        /// On ajoute 5 attributs à la classe Personnel (en plus des attributs qui ont été hérités de la classe Personne)
        /// </summary>
        private string rib;
        private float salaire;
        private DateTime dateEmbauche;
        protected int matricule;
        private static int cpt = 0;

        #endregion

        #region Constructeurs
        public Personnel(string nom, string prenom, DateTime dateNaissance, string adresse, string ville, string sexe, string rib, float salaire, DateTime dateEmbauche) : base(nom, prenom, dateNaissance, adresse, ville, sexe)
        {
            this.rib = rib;
            this.salaire = salaire;
            this.dateEmbauche = dateEmbauche;
            matricule = cpt++;
        }
        #endregion

        #region Propriétés
        public int Matricule
        {
            get => matricule;
        }
        #endregion
    }
}