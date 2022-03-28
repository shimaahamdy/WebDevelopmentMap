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
        string token;
        public Form1()
        {
            InitializeComponent();
            clinet = new HttpClient();
            clinet.BaseAddress = new Uri("https://localhost:7036/api/");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Instructor Inst = new Instructor()
            {
              Email = txtEmail.Text,
              Password = txtPass.Text
            };

            HttpResponseMessage response = clinet.PostAsJsonAsync("Login", Inst).Result;
            if (response.IsSuccessStatusCode)
            {
                token = response.Content.ReadAsStringAsync().Result;
                Form2 f = new Form2(token);
                f.ShowDialog();
            }
                
        }
    }
}
