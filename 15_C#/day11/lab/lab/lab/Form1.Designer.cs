namespace lab
{
    partial class frmNotePad
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnCustDiolg = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtRtf = new System.Windows.Forms.RichTextBox();
            this.digOpen = new System.Windows.Forms.OpenFileDialog();
            this.digSave = new System.Windows.Forms.SaveFileDialog();
            this.digFont = new System.Windows.Forms.FontDialog();
            this.digColor = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(0, 0);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(94, 29);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(125, 0);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(94, 29);
            this.btnFont.TabIndex = 1;
            this.btnFont.Text = "font";
            this.btnFont.UseVisualStyleBackColor = true;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(263, 0);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(94, 29);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnCustDiolg
            // 
            this.btnCustDiolg.Location = new System.Drawing.Point(410, 0);
            this.btnCustDiolg.Name = "btnCustDiolg";
            this.btnCustDiolg.Size = new System.Drawing.Size(94, 29);
            this.btnCustDiolg.TabIndex = 3;
            this.btnCustDiolg.Text = "custDiolg";
            this.btnCustDiolg.UseVisualStyleBackColor = true;
            this.btnCustDiolg.Click += new System.EventHandler(this.btnCustDiolg_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(539, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(665, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // txtRtf
            // 
            this.txtRtf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRtf.Location = new System.Drawing.Point(0, 35);
            this.txtRtf.Name = "txtRtf";
            this.txtRtf.Size = new System.Drawing.Size(799, 362);
            this.txtRtf.TabIndex = 6;
            this.txtRtf.Text = "";
            // 
            // frmNotePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRtf);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCustDiolg);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnOpen);
            this.Name = "frmNotePad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "notePad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnOpen;
        private Button btnFont;
        private Button btnColor;
        private Button btnCustDiolg;
        private Button btnSave;
        private Button btnExit;
        private RichTextBox txtRtf;
        private OpenFileDialog digOpen;
        private SaveFileDialog digSave;
        private FontDialog digFont;
        private ColorDialog digColor;
    }
}