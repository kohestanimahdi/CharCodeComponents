using System;
using System.Windows.Forms;

namespace CharCodeComponents.Forms
{
    public partial class UMessageBoxYN : Form
    {
        public UMessageBoxYN(string lbl)
        {
            InitializeComponent();
            this.KeyPreview = true;
            label1.Text = lbl;

            this.KeyPreview = true;
        }



        private void UMessageBoxYN_Load(object sender, EventArgs e)
        {
            label1.Visible = true;
            BtnYes.Enabled = true;

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void UMessageBoxYN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.No;
                this.Close();
            }
            else if (e.KeyCode == Keys.F2)
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }
    }
}
