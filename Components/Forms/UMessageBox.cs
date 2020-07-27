using System;
using System.Drawing;
using System.Windows.Forms;

namespace CharCodeComponents.Forms
{
    public enum MessageBoxType
    {
        Message = 0,
        Success = 1,
        Error = 2,
        Warning = 3
    }
    public partial class UMessageBox : Form
    {
        public UMessageBox(string label, MessageBoxType State_Msg)
        {
            InitializeComponent();
            label1.Text = label;
            State_Msg2 = State_Msg;
            this.KeyPreview = true;
            //label1.Location = new Point((this.Width - 177) - (label1.Size.Width / 2), 15);
        }

        MessageBoxType State_Msg2 = MessageBoxType.Message;

        private void UMessageBox_Load(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.TopLeft;
            if (State_Msg2 == MessageBoxType.Error)
            {
         
                PanelSym.BackColor = Color.FromArgb(211, 29, 2);
                buttonOk.BackColor = Color.FromArgb(211, 29, 2);
                PicAlert.Image = Properties.Resources.no_success_icon3;
            }
            else if (State_Msg2 == MessageBoxType.Success)
            {
                PanelSym.BackColor = Color.FromArgb(65, 173, 73);
                buttonOk.BackColor = Color.FromArgb(65, 173, 73);
                PicAlert.Image = Properties.Resources.Tick_Mark_Dark_512;
            }
            else if (State_Msg2 == MessageBoxType.Message)
            {
                PicAlert.Visible = false;
            }
            else if (State_Msg2 == MessageBoxType.Warning)
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
