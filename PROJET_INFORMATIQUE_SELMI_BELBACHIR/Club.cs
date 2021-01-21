using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_INFORMATIQUE_SELMI_BELBACHIR
{
    /// <summary>
    /// CLASSE CLUB A INSTANCIER
    /// </summary>
    class Club
    {
        #region Attributs
        private List<Membre> membres; // Liste de membres
        private List<Personne> personnels; // Liste de Personnes
        private List<Cours> cours; // Liste de Cours
        private string ville; // Ville où se trouve le club
        #endregion

        #region Constructeurs
        public Club(List<Membre> membres, List<Personne> personnels, string ville)
        {
            this.membres = membres;
            this.personnels = personnels;
            this.ville = ville;
        }

        public Club(string ville)
        {
            this.ville = ville;
            this.membres = new List<Membre>();
            this.personnels = new List<Personne>();
        }
        #endregion

        #region Méthodes
        public Personne inscriptionEntraîneur(string nom, string prenom, DateTime dateNaissance, string adresse,
            string ville, string sexe, string statut)
        {
            string a = ""; // /!\
            Entraîneur nouveauEntraineur = new Entraîneur(nom, prenom, dateNaissance, adresse, ville, sexe, a, 2,Convert.ToDateTime("12/07/1997"),statut);
            personnels.Add(nouveauEntraineur);
            //  personnels.Add(nouveauEntraineur);
            return nouveauEntraineur;
        }


        public MembreLoisir inscriptionLoisir(string nom, string prenom, string dateNaissance, string adresse,
            string ville, string sexe)
        {
            DateTime dt = DateTime.Parse("10/10/2000");
            //DateTime dt = Convert.ToDateTime(dateNaissance);
            MembreLoisir nouveauMembre = new MembreLoisir(nom, prenom, dt, adresse, ville, sexe, false);
            membres.Add(nouveauMembre);
            Console.WriteLine("Vous êtes maintenant inscrit " + nouveauMembre.Prenom + " !");
            return nouveauMembre;
        }

        public MembreCompetition inscriptionCompetition(string nom, string prenom, DateTime dateNaissance, string adresse,
            string ville, string sexe, int classement)
        {
            List<MembreCompetition> equipe = new List<MembreCompetition>();
            List<Competition> compétitions = new List<Competition>();

            MembreCompetition nouveauMembre = new MembreCompetition(nom, prenom, dateNaissance, adresse, ville, sexe, false, classement, equipe, compétitions);
            membres.Add(nouveauMembre);
            return nouveauMembre;
        }



        public string payerCotisation(int id)
        {
            string msg = "Vous n'êtes pas inscrit dans ce club !";
            membres.Find(x =>
            {
                if (x.Id == id)
                {
                    x.payerCotisation();
                    msg = x.Nom + " " + x.Prenom + " a payé sa cotisation";
                    return true;
                }

                return false;
            });

            return msg;

        }

        public float montantCotisation(int id)
        {
            float montant = 0;
            membres.Find(x =>
            {
                if (x.Id == id)
                {
                    if (x.Ville == this.ville)
                    {
                        if (x.Age() > 18)
                        {
                            montant = 200;
                        }

                        else
                        {
                            montant = 130;
                        }
                    }

                    else
                    {
                        if (x.Age() > 18)
                        {
                            montant = 280;
                        }

                        else
                        {
                            montant = 180;
                        }
                    }

                    if (x is MembreCompetition m)
                    {
                        montant += 20;
                    }
                    return true;
                }

                return false;
            });
            return montant;
        }
        #endregion
    }
}
