namespace prjRevenuQuebec
{
    partial class frmEmployes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPremier = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.cboCompagnie = new System.Windows.Forms.ComboBox();
            this.txtSalaire = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModifierEm = new System.Windows.Forms.Button();
            this.btnSupprimerEm = new System.Windows.Forms.Button();
            this.btnSauvegarderEm = new System.Windows.Forms.Button();
            this.btnAnnulerEm = new System.Windows.Forms.Button();
            this.btnAjouterEm = new System.Windows.Forms.Button();
            this.txtNomEm = new System.Windows.Forms.TextBox();
            this.txtFonction = new System.Windows.Forms.TextBox();
            this.txtNumeroEm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblInfo);
            this.groupBox1.Controls.Add(this.btnPremier);
            this.groupBox1.Controls.Add(this.btnPrecedent);
            this.groupBox1.Controls.Add(this.btnDernier);
            this.groupBox1.Controls.Add(this.btnSuivant);
            this.groupBox1.Controls.Add(this.cboCompagnie);
            this.groupBox1.Controls.Add(this.txtSalaire);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnModifierEm);
            this.groupBox1.Controls.Add(this.btnSupprimerEm);
            this.groupBox1.Controls.Add(this.btnSauvegarderEm);
            this.groupBox1.Controls.Add(this.btnAnnulerEm);
            this.groupBox1.Controls.Add(this.btnAjouterEm);
            this.groupBox1.Controls.Add(this.txtNomEm);
            this.groupBox1.Controls.Add(this.txtFonction);
            this.groupBox1.Controls.Add(this.txtNumeroEm);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(63, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 431);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GESTION DES EMPLOYES";
            // 
            // btnPremier
            // 
            this.btnPremier.BackColor = System.Drawing.Color.Fuchsia;
            this.btnPremier.ForeColor = System.Drawing.Color.Black;
            this.btnPremier.Location = new System.Drawing.Point(157, 203);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(72, 25);
            this.btnPremier.TabIndex = 26;
            this.btnPremier.Text = "Premier";
            this.btnPremier.UseVisualStyleBackColor = false;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.BackColor = System.Drawing.Color.Fuchsia;
            this.btnPrecedent.ForeColor = System.Drawing.Color.Black;
            this.btnPrecedent.Location = new System.Drawing.Point(256, 203);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(72, 25);
            this.btnPrecedent.TabIndex = 25;
            this.btnPrecedent.Text = "Precedent";
            this.btnPrecedent.UseVisualStyleBackColor = false;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.BackColor = System.Drawing.Color.Fuchsia;
            this.btnDernier.ForeColor = System.Drawing.Color.Black;
            this.btnDernier.Location = new System.Drawing.Point(463, 203);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(72, 25);
            this.btnDernier.TabIndex = 24;
            this.btnDernier.Text = "Dernier";
            this.btnDernier.UseVisualStyleBackColor = false;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.BackColor = System.Drawing.Color.Fuchsia;
            this.btnSuivant.ForeColor = System.Drawing.Color.Black;
            this.btnSuivant.Location = new System.Drawing.Point(355, 203);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(72, 25);
            this.btnSuivant.TabIndex = 23;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = false;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // cboCompagnie
            // 
            this.cboCompagnie.FormattingEnabled = true;
            this.cboCompagnie.Location = new System.Drawing.Point(243, 89);
            this.cboCompagnie.Name = "cboCompagnie";
            this.cboCompagnie.Size = new System.Drawing.Size(237, 23);
            this.cboCompagnie.TabIndex = 22;
            // 
            // txtSalaire
            // 
            this.txtSalaire.ForeColor = System.Drawing.Color.Blue;
            this.txtSalaire.Location = new System.Drawing.Point(243, 148);
            this.txtSalaire.Name = "txtSalaire";
            this.txtSalaire.Size = new System.Drawing.Size(237, 22);
            this.txtSalaire.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Salaire:";
            // 
            // btnModifierEm
            // 
            this.btnModifierEm.BackColor = System.Drawing.Color.Black;
            this.btnModifierEm.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnModifierEm.Location = new System.Drawing.Point(578, 56);
            this.btnModifierEm.Name = "btnModifierEm";
            this.btnModifierEm.Size = new System.Drawing.Size(111, 31);
            this.btnModifierEm.TabIndex = 14;
            this.btnModifierEm.Text = "Modifier";
            this.btnModifierEm.UseVisualStyleBackColor = false;
            this.btnModifierEm.Click += new System.EventHandler(this.btnModifierEm_Click);
            // 
            // btnSupprimerEm
            // 
            this.btnSupprimerEm.BackColor = System.Drawing.Color.Black;
            this.btnSupprimerEm.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnSupprimerEm.Location = new System.Drawing.Point(578, 85);
            this.btnSupprimerEm.Name = "btnSupprimerEm";
            this.btnSupprimerEm.Size = new System.Drawing.Size(111, 31);
            this.btnSupprimerEm.TabIndex = 13;
            this.btnSupprimerEm.Text = "Supprimer";
            this.btnSupprimerEm.UseVisualStyleBackColor = false;
            this.btnSupprimerEm.Click += new System.EventHandler(this.btnSupprimerEm_Click);
            // 
            // btnSauvegarderEm
            // 
            this.btnSauvegarderEm.BackColor = System.Drawing.Color.Black;
            this.btnSauvegarderEm.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnSauvegarderEm.Location = new System.Drawing.Point(578, 113);
            this.btnSauvegarderEm.Name = "btnSauvegarderEm";
            this.btnSauvegarderEm.Size = new System.Drawing.Size(111, 31);
            this.btnSauvegarderEm.TabIndex = 12;
            this.btnSauvegarderEm.Text = "Sauvegarder";
            this.btnSauvegarderEm.UseVisualStyleBackColor = false;
            this.btnSauvegarderEm.Click += new System.EventHandler(this.btnSauvegarderEm_Click);
            // 
            // btnAnnulerEm
            // 
            this.btnAnnulerEm.BackColor = System.Drawing.Color.Black;
            this.btnAnnulerEm.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnAnnulerEm.Location = new System.Drawing.Point(578, 142);
            this.btnAnnulerEm.Name = "btnAnnulerEm";
            this.btnAnnulerEm.Size = new System.Drawing.Size(111, 31);
            this.btnAnnulerEm.TabIndex = 11;
            this.btnAnnulerEm.Text = "Annuler";
            this.btnAnnulerEm.UseVisualStyleBackColor = false;
            this.btnAnnulerEm.Click += new System.EventHandler(this.btnAnnulerEm_Click);
            // 
            // btnAjouterEm
            // 
            this.btnAjouterEm.BackColor = System.Drawing.Color.Black;
            this.btnAjouterEm.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnAjouterEm.Location = new System.Drawing.Point(578, 29);
            this.btnAjouterEm.Name = "btnAjouterEm";
            this.btnAjouterEm.Size = new System.Drawing.Size(111, 31);
            this.btnAjouterEm.TabIndex = 10;
            this.btnAjouterEm.Text = "Ajouter";
            this.btnAjouterEm.UseVisualStyleBackColor = false;
            this.btnAjouterEm.Click += new System.EventHandler(this.btnAjouterEm_Click);
            // 
            // txtNomEm
            // 
            this.txtNomEm.ForeColor = System.Drawing.Color.Blue;
            this.txtNomEm.Location = new System.Drawing.Point(243, 63);
            this.txtNomEm.Name = "txtNomEm";
            this.txtNomEm.Size = new System.Drawing.Size(237, 22);
            this.txtNomEm.TabIndex = 9;
            // 
            // txtFonction
            // 
            this.txtFonction.ForeColor = System.Drawing.Color.Blue;
            this.txtFonction.Location = new System.Drawing.Point(243, 118);
            this.txtFonction.Name = "txtFonction";
            this.txtFonction.Size = new System.Drawing.Size(237, 22);
            this.txtFonction.TabIndex = 7;
            // 
            // txtNumeroEm
            // 
            this.txtNumeroEm.ForeColor = System.Drawing.Color.Blue;
            this.txtNumeroEm.Location = new System.Drawing.Point(243, 35);
            this.txtNumeroEm.Name = "txtNumeroEm";
            this.txtNumeroEm.Size = new System.Drawing.Size(237, 22);
            this.txtNumeroEm.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nom:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Compagnie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fonction:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Numero:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "REVENU QUEBEC";
            // 
            // lblInfo
            // 
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(121, 261);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(458, 25);
            this.lblInfo.TabIndex = 27;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // frmEmployes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(867, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmEmployes";
            this.Text = "frmEmployes";
            this.Load += new System.EventHandler(this.frmEmployes_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.ComboBox cboCompagnie;
        private System.Windows.Forms.TextBox txtSalaire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModifierEm;
        private System.Windows.Forms.Button btnSupprimerEm;
        private System.Windows.Forms.Button btnSauvegarderEm;
        private System.Windows.Forms.Button btnAnnulerEm;
        private System.Windows.Forms.Button btnAjouterEm;
        private System.Windows.Forms.TextBox txtNomEm;
        private System.Windows.Forms.TextBox txtFonction;
        private System.Windows.Forms.TextBox txtNumeroEm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfo;
    }
}