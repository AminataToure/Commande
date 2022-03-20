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
    public class ControllerCommande
    {
        public static String gernererNumCmd()
        {
            int numCmd = 1;
            if(ControllerCommande.FindAll().Count != 0)
            {
                Commande c = CommandeDAO.FindAll().Last<Commande>();
                numCmd = Convert.ToInt32(c.Numero.Substring(c.Numero.Length - 1)) + 1;
            }
            String numC = "";
            if (numCmd < 10)
            {
                numC = "Cmd0000" + numCmd;
            }
            else if (numCmd >= 10 && numCmd < 100)
            {
                numC = "Cmd000" + numCmd;
            }
            else if (numCmd >= 100 && numCmd < 1000)
            {
                numC = "Cmd00" + numCmd;
            }
            else if (numCmd >= 1000 && numCmd < 10000)
            {
                numC = "Cmd0" + numCmd;
            }
            else
            {
                numC = "Cmd" + numCmd;
            }
            return numC;
        }
        static List<Commande> lesCommande = CommandeDAO.FindAll();
        public static void save(string n,Client c ,DateTime dt, List<LigneCommande> lCmd, String mt)
        {
           
            if(mt == "" || c==null)
            {
                MessageBox.Show("Les champs ne doivent pas être vide");
            }
            else
            {
                Commande cmd = new Commande(n, c, dt, lCmd, Convert.ToDouble(mt));
                if (lesCommande.Contains(cmd))
                {
                    MessageBox.Show("La commande existe dèja");
                    return;
                }
                else
                {
                    if (CommandeDAO.AddCommande(cmd) == true)
                    {
                        MessageBox.Show("Votre commande à été enregistre");
                    }
                }

            }
        }
        /********************************************************************************************************/
        public static void delete(string n)
        {
            DialogResult dr = MessageBox.Show("Si vous voullez supprimer la commande toute ces lignes seront supprimer aussi", "Attention", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
               
                bool result = CommandeDAO.delete(n);
                LigneCommandeDAO.deleteAllLigne(n);
                if (result == true)
                {
                    MessageBox.Show("Suppression effectuer avec succès");
                }

            }

        }
        /**************************************************************************************************************************/
        public static List<Commande> FindAll()
        {
            return CommandeDAO.FindAll();
        }
        /*****************************************************************************************************************/
        public static List<Commande> FindBynumero(string n)
        {
            List<Commande> lesCommande = new List<Commande>();
            lesCommande.Add(CommandeDAO.FindByNum(n));
            return lesCommande;
        }
        /*****************************************************************************************************************************/
        public static List<LigneCommande> FindbyNumCmd(string n)
        {
            return LigneCommandeDAO.FindByNum(n);
        }
        public static Commande FindByNum(string n)
        {
            return CommandeDAO.FindByNum(n);
        }
        public static void updateMt(String num)
        {
            List<LigneCommande> lesLigne = LigneCommandeDAO.FindAll();
            double mt = 0;
            foreach (LigneCommande ligne in lesLigne)
            {
                if (ligne.NumCmd.Numero.Equals(num))
                {
                    mt = mt + ligne.TotalLigne;
                }

            }
            CommandeDAO.updateMt(num, mt);

        }
    }
}
