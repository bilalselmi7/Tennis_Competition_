using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_INFORMATIQUE_SELMI_BELBACHIR
{
    public class EquipeCompetition
    {
        private MembreCompetition capitaine;
        private List<MembreCompetition> coequipiers;
        private Competition competition;

        public EquipeCompetition(MembreCompetition capitaine, List<MembreCompetition> coequipiers, Competition competition)
        {
            this.capitaine = capitaine;
            this.coequipiers = coequipiers;
            this.competition = competition;
        }
    }
}