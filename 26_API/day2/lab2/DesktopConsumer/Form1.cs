using DesktopConsumer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopConsumer
{
    public partial class Form1 : Form
    {
        HttpClient clinet;
        public Form1()
        {
            InitializeComponent();
            clinet = new HttpClient();
            clinet.BaseAddress = new Uri("https://localhost:44388/api/");
            loadDate();
        }
        private void loadDate()
        {
            HttpResponseMessage response = clinet.GetAsync("Courses").Result;
            if(response.IsSuccessStatusCode)
            {
               List<Course> courses = response.Content.ReadAsAsync<List<Course>>().Result;
               CoursesGrid.DataSource = courses;
            }

            response = clinet.GetAsync("Topics").Result;
            if(response.IsSuccessStatusCode)
            {
                List<Topic> topics = response.Content.ReadAsAsync<List<Topic>>().Result;
                this.ComTopic.DisplayMember = "Top_Name";
                this.ComTopic.ValueMember = "Top_Id";
                this.ComTopic.DataSource = topics;
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            Course course = new Course()
            {
                Crs_Id = (int)numID.Value,
                Crs_Name = txtName.Text,
                Crs_Duration = (int)numDur.Value,
                Top_Id = (int)this.ComTopic.SelectedValue
            };

            HttpResponseMessage response = clinet.PostAsJsonAsync("Courses", course).Result;
            if(response.IsSuccessStatusCode)
                loadDate();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = (int)CoursesGrid.SelectedRows[0].Cells[0].Value;
            HttpResponseMessage response = clinet.DeleteAsync($"Courses/{id}").Result;
            if (response.IsSuccessStatusCode)
                loadDate();

        }

        private void Update_Click(object sender, EventArgs e)
        {
            Course course = new Course()
            {
                Crs_Id = (int)numID.Value,
                Crs_Name = txtName.Text,
                Crs_Duration = (int)numDur.Value,
                Top_Id = (int)this.ComTopic.SelectedValue
            };

            HttpResponseMessage response = clinet.PutAsJsonAsync($"Courses/{course.Crs_Id}", course).Result;
            if (response.IsSuccessStatusCode)
                loadDate();
        }
    }
}
