using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginManger.Fronend
{
    public partial class FoodMenue : Form
    {
        public FoodMenue()
        {
            InitializeComponent();
        }
        private int lunchQ = 0;

        public int LunchQ
        {
            get { return lunchQ; }
            set { lunchQ = value; }
        }
        private int breakfastQ = 0;

        public int BreakfastQ
        {
            get { return breakfastQ; }
            set { breakfastQ = value; }
        }
        private int dinnerQ = 0;

        public int DinnerQ
        {
            get { return dinnerQ; }
            set { dinnerQ = value; }
        }

        private string cleaning = "";

        public string Cleaning
        {
            get { return cleaning; }
            set { cleaning = value; }
        }
        private string towel = "";

        public string Towel
        {
            get { return towel; }
            set { towel = value; }
        }

        private string surprise = "";

        public string Surprise
        {
            get { return surprise; }
            set { surprise = value; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (breakFast.Checked)
            {
                BreakfastQ = (int)numericUpDown1.Value;
            }
            if (Lunch.Checked)
            {
                LunchQ = (int)numericUpDown2.Value;
            }
            if (dinner.Checked)
            {
                DinnerQ = (int)numericUpDown3.Value;
            }
            if (checkBox5.Checked)
            {
                Cleaning = checkBox5.Text;
            }
            if (checkBox6.Checked)
            {
                Towel = checkBox6.Text;
            }
            if (checkBox4.Checked)
            {
                Surprise = checkBox4.Text;
            }

            this.Hide();
        }
    }
}
