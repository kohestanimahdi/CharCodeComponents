using System.Drawing;
using System.Windows.Forms;

namespace Components
{
    class CharCodeGrid : DataGridView
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
		}

		public CharCodeGrid()
		{
			base.ColumnHeadersDefaultCellStyle.Font = new Font("Behnam", 10.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
			base.DefaultCellStyle.Font = new Font("BenyaminNum", 12.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
			this.RightToLeft = RightToLeft.Yes;
			base.RowHeadersVisible = false;
			base.RowTemplate.Height = 46;
			base.BackgroundColor = SystemColors.Control;
			base.MultiSelect = false;
			base.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			base.AllowUserToAddRows = false;
			base.AllowUserToResizeRows = false;
			base.AllowUserToDeleteRows = false;
			base.AllowUserToResizeColumns = true;
			base.ReadOnly = true;
		}

		private bool _settingChange = true;
	}
}
