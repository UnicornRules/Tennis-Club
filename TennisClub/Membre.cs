using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TennisClub
{
    class Membre
    {
        
        string nom_Membre;
        public string NomMembre
        {
            get { return nom_Membre; }
            set { nom_Membre = value; }
        }

        string prenom_Membre;
        public string PrenomMembre
        {
            get { return prenom_Membre; }
            set { prenom_Membre = value; }
        }
        string sexe;
        public String Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }

        DateTime date_Naissance;
        public DateTime DateNaissance
        {
            get { return date_Naissance; }
            set { date_Naissance = value; }
        }

        string adresse;
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }


        string ville;
        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }

        string telephonePortbable;
        public string TelephonePortable
        {
            get { return telephonePortbable; }
            set { telephonePortbable = value; }
        }

        string classement;
        public string Classement
        {
            get { return classement; }
            set { classement = value; }
        }

        //constructeurs

        public Membre(string nom_membre, string prenom_Membre, string classement)
        {
            this.nom_Membre = nom_Membre;
            this.prenom_Membre = prenom_Membre;
            this.classement = classement;
        }

        public int NbMatchsJoues()
        {
            return 0;
        }
        public int NbMatchsPerdus()
        {
            return 0;
        }
        public int NbMatchsGagnes()
        {
            return 0;
        }
    }
}
