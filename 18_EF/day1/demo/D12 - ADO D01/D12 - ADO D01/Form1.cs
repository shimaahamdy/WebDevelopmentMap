using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace D12___ADO_D01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection SqlCN;
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCN = new SqlConnection();

            //SqlCN.ConnectionString = "Data Source=.;Initial Catalog=Northwind; " +
            //    "Integrated Security = true ; TrustServerCertificate=true";
          
            SqlCN.ConnectionString =
            ConfigurationManager.ConnectionStrings["NorthWindCN"].ConnectionString;

            this.Text = $"Branch ID {ConfigurationManager.AppSettings["BranchID"]}";

            SqlCN.StateChange += (sender, e) => this.Text = 
            $"Connection State Was {e.OriginalState} , New State {e.CurrentState}"; 

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (SqlCN.State == ConnectionState.Closed)
                SqlCN.Open();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (SqlCN.State != ConnectionState.Closed)
                SqlCN.Close();
        }
    }
}