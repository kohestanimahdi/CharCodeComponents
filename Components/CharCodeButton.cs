using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace CharCodeComponents
{
    class CharCodeButton: Button
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

		public bool PaintYes
		{
			get
			{
				return this._PaintYes;
			}
			set
			{
				this._PaintYes = value;
			}
		}

		public bool PaintNo
		{
			get
			{
				return this._PaintNo;
			}
			set
			{
				this._PaintNo = value;
			}
		}

		public bool PaintOthers
		{
			get
			{
				return this._PaintOthers;
			}
			set
			{
				this._PaintOthers = value;
			}
		}

		public bool BeepSounds
		{
			get
			{
				return this._BeepSounds;
			}
			set
			{
				this._BeepSounds = value;
			}
		}

		public bool PaintCurves
		{
			get
			{
				return this._PaintCurves;
			}
			set
			{
				this._PaintCurves = value;
			}
		}

		public CharCodeButton()
		{
			this.setSetting();
		}

		private void setSetting()
		{
			base.Height = 40;
		}

		protected override void OnClick(EventArgs e)
		{
			bool flag = base.DialogResult == DialogResult.Yes;
			if (flag)
			{
				bool beepSounds = this._BeepSounds;
				if (beepSounds)
				{
					SystemSounds.Beep.Play();
				}
			}
			base.OnClick(e);
		}

		protected override void OnMouseEnter(EventArgs e)
		{
			bool paintYes = this._PaintYes;
			if (paintYes)
			{
				this.BackColor = Color.FromArgb(68, 157, 68);
			}
			else
			{
				bool paintNo = this._PaintNo;
				if (paintNo)
				{
					this.BackColor = Color.FromArgb(197, 0, 0);
					this.ForeColor = Color.White;
				}
				else
				{
					bool paintOthers = this._PaintOthers;
					if (paintOthers)
					{
						this.BackColor = Color.FromArgb(24, 125, 57);
					}
				}
			}
			base.OnMouseEnter(e);
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			bool paintYes = this._PaintYes;
			if (paintYes)
			{
				this.BackColor = Color.FromArgb(92, 184, 92);
			}
			else
			{
				bool paintNo = this._PaintNo;
				if (paintNo)
				{
					this.BackColor = Color.White;
					this.ForeColor = Color.Black;
				}
				else
				{
					bool paintOthers = this._PaintOthers;
					if (paintOthers)
					{
						this.BackColor = Color.FromArgb(3, 162, 55);
					}
				}
			}
			base.OnMouseLeave(e);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000022B8 File Offset: 0x000004B8
		protected override void OnCreateControl()
		{
			this.Font = new Font("IRANSans Light", 11f, FontStyle.Regular);
			bool paintYes = this._PaintYes;
			if (paintYes)
			{
				this.BackColor = Color.FromArgb(3, 162, 55);
				this.ForeColor = Color.White;
				base.FlatStyle = FlatStyle.Standard;
			}
			else
			{
				bool paintNo = this._PaintNo;
				if (paintNo)
				{
					this.BackColor = Color.White;
					this.ForeColor = Color.Black;
					base.FlatStyle = FlatStyle.Standard;
				}
				else
				{
					bool paintOthers = this._PaintOthers;
					if (paintOthers)
					{
						this.BackColor = Color.FromArgb(92, 184, 92);
						this.ForeColor = Color.White;
						base.FlatStyle = FlatStyle.Standard;
					}
				}
			}
			base.OnCreateControl();
		}

		
		private bool _settingChange = true;

		private bool _BeepSounds = true;

		private bool _PaintCurves = false;

		private bool _PaintYes = false;

		private bool _PaintNo = false;

		private bool _PaintOthers = false;
	}
}
