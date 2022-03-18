using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D12___ADO_D01
{
    public partial class frmEmployeeGridView : Form
    {
        public frmEmployeeGridView()
        {
            InitializeComponent();
        }
        SqlConnection SqlCN;
        SqlCommand sqlCmd;
        SqlDataAdapter DA;

        DataTable Dt;
        private void frmEmployeeGridView_Load(object sender, EventArgs e)
        {
            SqlCN = new SqlConnection();

            SqlCN.ConnectionString = "Data Source=.;Initial Catalog=Northwind; " +
                "Integrated Security = true ; TrustServerCertificate=true";

            sqlCmd = new SqlCommand("Select * from Employees", SqlCN);

            DA = new SqlDataAdapter(sqlCmd);

            Dt = new();


            grdViewEmployees.DataSource = Dt;

            SqlCommandBuilder builder = new SqlCommandBuilder(DA);

            DA.InsertCommand = builder.GetInsertCommand();
            DA.DeleteCommand = builder.GetDeleteCommand();
            DA.UpdateCommand = builder.GetUpdateCommand();

            DA.Fill(Dt);

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///Call Insert , Update , Delete Commands
            DA.Update(Dt);
        }
    }
}
