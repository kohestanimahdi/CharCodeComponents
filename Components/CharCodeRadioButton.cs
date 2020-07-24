using System.Drawing;
using System.Windows.Forms;

namespace Components
{
    class CharCodeRadioButton : RadioButton
    {
        public bool settingChange
        {
            get
            {
                return this._settingChange;
            }
            set
            {
                this._settingChange = value;
            }
        }

        private void setSetting()
        {
            this.Font = new Font("Behnam", 11f, FontStyle.Regular, GraphicsUnit.Point, 178);
            this.RightToLeft = RightToLeft.Yes;
        }

        public CharCodeRadioButton()
        {
            this.setSetting();
        }

        private bool _settingChange = true;
    }
}
