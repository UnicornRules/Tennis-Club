using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisClub
{
    class Competition_Simple : Competition
    {

        int nbSimpleFemme;
        public int NbsimpleFemme
        {
            get { return nbSimpleFemme; }
            set { nbSimpleFemme = value; }
        }

        int nbSimpleHomme;
        public int NbSimpleHomme
        {
            get { return nbSimpleHomme; }
            set { nbSimpleHomme = value; }
        }
        //Constructeur
        public Competition_Simple()
        {

        }

        public int GetNbPointCompet()
        {
            return 0;
        }
    }
}
