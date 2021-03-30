using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisClub
{
    class Competition_Multi : Competition
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
        //constructeurs
        public Competition_Multi()
        {

        }

        public int GetNbPointCompet()
        {
            return 0;
        }

    }
}
