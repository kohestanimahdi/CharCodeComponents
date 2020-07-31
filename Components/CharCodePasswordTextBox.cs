using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CharCodeComponents
{
    public partial class CharCodePasswordTextBox : UserControl
    {
        public CharCodePasswordTextBox()
        {
            InitializeComponent();
        }

        private void ButtonShowPassword_Click(object sender, EventArgs e)
        {
            TextBoxPassword.UseSystemPasswordChar = !TextBoxPassword.UseSystemPasswordChar;
        }
    }
}
