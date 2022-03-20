using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Produit
    {
        String reference;
        String designation;
        Double prix;
        int quantite;

        public Produit(string reference, string designation, double prix, int quantite)
        {
            this.reference = reference;
            this.Designation = designation;
            this.prix = prix;
            this.quantite = quantite;
        }


        public string Reference { get => reference; set => reference = value; }
        public string Designation { get => designation; set => designation = value; }
        public float Prix { get => (float)prix; set => prix = value; }
        public int Quantite { get => quantite; set => quantite = value; }
       

        public override bool Equals(object obj)
        {
            return obj is Produit produit &&
                   reference == produit.reference;
        }


        public override string ToString()
        {
            return reference + " | " + designation + " | " + prix +" | "+quantite;
        }

    }
}
