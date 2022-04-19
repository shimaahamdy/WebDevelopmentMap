namespace EFDetailedView
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.numYTDSales = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CBPub = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.numAdv = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numRoy = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.tctTit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labHead = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numYTDSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoy)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(499, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 68;
            this.label8.Text = "YtdSales";
            // 
            // numYTDSales
            // 
            this.numYTDSales.Location = new System.Drawing.Point(615, 222);
            this.numYTDSales.Maximum = new decimal(new int[] {
            2500000,
            0,
            0,
            0});
            this.numYTDSales.Name = "numYTDSales";
            this.numYTDSales.Size = new System.Drawing.Size(150, 27);
            this.numYTDSales.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "Advance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 65;
            this.label9.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(110, 224);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(167, 27);
            this.txtNotes.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "PubID";
            // 
            // CBPub
            // 
            this.CBPub.FormattingEnabled = true;
            this.CBPub.Location = new System.Drawing.Point(110, 270);
            this.CBPub.Name = "CBPub";
            this.CBPub.Size = new System.Drawing.Size(167, 28);
            this.CBPub.TabIndex = 62;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(40, 364);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 47);
            this.btnSave.TabIndex = 61;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 60;
            this.label6.Text = "Price";
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(615, 78);
            this.numPrice.Maximum = new decimal(new int[] {
            2500000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(150, 27);
            this.numPrice.TabIndex = 59;
            // 
            // numAdv
            // 
            this.numAdv.Location = new System.Drawing.Point(615, 120);
            this.numAdv.Maximum = new decimal(new int[] {
            2500000,
            0,
            0,
            0});
            this.numAdv.Name = "numAdv";
            this.numAdv.Size = new System.Drawing.Size(150, 27);
            this.numAdv.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Royalty";
            // 
            // numRoy
            // 
            this.numRoy.Location = new System.Drawing.Point(615, 167);
            this.numRoy.Maximum = new decimal(new int[] {
            2500000,
            0,
            0,
            0});
            this.numRoy.Name = "numRoy";
            this.numRoy.Size = new System.Drawing.Size(150, 27);
            this.numRoy.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Type";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(110, 166);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(167, 27);
            this.txtType.TabIndex = 54;
            // 
            // tctTit
            // 
            this.tctTit.Location = new System.Drawing.Point(110, 119);
            this.tctTit.Name = "tctTit";
            this.tctTit.Size = new System.Drawing.Size(167, 27);
            this.tctTit.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Title";
            // 
            // txtTitID
            // 
            this.txtTitID.Location = new System.Drawing.Point(110, 80);
            this.txtTitID.Name = "txtTitID";
            this.txtTitID.Size = new System.Drawing.Size(167, 27);
            this.txtTitID.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "TtileID";
            // 
            // labHead
            // 
            this.labHead.AutoSize = true;
            this.labHead.Location = new System.Drawing.Point(316, 33);
            this.labHead.Name = "labHead";
            this.labHead.Size = new System.Drawing.Size(135, 20);
            this.labHead.TabIndex = 49;
            this.labHead.Text = "Title Detailed View";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 48);
            this.button1.TabIndex = 69;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numYTDSales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CBPub);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.numAdv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numRoy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.tctTit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labHead);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numYTDSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label8;
        private NumericUpDown numYTDSales;
        private Label label5;
        private Label label9;
        private TextBox txtNotes;
        private Label label7;
        private ComboBox CBPub;
        private Button btnSave;
        private Label label6;
        private NumericUpDown numPrice;
        private NumericUpDown numAdv;
        private Label label4;
        private NumericUpDown numRoy;
        private Label label3;
        private TextBox txtType;
        private TextBox tctTit;
        private Label label2;
        private TextBox txtTitID;
        private Label label1;
        private Label labHead;
        private Button button1;
    }
}