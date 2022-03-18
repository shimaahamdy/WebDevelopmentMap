namespace DetailedView
{
    partial class detailedView
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
            this.labHead = new System.Windows.Forms.Label();
            this.labProductIDText = new System.Windows.Forms.Label();
            this.labProductID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantiy = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numOrder = new System.Windows.Forms.NumericUpDown();
            this.numLevel = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.chBoxDis = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.CBC = new System.Windows.Forms.ComboBox();
            this.CBS = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // labHead
            // 
            this.labHead.AutoSize = true;
            this.labHead.Location = new System.Drawing.Point(335, 53);
            this.labHead.Name = "labHead";
            this.labHead.Size = new System.Drawing.Size(163, 20);
            this.labHead.TabIndex = 1;
            this.labHead.Text = "Products Detailed View";
            // 
            // labProductIDText
            // 
            this.labProductIDText.AutoSize = true;
            this.labProductIDText.Location = new System.Drawing.Point(471, 89);
            this.labProductIDText.Name = "labProductIDText";
            this.labProductIDText.Size = new System.Drawing.Size(82, 20);
            this.labProductIDText.TabIndex = 2;
            this.labProductIDText.Text = "ProductID :";
            // 
            // labProductID
            // 
            this.labProductID.AutoSize = true;
            this.labProductID.Location = new System.Drawing.Point(559, 89);
            this.labProductID.Name = "labProductID";
            this.labProductID.Size = new System.Drawing.Size(24, 20);
            this.labProductID.TabIndex = 3;
            this.labProductID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ProductName";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(138, 89);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(288, 27);
            this.txtProductName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "QuantityPerUnit";
            // 
            // txtQuantiy
            // 
            this.txtQuantiy.Location = new System.Drawing.Point(138, 131);
            this.txtQuantiy.Name = "txtQuantiy";
            this.txtQuantiy.Size = new System.Drawing.Size(346, 27);
            this.txtQuantiy.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(138, 175);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(78, 27);
            this.txtPrice.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "UnitPrice";
            // 
            // numStock
            // 
            this.numStock.Location = new System.Drawing.Point(109, 224);
            this.numStock.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(150, 27);
            this.numStock.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "UnitsInStock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "UnitsOnOrder";
            // 
            // numOrder
            // 
            this.numOrder.Location = new System.Drawing.Point(415, 224);
            this.numOrder.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numOrder.Name = "numOrder";
            this.numOrder.Size = new System.Drawing.Size(150, 27);
            this.numOrder.TabIndex = 13;
            // 
            // numLevel
            // 
            this.numLevel.Location = new System.Drawing.Point(726, 226);
            this.numLevel.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numLevel.Name = "numLevel";
            this.numLevel.Size = new System.Drawing.Size(150, 27);
            this.numLevel.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(624, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "ReorderLevel";
            // 
            // chBoxDis
            // 
            this.chBoxDis.AutoSize = true;
            this.chBoxDis.Location = new System.Drawing.Point(13, 287);
            this.chBoxDis.Name = "chBoxDis";
            this.chBoxDis.Size = new System.Drawing.Size(118, 24);
            this.chBoxDis.TabIndex = 16;
            this.chBoxDis.Text = "Discontinued";
            this.chBoxDis.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 391);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 47);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CBC
            // 
            this.CBC.FormattingEnabled = true;
            this.CBC.Location = new System.Drawing.Point(415, 283);
            this.CBC.Name = "CBC";
            this.CBC.Size = new System.Drawing.Size(151, 28);
            this.CBC.TabIndex = 19;
            // 
            // CBS
            // 
            this.CBS.FormattingEnabled = true;
            this.CBS.Location = new System.Drawing.Point(725, 285);
            this.CBS.Name = "CBS";
            this.CBS.Size = new System.Drawing.Size(151, 28);
            this.CBS.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Categories";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(640, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Suppliers";
            // 
            // detailedView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CBS);
            this.Controls.Add(this.CBC);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chBoxDis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numLevel);
            this.Controls.Add(this.numOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantiy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labProductID);
            this.Controls.Add(this.labProductIDText);
            this.Controls.Add(this.labHead);
            this.Name = "detailedView";
            this.Text = "detailedView";
            this.Load += new System.EventHandler(this.detailedView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labHead;
        private Label labProductIDText;
        private Label labProductID;
        private Label label1;
        private TextBox txtProductName;
        private Label label2;
        private TextBox txtQuantiy;
        private TextBox txtPrice;
        private Label label3;
        private NumericUpDown numStock;
        private Label label4;
        private Label label5;
        private NumericUpDown numOrder;
        private NumericUpDown numLevel;
        private Label label6;
        private CheckBox chBoxDis;
        private Button btnSave;
        private ComboBox CBC;
        private ComboBox CBS;
        private Label label7;
        private Label label8;
    }
}