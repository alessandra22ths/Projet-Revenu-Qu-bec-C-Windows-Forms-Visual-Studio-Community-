using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjRevenuQuebec
{
    public partial class frmPrincipale: Form
    { 
        public frmPrincipale()
        {
            InitializeComponent();
        }

        private void RemplirDataset()
        {
            clsGlobalReve.setReve = new DataSet();

            SqlConnection mycon = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RevenuQcDB;Integrated Security=True");
            mycon.Open();

            string sql = "SELECT * FROM Compagnies";
            SqlCommand mycmd = new SqlCommand(sql, mycon); 
            clsGlobalReve.adpCompagnies = new SqlDataAdapter(mycmd); 
            clsGlobalReve.adpCompagnies.Fill(clsGlobalReve.setReve, "Compagnies"); 

            sql = "SELECT * FROM Employes";
            SqlCommand mycmd2 = new SqlCommand(sql, mycon); 
            clsGlobalReve.adpEmployes = new SqlDataAdapter(mycmd2);
            clsGlobalReve.adpEmployes.Fill(clsGlobalReve.setReve, "Employes"); 

            DataColumn[] cles = new DataColumn[1];
            cles[0] = clsGlobalReve.setReve.Tables["Compagnies"].Columns["Numero"];
            clsGlobalReve.setReve.Tables["Compagnies"].PrimaryKey = cles; 
        }
        private void compagniesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmCompagnies fa = new frmCompagnies();
            fa.MdiParent = this;
            fa.Show();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void employesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frmEmployes fe = new frmEmployes();
            fe.MdiParent = this;
            fe.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder mybuld = new SqlCommandBuilder(clsGlobalReve.adpCompagnies);
            clsGlobalReve.adpCompagnies.Update(clsGlobalReve.setReve, "Compagnies");

            SqlCommandBuilder mybuld2 = new SqlCommandBuilder(clsGlobalReve.adpEmployes);
            clsGlobalReve.adpEmployes.Update(clsGlobalReve.setReve, "Employes");
        }

        private void frmPrincipale_Load_1(object sender, EventArgs e)
        {
            RemplirDataset();
        }
    }
}
