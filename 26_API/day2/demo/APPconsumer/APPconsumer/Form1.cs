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

namespace APPconsumer
{
    public partial class Form1 : Form
    {
        HttpClient client;
        public Form1()
        {
            InitializeComponent();
             client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8888/api/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        HttpResponseMessage res= client.GetAsync("students").Result;

            if (res.IsSuccessStatusCode)
            {
              List<student> sts= res.Content.ReadAsAsync<List<student>>().Result;
                dgv_student.DataSource = sts;
            }
            else
            {
                MessageBox.Show("error");
            }

            HttpResponseMessage mess = client.GetAsync("Departments").Result;
            if (mess.IsSuccessStatusCode)
            {
                List<department> depts = mess.Content.ReadAsAsync<List<department>>().Result;

                cb_dept.DisplayMember = "name";
                cb_dept.ValueMember = "id";
                cb_dept.DataSource = depts;


            }
           


        
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            student s = new student()
            {
                name = txt_name.Text,
                age = int.Parse(txt_age.Text),
                address = txt_address.Text,
                deptid = (int)cb_dept.SelectedValue
            };

            //HttpClient client = new HttpClient();
          HttpResponseMessage res=  client.PostAsJsonAsync("students", s).Result;
            if (res.IsSuccessStatusCode)
            {
                Form1_Load(null, null);
            }
            else
            {
                MessageBox.Show("error");
            }
        
        }

        private void dgv_student_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(MessageBox.Show("are you sure to delete this student", "confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id =(int) dgv_student.SelectedRows[0].Cells[0].Value;
              HttpResponseMessage mess=  client.DeleteAsync($"students/{id}").Result;
                if (mess.IsSuccessStatusCode)
                {
                    Form1_Load(null, null);
                }

            }
        }
    }
}
