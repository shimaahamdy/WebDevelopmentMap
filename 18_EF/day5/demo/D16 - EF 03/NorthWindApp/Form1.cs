using Dapper;
using Microsoft.EntityFrameworkCore;

namespace NorthWindApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthWindContext context = new();
        private void Form1_Load(object sender, EventArgs e)
        {
            //var PrdLst=  context.PrdTexts.FromSqlRaw("Exec TestPrd").ToList();

            //this.grdViewPrds.DataSource = PrdLst;

            grdViewPrds.DataSource = 
            context.Database.GetDbConnection().Query<Product>("Select * from Products").AsList<Product>();


        }
    }
}