using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace D13_ADO_D02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SqlCN = new SqlConnection();
            SqlCN.ConnectionString =
                @"Data Source=.\MSSQL2019;Initial Catalog=Northwind; " +
                "Integrated Security = true;TrustServerCertificate=true";

            sqlCmdSelectAllPrds = new SqlCommand("Select * from Products", SqlCN);
            sqlDaPrds = new SqlDataAdapter(sqlCmdSelectAllPrds);

            sqlCmdSelectAllCategories = new SqlCommand("Select CategoryID as CatID , CategoryName from Categories ", SqlCN);
            sqlDaCategories = new(sqlCmdSelectAllCategories);

            DTPrds = new DataTable();
            dtCategories = new();
            
            sqlDaPrds.Fill (DTPrds);
            sqlDaCategories.Fill (dtCategories);

            grdViewPrds.DataSource = DTPrds;


            DataGridViewComboBoxColumn DC = new();
            DC.HeaderText = "Categories";
            DC.DataSource = dtCategories;
            DC.DisplayMember = "CategoryName";
            DC.ValueMember = "CatID";
            ///Bind Selected Value in ComboBox Col with Category ID in Product Data Source
            DC.DataPropertyName = "CategoryID";


            grdViewPrds.Columns.Add(DC);

            grdViewPrds.Columns["CategoryID"].Visible = false;
            grdViewPrds.Columns[0].ReadOnly = true;

        }

        SqlConnection SqlCN;
        SqlCommand sqlCmdSelectAllPrds;
        SqlCommand sqlCmdSelectAllCategories;
        SqlDataAdapter sqlDaPrds;
        SqlDataAdapter sqlDaCategories;
        DataTable DTPrds;
        DataTable dtCategories;

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataRow Dr in DTPrds.Rows)
            {
                Trace.WriteLine(Dr.RowState);
            }
        }
    }
}