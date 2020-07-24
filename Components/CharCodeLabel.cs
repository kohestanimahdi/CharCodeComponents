﻿using System.Drawing;
using System.Windows.Forms;

namespace Components
{
    class CharCodeLabel:Label
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
			this.TextAlign = ContentAlignment.MiddleRight;
		}

		public CharCodeLabel()
		{
			this.setSetting();
		}

		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.ResumeLayout(false);
		}

		private bool _settingChange = true;
	}
}
