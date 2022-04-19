using EFGridView.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR.Client;
using EFGridView.Entites;

namespace EFGridView
{
    
    public partial class Form1 : Form
    {
        PubsContext context = new PubsContext();
        HubConnection con;
        public Form1()
        {
            InitializeComponent();
            context.Employees.Load();
          
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {


            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //start and build connection
            con = new HubConnectionBuilder().WithUrl("https://localhost:7030/EmployeesHub").Build();

            //start connection
            con.StartAsync();

            //subsucripe to event
            con.On<string, int, string, float>("newEmp", (name, age, gen, sal) =>
            {
                this.listBox1.Items.Add("name: " + name + " age: " + age + " gender: " +
                    gen + " salary: " + sal);
                //int rowId = Grid.Rows.Add();

                //// Grab the new row!
                //DataGridViewRow row = Grid.Rows[rowId];

                //// Add the data
                //row.Cells["Name"].Value = name;
                //row.Cells["Age"].Value = age;
                //row.Cells["Gender"].Value = gen;
                //row.Cells["Salary"].Value = sal;
                

                //this.Grid.Rows.Add(name, age, gen, sal);


                
                

            });

        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string name = this.name.Text;
            int age = (int)this.age.Value;
            string Gen = this.gen.Text;
            float sal = (float)this.sal.Value;

            con.InvokeAsync("submitEmp", name, age, Gen, sal);
            context.SaveChanges();
        }
    }
}