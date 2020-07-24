using System;
using System.Windows.Forms;

namespace CharCodeComponents.Forms
{
    public partial class Loading_Gif : Form
    {
        public Loading_Gif()
        {
            InitializeComponent();

          
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (!ApplicationHelpers.FLGLoging)
            {

                timer1.Stop();
                this.Close();
            }
        }

        private void Loading_Gif_Load(object sender, EventArgs e)
        {

        }
    }
}

