namespace WindowsFormsApp2
{
    partial class Reset_Password
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
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtRpnew = new System.Windows.Forms.TextBox();
            this.txtRpCon = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(42, 54);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(126, 20);
            this.label.TabIndex = 0;
            this.label.Text = "New Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirm Password :";
            // 
            // txtRpnew
            // 
            this.txtRpnew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRpnew.Location = new System.Drawing.Point(173, 53);
            this.txtRpnew.Name = "txtRpnew";
            this.txtRpnew.Size = new System.Drawing.Size(321, 26);
            this.txtRpnew.TabIndex = 2;
            this.txtRpnew.UseSystemPasswordChar = true;
            // 
            // txtRpCon
            // 
            this.txtRpCon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRpCon.Location = new System.Drawing.Point(173, 100);
            this.txtRpCon.Name = "txtRpCon";
            this.txtRpCon.Size = new System.Drawing.Size(321, 26);
            this.txtRpCon.TabIndex = 3;
            this.txtRpCon.UseSystemPasswordChar = true;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.DarkGray;
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(398, 147);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(96, 47);
            this.btncancel.TabIndex = 15;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Green;
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(293, 147);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(99, 47);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Reset_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(526, 204);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtRpCon);
            this.Controls.Add(this.txtRpnew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Reset_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESET PASSWORD";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Reset_Password_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtRpnew;
        private System.Windows.Forms.TextBox txtRpCon;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnOk;
    }
}