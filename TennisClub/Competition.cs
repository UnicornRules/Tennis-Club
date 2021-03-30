using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisClub
{
    class Competition
    {
       

        string nom_Competition;
        public string NomCompetition
        {
            get { return nom_Competition; }
            set { nom_Competition = value; }
        }

        string niveau;
        public string Niveau
        {
            get { return niveau; }
            set { niveau = value; }
        }

        int nb_Joueurs;
        public int NbJoueurs
        {
            get { return nb_Joueurs; }
            set { nb_Joueurs = value; }
        }

        int nb_Journees;
        public int NbJournees
        {
            get { return nb_Journees; }
            set { nb_Journees = value; }
        }

        int classementMaxi;
        public int ClassementMaxi
        {
            get { return classementMaxi; }
            set { classementMaxi = value; }
        }

        public Competition()
        {

        }
        public string ClassementMaxi()
        {
            return "void";
        }

    }
}
