namespace CharCodeComponents
{
    partial class CharCodePasswordTextBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxPassword = new CharCodeComponents.CharCodeTextBox();
            this.ButtonShowPassword = new CharCodeComponents.CharCodeButton();
            this.SuspendLayout();
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxPassword.Font = new System.Drawing.Font("BenyaminNum", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TextBoxPassword.Location = new System.Drawing.Point(0, 0);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.settingChange = true;
            this.TextBoxPassword.Size = new System.Drawing.Size(265, 65);
            this.TextBoxPassword.TabIndex = 0;
            this.TextBoxPassword.UseSystemPasswordChar = true;
            // 
            // ButtonShowPassword
            // 
            this.ButtonShowPassword.BackColor = System.Drawing.Color.White;
            this.ButtonShowPassword.BackgroundImage = global::CharCodeComponents.Properties.Resources.hidden_and_invisible_;
            this.ButtonShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonShowPassword.BeepSounds = true;
            this.ButtonShowPassword.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonShowPassword.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonShowPassword.FlatAppearance.BorderSize = 0;
            this.ButtonShowPassword.Font = new System.Drawing.Font("IRANSans Light", 11F);
            this.ButtonShowPassword.Location = new System.Drawing.Point(265, 0);
            this.ButtonShowPassword.Name = "ButtonShowPassword";
            this.ButtonShowPassword.PaintCurves = false;
            this.ButtonShowPassword.PaintNo = false;
            this.ButtonShowPassword.PaintOthers = false;
            this.ButtonShowPassword.PaintYes = false;
            this.ButtonShowPassword.settingChange = true;
            this.ButtonShowPassword.Size = new System.Drawing.Size(79, 65);
            this.ButtonShowPassword.TabIndex = 1;
            this.ButtonShowPassword.UseVisualStyleBackColor = false;
            this.ButtonShowPassword.Click += new System.EventHandler(this.ButtonShowPassword_Click);
            // 
            // CharCodePasswordTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.ButtonShowPassword);
            this.Name = "CharCodePasswordTextBox";
            this.Size = new System.Drawing.Size(344, 65);
            this.ResumeLayout(false);

        }

        #endregion
        private CharCodeTextBox TextBoxPassword;
        private CharCodeButton ButtonShowPassword;
    }
}
