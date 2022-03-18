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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }
        public int totalAmountFromFrontend = 0;
        public int foodBill = 0;
        private double finalTotalFinalized = 0.0;
        private string paymentType;


        public double FinalTotalFinalized
        {
            get { return finalTotalFinalized; }
            set { finalTotalFinalized = value; }
        }

        public string PaymentType
        {
            get { return paymentType; }
            set { paymentType = value; }
        }
        private string paymentCardNumber;

        public string PaymentCardNumber
        {
            get { return paymentCardNumber; }
            set { paymentCardNumber = value; }
        }
        private string MM_YY_Of_Card;

        public string MM_YY_Of_Card1
        {
            get { return MM_YY_Of_Card; }
            set { MM_YY_Of_Card = value; }
        }
        private string CVC_Of_Card;

        public string CVC_Of_Card1
        {
            get { return CVC_Of_Card; }
            set { CVC_Of_Card = value; }
        }
        private string CardType;

        public string CardType1
        {
            get { return CardType; }
            set { CardType = value; }
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            double totalWithTax = Convert.ToDouble(totalAmountFromFrontend) * 0.07;
            double FinalTotal = Convert.ToDouble(totalAmountFromFrontend) + totalWithTax + foodBill;
            currentBillAmount.Text = "$" + Convert.ToString(totalAmountFromFrontend) + " USD";
            foodBillAmount.Text = "$" + Convert.ToString(foodBill) + " USD";
            taxamount.Text = "$" + Convert.ToString(totalWithTax) + " USD";
            totalamount.Text = "$" + Convert.ToString(FinalTotal) + " USD";
            FinalTotalFinalized = FinalTotal;
            this.currentBillAmount.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                PaymentType = paymentComboBox.Text;
                PaymentCardNumber = phoneNComboBox.Text;
                MM_YY_Of_Card1 = month.SelectedItem.ToString() + "/" + year.SelectedItem.ToString();
                CVC_Of_Card1 = CVC.Text;
                CardType1 = cardtype.Text;

                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error Closing the window", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (phoneNComboBox.Text.Substring(0, 1) == "3")
            {
                cardtype.Text = "AmericanExpress";
            }
            else if (phoneNComboBox.Text.Substring(0, 1) == "4")
            {
                cardtype.Text = "Visa";
            }
            else if (phoneNComboBox.Text.Substring(0, 1) == "5")
            {
                cardtype.Text = "MasterCard";
            }
            else if (phoneNComboBox.Text.Substring(0, 1) == "6")
            {
                cardtype.Text = "Discover";
            }
            else
                cardtype.Text = "Unknown";
        }

        private void phoneNComboBox_Leave(object sender, EventArgs e)
        {
            //long getphn = Convert.ToInt64(phoneNComboBox.Text);
            //string formatString = String.Format("{0:0000-0000-0000-0000}", getphn);
            //phoneNComboBox.Text = formatString;
        }
    }
}
