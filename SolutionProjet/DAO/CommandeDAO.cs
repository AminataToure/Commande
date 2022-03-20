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
    public class CommandeDAO
    {
        public static List<Commande> FindAll()
        {

            List<Commande> lesCommande = new List<Commande>();
            List<Client> lesTiers = ClientDAO.FindAll();
            try
            {
                Client clt = null;
                //Instancier la classe connexion 
                SqlConnection cnx = Connexion.GetInstance();
                SqlCommand cmd = new SqlCommand("select * from Commande ", cnx);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    /*****************************************************************/
                    foreach (Client c in lesTiers)
                    {
                        if (c.Code.Equals(dataReader.GetString(1)))
                        {
                            clt = c;
                        }
                    }
                    Commande commande = new Commande(dataReader.GetString(0), clt, dataReader.GetDateTime(2), dataReader.GetDouble(3));

                    lesCommande.Add(commande);
                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("FindAll DAO Commande : Pb de connexion\n " + ex.Message);
            }
            return lesCommande;
        }
        /*******************************************************************************************************************/
        public static Commande FindByNum(String num)
        {
            Commande commandes = null;
            List<Client> lesclient = ClientDAO.FindAll();
            Client clt = null;
            try
            {
                //Instancier la classe connexion               
                SqlConnection cnx = Connexion.GetInstance();
                SqlCommand cmd = new SqlCommand("select * from Commande where numero=@num", cnx);
                cmd.Parameters.Add("@num", num);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    /*****************************************************************/
                    foreach (Client c in lesclient)
                    {
                        if (c.Code.Equals(dataReader.GetString(1)))
                        {
                            clt = c;
                        }
                    }
                    Commande commande = new Commande(dataReader.GetString(0),clt,dataReader.GetDateTime(2), dataReader.GetDouble(3));

                    commandes = commande;
                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Find by numéro: Pb de connexion\n " + ex.Message);
            }
            return commandes;
        }
        /******************************************************************************************************************/
        public static bool AddCommande(Commande commande)
        {
            try
            {
                //Instancier la classe connexion 
                SqlConnection cnx = Connexion.GetInstance();
                SqlCommand cmd = new SqlCommand("INSERT INTO Commande(numero,codeClt,dateCommande,montantT) values(@n,@clt,@d,@mt)", cnx);
                cmd.Parameters.Add("@n", commande.Numero);
                cmd.Parameters.Add("@clt", commande.CodeClient.Code);
                cmd.Parameters.Add("@d", commande.Date);
                cmd.Parameters.Add("@mt", commande.MontantTotal);
                int ligne = cmd.ExecuteNonQuery();
                if (ligne != 0)
                {
                    return true;
                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add: Pb de connexion\n " + ex.Message);
            }
            return false;

        }
        /******************************************************************************************************************/
        public static bool delete(String num)
        {
            try
            {
                SqlConnection cnx = Connexion.GetInstance();
                SqlCommand cmd = new SqlCommand("Delete from Commande where numero=@num", cnx);
                cmd.Parameters.Add("@num", num);
                int nbrLigne = cmd.ExecuteNonQuery();
                if (nbrLigne > 0)
                {
                    return true;
                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Commande : Pb de Suppréssion\n" + ex.Message, "Attention");
            }
            return false;
        }
        /***************************************************************************************************************/
        public static void updateMt(string num,double mt)
        {
            try
            {
                SqlConnection cnx = Connexion.GetInstance();
                SqlCommand cmd = new SqlCommand("update Commande set montantT=@m where numero=@nc", cnx);
                cmd.Parameters.Add("@nc", num);
                cmd.Parameters.Add("@m", mt);
                int ligne = cmd.ExecuteNonQuery();
                if (ligne != 0)
                {
                    MessageBox.Show("Mise en jour éffectuer avec succè");
                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Commande update: Pb de connexion\n " + ex.Message);
            }
        }
    }
}
