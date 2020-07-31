using System;
using System.Drawing;
using System.Windows.Forms;

namespace CharCodeComponents.Forms
{

    public partial class UMessageBox : Form
    {
        public UMessageBox(string label, MessageBoxIcon State_Msg)
        {
            InitializeComponent();
            label1.Text = label;
            State_Msg2 = State_Msg;
            this.KeyPreview = true;
            //label1.Location = new Point((this.Width - 177) - (label1.Size.Width / 2), 15);
        }

        MessageBoxIcon State_Msg2 = MessageBoxIcon.None;

        private void UMessageBox_Load(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.TopLeft;
            if (State_Msg2 == MessageBoxIcon.Error)
            {
         
                PanelSym.BackColor = Color.FromArgb(211, 29, 2);
                buttonOk.BackColor = Color.FromArgb(211, 29, 2);
                PicAlert.Image = Properties.Resources.no_success_icon3;
            }
            else if (State_Msg2 == MessageBoxIcon.Information)
            {
                PanelSym.BackColor = Color.FromArgb(65, 173, 73);
                buttonOk.BackColor = Color.FromArgb(65, 173, 73);
                PicAlert.Image = Properties.Resources.Tick_Mark_Dark_512;
            }
            else if (State_Msg2 == MessageBoxIcon.None)
            {
                PicAlert.Visible = false;
            }
            else if (State_Msg2 == MessageBoxIcon.Warning)
            {
                PanelSym.BackColor = Color.FromArgb(255, 105, 0);
                buttonOk.BackColor = Color.FromArgb(255, 105, 0);
                PicAlert.Image = Properties.Resources.Tick_Org;
            }
        }
        private void UMessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
