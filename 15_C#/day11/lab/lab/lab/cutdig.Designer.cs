namespace lab
{
    partial class frmCutDig
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
            this.RText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCutDigOK = new System.Windows.Forms.Button();
            this.btnCutDigCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RText
            // 
            this.RText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RText.Location = new System.Drawing.Point(12, 38);
            this.RText.Name = "RText";
            this.RText.Size = new System.Drawing.Size(550, 132);
            this.RText.TabIndex = 1;
            this.RText.Text = "";
            this.RText.TextChanged += new System.EventHandler(this.RText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "write your text";
            // 
            // btnCutDigOK
            // 
            this.btnCutDigOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCutDigOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCutDigOK.Location = new System.Drawing.Point(41, 179);
            this.btnCutDigOK.Name = "btnCutDigOK";
            this.btnCutDigOK.Size = new System.Drawing.Size(94, 29);
            this.btnCutDigOK.TabIndex = 3;
            this.btnCutDigOK.Text = "ok";
            this.btnCutDigOK.UseVisualStyleBackColor = true;
            this.btnCutDigOK.Click += new System.EventHandler(this.btnCutDigOK_Click);
            // 
            // btnCutDigCancel
            // 
            this.btnCutDigCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCutDigCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCutDigCancel.Location = new System.Drawing.Point(421, 179);
            this.btnCutDigCancel.Name = "btnCutDigCancel";
            this.btnCutDigCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCutDigCancel.TabIndex = 4;
            this.btnCutDigCancel.Text = "cancel";
            this.btnCutDigCancel.UseVisualStyleBackColor = true;
            // 
            // frmCutDig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 220);
            this.Controls.Add(this.btnCutDigCancel);
            this.Controls.Add(this.btnCutDigOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCutDig";
            this.ShowInTaskbar = false;
            this.Text = "addText";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox RText;
        private Label label1;
        private Button btnCutDigOK;
        private Button btnCutDigCancel;
    }
}