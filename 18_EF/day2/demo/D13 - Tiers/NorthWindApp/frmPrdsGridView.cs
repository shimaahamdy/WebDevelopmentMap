using BLL;
using System.Diagnostics;

namespace NorthWindApp
{
    public partial class frmPrdsGridView : Form
    {
        ProductList PrdLst;

        public frmPrdsGridView()
        {
            InitializeComponent();

            PrdLst=ProductManager.SelectAllProducts();

            bndingSourcePrds.DataSource = PrdLst;

            bndingSourcePrds.AddingNew+= (sender ,e)=> e.NewObject = new Product() {  ProductID=-1 , State = EntityState.Added};

            //bndingSourcePrds.DataSource =  (from P in ProductManager.SelectAllProducts()
            //                               where P.Discontinued == true
            //                               select P).ToList();

            grdViewPrds.DataSource = bndingSourcePrds;
        }

        private void grdViewPrds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var Prd in PrdLst)
            {
                Debug.WriteLine(Prd.State);
            }
        }
    }
}