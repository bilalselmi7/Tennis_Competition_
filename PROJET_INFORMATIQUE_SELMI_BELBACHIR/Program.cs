using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_INFORMATIQUE_SELMI_BELBACHIR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Encoding.ASCII.GetBytes("A")[0]); //On classe par ordre alphabetique grace au code ASCII (que la premiere lettre dans un premier temps ([0]) 
            Club AMMA = new Club("Paris");

            MembreLoisir lies = AMMA.inscriptionLoisir("Haouas", "Lies", "10/27/1999", "27 rue du Maroc", "Paris", "M");
            MembreLoisir A = AMMA.inscriptionLoisir("Aouas", "Lies", "10/27/1999", "27 rue du Maroc", "Paris", "M");
            MembreLoisir C = AMMA.inscriptionLoisir("Bouas", "Maman", "10/27/1999", "27 rue du Maroc", "Paris", "M");
            MembreLoisir B = AMMA.inscriptionLoisir("Bouas", "Lies", "10/27/1999", "27 rue du Maroc", "Paris", "M");
            
             Console.WriteLine(lies.age());
             Console.WriteLine(lies.Id);
             Console.WriteLine(AMMA.montantCotisation(0));
             Console.WriteLine(lies.reserver("1/19/2016"));
             Console.WriteLine(lies.Adresse);
             Console.WriteLine(AMMA.modifierAdresseMembre(0, "12 rue la Défense"));
             Console.WriteLine(lies.Adresse);
             Console.WriteLine(AMMA.supprimerMembre(0));
             Console.WriteLine(AMMA.payerCotisation(0));
            
            List<Membre> t = AMMA.RechercheMembreAlphabet(AMMA.Membres);

            foreach (Membre m in t)
            {
                Console.WriteLine(m.Nom + " " + m.Prenom);
            }

        }
    }
}