namespace D11___WinForms
{
    partial class frmNotePad
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnDlgCust = new System.Windows.Forms.Button();
            this.txtRtf = new System.Windows.Forms.RichTextBox();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(94, 29);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Location = new System.Drawing.Point(353, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnColor
            // 
            this.btnColor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnColor.Location = new System.Drawing.Point(353, 409);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(94, 29);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(694, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnFont
            // 
            this.btnFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFont.Location = new System.Drawing.Point(12, 409);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(94, 29);
            this.btnFont.TabIndex = 4;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnDlgCust
            // 
            this.btnDlgCust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDlgCust.Location = new System.Drawing.Point(694, 409);
            this.btnDlgCust.Name = "btnDlgCust";
            this.btnDlgCust.Size = new System.Drawing.Size(94, 29);
            this.btnDlgCust.TabIndex = 5;
            this.btnDlgCust.Text = "Cust Dlg";
            this.btnDlgCust.UseVisualStyleBackColor = true;
            this.btnDlgCust.Click += new System.EventHandler(this.btnDlgCust_Click);
            // 
            // txtRtf
            // 
            this.txtRtf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRtf.Location = new System.Drawing.Point(12, 61);
            this.txtRtf.Name = "txtRtf";
            this.txtRtf.Size = new System.Drawing.Size(776, 326);
            this.txtRtf.TabIndex = 6;
            this.txtRtf.Text = "";
            // 
            // dlgOpen
            // 
            this.dlgOpen.InitialDirectory = "D:";
            this.dlgOpen.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgOpen_FileOk);
            // 
            // dlgSave
            // 
            this.dlgSave.InitialDirectory = "D:";
            // 
            // frmNotePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRtf);
            this.Controls.Add(this.btnDlgCust);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Name = "frmNotePad";
            this.Text = "frmNotePad";
            this.Load += new System.EventHandler(this.frmNotePad_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnOpen;
        private Button btnSave;
        private Button btnColor;
        private Button btnClose;
        private Button btnFont;
        private Button btnDlgCust;
        private RichTextBox txtRtf;
        private ColorDialog dlgColor;
        private FontDialog dlgFont;
        private OpenFileDialog dlgOpen;
        private SaveFileDialog dlgSave;
    }
}