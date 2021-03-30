using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TennisClub
{
    class Equipe
    {
        //collections
        public ArrayList Joueurs = new ArrayList();
        public ArrayList Journees = new ArrayList();
        int num_Equipe;
        public int NumEquipe
        {
            get { return num_Equipe; }
            set { num_Equipe = value; }
        }

        string nom_Equipe;
        public string NomEquipe
        {
            get { return nom_Equipe; }
            set { nom_Equipe = value; }
        }
        string nom_Capitaine;
        public string NomCapitaine
        {
            get { return nom_Capitaine; }
            set { nom_Capitaine = value; }
        }

        Competition competition;
        internal Competition Competition
        {
            get { return competition; }
            set { competition = value; }
        }

        //constructeurs
        public Equipe(int num_Equipe, string nom_Equipe, string nom_Capitaine)
        {
           this.num_Equipe = num_Equipe;
            this.nom_Equipe = nom_Equipe;
            this.nom_Capitaine = nom_Capitaine;
        }
        //Methodes
        public int NbJoueurs()
        {
            return 0;
        }
        public void SuppJoueur (int NumJoueur)
        {

        }
        public void SuppJoueurs (int Position)
        {

        }
        public bool VerifEquipe()
        {
            return true;
        }

        
    }
}
