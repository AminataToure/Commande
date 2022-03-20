using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metier;
using DAO;

namespace contraster
{
    public class ControllerProduit
    {
        private static List<Produit> lp = ProduitDAO.FindALL();

        public static List<Produit> GetProduits()
        {
            return lp;
        }

        public static bool Add(Produit p)
        {
            
                if (lp.Contains(p))
                    return false;
                else
                {
                    lp.Add(p);
                    ProduitDAO.ADD(p);
                return true;
                }
          
        }

        public static bool Update(Produit p)
        {
            Produit prd = ProduitDAO.FindByRef(p.Reference);
            
            if (lp.Contains(prd))
            {
                lp.Remove(prd);
                lp.Add(p);
                ProduitDAO.UPDATE(p);
                return true;
            }
            else
            {
                return false;
            }
           
             
        }

        public static List<Produit> Findref(string resf)
        {
            List<Produit> c = new List<Produit>();
            c.Add(ProduitDAO.FindByRef(resf));

            return c;
        }
        public static bool Remove(Produit p)
        {
            if (lp.Contains(p))
            {
                lp.Remove(p);
                ProduitDAO.DELETE(p.Reference);
                return true;
            }

            return false;
        }
        public static List<Produit> FindAll()
        {
            return ProduitDAO.FindALL();
        }
        public static Produit FindRef(string r)
        {
            return ProduitDAO.FindByRef(r);
        }
        public static List<Produit> Findqte(String qte)
        {
            List<Produit> c = ProduitDAO.FindByqte(qte);
            return c;
        }
        public static void updateQteS(Produit p)
        {
            ProduitDAO.UpdateQteStock(p);
        }
    }
}
