using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Commande
    {

        private string numero;
        private Client codeClient;
        private DateTime date;
        private List<LigneCommande> ligneCmd = new List<LigneCommande>();
        private Double montantTotal;

        public Client CodeClient { get => codeClient; set => codeClient = value; }
        public string Numero { get => numero; set => numero = value; }
        public DateTime Date { get => date; set => date = value; }
        public double MontantTotal { get => montantTotal; set => montantTotal = value; }
        public List<LigneCommande> LigneCmd { get => ligneCmd; set => ligneCmd = value; }

        public Commande(string numCmd, Client codeClient, DateTime date, double montantTotal)
        {
            this.numero = numCmd;
            this.codeClient = codeClient;
            this.date = date;
            this.montantTotal = montantTotal;
        }

        public Commande(string numCmd, Client codeClient, DateTime date, List<LigneCommande> ligneCmd, double montantTotal) : this(numCmd)
        {
            this.codeClient = codeClient;
            this.date = date;
            this.ligneCmd = ligneCmd;
            this.montantTotal = montantTotal;
        }

        public Commande(string numCmd)
        {
            this.numero = numCmd;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Commande commande &&
                   numero == commande.numero;
        }
    }
}
