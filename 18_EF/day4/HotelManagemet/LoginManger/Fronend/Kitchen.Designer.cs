namespace LoginManger.Fronend
{
    partial class Kitchen
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.t = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.queueListBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.supplyCheckBox = new System.Windows.Forms.CheckBox();
            this.surpriseCheckBox = new System.Windows.Forms.CheckBox();
            this.dinnerTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.breakfastTextBox = new System.Windows.Forms.TextBox();
            this.lunchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Bill = new System.Windows.Forms.Button();
            this.towelCheckBox = new System.Windows.Forms.CheckBox();
            this.cleaningCheckBox = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roomNTextBox = new System.Windows.Forms.TextBox();
            this.floorNTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.phoneNTextBox = new System.Windows.Forms.TextBox();
            this.roomTypeTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.t.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Grid);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1320, 541);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "overview";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(3, 3);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersWidth = 51;
            this.Grid.RowTemplate.Height = 29;
            this.Grid.Size = new System.Drawing.Size(1314, 535);
            this.Grid.TabIndex = 0;
            // 
            // t
            // 
            this.t.BackColor = System.Drawing.Color.Cornsilk;
            this.t.Controls.Add(this.button1);
            this.t.Controls.Add(this.queueListBox);
            this.t.Controls.Add(this.panel2);
            this.t.Controls.Add(this.panel1);
            this.t.Location = new System.Drawing.Point(4, 29);
            this.t.Name = "t";
            this.t.Padding = new System.Windows.Forms.Padding(3);
            this.t.Size = new System.Drawing.Size(1320, 541);
            this.t.TabIndex = 0;
            this.t.Text = "TODO*";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1039, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 29);
            this.button1.TabIndex = 37;
            this.button1.Text = "Update Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // queueListBox
            // 
            this.queueListBox.FormattingEnabled = true;
            this.queueListBox.ItemHeight = 20;
            this.queueListBox.Location = new System.Drawing.Point(981, 59);
            this.queueListBox.Name = "queueListBox";
            this.queueListBox.Size = new System.Drawing.Size(304, 324);
            this.queueListBox.TabIndex = 5;
            this.queueListBox.SelectedIndexChanged += new System.EventHandler(this.queueListBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cornsilk;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.supplyCheckBox);
            this.panel2.Controls.Add(this.surpriseCheckBox);
            this.panel2.Controls.Add(this.dinnerTextBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.breakfastTextBox);
            this.panel2.Controls.Add(this.lunchTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Bill);
            this.panel2.Controls.Add(this.towelCheckBox);
            this.panel2.Controls.Add(this.cleaningCheckBox);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Location = new System.Drawing.Point(485, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 523);
            this.panel2.TabIndex = 16;
            // 
            // supplyCheckBox
            // 
            this.supplyCheckBox.AutoSize = true;
            this.supplyCheckBox.Location = new System.Drawing.Point(149, 340);
            this.supplyCheckBox.Name = "supplyCheckBox";
            this.supplyCheckBox.Size = new System.Drawing.Size(158, 24);
            this.supplyCheckBox.TabIndex = 36;
            this.supplyCheckBox.Text = "Food/Supply status";
            this.supplyCheckBox.UseVisualStyleBackColor = true;
            this.supplyCheckBox.CheckedChanged += new System.EventHandler(this.supplyCheckBox_CheckedChanged);
            // 
            // surpriseCheckBox
            // 
            this.surpriseCheckBox.AutoSize = true;
            this.surpriseCheckBox.Location = new System.Drawing.Point(303, 267);
            this.surpriseCheckBox.Name = "surpriseCheckBox";
            this.surpriseCheckBox.Size = new System.Drawing.Size(126, 24);
            this.surpriseCheckBox.TabIndex = 35;
            this.surpriseCheckBox.Text = "sweet Surprise";
            this.surpriseCheckBox.UseVisualStyleBackColor = true;
            // 
            // dinnerTextBox
            // 
            this.dinnerTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dinnerTextBox.Location = new System.Drawing.Point(26, 169);
            this.dinnerTextBox.Name = "dinnerTextBox";
            this.dinnerTextBox.Size = new System.Drawing.Size(149, 27);
            this.dinnerTextBox.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(26, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 22);
            this.label7.TabIndex = 33;
            this.label7.Text = "Dinner [QTY]";
            // 
            // breakfastTextBox
            // 
            this.breakfastTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.breakfastTextBox.Location = new System.Drawing.Point(26, 84);
            this.breakfastTextBox.Name = "breakfastTextBox";
            this.breakfastTextBox.Size = new System.Drawing.Size(149, 27);
            this.breakfastTextBox.TabIndex = 32;
            // 
            // lunchTextBox
            // 
            this.lunchTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lunchTextBox.Location = new System.Drawing.Point(273, 84);
            this.lunchTextBox.Name = "lunchTextBox";
            this.lunchTextBox.Size = new System.Drawing.Size(129, 27);
            this.lunchTextBox.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Breakfast [QTY]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(270, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "Lunch [QTY]";
            // 
            // Bill
            // 
            this.Bill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bill.Location = new System.Drawing.Point(81, 405);
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(256, 40);
            this.Bill.TabIndex = 18;
            this.Bill.Text = "Change Food Selection";
            this.Bill.UseVisualStyleBackColor = true;
            this.Bill.Click += new System.EventHandler(this.Bill_Click);
            // 
            // towelCheckBox
            // 
            this.towelCheckBox.AutoSize = true;
            this.towelCheckBox.Location = new System.Drawing.Point(162, 267);
            this.towelCheckBox.Name = "towelCheckBox";
            this.towelCheckBox.Size = new System.Drawing.Size(74, 24);
            this.towelCheckBox.TabIndex = 17;
            this.towelCheckBox.Text = "towels";
            this.towelCheckBox.UseVisualStyleBackColor = true;
            // 
            // cleaningCheckBox
            // 
            this.cleaningCheckBox.AutoSize = true;
            this.cleaningCheckBox.Location = new System.Drawing.Point(13, 267);
            this.cleaningCheckBox.Name = "cleaningCheckBox";
            this.cleaningCheckBox.Size = new System.Drawing.Size(89, 24);
            this.cleaningCheckBox.TabIndex = 15;
            this.cleaningCheckBox.Text = "Cleaning";
            this.cleaningCheckBox.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(13, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 22);
            this.label18.TabIndex = 3;
            this.label18.Text = "TO DO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.roomNTextBox);
            this.panel1.Controls.Add(this.floorNTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.firstNameTextBox);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.lastNameTextBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.phoneNTextBox);
            this.panel1.Controls.Add(this.roomTypeTextBox);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(8, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 346);
            this.panel1.TabIndex = 15;
            // 
            // roomNTextBox
            // 
            this.roomNTextBox.Enabled = false;
            this.roomNTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomNTextBox.Location = new System.Drawing.Point(20, 279);
            this.roomNTextBox.Name = "roomNTextBox";
            this.roomNTextBox.Size = new System.Drawing.Size(113, 27);
            this.roomNTextBox.TabIndex = 21;
            // 
            // floorNTextBox
            // 
            this.floorNTextBox.Enabled = false;
            this.floorNTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.floorNTextBox.Location = new System.Drawing.Point(191, 186);
            this.floorNTextBox.Name = "floorNTextBox";
            this.floorNTextBox.Size = new System.Drawing.Size(113, 27);
            this.floorNTextBox.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(20, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Enabled = false;
            this.firstNameTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameTextBox.Location = new System.Drawing.Point(20, 38);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(195, 27);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(20, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 22);
            this.label15.TabIndex = 13;
            this.label15.Text = "Room type";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Enabled = false;
            this.lastNameTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameTextBox.Location = new System.Drawing.Point(221, 38);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(215, 27);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(191, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "Floor#";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(20, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 22);
            this.label14.TabIndex = 11;
            this.label14.Text = "Phone Number";
            // 
            // phoneNTextBox
            // 
            this.phoneNTextBox.Enabled = false;
            this.phoneNTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNTextBox.Location = new System.Drawing.Point(20, 109);
            this.phoneNTextBox.Name = "phoneNTextBox";
            this.phoneNTextBox.Size = new System.Drawing.Size(231, 27);
            this.phoneNTextBox.TabIndex = 10;
            // 
            // roomTypeTextBox
            // 
            this.roomTypeTextBox.Enabled = false;
            this.roomTypeTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomTypeTextBox.Location = new System.Drawing.Point(20, 186);
            this.roomTypeTextBox.Name = "roomTypeTextBox";
            this.roomTypeTextBox.Size = new System.Drawing.Size(113, 27);
            this.roomTypeTextBox.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(20, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 22);
            this.label12.TabIndex = 8;
            this.label12.Text = "Room#";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.t);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1328, 574);
            this.tabControl1.TabIndex = 1;
            // 
            // Kitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 574);
            this.Controls.Add(this.tabControl1);
            this.Name = "Kitchen";
            this.Text = "Kitchen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Kitchen_FormClosed);
            this.Load += new System.EventHandler(this.Kitchen_Load);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.t.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage2;
        private DataGridView Grid;
        private TabPage t;
        private Panel panel2;
        private Button Bill;
        private CheckBox towelCheckBox;
        private CheckBox cleaningCheckBox;
        private Label label18;
        private Panel panel1;
        private Label label6;
        private TextBox firstNameTextBox;
        private Label label15;
        private TextBox lastNameTextBox;
        private Label label9;
        private Label label14;
        private TextBox phoneNTextBox;
        private TextBox roomTypeTextBox;
        private Label label12;
        private TabControl tabControl1;
        private Button button1;
        private ListBox queueListBox;
        private CheckBox supplyCheckBox;
        private CheckBox surpriseCheckBox;
        private TextBox dinnerTextBox;
        private Label label7;
        private TextBox breakfastTextBox;
        private TextBox lunchTextBox;
        private Label label1;
        private Label label4;
        private TextBox roomNTextBox;
        private TextBox floorNTextBox;
    }
}