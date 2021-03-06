﻿using System.Drawing;
using System.Windows.Forms;

namespace CharCodeComponents
{
    class CharCodeCheckBox: CheckBox
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

		public CharCodeCheckBox()
		{
			this.setSetting();
		}

		private void setSetting()
		{
			this.Font = new Font("Behnam", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
			this.RightToLeft = RightToLeft.Yes;
		}

		private bool _settingChange = true;
	}
}
