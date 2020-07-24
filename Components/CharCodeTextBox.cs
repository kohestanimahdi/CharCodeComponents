using System.Drawing;
using System.Windows.Forms;

namespace CharCodeComponents
{
    class CharCodeTextBox : TextBox
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

		public CharCodeTextBox()
		{
			this.setSetting();
		}

		private void setSetting()
		{
			this.Font = new Font("BenyaminNum", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
			base.Width = 120;
			base.Height = 30;
			this.AutoSize = false;
		}

		private bool _settingChange = true;
	}
}
