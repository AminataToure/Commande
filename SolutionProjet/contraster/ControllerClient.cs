using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metier;
using DAO;

namespace contraster
{
    public class ControllerClient
    {
        private static List<Client> lp = ClientDAO.FindAll();
        public static String gernererNumClt()
        {
            int numClt = ClientDAO.FindAll().Count + 1;
            String numC = "";
            if (numClt < 10)
            {
                numC = "C0000" + numClt;
            }
            else if (numClt >= 10 && numClt < 100)
            {
                numC = "Clt000" + numClt;
            }
            else if (numClt >= 100 && numClt < 1000)
            {
                numC = "C00" + numClt;
            }
            else if (numClt >= 1000 && numClt < 10000)
            {
                numC = "C0" + numClt;
            }
            else
            {
                numC = "C" + numClt;
            }
            return numC;
        }

        public static List<Client> GetClients()
        {
            return lp;
        }
        public static List<Client> FindAll()
        {
            return ClientDAO.FindAll();
        }

        public static bool Add(Client p)
        {
            
                if (lp.Contains(p))
                    return false;
                else
                {
                    lp.Add(p);
                    ClientDAO.AddClient(p);
                return true;
                }
          
        }

        public static bool Update(Client p)
        {
            Client prd = ClientDAO.FindByCode(p.Code);
            
            if (lp.Contains(prd))
            {
                lp.Remove(prd);
                lp.Add(p);
                ClientDAO.UpdateClient(p);
                return true;
            }
            else
            {
                return false;
            }
           
             
        }

        public static List<Client> Findref(string resf)
        {
            List<Client> c = new List<Client>();
            c.Add(ClientDAO.FindByCode(resf));

            return c;
        }
        public static bool Remove(Client p)
        {
            if (lp.Contains(p))
            {
                lp.Remove(p);
                ClientDAO.DeleteClient(p.Code);
                return true;
            }

            return false;
        }

       
    }
}
