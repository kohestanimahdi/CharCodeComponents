using System;
using System.Drawing;
using System.Windows.Forms;

namespace CharCodeComponents
{
    class CharCodeComboBox:ComboBox
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
			this.Font = new Font("BenyaminNum", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
		}

		public bool AutoDropDown
		{
			get
			{
				return this._AutoDropDown;
			}
			set
			{
				this._AutoDropDown = value;
			}
		}

		public CharCodeComboBox()
		{
			this.setSetting();
		}

		protected override void OnEnter(EventArgs e)
		{
			base.OnEnter(e);
			bool autoDropDown = this._AutoDropDown;
			if (autoDropDown)
			{
				bool flag = this.Flag_Clicked == 0;
				if (flag)
				{
					base.DroppedDown = true;
				}
				this.Flag_Clicked = 0;
			}
		}

		protected override void OnMouseClick(MouseEventArgs e)
		{
			base.OnMouseClick(e);
			bool autoDropDown = this._AutoDropDown;
			if (autoDropDown)
			{
				this.Flag_Clicked = 1;
				base.DroppedDown = true;
			}
		}

		public int GetInt
		{
			get
			{
				int result;
				int.TryParse(this.Text, out result);
				return result;
			}
		}


		public long GetInt64
		{
			get
			{
				long result;
				long.TryParse(this.Text, out result);
				return result;
			}
		}

		private bool _settingChange = true;

		private bool _AutoDropDown = true;

		private int Flag_Clicked = 0;
	}
}
