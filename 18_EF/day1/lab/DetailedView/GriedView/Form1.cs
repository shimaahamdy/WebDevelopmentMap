using Microsoft.Data.SqlClient;
using System.Data;
namespace GriedView
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConn;  //to connect with database
        SqlCommand sqlCmd;    //commands that will applied to database
        DataTable DTable;
        SqlDataAdapter adapter;
        SqlCommandBuilder updateTable;

        SqlDataAdapter sqlDaCategories;
        DataTable dtCategories;
        SqlCommand sqlCmdSelectAllCategories;

        SqlDataAdapter sqlDaSuppliers;
        DataTable dtSuppliers;
        SqlCommand sqlCmdSelectAllSuppliers;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConn = new SqlConnection();

            sqlConn.ConnectionString = "Data Source=.;Initial Catalog=Northwind; " +
               "Integrated Security = true ; TrustServerCertificate=true";
            sqlCmd = new SqlCommand("select * from Products", sqlConn);

            sqlCmdSelectAllCategories = new SqlCommand("Select CategoryID as CatID , CategoryName from Categories ", sqlConn);
            sqlCmdSelectAllSuppliers = new SqlCommand("Select SupplierID as SupID , CompanyName from Suppliers ", sqlConn);


            adapter = new SqlDataAdapter(sqlCmd);
            DTable = new DataTable();
            adapter.Fill(DTable);

            sqlDaCategories = new(sqlCmdSelectAllCategories);
            dtCategories = new();
            sqlDaCategories.Fill(dtCategories);

            gridProducts.DataSource = DTable;
            DataGridViewComboBoxColumn DC = new();
            DC.HeaderText = "Categories";
            DC.DataSource = dtCategories;
            DC.DisplayMember = "CategoryName";
            DC.ValueMember = "CatID";
            ///Bind Selected Value in ComboBox Col with Category ID in Product Data Source
            DC.DataPropertyName = "CategoryID";


            this.gridProducts.Columns.Add(DC);

            sqlDaSuppliers = new(sqlCmdSelectAllSuppliers);
            dtSuppliers = new();
            sqlDaSuppliers.Fill(dtSuppliers);


            DataGridViewComboBoxColumn DS = new();
            DS.HeaderText = "Suppliers";
            DS.DataSource = dtSuppliers;
            DS.DisplayMember = "CompanyName";
            DS.ValueMember = "SupID";
            DS.DataPropertyName = "SupplierID";


            this.gridProducts.Columns.Add(DS);
            gridProducts.Columns["CategoryID"].Visible = false;
            gridProducts.Columns["SupplierID"].Visible = false;
            gridProducts.Columns[0].ReadOnly = true;



            //complex data binding

            updateTable = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = updateTable.GetInsertCommand();
            adapter.UpdateCommand = updateTable.GetUpdateCommand();
            adapter.DeleteCommand = updateTable.GetDeleteCommand();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adapter.Update(DTable);
        }
    }
}