using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjRevenuQuebec
{
    public partial class frmEmployes: Form
    {
        DataTable tabEmployes;     
        int indicecourant;
        string mode;

        public frmEmployes()
        {
            InitializeComponent();
        }
        private void MontrerButton(bool AjModSup, bool SauvAn, bool Navig)
        {
            btnAjouterEm.Visible = btnModifierEm.Visible = btnSupprimerEm.Visible = AjModSup;
            btnSauvegarderEm.Visible = btnAnnulerEm.Visible = SauvAn;
         
            btnPremier.Visible = btnPrecedent.Visible = btnSuivant.Visible = btnDernier.Visible = Navig;
        }

        private void Afficher()
        {
            DataRow myrow = tabEmployes.Rows[indicecourant];
            txtNumeroEm.Text = myrow["Numero"].ToString();
            txtNomEm.Text = myrow["Nom"].ToString();
            cboCompagnie.Text = myrow["CompagnieNum"].ToString();
            txtFonction.Text = myrow["Fonction"].ToString();
            txtSalaire.Text = myrow["Salaire"].ToString();


            lblInfo.Text = "Employes " + (indicecourant + 1) + " sur un total de " + tabEmployes.Rows.Count;
        }


        private void btnPremier_Click(object sender, EventArgs e)
        {
            indicecourant = 0;
            Afficher();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if (indicecourant > 0)
                indicecourant--; 
            Afficher();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if (indicecourant < tabEmployes.Rows.Count - 1)
                indicecourant++; 
            Afficher();
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            indicecourant = tabEmployes.Rows.Count - 1;
            Afficher();
        }

        private void btnAjouterEm_Click(object sender, EventArgs e)
        {
            mode = "ajout"; 
            txtNumeroEm.Text = txtNomEm.Text = cboCompagnie.Text = txtFonction.Text = txtSalaire.Text = "";
            txtNumeroEm.Focus(); 
            MontrerButton(false, true, false); 
            
        }

        private void btnModifierEm_Click(object sender, EventArgs e)
        {
            mode = "modif"; 
            txtNumeroEm.Focus();
            MontrerButton(false, true, false);
        }

        private void btnSupprimerEm_Click(object sender, EventArgs e)
        {
            string msg = "Etes vous sur de vouloir supprimer cet employe?";
            string tit = "Suppression permanente";

            if (MessageBox.Show(msg, tit, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                tabEmployes.Rows[indicecourant].Delete(); 
                indicecourant = 0; 
                Afficher(); 
            }
        }

        private void btnSauvegarderEm_Click(object sender, EventArgs e)
        {
            DataRow myrow;

            if (mode == "ajout")
            {
                myrow = tabEmployes.NewRow(); 
                myrow["Numero"] = txtNumeroEm.Text;
                myrow["Nom"] = txtNomEm.Text;
                myrow["Compagnie"] = cboCompagnie.Text;
                myrow["Fonction"] = txtFonction.Text;
                myrow["Salaire"] = txtSalaire.Text;


                tabEmployes.Rows.Add(myrow); 
                indicecourant = tabEmployes.Rows.Count - 1; 
            }

            if (mode == "modif")
            {
                myrow = tabEmployes.Rows[indicecourant];
                myrow["Numero"] = txtNumeroEm.Text;
                myrow["Nom"] = txtNomEm.Text;
                myrow["Compagnie"] = cboCompagnie.Text;
                myrow["Fonction"] = txtFonction.Text;
                myrow["Salaire"] = txtSalaire.Text;
            }

            mode = ""; 
            Afficher(); 
            MontrerButton(true, false, true);
        }

        private void btnAnnulerEm_Click(object sender, EventArgs e)
        {

            Afficher();
            MontrerButton(true, false, true);
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
        }

        private void frmEmployes_Load_1(object sender, EventArgs e)
        {
            tabEmployes = clsGlobalReve.setReve.Tables["Employes"];
            indicecourant = 0;
            Afficher();
            MontrerButton(true, false, true);
        }
    }
}
