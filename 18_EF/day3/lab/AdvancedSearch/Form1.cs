using EFGridView.Context;
using Microsoft.EntityFrameworkCore;

namespace AdvancedSearch
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChTitleClick(object sender, EventArgs e)
        {
           
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            if (ChTitle.Checked && ChDate.Checked)
            {
                var Results = (from t in context.Titles
                               where t.Title1.StartsWith(this.txtTitle.Text) && t.Type.Contains(this.txtTitle.Text)
                               select t
                             ).ToList();
                this.Grid.DataSource = Results;
            }
            else if (ChTitle.Checked)
            {
                var Results = (from t in context.Titles
                               where t.Title1.Contains(this.txtTitle.Text)
                               select t
                          ).ToList();
                this.Grid.DataSource = Results;
            }
            else if (ChDate.Checked)
            {
                var Results = (from t in context.Titles
                               where t.Type.Contains(this.txtTitle.Text)
                               select t
                           ).ToList();
                this.Grid.DataSource = Results;
            }
            else
            {
                this.Grid.DataSource = context.Titles.Local.ToBindingList();
            }
        }
    }
}