using DAO;
using Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contraster
{
    public class ControllerLigneCommande
    {
        static List<LigneCommande> lesLigneCommande = LigneCommandeDAO.FindAll();
        public static bool save(Commande c, Produit p, String q)
        {
            if (q == "" || Convert.ToInt32(q) <= 0)
            {
                MessageBox.Show("La quantité doit être doit avoir une valeur positive");
                return false;
            }
            else if (p.Quantite <= Convert.ToInt32(q))
            {
                MessageBox.Show("La quantité doit être inférieur a la quantité en stock");
                return false;
            }
            else
            {
                int qte = Convert.ToInt32(q); double montantT = p.Prix * qte;
                LigneCommande cmd = new LigneCommande(c, p, qte, p.Prix, montantT);
                if (lesLigneCommande.Contains(cmd))
                {
                    MessageBox.Show("La commande existe dèja");
                    return false;
                }
                else
                {
                    LigneCommandeDAO.AddCommande(cmd);
                    p.Quantite = p.Quantite - qte;
                    ProduitDAO.UPDATE(p);
                    MessageBox.Show("Ligne commande ajouté");
                    return true;
                }
            }

        }
        public static void updateProduit(Commande cmd,Produit p,string nouvelleQ,Produit ancienP)
        {
            LigneCommande l= LigneCommandeDAO.FindByCod(p.Reference);
            if (Convert.ToInt32(nouvelleQ)<0)
            {
                MessageBox.Show("La nouvelle quantité doit être positive");
            }
            else if(Convert.ToInt32(nouvelleQ) > p.Quantite)
            {
                MessageBox.Show("La nouvelle quantité est supérieur à la quatité en stock");
            }
            else
            {   
                //Produit ancienP = ControllerLigneCommande.
                Produit nouvauP = new Produit(p.Reference, p.Designation, p.Prix, (p.Quantite + l.QteCmd) - Convert.ToInt32(nouvelleQ));
                ProduitDAO.UpdateQteStock(nouvauP);
                LigneCommande lcmd = new LigneCommande(cmd, nouvauP, Convert.ToInt32(nouvelleQ), nouvauP.Prix,nouvauP.Prix * Convert.ToInt32(nouvelleQ));
                LigneCommandeDAO.UpdateLigneCode(lcmd);               
            }
        }
       /* public static bool Update(Commande c, Produit p, String q)
        {
            if (q == "" || Convert.ToInt32(q) <= 0)
            {
                MessageBox.Show("La quantité doit être doit avoir une valeur positive");
                return false;
            }
            else if (p.Quantite <= Convert.ToInt32(q))
            {
                MessageBox.Show("La quantité doit être inférieur a la quantité en stock");
                return false;
            }
            else
            {
                
            }
            else
            {
                                
                int qte = Convert.ToInt32(q); double montantT = p.Prix * qte;
                LigneCommande cmd = new LigneCommande(c, p, qte, p.Prix, montantT);
                if (lesLigneCommande.Contains(cmd))
                {
                    MessageBox.Show("La commande existe dèja");
                    return false;
                }
                else
                {
                    p.Quantite = p.Quantite - qte;
                    ProduitDAO.UPDATE(p);
                    MessageBox.Show("Ligne commande ajouté");
                    return true;
                }
            }
        }*/
            /**********************************************************************************************/
         public static void delete(string n, string c)
        {
            DialogResult dr = MessageBox.Show("Voullez vous vraiment supprimer", "Attention", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                LigneCommande ligneCommande = LigneCommandeDAO.FindByCod(c);
                Produit p = ProduitDAO.FindByRef(ligneCommande.CodProd.Reference);
                ligneCommande.CodProd.Quantite = p.Quantite + ligneCommande.QteCmd;
                ProduitDAO.UPDATE(ligneCommande.CodProd);
                LigneCommandeDAO.delete(n, c);
            }

        }
        /**********************************************************************************/
        public static List<LigneCommande> FindAll()
        {
            return LigneCommandeDAO.FindAll();
        }
        /*************************************************************************************/
        public static List<LigneCommande> findAllNum(string num)
        {
            return LigneCommandeDAO.FindByNum(num);
        }
    }
}
