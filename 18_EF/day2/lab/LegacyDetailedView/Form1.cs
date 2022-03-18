using BusinessLogicLayer;
namespace LegacyDetailedView

{
    public partial class Form1 : Form
    {
        BindingSource productsWraper;
        BindingNavigator productsUI;
        TitleList TiTlst;
        PublisherList pubList;
        public Form1()
        {
            
            InitializeComponent();
            TiTlst = TitleManger.SelectAllTitles();
            productsWraper = new BindingSource(TiTlst, "");
            productsUI = new BindingNavigator(productsWraper);

           productsUI.Dock = DockStyle.Top;
           this.Controls.Add(productsUI);
            this.productsWraper.AddingNew += (obj, e) =>
            {
                Title t = new Title();
                t.State = EntityState.Added;

                e.NewObject = t;
            };
            //productsUI.ItemRemoved += (s, e) =>
            //{
            //    throw new NotImplementedException();
            //};
            this.txtTitID.DataBindings.Add("Text", productsWraper, "title_id");
            this.tctTit.DataBindings.Add("Text", productsWraper, "title");
            this.txtType.DataBindings.Add("Text", productsWraper, "type");
            this.txtNotes.DataBindings.Add("Text", productsWraper, "notes");
            this.numPrice.DataBindings.Add("Value", productsWraper, "price");
            this.numAdv.DataBindings.Add("Value", productsWraper, "advance");
            this.numRoy.DataBindings.Add("Value", productsWraper, "royalty");
            this.numYTDSales.DataBindings.Add("Value", productsWraper, "ytd_sales");

            pubList = PuplisherManger.SelectAllPulishers();
            this.CBPub.DataSource = pubList;
            CBPub.DisplayMember = "pub_name";
            CBPub.ValueMember = "pub_id";
            ///Bind Selected Value in ComboBox Col with Category ID in Product Data Source
            CBPub.DataBindings.Add(new Binding("SelectedValue", productsWraper, "pub_id"));

            
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TitleManger.updateAllTitiles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Title)this.productsWraper.Current).State = EntityState.Deleted;

        }
    }
}