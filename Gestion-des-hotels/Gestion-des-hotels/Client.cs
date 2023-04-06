using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_des_hotels
{
    internal class Client
    {

        //creation des propriete de la classe client sans attributs parceque il n y a pas des contraints sur les attributs  

        


        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string NbCarte { get; set; }
        public string NbChambre { get; set; }


        //creation d'un constructeur qui intialise tout les atributs 
        public Client(string nom, string prenom, string email, string nbCarte, string nbChambre)
        {
            Nom = nom;
            Prenom = prenom;
            Email = email;
            NbCarte = nbCarte;
            NbChambre = nbChambre;
        }

    }
}
