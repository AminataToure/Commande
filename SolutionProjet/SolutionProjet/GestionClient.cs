using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;
using contraster;

namespace SolutionProjet
{
    public partial class GestionClient : Form
    {
        public GestionClient()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void GestionClient_Load(object sender, EventArgs e)
        {
            txtCode.Text = ControllerClient.gernererNumClt();
            if (dgvClient.SelectedCells.Count > 0)
                btnActualiser.Enabled = false;
            dgvClient.DataSource = ControllerClient.GetClients().ToArray();
            txtCode.Enabled = false;
            txtAdresse.Clear();
            txtMail.Clear();
            txtNom.Clear();
            txtPrenom.Clear();
            txtTelephone.Clear();
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
          if(txtTelephone.Text==""||txtPrenom.Text == "" ||txtNom.Text == "" ||txtMail.Text == "" ||txtCode.Text == "" ||txtAdresse.Text == "")
            {
                MessageBox.Show("(Pas de vide) Veuillez remplir la zone de texte");
            }
            else
            {
                String addresse = txtAdresse.Text;
                String Code = txtCode.Text;
                String mail = txtMail.Text;
                String nom = txtNom.Text;
                String prenom = txtPrenom.Text;
                String tele = txtTelephone.Text;
                Client c1 = new Client(Code, nom, prenom, tele, addresse, mail);

                if (ControllerClient.Add(c1) == true)
                {
                    MessageBox.Show("Le client a été bien ajouter");
                    GestionClient_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Problem d'ajout: Le client existe déjà dans la base");
                }
            }
        }
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (txtTelephone.Text == "" || txtPrenom.Text == "" || txtNom.Text == "" || txtMail.Text == "" || txtCode.Text == "" || txtAdresse.Text == "")
            {
                MessageBox.Show("(Pas de vide) Veuillez remplir la zone de texte");
            }
            else
            {
                String addresse = txtAdresse.Text;
                String Code = txtCode.Text;
                String mail = txtMail.Text;
                String nom = txtNom.Text;
                String prenom = txtPrenom.Text;
                String tele = txtTelephone.Text;
                Client c1 = new Client(Code, nom, prenom, tele, addresse, mail);
                if (ControllerClient.Update(c1) == true)
                {
                    MessageBox.Show("Mise en jour effectuer avec succè!");
                    GestionClient_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Problem de modification: Client inexistant dans la base!");
                }
            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

            if (txtTelephone.Text == "" || txtPrenom.Text == "" || txtNom.Text == "" || txtMail.Text == "" || txtCode.Text == "" || txtAdresse.Text == "")
            {
                MessageBox.Show("(Pas de vide) Veuillez remplir la zone de texte");
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Voulez-vous supprimer le client ?", "Supprestion", buttons);
                if (result == DialogResult.Yes)
                {
                    String addresse = txtAdresse.Text;
                    String Code = txtCode.Text;
                    String mail = txtMail.Text;
                    String nom = txtNom.Text;
                    String prenom = txtPrenom.Text;
                    String tele = txtTelephone.Text;
                    Client c1 = new Client(Code, nom, prenom, tele, addresse, mail);
                    if (ControllerClient.Remove(c1) == true)
                    {
                        MessageBox.Show("Client a été bien Supprimer!");
                        GestionClient_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Problem de Supprestion: Client inexite déjà dans la base!");
                    }
                }
            }
        }

        private void btnChercherCode_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                MessageBox.Show("Le champ du Code est vide!");
            }
            else
            {
                Client xcf = null;
                String codes = txtCode.Text;
                List<Client> cc = ControllerClient.GetClients();
                foreach (Client xx in cc)
                {
                    if (xx.Code.Equals(codes))
                        xcf = xx;

                }
                if (cc.Contains(xcf))
                {
                    dgvClient.DataSource = ControllerClient.Findref(codes);
                  
                }
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulez vous quitter ?");
            this.Close();
        }

        private void dgvClient_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int pos = e.RowIndex;
            if (pos != -1)
            {
                txtCode.Text = dgvClient.Rows[pos].Cells[0].Value.ToString();
                txtNom.Text = dgvClient.Rows[pos].Cells[1].Value.ToString();
                txtPrenom.Text = dgvClient.Rows[pos].Cells[2].Value.ToString();
                txtTelephone.Text = dgvClient.Rows[pos].Cells[3].Value.ToString();
                txtAdresse.Text = dgvClient.Rows[pos].Cells[4].Value.ToString();
                txtMail.Text = dgvClient.Rows[pos].Cells[5].Value.ToString();
                btnActualiser.Enabled = true;
            }
        }

        private void btnVide_Click(object sender, EventArgs e)
        {
            txtAdresse.Clear();
            txtCode.Clear();
            txtMail.Clear();
            txtNom.Clear();
            txtPrenom.Clear();
            txtTelephone.Clear();
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            GestionClient_Load(sender, e);
        }
    }
}
