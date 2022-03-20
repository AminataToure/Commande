using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class LigneCommande
    {
        private Commande numCmd;
        private Produit codProd;
        private int qteCmd;
        private Double prix;
        private double totalLigne;

        public Commande NumCmd { get => numCmd; set => numCmd = value; }
        public Produit CodProd { get => codProd; set => codProd = value; }
        public int QteCmd { get => qteCmd; set => qteCmd = value; }
        public double Prix { get => prix; set => prix = value; }
        public double TotalLigne { get => totalLigne; set => totalLigne = value; }

        public LigneCommande(Commande numCmd, Produit codProd, int qteCmd, double prix, double totalLigne)
        {
            this.numCmd = numCmd;
            this.codProd = codProd;
            this.qteCmd = qteCmd;
            this.prix = prix;
            this.totalLigne = totalLigne;
        }

        public override string ToString()
        {
            return this.prix + " " + this.qteCmd;
        }

        public override bool Equals(object obj)
        {
            return obj is LigneCommande commande &&
                   EqualityComparer<Commande>.Default.Equals(numCmd, commande.numCmd) &&
                   EqualityComparer<Produit>.Default.Equals(codProd, commande.codProd);
        }
    }
}
