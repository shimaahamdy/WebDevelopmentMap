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
    public partial class frmSqlAdapter : Form
    {
        public frmSqlAdapter()
        {
            InitializeComponent();
        }
        SqlConnection SqlCN;

        SqlCommand sqlCmd;
        private void frmSqlAdapter_Load(object sender, EventArgs e)
        {
            SqlCN = new SqlConnection();

            SqlCN.ConnectionString = "Data Source=.;Initial Catalog=Northwind; " +
                "Integrated Security = true ; TrustServerCertificate=true";

            sqlCmd = new SqlCommand("SelectALLEmployees" , SqlCN);

            sqlCmd.CommandType = CommandType.StoredProcedure;

            adapter = new SqlDataAdapter(sqlCmd);

            DT = new();
            EmployeeBindingSource = new BindingSource(DT, "");

            //EmployeeBindingSource.AddingNew += (sender, e) =>
            // {
            //     DataRow Dr = DT.NewRow();
            //     Dr["BirthDate"] = DateTime.Now;
            //     e.NewObject = Dr;
            //  };
 


            navigator = new BindingNavigator(EmployeeBindingSource);
            navigator.Dock = DockStyle.Top;

            this.Controls.Add(navigator);


        }
        DataTable DT;
        SqlDataAdapter adapter;

        BindingSource EmployeeBindingSource;
        //UI Ctrl
        BindingNavigator navigator;

        private void btnExecute_Click(object sender, EventArgs e)
        {

            adapter.Fill(DT); //Execute Select Command

            #region No Binding , Manually Adding Data to Control
            //foreach (DataRow item in DT.Rows)
            //{
            //    lstEmployees.Items.Add(item["LastName"]);
            //} 
            #endregion

            ///Data Binding
            ///Complex Data Binding (Data Source)


            
            //lstEmployees.DataSource = DT;
            lstEmployees.DataSource = EmployeeBindingSource;
            lstEmployees.DisplayMember = "LastName";
            lstEmployees.ValueMember = "EmployeeID";


            ///SimpleData Binding 
            //lblEmployeeID.DataBindings.Add("Text", DT, "EmployeeID");
            //txtLastName.DataBindings.Add("Text", DT, "LastName");
            //clndrBirthDate.DataBindings.Add("SelectionStart", DT, "BirthDate");

            lblEmployeeID.DataBindings.Add("Text", EmployeeBindingSource, "EmployeeID");
            txtLastName.DataBindings.Add("Text", EmployeeBindingSource, "LastName");
            clndrBirthDate.DataBindings.Add("SelectionStart", EmployeeBindingSource, "BirthDate");

            btnPrev.Click += (sender, e) => EmployeeBindingSource.MovePrevious();

        }
        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text =
                lstEmployees.SelectedValue.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            EmployeeBindingSource.MoveNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow Dr = DT.NewRow();
            Dr["BirthDate"] = DateTime.Now;
            DT.Rows.Add(Dr);
        }
    }
}
