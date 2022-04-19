namespace AdvancedSearch
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
            this.Grid = new System.Windows.Forms.DataGridView();
            this.ChTitle = new System.Windows.Forms.CheckBox();
            this.ChDate = new System.Windows.Forms.CheckBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(1, 85);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersWidth = 51;
            this.Grid.RowTemplate.Height = 29;
            this.Grid.Size = new System.Drawing.Size(1162, 486);
            this.Grid.TabIndex = 0;
            // 
            // ChTitle
            // 
            this.ChTitle.AutoSize = true;
            this.ChTitle.Location = new System.Drawing.Point(33, 22);
            this.ChTitle.Name = "ChTitle";
            this.ChTitle.Size = new System.Drawing.Size(60, 24);
            this.ChTitle.TabIndex = 1;
            this.ChTitle.Text = "Title";
            this.ChTitle.UseVisualStyleBackColor = true;
            this.ChTitle.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.ChTitle.Click += new System.EventHandler(this.ChTitleClick);
            // 
            // ChDate
            // 
            this.ChDate.AutoSize = true;
            this.ChDate.Location = new System.Drawing.Point(115, 22);
            this.ChDate.Name = "ChDate";
            this.ChDate.Size = new System.Drawing.Size(62, 24);
            this.ChDate.TabIndex = 2;
            this.ChDate.Text = "Type";
            this.ChDate.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(258, 22);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(228, 27);
            this.txtTitle.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(517, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 572);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.ChDate);
            this.Controls.Add(this.ChTitle);
            this.Controls.Add(this.Grid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView Grid;
        private CheckBox ChTitle;
        private CheckBox ChDate;
        private TextBox txtTitle;
        private Button button1;
    }
}