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


namespace Projet
{
    public partial class GestionProduit : Form
    {
        public GestionProduit()
        {
            InitializeComponent();
        }

        private void GestionProduit_Load(object sender, EventArgs e)
        {
            dgvProduit.DataSource = ControllerProduit.GetProduits().ToArray();
            txtDes.Clear();
            txtPrix.Clear();
            txtQte.Clear();
            txtRef.Clear();
            
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
           if(txtDes.Text==""||txtPrix.Text == "" ||txtQte.Text == "" ||txtRef.Text == "")
            {
                MessageBox.Show("(Pas de vide) Veuillez remplir les zones de texte");
            }
            else
            {
                String des = txtDes.Text;
                String refs = txtRef.Text;
                Double prix = Convert.ToDouble(txtPrix.Text);
                int qte = Convert.ToInt32(txtQte.Text);
                Produit prd = new Produit(refs, des, prix, qte);

                if (ControllerProduit.Add(prd)==true)
                {
                    MessageBox.Show("Le produit a été bien ajouter");
                    GestionProduit_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Problem d'ajout: Produit existent dans la base");
                }
            }
            
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (txtDes.Text == "" || txtPrix.Text == "" || txtQte.Text == "" || txtRef.Text == "")
            {
                MessageBox.Show("Choisir un produit dans la liste");
            }
            else
            {
                String des = txtDes.Text;
                String refs = txtRef.Text;
                Double prix = Convert.ToDouble(txtPrix.Text);
                int qte = Convert.ToInt32(txtQte.Text);
                Produit prd = new Produit(refs, des, prix, qte);
                if (ControllerProduit.Update(prd)==true)
                {
                    MessageBox.Show("Produit a été bien modifier!");
                    GestionProduit_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Problem de modification: Produit inexistant dans la base!");
                }
            }
            
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (txtDes.Text == "" || txtPrix.Text == "" || txtQte.Text == "" || txtRef.Text == "")
            {
                MessageBox.Show("Choisir un produit dans la liste pour le supprimer!");
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Voulez-vous supprimer ce produit ?", "Supprestion", buttons);
                if (result == DialogResult.Yes)
                {
                    String des = txtDes.Text;
                    String refs = txtRef.Text;
                    Double prix = Convert.ToDouble(txtPrix.Text);
                    int qte = Convert.ToInt32(txtQte.Text);
                    Produit prd = new Produit(refs, des, prix, qte);
                    if (ControllerProduit.Remove(prd) == true)
                    {
                        MessageBox.Show("Produit a été bien Supprimer!");
                        GestionProduit_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Problem de Supprestion: Produit inexistant dans la base!");
                    }
                }
                
            }

        }

        private void btnChercher_Click(object sender, EventArgs e)
        {
            if (rbReferance.Checked == false || rbQte.Checked == false)
            {
                if (rbReferance.Checked)
                {
                    if (txtRef.Text == "")
                    {
                        MessageBox.Show("Le champ du Referance est vide!");
                    }
                    else
                    {
                        Produit xcf = null;
                        String refs = txtRef.Text;
                        List<Produit> cc = ControllerProduit.GetProduits();
                        foreach (Produit xx in cc)
                        {
                            if (xx.Reference.Equals(refs))
                                xcf = xx;

                        }
                        if (cc.Contains(xcf))
                        {
                            dgvProduit.DataSource = ControllerProduit.Findref(refs);
                            rbReferance.Checked = false;
                        }

                        else
                        {
                            MessageBox.Show("Le Produit n'exsiste pas dans la base!");
                            GestionProduit_Load(sender, e);
                            rbReferance.Checked = false;
                        }


                    }
                }


                if (rbQte.Checked)
                {
                    if (txtQte.Text == "")
                    {
                        MessageBox.Show("Le champ du qte est vide!");
                    }
                    else
                    {
                        String qte = txtQte.Text;
                        List<Produit> prds = ControllerProduit.Findqte(qte);
                        if (prds.Any<Produit>()==false)
                        {
                            MessageBox.Show("La quantité demandé est insuffisant!");
                            GestionProduit_Load(sender, e);
                            rbQte.Checked = false;
                        }
                        else
                        {
                            dgvProduit.DataSource = prds.ToArray();
                            rbQte.Checked = false;

                        }


                    }
                }
            }else
            {
                MessageBox.Show("Veuillez sélectionner une méthode de recherche!");
            }

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProduit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = e.RowIndex;
            if (pos != -1)
            {
                txtRef.Text = dgvProduit.Rows[pos].Cells[0].Value.ToString();
                txtDes.Text = dgvProduit.Rows[pos].Cells[1].Value.ToString();
                txtPrix.Text = dgvProduit.Rows[pos].Cells[2].Value.ToString();
                txtQte.Text = dgvProduit.Rows[pos].Cells[3].Value.ToString();

            }
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            GestionProduit_Load(sender, e);
            MessageBox.Show("la base a été bien actualiser!");
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            txtDes.Clear();
            txtPrix.Clear();
            txtQte.Clear();
            txtRef.Clear();
        }
    }
}
