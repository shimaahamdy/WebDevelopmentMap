using Microsoft.Data.SqlClient;
using System.Data;


namespace DetailedView
{
    public partial class detailedView : Form
    {
        SqlConnection sqlConn;  //to connect with database
        SqlCommand sqlCmd;    //commands that will applied to database
        DataTable DTable;
        SqlDataAdapter adapter;
        BindingSource productsWraper; //wrapper class to Dtable (move next, prvious)
        
        BindingNavigator productsUI;
        SqlCommandBuilder updateTable;


        SqlDataAdapter sqlDaCategories;
        DataTable dtCategories;
        SqlCommand sqlCmdSelectAllCategories;

        SqlDataAdapter sqlDaSuppliers;
        DataTable dtSuppliers;
        SqlCommand sqlCmdSelectAllSuppliers;
        public detailedView()
        {
            InitializeComponent();
        }


        private void detailedView_Load(object sender, EventArgs e)
        {
            sqlConn = new SqlConnection();

            sqlConn.ConnectionString = "Data Source=.;Initial Catalog=Northwind; " +
               "Integrated Security = true ; TrustServerCertificate=true";

            sqlCmd = new SqlCommand("select * from Products", sqlConn);
            sqlCmdSelectAllCategories = new SqlCommand("Select CategoryID as CatID , CategoryName from Categories ", sqlConn);
            sqlCmdSelectAllSuppliers = new SqlCommand("Select SupplierID as SupID , CompanyName from Suppliers ", sqlConn);

            adapter = new SqlDataAdapter(sqlCmd);
            DTable = new DataTable();
            

            sqlDaCategories = new(sqlCmdSelectAllCategories);
            dtCategories = new();


            sqlDaSuppliers = new(sqlCmdSelectAllSuppliers);
            dtSuppliers = new();


            productsWraper = new BindingSource(DTable, "");
            productsUI = new BindingNavigator(productsWraper);
           
            productsUI.Dock = DockStyle.Top;
            this.Controls.Add(productsUI);

            updateTable = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = updateTable.GetInsertCommand();
            adapter.UpdateCommand = updateTable.GetUpdateCommand();
            adapter.DeleteCommand = updateTable.GetDeleteCommand();

            this.productsWraper.AddingNew += (obj, e) =>
            {
                DataRow row = DTable.NewRow();
                // row["ProductID"] = IDcounter++;
                row["ProductName"] = "product456";
                row["QuantityPerUnit"] = "12-box";
                row["UnitPrice"] = "10.45";
                row["UnitsInStock"] = 0;
                row["Discontinued"] = 0;
                row["UnitsOnOrder"] = 0;
                row["ReorderLevel"] = 0;
     

                DTable.Rows.Add(row);
            };

            //execute command and fill it in Dtable
            adapter.Fill(DTable);
            sqlDaSuppliers.Fill(dtSuppliers);
            sqlDaCategories.Fill(dtCategories);

            //simple data binding
            labProductID.DataBindings.Add("Text", productsWraper, "ProductID");
            txtProductName.DataBindings.Add("Text", productsWraper, "ProductName");
            txtQuantiy.DataBindings.Add("Text", productsWraper, "QuantityPerUnit");
            txtPrice.DataBindings.Add("Text", productsWraper, "UnitPrice");
            numLevel.DataBindings.Add("Value", productsWraper, "ReorderLevel");
            numOrder.DataBindings.Add("Value", productsWraper, "UnitsOnOrder");
            numStock.DataBindings.Add("Value", productsWraper, "UnitsInStock");
            chBoxDis.DataBindings.Add("Checked", productsWraper, "Discontinued");

            //complex binding

            CBC.DataSource = dtCategories;
            CBC.DisplayMember = "CategoryName";
            CBC.ValueMember = "CatID";
            CBC.DataBindings.Add(new Binding("SelectedValue", productsWraper, "CategoryID"));

            CBS.DataSource = dtSuppliers;
            CBS.DisplayMember = "CompanyName";
            CBS.ValueMember = "SupID";
            CBS.DataBindings.Add(new Binding("SelectedValue", productsWraper, "SupplierID"));



        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            adapter.Update(DTable);

        }



       

        private void button1_Click_1(object sender, EventArgs e)
        {
            //string ProductID = labProductID.Text;
            //DataRow row = DTable.Select("ProductID=" + ProductID).First();
            //row["UnitPrice"] = txtPrice.Text;
            //row["ReorderLevel"] = numLevel.Value;
            //row["UnitsOnOrder"] = numOrder.Value;
            //row["UnitsInStock"] = numStock.Value;
            //row["Discontinued"] = chBoxDis.Checked;
            //row["productname"] = txtProductName.Text;
            //row["QuantityPerUnit"] = txtQuantiy.Text;
            //row["CategoryID"] = CBC.SelectedValue;

        }
    }
}