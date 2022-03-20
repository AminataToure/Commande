using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    class Connexion
    {
        static String chaineCnx = "Data Source=DESKTOP-RO8GVS5\\SQLEXPRESS;Initial Catalog=BD_projetAminataJannetRahmaMohamed ;Integrated Security =True ";
        static SqlConnection cnx = new SqlConnection(chaineCnx);
        public static SqlConnection GetInstance()
        {
            try
            {
                if (cnx.State != System.Data.ConnectionState.Open)
                    cnx.Open();
            }
            catch (Exception ex) { MessageBox.Show("Vente: Pb de connexion\n " + ex.Message); }
            return cnx;
        }
    }
}

