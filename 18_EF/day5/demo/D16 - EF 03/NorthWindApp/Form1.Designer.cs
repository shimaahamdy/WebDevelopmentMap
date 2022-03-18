namespace NorthWindApp
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
            this.grdViewPrds = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewPrds)).BeginInit();
            this.SuspendLayout();
            // 
            // grdViewPrds
            // 
            this.grdViewPrds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewPrds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdViewPrds.Location = new System.Drawing.Point(0, 0);
            this.grdViewPrds.Name = "grdViewPrds";
            this.grdViewPrds.RowHeadersWidth = 51;
            this.grdViewPrds.RowTemplate.Height = 29;
            this.grdViewPrds.Size = new System.Drawing.Size(800, 450);
            this.grdViewPrds.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdViewPrds);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewPrds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdViewPrds;
    }
}