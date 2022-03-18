using Microsoft.EntityFrameworkCore;
using NorthWindApp.Context;
using System.Diagnostics;

namespace NorthWindApp
{
    public partial class frmProductsGridView : Form
    {
        public frmProductsGridView()
        {
            InitializeComponent();
        }
        NorthwindContext Context = new NorthwindContext();
        private void btnLoad_Click(object sender, EventArgs e)
        {
            //var Results = (from P in Context.Products
            //              where P.UnitsInStock > 0
            //              select P).ToList();

            //grdViewPrds.DataSource = Results;

            ///Two Way Binding in WindowsForms
            Context.Products.Load();
            ///Get All Products from Database into Local Copy

            grdViewPrds.DataSource = Context.Products.Local.ToBindingList();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdViewPrds.EndEdit();

            Context.SaveChanges();
        }

        private void frmProductsGridView_Load(object sender, EventArgs e)
        {
            var Results = (from P in Context.Products.Include( P=> P.Category).Include(P => P.Supplier)
                           where P.UnitsInStock == 0
                           select P
                           //select P.ProductName
                           //select new {P.ProductName , P.Category.CategoryName}
                          ).ToList();


            foreach (var item in Results)
            {
                Trace.WriteLine($"{item.ProductName} {item?.Category?.CategoryName??"NA"}");
            }
        }
    }
}