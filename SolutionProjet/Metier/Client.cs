using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Client
    {
        private String code;
        private String nom;
        private String prenom;
        private String numTel;
        private String adresse;
        private String mail;

        public Client(string code, string nom, string prenom, string numTel, string adresse, string mail)
        {
            this.code = code;
            this.nom = nom;
            this.prenom = prenom;
            this.numTel = numTel;
            this.adresse = adresse;
            this.mail = mail;
        }

        public string Code { get => code; set => code = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string NumTel { get => numTel; set => numTel = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Mail { get => mail; set => mail = value; }

        public override bool Equals(object obj)
        {
            return obj is Client client &&
                   code == client.code;
        }

        public override string ToString()
        {
            return nom+' '+prenom;
        }
    }

}
