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
    public partial class frmCompagnies: Form
    {
        DataTable tabCompagnies;    
        int indicecourant;         
        string mode;

        public frmCompagnies()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            mode = "ajout"; 
            txtNumero.Text = txtNom.Text = txtAdresse.Text = txtDomaine.Text = txtSite.Text = "";
            txtNumero.Focus(); 
            MontrerButton(false, true, false);
        }

        private void MontrerButton(bool AjModSup, bool SauvAn, bool Navig)
        {
            btnAjouter.Visible = btnModifier.Visible = btnSupprimer.Visible = AjModSup;
            btnSauvegarder.Visible = btnAnnuler.Visible = SauvAn;
        }

        private void Afficher()
        {
            DataRow myrow = tabCompagnies.Rows[indicecourant];
            txtNumero.Text = myrow["Numero"].ToString();
            txtNom.Text = myrow["Nom"].ToString();
            txtAdresse.Text = myrow["Adresse"].ToString();
            txtDomaine.Text = myrow["Domaine"].ToString();
            txtSite.Text = myrow["SiteWeb"].ToString();
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            string msg = "Etes vous sur de vouloir supprimer cet compagnie?";
            string tit = "Suppression permanente";

            if (MessageBox.Show(msg, tit, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                tabCompagnies.Rows[indicecourant].Delete();
                indicecourant = 0;
                Afficher();
            }
        }

        private void btnSauvegarder_Click_1(object sender, EventArgs e)
        {
            DataRow myrow;

            if (mode == "ajout")
            {
                myrow = tabCompagnies.NewRow();
                myrow["Numero"] = txtNumero.Text;
                myrow["Nom"] = txtNom.Text;
                myrow["Adresse"] = txtAdresse.Text;
                myrow["Domaine"] = txtDomaine.Text;
                myrow["Site Web"] = txtSite.Text;

                tabCompagnies.Rows.Add(myrow);
                indicecourant = tabCompagnies.Rows.Count - 1;
            }

            if (mode == "modif")
            {
                myrow = tabCompagnies.Rows[indicecourant];
                myrow["Numero"] = txtNumero.Text;
                myrow["Nom"] = txtNom.Text;
                myrow["Adresse"] = txtAdresse.Text;
                myrow["Domaine"] = txtDomaine.Text;
                myrow["SiteWeb"] = txtSite.Text;
            }

            mode = "";
            Afficher();
            MontrerButton(true, false, true);
        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            mode = "modif";
            txtNumero.Focus();
            MontrerButton(false, true, false);
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            Afficher();
            MontrerButton(true, false, true);
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkArtiste.Checked && chkAnnee.Checked == false && chkGenre.Checked == false)
            {
                // Obtiene el número del artista seleccionado
                string numArtistChoisi = cboArtiste.SelectedValue.ToString();

                // Busca canciones con ese número de artista
                DataRow[] results = tabChansons.Select("NumArtiste= " + numArtistChoisi + "");

                // Si hay resultados, se muestran en el DataGrid
                if (results.Length > 0)
                {
                    gridChansons.DataSource = results.CopyToDataTable(); // Convierte los resultados a DataTable
                }
                else
                {
                    gridChansons.DataSource = null; // No se encontró nada
                }
            }
        }

        private void frmCompagnies_Load_1(object sender, EventArgs e)
        {
            tabCompagnies = clsGlobalReve.setReve.Tables["Compagnies"];
            indicecourant = 0;
            Afficher();
            MontrerButton(true, false, true);

            gridCompagnies.DataSource = clsGlobalReve.setReve.Tables["Compagnies"];
        }
    }
}
