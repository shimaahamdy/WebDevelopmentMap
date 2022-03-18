
using EFGridView.Context;
using Microsoft.EntityFrameworkCore;

namespace EFGridView
{
    public partial class Form1 : Form
    {
        PubsContext context = new PubsContext();
        public Form1()
        {
            InitializeComponent();
            context.Titles.Load();
            this.Grid.DataSource = context.Titles.Local.ToBindingList();

            context.Publishers.Load();
            DataGridViewComboBoxColumn DC = new();
            DC.HeaderText = "Publishers";
            DC.DataSource = context.Publishers.Local.ToBindingList();
            DC.DisplayMember = "PubName";
            DC.ValueMember = "PubId";
            ///Bind Selected Value in ComboBox Col with Category ID in Product Data Source
            DC.DataPropertyName = "PubId";


            this.Grid.Columns.Add(DC);


            Grid.Columns["PubId"].Visible = false;
            Grid.Columns["Pub"].Visible = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }
    }
}