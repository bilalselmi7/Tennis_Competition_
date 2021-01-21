using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PROJET_INFORMATIQUE_SELMI_BELBACHIR
{
    public class MembreCompetition : Membre
    {
        private int classement;
        private List<MembreCompetition> equipeEntrainement;
        private List<MembreCompetition> equipeCompetitions;
        private List<Competition> compétitions;

        public MembreCompetition(string nom, string prenom, DateTime dateNaissance, string adresse, string ville, string sexe, bool cotisationPayer, int classement, List<MembreCompetition> equipeEntrainement, List<Competition> compétitions) : base(nom, prenom, dateNaissance, adresse, ville, sexe, cotisationPayer)
        {
            this.classement = classement;
            this.equipeEntrainement = equipeEntrainement;
            this.compétitions = compétitions;
        }
    }
}