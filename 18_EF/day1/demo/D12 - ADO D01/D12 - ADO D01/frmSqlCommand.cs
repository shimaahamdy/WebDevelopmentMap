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
    public partial class frmSqlCommand : Form
    {
        public frmSqlCommand()
        {
            InitializeComponent();
        }

        SqlConnection SqlCN;

        SqlCommand sqlCmd;
        private void frmSqlCommand_Load(object sender, EventArgs e)
        {
            SqlCN = new SqlConnection();

            SqlCN.ConnectionString = "Data Source=.;Initial Catalog=Northwind; " +
                "Integrated Security = true ; TrustServerCertificate=true";

            sqlCmd = new SqlCommand();

            sqlCmd.Connection = SqlCN;

            sqlCmd.CommandText = "Select * from Employees";

            //sqlCmd.CommandType = CommandType.Text;//Default

            cmdUpdateEmployee = new SqlCommand();
            cmdUpdateEmployee.Connection = SqlCN;
            cmdUpdateEmployee.CommandText = "UPDATE Employees SET FirstName = @FirstName WHERE  (EmployeeID = @EmployeeID)";

            cmdUpdateEmployee.Parameters.Add(new SqlParameter("FirstName", SqlDbType.NVarChar, 10));
            cmdUpdateEmployee.Parameters.Add(new SqlParameter("EmployeeID", SqlDbType.Int));



        }
        SqlCommand cmdUpdateEmployee;
        private void btnExecute_Click(object sender, EventArgs e)
        {
            if ( SqlCN?.State == ConnectionState.Closed)
                SqlCN.Open();

            SqlDataReader reader =  sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                lstEmployeeLastName.Items.Add(
                    //reader["LastName"].ToString()
                    reader.GetString("LastName")
                    );
            }

            ///Not Valid in WinForms
            //lstEmployeeLastName.DataSource = reader;

            SqlCN.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlCmd.CommandText = "Select count(*) from Employees";
            SqlCN.Open();
            this.Text = $"Employee Count {sqlCmd.ExecuteScalar()?.ToString()}";
            SqlCN.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCN.Open();

            cmdUpdateEmployee.Parameters["EmployeeID"].Value = 7;//lstEmployeeLastName.SelectedValue; ;
            cmdUpdateEmployee.Parameters["FirstName"].Value = "Sayed Sayed";


            if (cmdUpdateEmployee.ExecuteNonQuery() > 0)
                this.Text = "Updated";
            else
                this.Text = "Error";

            SqlCN.Close();
        }
    }
}
