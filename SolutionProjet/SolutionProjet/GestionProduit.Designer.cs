
namespace Projet
{
    partial class GestionProduit
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnChercher = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.dgvProduit = new System.Windows.Forms.DataGridView();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblQte = new System.Windows.Forms.Label();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnVider = new System.Windows.Forms.Button();
            this.rbReferance = new System.Windows.Forms.RadioButton();
            this.rbQte = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(59, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reference";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.BackColor = System.Drawing.SystemColors.Control;
            this.lblDes.Location = new System.Drawing.Point(59, 76);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(63, 13);
            this.lblDes.TabIndex = 2;
            this.lblDes.Text = "Designation";
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(163, 26);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(100, 20);
            this.txtRef.TabIndex = 5;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(163, 76);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(100, 20);
            this.txtDes.TabIndex = 6;
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(163, 126);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(100, 20);
            this.txtPrix.TabIndex = 7;
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(163, 179);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(100, 20);
            this.txtQte.TabIndex = 8;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(416, 21);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(416, 56);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 11;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(416, 95);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 12;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnChercher
            // 
            this.btnChercher.Location = new System.Drawing.Point(402, 129);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(104, 23);
            this.btnChercher.TabIndex = 13;
            this.btnChercher.Text = "Chercher par:";
            this.btnChercher.UseVisualStyleBackColor = true;
            this.btnChercher.Click += new System.EventHandler(this.btnChercher_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(416, 181);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 14;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // dgvProduit
            // 
            this.dgvProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduit.Location = new System.Drawing.Point(37, 264);
            this.dgvProduit.Name = "dgvProduit";
            this.dgvProduit.Size = new System.Drawing.Size(518, 174);
            this.dgvProduit.TabIndex = 15;
            this.dgvProduit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduit_CellClick);
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(70, 129);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(24, 13);
            this.lblPrix.TabIndex = 16;
            this.lblPrix.Text = "Prix";
            // 
            // lblQte
            // 
            this.lblQte.AutoSize = true;
            this.lblQte.Location = new System.Drawing.Point(70, 179);
            this.lblQte.Name = "lblQte";
            this.lblQte.Size = new System.Drawing.Size(47, 13);
            this.lblQte.TabIndex = 17;
            this.lblQte.Text = "Quantite";
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(470, 215);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(85, 48);
            this.btnActualiser.TabIndex = 5;
            this.btnActualiser.Text = "Actualiser la base";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // btnVider
            // 
            this.btnVider.Location = new System.Drawing.Point(217, 215);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(46, 22);
            this.btnVider.TabIndex = 18;
            this.btnVider.Text = "Vider";
            this.btnVider.UseVisualStyleBackColor = true;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // rbReferance
            // 
            this.rbReferance.AutoSize = true;
            this.rbReferance.Location = new System.Drawing.Point(383, 158);
            this.rbReferance.Name = "rbReferance";
            this.rbReferance.Size = new System.Drawing.Size(75, 17);
            this.rbReferance.TabIndex = 19;
            this.rbReferance.TabStop = true;
            this.rbReferance.Text = "Référance";
            this.rbReferance.UseVisualStyleBackColor = true;
            // 
            // rbQte
            // 
            this.rbQte.AutoSize = true;
            this.rbQte.Location = new System.Drawing.Point(470, 158);
            this.rbQte.Name = "rbQte";
            this.rbQte.Size = new System.Drawing.Size(65, 17);
            this.rbQte.TabIndex = 20;
            this.rbQte.TabStop = true;
            this.rbQte.Text = "Quantité";
            this.rbQte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rbQte.UseVisualStyleBackColor = true;
            // 
            // GestionProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.rbQte);
            this.Controls.Add(this.rbReferance);
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.lblQte);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.dgvProduit);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnChercher);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtQte);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.label1);
            this.Name = "GestionProduit";
            this.Text = "GestionProduit";
            this.Load += new System.EventHandler(this.GestionProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.TextBox txtQte;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnChercher;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.DataGridView dgvProduit;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblQte;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.RadioButton rbReferance;
        private System.Windows.Forms.RadioButton rbQte;
    }
}

