using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_INFORMATIQUE_SELMI_BELBACHIR
{
    /// <summary>
    /// Classe Competition où l'on pourra créer 
    /// </summary>
    public class Competition
    {
        private string nom;
        private int age;
        private DateTime dateDebut;
        private DateTime dateFin;
        private float prixParticipation;
        private string type;
        private string niveau;
        private int nbJoueurMin;


        private List<MembreCompetition> competiteurs;

        public Competition(string nom, int age, DateTime dateDebut, DateTime dateFin, float prixParticipation, string type, List<MembreCompetition> competiteurs)
        {
            this.nom = nom;
            this.age = age;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.prixParticipation = prixParticipation;
            this.type = type;
            this.competiteurs = competiteurs;
        }
    }
}