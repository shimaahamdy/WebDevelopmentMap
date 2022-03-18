using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D11___WinForms
{
    public partial class frmNotePad : Form
    {
        public frmNotePad()
        {
            InitializeComponent();
            this.btnClose.Click += (sender ,e)=> this.Close();
        }

        private void frmNotePad_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            dlgOpen.Filter = "Rich Text File|*.rtf|Text Files |*.txt";
            dlgSave.Filter = "Rich Text File|*.rtf|Text Files |*.txt";


        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                switch (dlgOpen.FilterIndex)
                {
                    case 1:
                        this.txtRtf.LoadFile(dlgOpen.FileName, RichTextBoxStreamType.RichText);
                        break;
                    case 2:
                        this.txtRtf.LoadFile(dlgOpen.FileName, RichTextBoxStreamType.PlainText);
                        break;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ( dlgSave.ShowDialog() == DialogResult.OK)
                txtRtf.SaveFile (dlgSave.FileName , (RichTextBoxStreamType)dlgSave.FilterIndex - 1 );
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (txtRtf.SelectedText.Length > 0)
                dlgFont.Font = txtRtf.SelectionFont;
            if ( dlgFont.ShowDialog() == DialogResult.OK)
                txtRtf.SelectionFont  = dlgFont.Font;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (txtRtf.SelectedText.Length > 0)
                dlgColor.Color = txtRtf.SelectionColor;

                if ( dlgColor.ShowDialog() == DialogResult.OK)
                txtRtf.SelectionColor = dlgColor.Color;
        }

        frmCustDlg dlg = new frmCustDlg();
        private void btnDlgCust_Click(object sender, EventArgs e)
        {
            dlg.UserText = "Type You Text Here";
            if (dlg.ShowDialog() == DialogResult.OK)
                txtRtf.AppendText(dlg.UserText);
        }

        private void dlgOpen_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
