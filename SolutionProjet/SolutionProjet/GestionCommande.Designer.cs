
namespace SolutionProjet
{
    partial class GestionCommande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMontantTotal = new System.Windows.Forms.TextBox();
            this.dgvLigneCmd = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSuppLigne = new System.Windows.Forms.Button();
            this.btnAddLigne = new System.Windows.Forms.Button();
            this.txtQteStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.txtqte = new System.Windows.Forms.TextBox();
            this.cbProduit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTiers = new System.Windows.Forms.ComboBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCommande = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigneCmd)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnSupprimer);
            this.panel3.Controls.Add(this.btnFermer);
            this.panel3.Location = new System.Drawing.Point(564, 379);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(501, 86);
            this.panel3.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Vider";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(217, 29);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 6;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(334, 29);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 8;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(375, 43);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(110, 23);
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "Modifier Ligne";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnEnregistrer);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtMontantTotal);
            this.panel2.Controls.Add(this.dgvLigneCmd);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.cbTiers);
            this.panel2.Controls.Add(this.txtNum);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(21, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 453);
            this.panel2.TabIndex = 26;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(153, 413);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(118, 23);
            this.btnEnregistrer.TabIndex = 33;
            this.btnEnregistrer.Text = "Sauvegarder";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(150, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Montant Total";
            // 
            // txtMontantTotal
            // 
            this.txtMontantTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontantTotal.Enabled = false;
            this.txtMontantTotal.Location = new System.Drawing.Point(280, 367);
            this.txtMontantTotal.Name = "txtMontantTotal";
            this.txtMontantTotal.Size = new System.Drawing.Size(62, 20);
            this.txtMontantTotal.TabIndex = 22;
            // 
            // dgvLigneCmd
            // 
            this.dgvLigneCmd.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvLigneCmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLigneCmd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column2,
            this.Column5});
            this.dgvLigneCmd.Location = new System.Drawing.Point(3, 195);
            this.dgvLigneCmd.Name = "dgvLigneCmd";
            this.dgvLigneCmd.Size = new System.Drawing.Size(510, 156);
            this.dgvLigneCmd.TabIndex = 32;
            this.dgvLigneCmd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLigneCmd_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numéro";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Produit";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantite";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prix de vente";
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnSuppLigne);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.btnAddLigne);
            this.panel1.Controls.Add(this.txtQteStock);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPrix);
            this.panel1.Controls.Add(this.txtqte);
            this.panel1.Controls.Add(this.cbProduit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 114);
            this.panel1.TabIndex = 31;
            // 
            // btnSuppLigne
            // 
            this.btnSuppLigne.Location = new System.Drawing.Point(375, 72);
            this.btnSuppLigne.Name = "btnSuppLigne";
            this.btnSuppLigne.Size = new System.Drawing.Size(110, 23);
            this.btnSuppLigne.TabIndex = 21;
            this.btnSuppLigne.Text = "Supprimer Ligne Cmd";
            this.btnSuppLigne.UseVisualStyleBackColor = true;
            this.btnSuppLigne.Click += new System.EventHandler(this.btnSuppLigne_Click);
            // 
            // btnAddLigne
            // 
            this.btnAddLigne.Location = new System.Drawing.Point(375, 9);
            this.btnAddLigne.Name = "btnAddLigne";
            this.btnAddLigne.Size = new System.Drawing.Size(110, 23);
            this.btnAddLigne.TabIndex = 20;
            this.btnAddLigne.Text = "Ajouter Ligne ";
            this.btnAddLigne.UseVisualStyleBackColor = true;
            this.btnAddLigne.Click += new System.EventHandler(this.btnAddLigne_Click);
            // 
            // txtQteStock
            // 
            this.txtQteStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQteStock.Enabled = false;
            this.txtQteStock.Location = new System.Drawing.Point(95, 56);
            this.txtQteStock.Name = "txtQteStock";
            this.txtQteStock.Size = new System.Drawing.Size(62, 20);
            this.txtQteStock.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-2, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantité en stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prix de Vente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantité";
            // 
            // txtPrix
            // 
            this.txtPrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrix.Enabled = false;
            this.txtPrix.Location = new System.Drawing.Point(269, 58);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(100, 20);
            this.txtPrix.TabIndex = 3;
            // 
            // txtqte
            // 
            this.txtqte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtqte.Location = new System.Drawing.Point(269, 14);
            this.txtqte.Name = "txtqte";
            this.txtqte.Size = new System.Drawing.Size(100, 20);
            this.txtqte.TabIndex = 2;
            // 
            // cbProduit
            // 
            this.cbProduit.FormattingEnabled = true;
            this.cbProduit.Location = new System.Drawing.Point(54, 11);
            this.cbProduit.Name = "cbProduit";
            this.cbProduit.Size = new System.Drawing.Size(121, 21);
            this.cbProduit.TabIndex = 1;
            this.cbProduit.SelectedIndexChanged += new System.EventHandler(this.cbProduit_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produit";
            // 
            // cbTiers
            // 
            this.cbTiers.FormattingEnabled = true;
            this.cbTiers.Location = new System.Drawing.Point(380, 17);
            this.cbTiers.Name = "cbTiers";
            this.cbTiers.Size = new System.Drawing.Size(121, 21);
            this.cbTiers.TabIndex = 30;
            // 
            // txtNum
            // 
            this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNum.Enabled = false;
            this.txtNum.Location = new System.Drawing.Point(80, 10);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Numéro";
            // 
            // dgvCommande
            // 
            this.dgvCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommande.Location = new System.Drawing.Point(564, 12);
            this.dgvCommande.Name = "dgvCommande";
            this.dgvCommande.Size = new System.Drawing.Size(501, 361);
            this.dgvCommande.TabIndex = 25;
            this.dgvCommande.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCommande_CellContentClick);
            // 
            // GestionCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 501);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvCommande);
            this.Name = "GestionCommande";
            this.Text = "GestionCommande";
            this.Load += new System.EventHandler(this.GestionCommande_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigneCmd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommande)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMontantTotal;
        private System.Windows.Forms.DataGridView dgvLigneCmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSuppLigne;
        private System.Windows.Forms.Button btnAddLigne;
        private System.Windows.Forms.TextBox txtQteStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.TextBox txtqte;
        private System.Windows.Forms.ComboBox cbProduit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTiers;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCommande;
        private System.Windows.Forms.Button button1;
    }
}