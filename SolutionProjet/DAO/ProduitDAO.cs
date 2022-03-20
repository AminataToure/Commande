using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;

namespace DAO
{
    public class ProduitDAO
    {
        public static List<Produit> FindALL()
        {
            List<Produit> produits = new List<Produit>();
            try
            {
                SqlConnection cnx = Connexion.GetInstance();
                SqlCommand cmd = new SqlCommand("select * from Produit", cnx);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Produit p = new Produit(dr.GetString(0), dr.GetString(1), dr.GetDouble(2), dr.GetInt32(3));
                    produits.Add(p);
                }
                cnx.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("PB-BD-FDA: "+ex.Message);
            }
            return produits;
        }
        public static bool ADD(Produit p)
        {
            try
            {
                SqlConnection cnx = Connexion.GetInstance();
                SqlCommand cmd = new SqlCommand("insert into Produit values(@reference,@designation,@prix,@quantite)", cnx);

                cmd.Parameters.Add("@reference", p.Reference);
                cmd.Parameters.Add("@designation", p.Designation);
                cmd.Parameters.Add("@prix", p.Prix);
                cmd.Parameters.Add("@quantite", p.Quantite);


                int n = cmd.ExecuteNonQuery();
                cnx.Close();
                if (n != 0)
                    return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("PB-BD-ADD: "+ex.Message);
            }
            return false;
        }
        public static bool DELETE(String reference)
        {
            try
            {
                SqlConnection cnx = Connexion.GetInstance();
                SqlCommand cmd = new SqlCommand("delete from Produit where reference=@reference", cnx);

                cmd.Parameters.Add("@reference", reference);


                int n = cmd.ExecuteNonQuery();
                cnx.Close();
                if (n != 0)
                    return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public static void UpdateQteStock(Produit p)
        {
            try
            {
                SqlConnection cnx = Connexion.GetInstance();
                SqlCommand cmd = new SqlCommand("update Produit set quantite=@quantite where reference=@reference", cnx);
                cmd.Parameters.Add("@reference", p.Reference);
                cmd.Parameters.Add("@quantite", p.Quantite);

                int n = cmd.ExecuteNonQuery();
                cnx.Close();
                if (n != 0)
                    MessageBox.Show("Mise en jour effectuer avec succè");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Pb update qte en stock: " + ex.Message);

            }
          
        }
        public static bool UPDATE(Produit p)
        {
            try
            {
                SqlConnection cnx = Connexion.GetInstance();

                SqlCommand cmd = new SqlCommand("update Produit set designation=@designiation, prix=@prix," +
                    "quantite=@quantite where reference=@reference", cnx);
                cmd.Parameters.Add("@reference", p.Reference);
                cmd.Parameters.Add("@designiation", p.Designation);
                cmd.Parameters.Add("@prix", p.Prix);
                cmd.Parameters.Add("@quantite", p.Quantite);

                int n = cmd.ExecuteNonQuery();
                cnx.Close();
                if (n != 0)
                    return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("PB-BD UPDATE: "+ex.Message);

            }
            return false;
        }
        public static Produit FindByRef(String reference)
        {
            Produit prd = null;
            try
            {
                SqlConnection cnx = Connexion.GetInstance();
                SqlCommand cmd = new SqlCommand("select * from Produit where reference=@reference", cnx);
                cmd.Parameters.Add("@reference", reference);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    prd = new Produit(dr.GetString(0), dr.GetString(1), dr.GetDouble(2), dr.GetInt32(3));
 
                }
                cnx.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("PB FINDBYREF: "+ex.Message);
            }
            return prd;
        }
        public static List<Produit> FindByqte(String quantite)
        {
            List<Produit> lesprd = new List<Produit>();
            try
            {
                SqlConnection cnx = Connexion.GetInstance();
                SqlCommand cmd = new SqlCommand("select * from Produit where quantite>=@quantite", cnx);
                cmd.Parameters.Add("@quantite", quantite);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Produit prd = new Produit(dr.GetString(0), dr.GetString(1), dr.GetDouble(2), dr.GetInt32(3));
                    lesprd.Add(prd);
                }
                cnx.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("PB FINDBYQTE: " + ex.Message);
            }
            return lesprd;
        }
    }
}

