using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Components
{
    class CharCodeNumberTextBox:TextBox
    {
		public bool useSeprator
		{
			get
			{
				return this._useSeprator;
			}
			set
			{
				this._useSeprator = value;
			}
		}
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

		private void setsetting()
		{
			this.Font = new Font("BenyaminNum", 13f, FontStyle.Regular, GraphicsUnit.Point, 178);
			base.Width = 120;
			base.Height = 30;
			this.AutoSize = false;
		}

		public CharCodeNumberTextBox()
		{
			this.setsetting();
		}

		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			bool flag = char.IsDigit(e.KeyChar) || e.KeyChar == '\b';
			if (flag)
			{
				e.Handled = false;
			}
			else
			{
				bool flag2 = e.KeyChar == ' ';
				if (flag2)
				{
					long num;
					bool flag3 = long.TryParse(this.Text.Replace(",", ""), out num);
					if (flag3)
					{
						this.Text = (num * 1000L).ToString();
					}
					e.Handled = true;
				}
				else
				{
					e.Handled = true;
				}
			}
			base.OnKeyPress(e);
		}

		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			if (useSeprator)
			{
				try
				{
					long num = 0L;
					bool flag = long.TryParse(this.Text.Replace(",", ""), out num);
					if (flag)
					{
						this.Text = string.Format("{0:N0}", num);
						base.SelectionStart = this.Text.Length;
					}
				}
				catch
				{
				}
			}
		}

		public long GetInt64
		{
			get
			{
				long result;
				long.TryParse(this.GetText, out result);
				return result;
			}
		}

		public int GetInt
		{
			get
			{
				int result;
				int.TryParse(this.GetText, out result);
				return result;
			}
		}

		public string GetText
		{
			get
			{
				return this.Text.Replace(",", "");
			}
		}

		private void SetObjectProperty(string propertyName, string value, object obj)
		{
			PropertyInfo property = obj.GetType().GetProperty(propertyName);
			bool flag = property != null;
			if (flag)
			{
				property.SetValue(obj, value, null);
			}
		}

		private bool _settingChange = true;
        private bool _useSeprator = true;
    }
}
