using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TennisClub
{
    class Club
    {
        public ArrayList Equipes = new ArrayList();
        public ArrayList Membres = new ArrayList();

        //constructeurs
        public Club (ArrayList Equipes, ArrayList Membres)
        {
            this.Equipes = Equipes;
            this.Membres = Membres;

        }


        //Methodes
        public int NbEquipe()
        {
            return 0;
        }
        public int GetnbMembres ()
        {
            return 0;
        }
        public void AddEquipe ()
        {

        }
        public void AddCompeteMulti()
        {

        }
        public void AddCompeteSimple()
        {

        }
        public void SuppCompet (int NomCompet)
        {

        }
    }
}
