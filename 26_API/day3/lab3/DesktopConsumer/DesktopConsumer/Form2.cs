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
using System.Net.Http.Headers;
using DesktopConsumer.Models;

namespace DesktopConsumer
{
    
    public partial class Form2 : Form
    {
        HttpClient client;
        public Form2(string token)
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7036/api/");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            loadDate();

        }
        private void loadDate()
        {
            HttpResponseMessage response = client.GetAsync("Instructors").Result;
            if (response.IsSuccessStatusCode)
            {
                List<Instructor> courses = response.Content.ReadAsAsync<List<Instructor>>().Result;
                CoursesGrid.DataSource = courses;
            }

            response = client.GetAsync("Departments").Result;
            if (response.IsSuccessStatusCode)
            {
                List<Department> departemnts = response.Content.ReadAsAsync<List<Department>>().Result;
                this.cb_dept.DisplayMember = "Dept_Name";
                this.cb_dept.ValueMember = "Dept_Id";
                this.cb_dept.DataSource = departemnts;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

     

      

        private void add_Click_1(object sender, EventArgs e)
        {
            Instructor inst = new Instructor()
            {
                Ins_Name = txt_insName.Text,
                Email = txt_email.Text,
                Password = txt_cpassword.Text,
                Salary = decimal.Parse(txt_salary.Text),
                Dept_Id = (int)this.cb_dept.SelectedValue

            };

            HttpResponseMessage response = client.PostAsJsonAsync("Instructors", inst).Result;
            if (response.IsSuccessStatusCode)
                loadDate();
        }

        private void Update_Click_1(object sender, EventArgs e)
        {
            int id = (int)CoursesGrid.SelectedRows[0].Cells[0].Value;
            Instructor inst = new Instructor()
            {
                Ins_Name = txt_insName.Text,
                Email = txt_email.Text,
                Password = txt_cpassword.Text,
                Salary = decimal.Parse(txt_salary.Text),
                Dept_Id = (int)this.cb_dept.SelectedValue,
                Ins_Id = id

            };
            
            HttpResponseMessage response = client.PutAsJsonAsync($"Instructors/{id}", inst).Result;
            if (response.IsSuccessStatusCode)
                loadDate();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            int id = (int)CoursesGrid.SelectedRows[0].Cells[0].Value;
            HttpResponseMessage response = client.DeleteAsync($"Instructors/{id}").Result;
            if (response.IsSuccessStatusCode)
                loadDate();
        }
    }
}
