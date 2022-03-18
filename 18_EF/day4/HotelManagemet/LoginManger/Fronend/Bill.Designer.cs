namespace LoginManger.Fronend
{
    partial class Bill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.ComboBox();
            this.month = new System.Windows.Forms.ComboBox();
            this.paymentComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.currentBillAmount = new System.Windows.Forms.TextBox();
            this.taxamount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.foodBillAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalamount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneNComboBox = new System.Windows.Forms.TextBox();
            this.CVC = new System.Windows.Forms.TextBox();
            this.cardtype = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 22);
            this.label9.TabIndex = 10;
            this.label9.Text = "Current Bill";
            // 
            // year
            // 
            this.year.FormattingEnabled = true;
            this.year.Items.AddRange(new object[] {
            "January ",
            "February ",
            "March ",
            "April ",
            "May ",
            "June ",
            "July ",
            "August ",
            "September ",
            "October ",
            "November ",
            "December"});
            this.year.Location = new System.Drawing.Point(148, 307);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(114, 28);
            this.year.TabIndex = 11;
            this.year.Text = "Month";
            // 
            // month
            // 
            this.month.FormattingEnabled = true;
            this.month.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.month.Location = new System.Drawing.Point(24, 307);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(95, 28);
            this.month.TabIndex = 12;
            this.month.Text = "Day";
            this.month.SelectedIndexChanged += new System.EventHandler(this.month_SelectedIndexChanged);
            // 
            // paymentComboBox
            // 
            this.paymentComboBox.FormattingEnabled = true;
            this.paymentComboBox.Items.AddRange(new object[] {
            "Credit",
            "Debit"});
            this.paymentComboBox.Location = new System.Drawing.Point(24, 251);
            this.paymentComboBox.Name = "paymentComboBox";
            this.paymentComboBox.Size = new System.Drawing.Size(123, 28);
            this.paymentComboBox.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(430, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 22);
            this.label12.TabIndex = 13;
            this.label12.Text = "Card Type";
            // 
            // currentBillAmount
            // 
            this.currentBillAmount.Enabled = false;
            this.currentBillAmount.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentBillAmount.Location = new System.Drawing.Point(158, 47);
            this.currentBillAmount.Name = "currentBillAmount";
            this.currentBillAmount.Size = new System.Drawing.Size(195, 27);
            this.currentBillAmount.TabIndex = 15;
            // 
            // taxamount
            // 
            this.taxamount.Enabled = false;
            this.taxamount.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.taxamount.Location = new System.Drawing.Point(158, 144);
            this.taxamount.Name = "taxamount";
            this.taxamount.Size = new System.Drawing.Size(195, 27);
            this.taxamount.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tax";
            // 
            // foodBillAmount
            // 
            this.foodBillAmount.Enabled = false;
            this.foodBillAmount.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foodBillAmount.Location = new System.Drawing.Point(158, 93);
            this.foodBillAmount.Name = "foodBillAmount";
            this.foodBillAmount.Size = new System.Drawing.Size(195, 27);
            this.foodBillAmount.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "food Bill";
            // 
            // totalamount
            // 
            this.totalamount.Enabled = false;
            this.totalamount.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalamount.Location = new System.Drawing.Point(158, 190);
            this.totalamount.Name = "totalamount";
            this.totalamount.Size = new System.Drawing.Size(195, 27);
            this.totalamount.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Total";
            // 
            // phoneNComboBox
            // 
            this.phoneNComboBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNComboBox.Location = new System.Drawing.Point(184, 252);
            this.phoneNComboBox.Name = "phoneNComboBox";
            this.phoneNComboBox.Size = new System.Drawing.Size(304, 27);
            this.phoneNComboBox.TabIndex = 22;
            this.phoneNComboBox.Leave += new System.EventHandler(this.phoneNComboBox_Leave);
            // 
            // CVC
            // 
            this.CVC.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CVC.Location = new System.Drawing.Point(293, 307);
            this.CVC.Name = "CVC";
            this.CVC.Size = new System.Drawing.Size(71, 27);
            this.CVC.TabIndex = 23;
            // 
            // cardtype
            // 
            this.cardtype.AutoSize = true;
            this.cardtype.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cardtype.Location = new System.Drawing.Point(557, 313);
            this.cardtype.Name = "cardtype";
            this.cardtype.Size = new System.Drawing.Size(84, 22);
            this.cardtype.TabIndex = 24;
            this.cardtype.Text = "Unknown";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.BurlyWood;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(625, 377);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 43);
            this.button7.TabIndex = 25;
            this.button7.Text = "Next";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.cardtype);
            this.Controls.Add(this.CVC);
            this.Controls.Add(this.phoneNComboBox);
            this.Controls.Add(this.totalamount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.foodBillAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.taxamount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentBillAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.year);
            this.Controls.Add(this.month);
            this.Controls.Add(this.paymentComboBox);
            this.Controls.Add(this.label12);
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label9;
        public ComboBox year;
        public ComboBox month;
        public ComboBox paymentComboBox;
        private Label label12;
        public TextBox currentBillAmount;
        public TextBox taxamount;
        private Label label1;
        public TextBox foodBillAmount;
        private Label label2;
        public TextBox totalamount;
        private Label label3;
        public TextBox phoneNComboBox;
        public TextBox CVC;
        private Label cardtype;
        private Button button7;
    }
}