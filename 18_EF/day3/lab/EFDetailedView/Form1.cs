using EFGridView.Context;
using EFGridView.Entites;
using Microsoft.EntityFrameworkCore;

namespace EFDetailedView
{
    public partial class Form1 : Form
    {
        BindingSource Wraper;
        BindingNavigator productsUI;
        PubsContext context = new PubsContext();

        public Form1()
        {
        
            InitializeComponent();
           
            context.Titles.Load();
            Wraper = new BindingSource(context.Titles.Local.ToBindingList(), "");
            productsUI = new BindingNavigator(Wraper);

            productsUI.Dock = DockStyle.Top;
            this.Controls.Add(productsUI);
          
          
            this.txtTitID.DataBindings.Add("Text", Wraper, "TitleId");
            this.tctTit.DataBindings.Add("Text", Wraper, "Title1");
            this.txtType.DataBindings.Add("Text", Wraper, "Type");
            this.txtNotes.DataBindings.Add("Text", Wraper, "Notes");
            this.numPrice.DataBindings.Add("Value", Wraper, "Price");
            this.numAdv.DataBindings.Add("Value", Wraper, "Advance");
            this.numRoy.DataBindings.Add("Value", Wraper, "Royalty");
            this.numYTDSales.DataBindings.Add("Value", Wraper, "YtdSales");

            this.Wraper.AddingNew += (obj, e) =>
            {
                Title t = new Title();
                t.TitleId = "BN1111";

                t.Title1 = "NA";
                t.Type = "business";
                t.PubId = "1756";
                t.Price = 1;
                t.Advance = 1;
                t.Royalty = 0;
                t.YtdSales = 1;
                t.Notes = "NA";

                string iDate = "05/05/2005";
                DateTime oDate = Convert.ToDateTime(iDate);

                e.NewObject = t;
            };
            context.Publishers.Load();
            CBPub.DataSource = context.Publishers.Local.ToBindingList();
            CBPub.DisplayMember = "PubName";
            CBPub.ValueMember = "PubId";
            ///Bind Selected Value in ComboBox Col with Category ID in Product Data Source
            CBPub.DataBindings.Add(new Binding("SelectedValue", Wraper, "PubId"));

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}