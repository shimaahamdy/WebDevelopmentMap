namespace DesktopConsumer
{
    partial class Form1
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
            this.CoursesGrid = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.ComTopic = new System.Windows.Forms.ComboBox();
            this.numID = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numDur = new System.Windows.Forms.NumericUpDown();
            this.Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDur)).BeginInit();
            this.SuspendLayout();
            // 
            // CoursesGrid
            // 
            this.CoursesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoursesGrid.Location = new System.Drawing.Point(3, 12);
            this.CoursesGrid.Name = "CoursesGrid";
            this.CoursesGrid.RowHeadersWidth = 51;
            this.CoursesGrid.RowTemplate.Height = 24;
            this.CoursesGrid.Size = new System.Drawing.Size(654, 279);
            this.CoursesGrid.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(761, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 22);
            this.txtName.TabIndex = 2;
            // 
            // ComTopic
            // 
            this.ComTopic.FormattingEnabled = true;
            this.ComTopic.Location = new System.Drawing.Point(761, 149);
            this.ComTopic.Name = "ComTopic";
            this.ComTopic.Size = new System.Drawing.Size(130, 24);
            this.ComTopic.TabIndex = 4;
            // 
            // numID
            // 
            this.numID.Location = new System.Drawing.Point(761, 32);
            this.numID.Name = "numID";
            this.numID.Size = new System.Drawing.Size(120, 22);
            this.numID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(687, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "CRSID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(674, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "CRSName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(670, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "CRSDuration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(687, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Topic";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(784, 200);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(102, 37);
            this.add.TabIndex = 10;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 34);
            this.button2.TabIndex = 11;
            this.button2.Text = "DeleteSelected";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numDur
            // 
            this.numDur.Location = new System.Drawing.Point(766, 106);
            this.numDur.Name = "numDur";
            this.numDur.Size = new System.Drawing.Size(120, 22);
            this.numDur.TabIndex = 12;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(663, 200);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(102, 37);
            this.Update.TabIndex = 13;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.numDur);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numID);
            this.Controls.Add(this.ComTopic);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.CoursesGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CoursesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CoursesGrid;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox ComTopic;
        private System.Windows.Forms.NumericUpDown numID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numDur;
        private System.Windows.Forms.Button Update;
    }
}

