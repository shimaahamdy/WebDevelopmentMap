namespace D12___ADO_D01
{
    partial class frmSqlAdapter
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
            this.btnExecute = new System.Windows.Forms.Button();
            this.lstEmployees = new System.Windows.Forms.ListBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.clndrBirthDate = new System.Windows.Forms.MonthCalendar();
            this.pckerHireDate = new System.Windows.Forms.DateTimePicker();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(694, 444);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(94, 29);
            this.btnExecute.TabIndex = 0;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lstEmployees
            // 
            this.lstEmployees.FormattingEnabled = true;
            this.lstEmployees.ItemHeight = 20;
            this.lstEmployees.Location = new System.Drawing.Point(638, 58);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(150, 284);
            this.lstEmployees.TabIndex = 1;
            this.lstEmployees.SelectedIndexChanged += new System.EventHandler(this.lstEmployees_SelectedIndexChanged);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(212, 44);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(50, 20);
            this.lblEmployeeID.TabIndex = 2;
            this.lblEmployeeID.Text = "label1";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(212, 83);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(125, 27);
            this.txtLastName.TabIndex = 3;
            // 
            // clndrBirthDate
            // 
            this.clndrBirthDate.Location = new System.Drawing.Point(212, 135);
            this.clndrBirthDate.MaxSelectionCount = 1;
            this.clndrBirthDate.Name = "clndrBirthDate";
            this.clndrBirthDate.TabIndex = 4;
            // 
            // pckerHireDate
            // 
            this.pckerHireDate.Location = new System.Drawing.Point(212, 384);
            this.pckerHireDate.Name = "pckerHireDate";
            this.pckerHireDate.Size = new System.Drawing.Size(250, 27);
            this.pckerHireDate.TabIndex = 5;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(380, 444);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 29);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(212, 444);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(94, 29);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSqlAdapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pckerHireDate);
            this.Controls.Add(this.clndrBirthDate);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.lstEmployees);
            this.Controls.Add(this.btnExecute);
            this.Name = "frmSqlAdapter";
            this.Text = "frmSqlAdapter";
            this.Load += new System.EventHandler(this.frmSqlAdapter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnExecute;
        private ListBox lstEmployees;
        private Label lblEmployeeID;
        private TextBox txtLastName;
        private MonthCalendar clndrBirthDate;
        private DateTimePicker pckerHireDate;
        private Button btnNext;
        private Button btnPrev;
        private Button button1;
    }
}