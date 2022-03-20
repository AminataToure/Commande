using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metier;
using System.Windows.Forms;
using Metier;
using System.Data.SqlClient;

namespace DAO
{
   public class ClientDAO
    {
        public static List<Client> FindAll()
        {
            List<Client> clients = new List<Client>();
            try
            {
                SqlConnection cnx = Connexion.GetInstance();
                SqlCommand cmd = new SqlCommand("select*from Client", cnx);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Client c = new Client(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5));
                    clients.Add(c);


                }
                cnx.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return clients;
        }
        public static bool AddClient(Client c)
        {
            try
            {
                SqlConnection cnx = Connexion.GetInstance();
                SqlCommand cl = new SqlCommand("insert into Client(code,nom,prenom,telephone,adresse,mail) values(@code,@nom,@prenom,@numTel,@adresse,@mail)", cnx);
                cl.Parameters.Add("@code", c.Code);
                cl.Parameters.Add("@nom", c.Nom);
                cl.Parameters.Add("@prenom", c.Prenom);
                cl.Parameters.Add("@numTel", c.NumTel);
                cl.Parameters.Add("@adresse", c.Adresse);
                cl.Parameters.Add("@mail", c.Mail);
                int n = cl.ExecuteNonQuery();
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
        public static bool UpdateClient(Client c)
        {
            try
            {
                SqlConnection cnx = Connexion.GetInstance();
                SqlCommand cl = new SqlCommand("update Client set (telephone=@telephone,adresse=@adresse,mail=@mail) where code=@code", cnx);//requete*
                cl.Parameters.Add("@code", c.Code);                
                cl.Parameters.Add("@telephone", c.NumTel);
                cl.Parameters.Add("@adresse", c.Adresse);
                cl.Parameters.Add("@mail", c.Mail);
                int n = cl.ExecuteNonQuery();
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
        public static bool DeleteClient(string code)
        {
            try
            {
                SqlConnection cnx = Connexion.GetInstance();
                SqlCommand cl = new SqlCommand("Delete from Client where code=@code", cnx);
                cl.Parameters.Add("@code", code);
                int n = cl.ExecuteNonQuery();
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
        public static Client FindByCode(string code)
        {
            Client c=null;
            try
            {
                SqlConnection cnx = Connexion.GetInstance();
                SqlCommand cl = new SqlCommand("select * from Client where code=@code", cnx);
                cl.Parameters.Add("@code", code);
                SqlDataReader dr = cl.ExecuteReader();
                while (dr.Read())
                {
                    c = new Client(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4),dr.GetString(5));
                }
                cnx.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return c;
        }
    }
    }

