namespace CharCodeComponents.Forms
{
    partial class UMessageBox
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new CharCodeComponents.CharCodeLabel();
            this.PanelSym = new System.Windows.Forms.Panel();
            this.PicAlert = new System.Windows.Forms.PictureBox();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Behnam", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.settingChange = true;
            this.label1.Size = new System.Drawing.Size(448, 86);
            this.label1.TabIndex = 4;
            // 
            // PanelSym
            // 
            this.PanelSym.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelSym.Location = new System.Drawing.Point(518, 0);
            this.PanelSym.Name = "PanelSym";
            this.PanelSym.Size = new System.Drawing.Size(10, 148);
            this.PanelSym.TabIndex = 7;
            // 
            // PicAlert
            // 
            this.PicAlert.Image = global::CharCodeComponents.Properties.Resources.no_success_icon3;
            this.PicAlert.Location = new System.Drawing.Point(466, 12);
            this.PicAlert.Name = "PicAlert";
            this.PicAlert.Size = new System.Drawing.Size(46, 42);
            this.PicAlert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicAlert.TabIndex = 5;
            this.PicAlert.TabStop = false;
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.Black;
            this.buttonOk.FlatAppearance.BorderSize = 0;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Font = new System.Drawing.Font("Behnam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonOk.ForeColor = System.Drawing.Color.White;
            this.buttonOk.Location = new System.Drawing.Point(206, 107);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(107, 34);
            this.buttonOk.TabIndex = 8;
            this.buttonOk.Text = "تایید";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // UMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(528, 148);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.PanelSym);
            this.Controls.Add(this.PicAlert);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UMessageBox";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UMessageBox_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UMessageBox_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PicAlert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CharCodeLabel label1;
        private System.Windows.Forms.PictureBox PicAlert;
        private System.Windows.Forms.Panel PanelSym;
        private System.Windows.Forms.Button buttonOk;
    }
}