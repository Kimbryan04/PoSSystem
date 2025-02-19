namespace WindowsFormsApp2
{
    partial class CancelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelForm));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblid = new System.Windows.Forms.Label();
            this.lblpcode = new System.Windows.Forms.Label();
            this.lbldesc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtpcode = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txttransno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtdisc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcancel = new System.Windows.Forms.TextBox();
            this.txtvoidby = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboaddinv = new System.Windows.Forms.ComboBox();
            this.txtreason = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.cancelqty = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cancelqty)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cancel Order Detail";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(884, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 54);
            this.panel1.TabIndex = 9;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(116, 127);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(32, 20);
            this.lblid.TabIndex = 10;
            this.lblid.Text = "Id :";
            // 
            // lblpcode
            // 
            this.lblpcode.AutoSize = true;
            this.lblpcode.Location = new System.Drawing.Point(27, 170);
            this.lblpcode.Name = "lblpcode";
            this.lblpcode.Size = new System.Drawing.Size(121, 20);
            this.lblpcode.TabIndex = 11;
            this.lblpcode.Text = "Product Code :";
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Location = new System.Drawing.Point(49, 216);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(99, 20);
            this.lbldesc.TabIndex = 12;
            this.lbldesc.Text = "Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "SOLD ITEM(S)";
            // 
            // txtid
            // 
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(162, 125);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(190, 26);
            this.txtid.TabIndex = 13;
            // 
            // txtpcode
            // 
            this.txtpcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpcode.Enabled = false;
            this.txtpcode.Location = new System.Drawing.Point(162, 168);
            this.txtpcode.Name = "txtpcode";
            this.txtpcode.Size = new System.Drawing.Size(190, 26);
            this.txtpcode.TabIndex = 14;
            // 
            // txtdesc
            // 
            this.txtdesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdesc.Enabled = false;
            this.txtdesc.Location = new System.Drawing.Point(162, 215);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(190, 76);
            this.txtdesc.TabIndex = 15;
            // 
            // txtprice
            // 
            this.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprice.Enabled = false;
            this.txtprice.Location = new System.Drawing.Point(538, 171);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(321, 26);
            this.txtprice.TabIndex = 19;
            // 
            // txttransno
            // 
            this.txttransno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttransno.Enabled = false;
            this.txttransno.Location = new System.Drawing.Point(537, 124);
            this.txttransno.Name = "txttransno";
            this.txttransno.Size = new System.Drawing.Size(322, 26);
            this.txttransno.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Transaction No. :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Total :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Qty / Discount :";
            // 
            // txtqty
            // 
            this.txtqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtqty.Enabled = false;
            this.txtqty.Location = new System.Drawing.Point(538, 218);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(155, 26);
            this.txtqty.TabIndex = 22;
            // 
            // txttotal
            // 
            this.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(538, 260);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(321, 26);
            this.txttotal.TabIndex = 24;
            // 
            // txtdisc
            // 
            this.txtdisc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdisc.Enabled = false;
            this.txtdisc.Location = new System.Drawing.Point(699, 217);
            this.txtdisc.Name = "txtdisc";
            this.txtdisc.Size = new System.Drawing.Size(160, 26);
            this.txtdisc.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(19, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 23);
            this.label7.TabIndex = 26;
            this.label7.Text = "CANCEL ITEM(S)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Add To Inventory ?";
            // 
            // txtcancel
            // 
            this.txtcancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcancel.Enabled = false;
            this.txtcancel.Location = new System.Drawing.Point(165, 415);
            this.txtcancel.Name = "txtcancel";
            this.txtcancel.Size = new System.Drawing.Size(213, 26);
            this.txtcancel.TabIndex = 30;
            // 
            // txtvoidby
            // 
            this.txtvoidby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtvoidby.Location = new System.Drawing.Point(165, 370);
            this.txtvoidby.Name = "txtvoidby";
            this.txtvoidby.Size = new System.Drawing.Size(214, 26);
            this.txtvoidby.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Cancel By :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(84, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Void By :";
            // 
            // cboaddinv
            // 
            this.cboaddinv.FormattingEnabled = true;
            this.cboaddinv.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboaddinv.Location = new System.Drawing.Point(165, 454);
            this.cboaddinv.Name = "cboaddinv";
            this.cboaddinv.Size = new System.Drawing.Size(214, 28);
            this.cboaddinv.TabIndex = 32;
            this.cboaddinv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboaddinv_KeyPress);
            // 
            // txtreason
            // 
            this.txtreason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtreason.Location = new System.Drawing.Point(537, 415);
            this.txtreason.Multiline = true;
            this.txtreason.Name = "txtreason";
            this.txtreason.Size = new System.Drawing.Size(322, 76);
            this.txtreason.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(454, 413);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "Reasons :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(430, 368);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 20);
            this.label12.TabIndex = 33;
            this.label12.Text = "Cancel Qty :";
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCancelOrder.ForeColor = System.Drawing.Color.White;
            this.btnCancelOrder.Location = new System.Drawing.Point(737, 529);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(122, 37);
            this.btnCancelOrder.TabIndex = 37;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // cancelqty
            // 
            this.cancelqty.Location = new System.Drawing.Point(537, 365);
            this.cancelqty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cancelqty.Name = "cancelqty";
            this.cancelqty.Size = new System.Drawing.Size(321, 26);
            this.cancelqty.TabIndex = 38;
            this.cancelqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CancelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 578);
            this.Controls.Add(this.cancelqty);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.txtreason);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboaddinv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcancel);
            this.Controls.Add(this.txtvoidby);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdisc);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txttransno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.txtpcode);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbldesc);
            this.Controls.Add(this.lblpcode);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CancelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CancelForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cancelqty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblpcode;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCancelOrder;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.TextBox txtpcode;
        public System.Windows.Forms.TextBox txtdesc;
        public System.Windows.Forms.TextBox txtprice;
        public System.Windows.Forms.TextBox txttransno;
        public System.Windows.Forms.TextBox txtqty;
        public System.Windows.Forms.TextBox txttotal;
        public System.Windows.Forms.TextBox txtdisc;
        public System.Windows.Forms.TextBox txtcancel;
        public System.Windows.Forms.TextBox txtvoidby;
        public System.Windows.Forms.ComboBox cboaddinv;
        public System.Windows.Forms.TextBox txtreason;
        public System.Windows.Forms.NumericUpDown cancelqty;
    }
}