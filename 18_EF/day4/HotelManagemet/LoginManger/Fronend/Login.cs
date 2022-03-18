using LoginManger.Context;
using LoginManger.Fronend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagemet.Frontend
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CenterToScreen();

        }

       

      

           
        private void down(object sender, MouseEventArgs e)
        {
            if(this.txtName.Text == String.Empty)
            this.txtName.Text = "Username";

            if(this.txtPass.Text == String.Empty)
            this.txtPass.Text = "Password";
        }

     

        private void sign(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string password = txtPass.Text;
            using (MyLoginManger Context = new())
            {
                var vaild = Context.Frontends.Where(f => f.PassWord == password && f.UserName == username).Any();
                if(vaild)
                {
                    site s = new site();
                    s.ShowDialog();
                    this.Hide();

                }
                else if(Context.Kitchens.Where( k => k.UserName == username && k.PassWord == password).Any())
                {
                    Kitchen k = new();
                    k.ShowDialog();
                    this.Hide();
                }
            }
        }
    }
}
