using contraster;
using Metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolutionProjet
{
    public partial class GestionCommande : Form
    {
        public GestionCommande()
        {
            InitializeComponent();
        }

        public void viderChampsCmd()
        {
            txtMontantTotal.Text = "";
            txtqte.Text = "";
            txtQteStock.Text = "";
            cbProduit.Items.Clear();
            dgvLigneCmd.Rows.Clear();
            cbTiers.Items.Clear();
            txtPrix.Text = "";
            txtNum.Text = ControllerCommande.gernererNumCmd();

        }
        private void btnAddLigne_Click(object sender, EventArgs e)
        {
            Commande c = new Commande(txtNum.Text);
            bool resul = ControllerLigneCommande.save(c, (Produit)cbProduit.SelectedItem, txtqte.Text);
            List<LigneCommande> lCmd = ControllerLigneCommande.findAllNum(txtNum.Text);
            double m = 0;
            foreach (LigneCommande l in lCmd)
            {
                m = m + (l.QteCmd * l.CodProd.Prix);
            }
            txtMontantTotal.Text = m.ToString();
            if (resul == true)
            {
                viderChampsCmd();
                GestionCommande_Load(sender, e);
            }
        }

        private void btnSuppLigne_Click(object sender, EventArgs e)
        {
            Produit p = (Produit)cbProduit.SelectedItem;
            ControllerLigneCommande.delete(txtNum.Text, p.Reference);
            viderChampsCmd();
            GestionCommande_Load(sender, e);
        }

        private void GestionCommande_Load(object sender, EventArgs e)
        {
            dgvLigneCmd.Rows.Clear();
            txtNum.Text = ControllerCommande.gernererNumCmd();
            cbProduit.Items.AddRange(ControllerProduit.FindAll().ToArray());
            dgvCommande.DataSource = ControllerCommande.FindAll().ToArray();
            cbTiers.Items.Clear();
            cbTiers.Items.AddRange(ControllerClient.FindAll().ToArray());
            //Actualiser l'interface ligne commande
            List<LigneCommande> lignes = ControllerLigneCommande.findAllNum(txtNum.Text);
            if (lignes.Count != 0)
            {
                foreach (LigneCommande l in lignes)
                {
                    dgvLigneCmd.Rows.Add(l.NumCmd.Numero, l.CodProd, l.QteCmd, l.CodProd.Prix, l.QteCmd * l.CodProd.Prix);
                }
            }
            //Calcule Montant 
            double m = 0;
            foreach (LigneCommande l in lignes)
            {
                m = m + (l.QteCmd * l.CodProd.Prix);
            }
            txtMontantTotal.Text = m.ToString();

        }

        private void cbProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProduit.SelectedIndex != -1)
            {
                Produit p = (Produit)cbProduit.SelectedItem;
                txtQteStock.Text = p.Quantite.ToString();
                txtPrix.Text = p.Prix.ToString();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            ControllerCommande.delete(txtNum.Text);
            viderChampsCmd();
            GestionCommande_Load(sender, e);
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (ControllerCommande.FindByNum(txtNum.Text) == null)
            {
                List<LigneCommande> lcmd = ControllerLigneCommande.findAllNum(txtNum.Text);
                Client cl = (Client)cbTiers.SelectedItem;
                ControllerCommande.save(txtNum.Text, cl, DateTime.Now, lcmd, txtMontantTotal.Text);
                dgvCommande.DataSource = ControllerCommande.FindAll().ToArray();
                viderChampsCmd();
                GestionCommande_Load(sender, e);
            }
            else
            {
                ControllerCommande.updateMt(txtNum.Text);
                viderChampsCmd();
                GestionCommande_Load(sender, e);

            }

        }

        private void dgvLigneCmd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            txtNum.Text = dgvLigneCmd.Rows[indice].Cells[0].Value.ToString();
            cbProduit.SelectedItem = (Produit)dgvLigneCmd.Rows[indice].Cells[1].Value;
            Produit pro = (Produit)cbProduit.SelectedItem;
            txtqte.Text = dgvLigneCmd.Rows[indice].Cells[2].Value.ToString();
            txtPrix.Text = dgvLigneCmd.Rows[indice].Cells[3].Value.ToString();
          
            txtQteStock.Text = pro.Quantite.ToString();
        }

        private void dgvCommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvLigneCmd.Rows.Clear();
            int indice = e.RowIndex;
            if (indice != -1)
            {
               // cbTiers.Items.Clear();             
                txtNum.Text = dgvCommande.Rows[indice].Cells[1].Value.ToString();
                cbTiers.SelectedItem =(Client)dgvCommande.Rows[indice].Cells[0].Value;
                List<Commande> c = ControllerCommande.FindBynumero(txtNum.Text);   
                txtMontantTotal.Text = dgvCommande.Rows[indice].Cells[3].Value.ToString();
                List<LigneCommande> lCmd = ControllerCommande.FindbyNumCmd(txtNum.Text);
                foreach (LigneCommande l in lCmd)
                {
                    dgvLigneCmd.Rows.Add(l.NumCmd.Numero, l.CodProd, l.QteCmd, l.CodProd.Prix, l.QteCmd * l.CodProd.Prix);
                }
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {            
            Produit p = (Produit)cbProduit.SelectedItem;          
            Produit aP = ControllerProduit.FindRef(p.Reference);
           // Commande cmd = ControllerCommande.FindByNum(txtNum.Text);
            ControllerLigneCommande.updateProduit(new Commande(txtNum.Text), p, txtqte.Text,aP);
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {






































        }
    }
}
