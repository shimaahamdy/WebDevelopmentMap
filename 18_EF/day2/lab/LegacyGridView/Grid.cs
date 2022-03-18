using BusinessLogicLayer;
using System.Diagnostics;

namespace LegacyGridView
{
    public partial class Grid : Form
    {
        TitleList TiTlst;
        PublisherList pubList;
        public Grid()
        {
            
            InitializeComponent();

            TiTlst = TitleManger.SelectAllTitles();
            //bind grid to list of titles objects
            TitleBindingSource.DataSource = TiTlst; 
           titlesGrid.DataSource = TitleBindingSource;
            // titlesGrid.DataSource = TitleManger.SelectAllTitles();

            TitleBindingSource.AddingNew += (sender, e) =>
            {
                Title t = new Title();
                t.State = EntityState.Added;

                e.NewObject = t;
            };

            //this.titlesGrid.UserDeletingRow += (sender, e) =>
            // {
            //     Title t = new Title();
            //     t.title_id = e.Row.Cells[0].ToString();

            //     e.NewObject = t;


            // };

            DataGridViewComboBoxColumn DC = new();
            pubList = PuplisherManger.SelectAllPulishers(); 
            DC.HeaderText = "Publishers";
            DC.DataSource = pubList;
            DC.DisplayMember = "pub_name";
            DC.ValueMember = "pub_id";
            ///Bind Selected Value in ComboBox Col with Category ID in Product Data Source
            DC.DataPropertyName = "pub_id";


            this.titlesGrid.Columns.Add(DC);


            titlesGrid.Columns["pub_id"].Visible = false;

            




        }
       

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TitleManger.updateAllTitiles();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Title)this.TitleBindingSource.Current).State = EntityState.Deleted;
            
        }
    }
}