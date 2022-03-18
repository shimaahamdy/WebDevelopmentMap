namespace lab
{
    public partial class frmNotePad : Form
    {
        public frmNotePad()
        {
            InitializeComponent();
            this.btnExit.Click += (sender, e) => this.Close();
            this.btnFont.Click += (object sender, EventArgs e) =>
            {
                if (txtRtf.SelectedText.Length > 0)
                    digFont.Font = txtRtf.SelectionFont;
                if (digFont.ShowDialog() == DialogResult.OK)
                    txtRtf.SelectionFont = digFont.Font;
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
           digOpen.Filter = "Rich Text File|*.rtf|Text Files |*.txt";
           digSave.Filter = "Rich Text File|*.rtf|Text Files |*.txt";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if(digOpen.ShowDialog() == DialogResult.OK)
            {
                txtRtf.LoadFile(digOpen.FileName, (RichTextBoxStreamType)digOpen.FilterIndex-1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(digSave.ShowDialog() == DialogResult.OK)
            {
                txtRtf.SaveFile(digSave.FileName, (RichTextBoxStreamType)digSave.FilterIndex - 1);
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (txtRtf.SelectedText.Length > 0)
                digColor.Color = txtRtf.SelectionColor;
            if(digColor.ShowDialog()==DialogResult.OK)
                txtRtf.SelectionColor = digColor.Color;
        }

        frmCutDig formcutdig = new frmCutDig();

        private void btnCustDiolg_Click(object sender, EventArgs e)
        {
            
            if (formcutdig.ShowDialog() == DialogResult.OK)
                txtRtf.AppendText(formcutdig.TextBox);
        }
    }
}