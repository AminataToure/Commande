using Metier;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class LigneCommandeDAO
    {
        public static List<LigneCommande> FindAll()
        {
            List<LigneCommande> lesCommande = new List<LigneCommande>();
            try
            {
                List<Produit> lesproduits = ProduitDAO.FindALL();
                List<Commande> commandes = CommandeDAO.FindAll();
                //Instancier la classe connexion 
                SqlConnection cnx = Connexion.GetInstance();
                SqlCommand cmd = new SqlCommand("select * from LigneCommande ", cnx);
                Produit V_Produit = null;
                Commande V_Commande = null;
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    /********************************************************************/
                    foreach (Produit p in lesproduits)
                    {
                        if (p.Reference.Equals(dataReader.GetString(1)))
                        {
                            V_Produit = p;
                            break;
                        }
                    }
                    LigneCommande Lcmd = new LigneCommande(new Commande(dataReader.GetString(0)), V_Produit, dataReader.GetInt32(2), dataReader.GetDouble(3), dataReader.GetDouble(4));
                    lesCommande.Add(Lcmd);

                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("FindAll DAO LigneCommande: Pb de connexion\n " + ex.Message);
            }
            return lesCommande;
        }
        /************************************************************************************************************************/
        public static bool AddCommande(LigneCommande lignecommande)
        {
            try
            {                
                SqlConnection cnx = Connexion.GetInstance();
                SqlCommand cmd = new SqlCommand("INSERT INTO LigneCommande values(@nc,@cp,@qc,@pV,@tL)", cnx);
                cmd.Parameters.Add("@nc", lignecommande.NumCmd.Numero);
                cmd.Parameters.Add("@cp", lignecommande.CodProd.Reference);
                cmd.Parameters.Add("@qc", lignecommande.QteCmd);
                cmd.Parameters.Add("@pV", lignecommande.CodProd.Prix);
                cmd.Parameters.Add("@tL", lignecommande.TotalLigne);
                int ligne = cmd.ExecuteNonQuery();
                if (ligne != 0)
                {
                    return true;
                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ligne commande Add: Pb de connexion\n " + ex.Message);
            }
            return false;

        }
        /*********Cette méthode modifiéra un seul ligne produit choisie par utilisateur*/
        public static bool UpdateLigneCode(LigneCommande lignecommande)
        {
            try
            {
               
                SqlConnection cnx = Connexion.GetInstance();
                SqlCommand cmd = new SqlCommand("update LigneCommande set qteCmd=@qc,totalLigne=@tl where codProd=@cp and numcmd=@n", cnx);
                cmd.Parameters.Add("@cp", lignecommande.CodProd.Reference);
                cmd.Parameters.Add("@n", lignecommande.NumCmd.Numero);
                cmd.Parameters.Add("@qc", lignecommande.QteCmd);
                cmd.Parameters.Add("@tl", lignecommande.TotalLigne);
                int ligne = cmd.ExecuteNonQuery();
                if (ligne != 0)
                {
                    return true;
                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("update: Pb de connexion\n " + ex.Message);
            }
            return false;
        }
        /*************Modifier une Ligne de commande*******************************************************************/
        public static bool UpdateCommande(LigneCommande lignecommande)
        {
            try
            {
                SqlConnection cnx = Connexion.GetInstance();
                SqlCommand cmd = new SqlCommand("update LigneCommande set qteCmd=@qc,totalLigne=@tl where numcmd=@nc and codProd=@cp", cnx);
                cmd.Parameters.Add("@nc", lignecommande.NumCmd.Numero);
                cmd.Parameters.Add("@cp", lignecommande.CodProd.Reference);
                cmd.Parameters.Add("@qc", lignecommande.QteCmd);
                cmd.Parameters.Add("@tl", lignecommande.TotalLigne);
                int ligne = cmd.ExecuteNonQuery();
                if (ligne != 0)
                {
                    return true;
                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("update: Pb de connexion\n " + ex.Message);
            }
            return false;
        }
        /******************Supprission d'une seule ligne dans Ligne Commande************************************/
        public static void delete(string n, string c)
        {
            try
            {
                SqlConnection cnx = Connexion.GetInstance();
                SqlCommand cmd = new SqlCommand("Delete from LigneCommande where numcmd=@n and CodProd=@c", cnx);
                cmd.Parameters.Add("@n", n);
                cmd.Parameters.Add("@c", c);
                int nbrLigne = cmd.ExecuteNonQuery();
                if (nbrLigne > 0)
                {
                    MessageBox.Show("Suppréssion éffectuer avec succés");
                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ligne Commande : Pb de Suppréssion\n" + ex.Message, "Attention");
            }
        }
        /************************************************************************************************************************/
        public static LigneCommande FindByNumCod(string cod,string num)
        {
            LigneCommande ligneCommande = null;
            List<Produit> produits = ProduitDAO.FindALL();
            Produit prod = null;

            try
            {
                SqlConnection cnx = Connexion.GetInstance();
                SqlCommand cmd = new SqlCommand("select * from LigneCommande where codProd=@cp and numcmd=@num", cnx);
                //cmd.Parameters.Add("@nC", num);
                cmd.Parameters.Add("@cp", cod);
                cmd.Parameters.Add("@num", num);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    foreach (Produit p in produits)
                    {
                        if (p.Reference.Equals(dataReader.GetString(1)))
                        {
                            prod = p;
                        }
                    }

                    ligneCommande = new LigneCommande(new Commande(dataReader.GetString(0)), prod, dataReader.GetInt32(2), dataReader.GetDouble(3), dataReader.GetDouble(4));
                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Find by code num produit: Pb de connexion\n " + ex.Message);
            }
            return ligneCommande;
        }
        /************************************************************************************************************************/
        public static List<LigneCommande> FindByNum(String num)
        {
            List<LigneCommande> ligneCommande = new List<LigneCommande>();
            List<Produit> produits = ProduitDAO.FindALL();
            Produit prod = null;
            try
            {
                //Instancier la classe connexion               
                SqlConnection cnx = Connexion.GetInstance();
                SqlCommand cmd = new SqlCommand("select * from LigneCommande where numcmd=@n", cnx);
                cmd.Parameters.Add("@n", num);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    foreach (Produit p in produits)
                    {
                        if (p.Reference.Equals(dataReader.GetString(1)))
                        {
                            prod = p;
                        }
                    }
                    LigneCommande l = new LigneCommande(new Commande(dataReader.GetString(0)), prod, dataReader.GetInt32(2), dataReader.GetDouble(3), dataReader.GetDouble(4));
                    ligneCommande.Add(l);
                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Find by numéro: Pb de connexion\n " + ex.Message);
            }
            return ligneCommande;
        }
        /*****************************************************************************************************************/
        public static List<LigneCommande> FindByAllLigneNumCod(string num)
        {
            List<LigneCommande> lesLigneCommande = new List<LigneCommande>();
            List<Produit> produits = ProduitDAO.FindALL();
            Produit prod = null;

            try
            {
                SqlConnection cnx = Connexion.GetInstance();
                SqlCommand cmd = new SqlCommand("select * from LigneCommande where numcmd=@num", cnx);
                //cmd.Parameters.Add("@nC", num);
                cmd.Parameters.Add("@num", num);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    foreach (Produit p in produits)
                    {
                        if (p.Reference.Equals(dataReader.GetString(1)))
                        {
                            prod = p;
                        }
                    }

                    LigneCommande ligneCommande = new LigneCommande(new Commande(dataReader.GetString(0)), prod, dataReader.GetInt32(2), dataReader.GetDouble(3), dataReader.GetDouble(4));
                    lesLigneCommande.Add(ligneCommande);
                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Find by code num produit: Pb de connexion\n " + ex.Message);
            }
            return lesLigneCommande;
        }

        /*********************************************************************************************************************/
        public static LigneCommande FindByCod(String code)
        {
            LigneCommande ligneCommande = null;
            List<Produit> produits = ProduitDAO.FindALL();
            Produit prod = null;
            try
            {
                //Instancier la classe connexion               
                SqlConnection cnx = Connexion.GetInstance();
                SqlCommand cmd = new SqlCommand("select * from LigneCommande where codProd=@n", cnx);
                cmd.Parameters.Add("@n", code);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    foreach (Produit p in produits)
                    {
                        if (p.Reference.Equals(dataReader.GetString(1)))
                        {
                            prod = p;
                        }
                    }
                    ligneCommande = new LigneCommande(new Commande(dataReader.GetString(0)), prod, dataReader.GetInt32(2), dataReader.GetDouble(3), dataReader.GetDouble(4));
                   
                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Find by numéro: Pb de connexion\n " + ex.Message);
            }
            return ligneCommande;
        }
        /****Cette méthode permet de supprimer toute les ligne lier a une commande******/
        public static void deleteAllLigne(string n)
        {
            try
            {
                SqlConnection cnx = Connexion.GetInstance();
                SqlCommand cmd = new SqlCommand("Delete from LigneCommande where numcmd=@n ", cnx);
                cmd.Parameters.Add("@n", n);
                int nbrLigne = cmd.ExecuteNonQuery();
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delete Ligne Commande : Pb de Suppréssion\n" + ex.Message, "Attention");
            }
        }
    }
}
