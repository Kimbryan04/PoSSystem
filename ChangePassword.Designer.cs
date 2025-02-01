namespace WindowsFormsApp2
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.btnNext = new System.Windows.Forms.Button();
            this.txtcurpass = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtnewpass = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtConpass = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Green;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(396, 282);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 47);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtcurpass
            // 
            // 
            // 
            // 
            this.txtcurpass.CustomButton.Image = null;
            this.txtcurpass.CustomButton.Location = new System.Drawing.Point(224, 2);
            this.txtcurpass.CustomButton.Name = "";
            this.txtcurpass.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtcurpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtcurpass.CustomButton.TabIndex = 1;
            this.txtcurpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcurpass.CustomButton.UseSelectable = true;
            this.txtcurpass.CustomButton.Visible = false;
            this.txtcurpass.DisplayIcon = true;
            this.txtcurpass.Icon = ((System.Drawing.Image)(resources.GetObject("txtcurpass.Icon")));
            this.txtcurpass.Lines = new string[0];
            this.txtcurpass.Location = new System.Drawing.Point(144, 166);
            this.txtcurpass.MaxLength = 32767;
            this.txtcurpass.Name = "txtcurpass";
            this.txtcurpass.PasswordChar = '●';
            this.txtcurpass.PromptText = "Current Password";
            this.txtcurpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcurpass.SelectedText = "";
            this.txtcurpass.SelectionLength = 0;
            this.txtcurpass.SelectionStart = 0;
            this.txtcurpass.ShortcutsEnabled = true;
            this.txtcurpass.Size = new System.Drawing.Size(250, 28);
            this.txtcurpass.TabIndex = 17;
            this.txtcurpass.UseSelectable = true;
            this.txtcurpass.WaterMark = "Current Password";
            this.txtcurpass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcurpass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 54);
            this.panel1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Change Password Form";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(499, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtnewpass
            // 
            // 
            // 
            // 
            this.txtnewpass.CustomButton.Image = null;
            this.txtnewpass.CustomButton.Location = new System.Drawing.Point(224, 2);
            this.txtnewpass.CustomButton.Name = "";
            this.txtnewpass.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtnewpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtnewpass.CustomButton.TabIndex = 1;
            this.txtnewpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtnewpass.CustomButton.UseSelectable = true;
            this.txtnewpass.CustomButton.Visible = false;
            this.txtnewpass.DisplayIcon = true;
            this.txtnewpass.Icon = ((System.Drawing.Image)(resources.GetObject("txtnewpass.Icon")));
            this.txtnewpass.Lines = new string[0];
            this.txtnewpass.Location = new System.Drawing.Point(144, 166);
            this.txtnewpass.MaxLength = 32767;
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.PasswordChar = '●';
            this.txtnewpass.PromptText = "New Password";
            this.txtnewpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtnewpass.SelectedText = "";
            this.txtnewpass.SelectionLength = 0;
            this.txtnewpass.SelectionStart = 0;
            this.txtnewpass.ShortcutsEnabled = true;
            this.txtnewpass.Size = new System.Drawing.Size(250, 28);
            this.txtnewpass.TabIndex = 19;
            this.txtnewpass.UseSelectable = true;
            this.txtnewpass.Visible = false;
            this.txtnewpass.WaterMark = "New Password";
            this.txtnewpass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtnewpass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(51, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(151, 93);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(146, 32);
            this.lblusername.TabIndex = 21;
            this.lblusername.Text = "Username";
            // 
            // txtConpass
            // 
            // 
            // 
            // 
            this.txtConpass.CustomButton.Image = null;
            this.txtConpass.CustomButton.Location = new System.Drawing.Point(224, 2);
            this.txtConpass.CustomButton.Name = "";
            this.txtConpass.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtConpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConpass.CustomButton.TabIndex = 1;
            this.txtConpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConpass.CustomButton.UseSelectable = true;
            this.txtConpass.CustomButton.Visible = false;
            this.txtConpass.DisplayIcon = true;
            this.txtConpass.Icon = ((System.Drawing.Image)(resources.GetObject("txtConpass.Icon")));
            this.txtConpass.Lines = new string[0];
            this.txtConpass.Location = new System.Drawing.Point(144, 218);
            this.txtConpass.MaxLength = 32767;
            this.txtConpass.Name = "txtConpass";
            this.txtConpass.PasswordChar = '●';
            this.txtConpass.PromptText = "Confirm Password";
            this.txtConpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConpass.SelectedText = "";
            this.txtConpass.SelectionLength = 0;
            this.txtConpass.SelectionStart = 0;
            this.txtConpass.ShortcutsEnabled = true;
            this.txtConpass.Size = new System.Drawing.Size(250, 28);
            this.txtConpass.TabIndex = 22;
            this.txtConpass.UseSelectable = true;
            this.txtConpass.Visible = false;
            this.txtConpass.WaterMark = "Confirm Password";
            this.txtConpass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConpass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(396, 282);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 47);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 350);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtConpass);
            this.Controls.Add(this.txtcurpass);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtnewpass);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        public MetroFramework.Controls.MetroTextBox txtcurpass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pictureBox1;
        public MetroFramework.Controls.MetroTextBox txtnewpass;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblusername;
        public MetroFramework.Controls.MetroTextBox txtConpass;
        private System.Windows.Forms.Button btnSave;
    }
}