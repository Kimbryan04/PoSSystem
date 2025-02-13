namespace WindowsFormsApp2
{
    partial class Cashier
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblusername = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.dvgCashier = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdd = new System.Windows.Forms.DataGridViewImageColumn();
            this.colReduce = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.labeltimer = new System.Windows.Forms.Label();
            this.lblvatable = new System.Windows.Forms.Label();
            this.lblvat = new System.Windows.Forms.Label();
            this.lbldisc = new System.Windows.Forms.Label();
            this.lblsalestotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltransno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labeldisplaytotal = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.slider = new System.Windows.Forms.Panel();
            this.btnlog = new System.Windows.Forms.Button();
            this.btnchangepass = new System.Windows.Forms.Button();
            this.btnsales = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsettle = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btntransact = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCashier)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.White;
            this.lblusername.Location = new System.Drawing.Point(55, 120);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(83, 20);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "Username";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.lblusername);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 157);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.dvgCashier);
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Controls.Add(this.panelTitle);
            this.panelMain.Controls.Add(this.panel4);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(215, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(985, 700);
            this.panelMain.TabIndex = 5;
            // 
            // dvgCashier
            // 
            this.dvgCashier.AllowUserToAddRows = false;
            this.dvgCashier.BackgroundColor = System.Drawing.Color.White;
            this.dvgCashier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCashier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgCashier.ColumnHeadersHeight = 30;
            this.dvgCashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgCashier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.colAdd,
            this.colReduce,
            this.Delete});
            this.dvgCashier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgCashier.EnableHeadersVisualStyles = false;
            this.dvgCashier.GridColor = System.Drawing.Color.DarkGray;
            this.dvgCashier.Location = new System.Drawing.Point(10, 66);
            this.dvgCashier.Name = "dvgCashier";
            this.dvgCashier.RowHeadersVisible = false;
            this.dvgCashier.Size = new System.Drawing.Size(765, 634);
            this.dvgCashier.TabIndex = 7;
            this.dvgCashier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCashier_CellContentClick);
            this.dvgCashier.SelectionChanged += new System.EventHandler(this.dvgCashier_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "No.";
            this.Column1.Name = "Column1";
            this.Column1.Width = 59;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "Id";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            this.Column9.Width = 49;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Pcode";
            this.Column2.Name = "Column2";
            this.Column2.Width = 83;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.HeaderText = "Price";
            this.Column5.Name = "Column5";
            this.Column5.Width = 71;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column6.HeaderText = "Qty";
            this.Column6.Name = "Column6";
            this.Column6.Width = 60;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Discount";
            this.Column7.Name = "Column7";
            this.Column7.Width = 97;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "Total";
            this.Column8.Name = "Column8";
            this.Column8.Width = 67;
            // 
            // colAdd
            // 
            this.colAdd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAdd.HeaderText = "";
            this.colAdd.Image = ((System.Drawing.Image)(resources.GetObject("colAdd.Image")));
            this.colAdd.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colAdd.Name = "colAdd";
            this.colAdd.Width = 5;
            // 
            // colReduce
            // 
            this.colReduce.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colReduce.HeaderText = "";
            this.colReduce.Image = ((System.Drawing.Image)(resources.GetObject("colReduce.Image")));
            this.colReduce.Name = "colReduce";
            this.colReduce.Width = 5;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.Width = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtqty);
            this.panel3.Controls.Add(this.labeltimer);
            this.panel3.Controls.Add(this.lblvatable);
            this.panel3.Controls.Add(this.lblvat);
            this.panel3.Controls.Add(this.lbldisc);
            this.panel3.Controls.Add(this.lblsalestotal);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lbldate);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lbltransno);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.labeldisplaytotal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(775, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 634);
            this.panel3.TabIndex = 6;
            // 
            // txtqty
            // 
            this.txtqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtqty.Location = new System.Drawing.Point(144, 250);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(40, 26);
            this.txtqty.TabIndex = 16;
            this.txtqty.Text = "1";
            this.txtqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labeltimer
            // 
            this.labeltimer.BackColor = System.Drawing.Color.DarkCyan;
            this.labeltimer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labeltimer.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltimer.ForeColor = System.Drawing.Color.White;
            this.labeltimer.Location = new System.Drawing.Point(0, 572);
            this.labeltimer.Name = "labeltimer";
            this.labeltimer.Size = new System.Drawing.Size(210, 62);
            this.labeltimer.TabIndex = 15;
            this.labeltimer.Text = "00:00:00";
            this.labeltimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblvatable
            // 
            this.lblvatable.AutoSize = true;
            this.lblvatable.Location = new System.Drawing.Point(101, 465);
            this.lblvatable.Name = "lblvatable";
            this.lblvatable.Size = new System.Drawing.Size(37, 20);
            this.lblvatable.TabIndex = 14;
            this.lblvatable.Text = "0.00";
            // 
            // lblvat
            // 
            this.lblvat.AutoSize = true;
            this.lblvat.Location = new System.Drawing.Point(101, 428);
            this.lblvat.Name = "lblvat";
            this.lblvat.Size = new System.Drawing.Size(37, 20);
            this.lblvat.TabIndex = 13;
            this.lblvat.Text = "0.00";
            // 
            // lbldisc
            // 
            this.lbldisc.AutoSize = true;
            this.lbldisc.Location = new System.Drawing.Point(101, 392);
            this.lbldisc.Name = "lbldisc";
            this.lbldisc.Size = new System.Drawing.Size(37, 20);
            this.lbldisc.TabIndex = 12;
            this.lbldisc.Text = "0.00";
            // 
            // lblsalestotal
            // 
            this.lblsalestotal.AutoSize = true;
            this.lblsalestotal.Location = new System.Drawing.Point(101, 359);
            this.lblsalestotal.Name = "lblsalestotal";
            this.lblsalestotal.Size = new System.Drawing.Size(37, 20);
            this.lblsalestotal.TabIndex = 11;
            this.lblsalestotal.Text = "0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 464);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "VATable :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(53, 427);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "VAT :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Discount :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Sales Total :";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(20, 250);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Barcode";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(16, 177);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(73, 20);
            this.lbldate.TabIndex = 4;
            this.lbldate.Text = "00000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Date";
            // 
            // lbltransno
            // 
            this.lbltransno.AutoSize = true;
            this.lbltransno.Location = new System.Drawing.Point(16, 107);
            this.lbltransno.Name = "lbltransno";
            this.lbltransno.Size = new System.Drawing.Size(121, 20);
            this.lbltransno.TabIndex = 2;
            this.lbltransno.Text = "00000000000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Transaction No";
            // 
            // labeldisplaytotal
            // 
            this.labeldisplaytotal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labeldisplaytotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.labeldisplaytotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldisplaytotal.ForeColor = System.Drawing.Color.White;
            this.labeldisplaytotal.Location = new System.Drawing.Point(0, 0);
            this.labeldisplaytotal.Name = "labeldisplaytotal";
            this.labeldisplaytotal.Size = new System.Drawing.Size(210, 30);
            this.labeldisplaytotal.TabIndex = 0;
            this.labeldisplaytotal.Text = "0.00";
            this.labeldisplaytotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labeldisplaytotal.Click += new System.EventHandler(this.labeldisplaytotal_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelTitle.Controls.Add(this.pictureBox2);
            this.panelTitle.Controls.Add(this.lbltitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(10, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(975, 66);
            this.panelTitle.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(937, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(22, 18);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(170, 25);
            this.lbltitle.TabIndex = 2;
            this.lbltitle.Text = "Name and Role ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 700);
            this.panel4.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.slider);
            this.panel1.Controls.Add(this.btnlog);
            this.panel1.Controls.Add(this.btnchangepass);
            this.panel1.Controls.Add(this.btnsales);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.btnsettle);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.btntransact);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 700);
            this.panel1.TabIndex = 3;
            // 
            // slider
            // 
            this.slider.Location = new System.Drawing.Point(205, 157);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(10, 53);
            this.slider.TabIndex = 7;
            this.slider.Paint += new System.Windows.Forms.PaintEventHandler(this.slider_Paint);
            // 
            // btnlog
            // 
            this.btnlog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnlog.FlatAppearance.BorderSize = 0;
            this.btnlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlog.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlog.ForeColor = System.Drawing.Color.White;
            this.btnlog.Location = new System.Drawing.Point(0, 647);
            this.btnlog.Name = "btnlog";
            this.btnlog.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnlog.Size = new System.Drawing.Size(215, 53);
            this.btnlog.TabIndex = 40;
            this.btnlog.Text = "Logout";
            this.btnlog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlog.UseVisualStyleBackColor = true;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // btnchangepass
            // 
            this.btnchangepass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnchangepass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnchangepass.FlatAppearance.BorderSize = 0;
            this.btnchangepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchangepass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchangepass.ForeColor = System.Drawing.Color.White;
            this.btnchangepass.Location = new System.Drawing.Point(0, 475);
            this.btnchangepass.Name = "btnchangepass";
            this.btnchangepass.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnchangepass.Size = new System.Drawing.Size(215, 53);
            this.btnchangepass.TabIndex = 39;
            this.btnchangepass.Text = "Change Password";
            this.btnchangepass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnchangepass.UseVisualStyleBackColor = true;
            this.btnchangepass.Click += new System.EventHandler(this.btnchangepass_Click);
            // 
            // btnsales
            // 
            this.btnsales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsales.FlatAppearance.BorderSize = 0;
            this.btnsales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsales.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsales.ForeColor = System.Drawing.Color.White;
            this.btnsales.Location = new System.Drawing.Point(0, 422);
            this.btnsales.Name = "btnsales";
            this.btnsales.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnsales.Size = new System.Drawing.Size(215, 53);
            this.btnsales.TabIndex = 37;
            this.btnsales.Text = "Daily Sales";
            this.btnsales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsales.UseVisualStyleBackColor = true;
            this.btnsales.Click += new System.EventHandler(this.btnsales_Click);
            // 
            // btnclear
            // 
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnclear.FlatAppearance.BorderSize = 0;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(0, 369);
            this.btnclear.Name = "btnclear";
            this.btnclear.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnclear.Size = new System.Drawing.Size(215, 53);
            this.btnclear.TabIndex = 36;
            this.btnclear.Text = "Clear Cart";
            this.btnclear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsettle
            // 
            this.btnsettle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsettle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsettle.FlatAppearance.BorderSize = 0;
            this.btnsettle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsettle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsettle.ForeColor = System.Drawing.Color.White;
            this.btnsettle.Location = new System.Drawing.Point(0, 316);
            this.btnsettle.Name = "btnsettle";
            this.btnsettle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnsettle.Size = new System.Drawing.Size(215, 53);
            this.btnsettle.TabIndex = 35;
            this.btnsettle.Text = "Settle Payment";
            this.btnsettle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsettle.UseVisualStyleBackColor = true;
            this.btnsettle.Click += new System.EventHandler(this.btnsettle_Click);
            // 
            // btnadd
            // 
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(0, 263);
            this.btnadd.Name = "btnadd";
            this.btnadd.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnadd.Size = new System.Drawing.Size(215, 53);
            this.btnadd.TabIndex = 34;
            this.btnadd.Text = "Add Discount";
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(0, 210);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnsearch.Size = new System.Drawing.Size(215, 53);
            this.btnsearch.TabIndex = 33;
            this.btnsearch.Text = "Search Product";
            this.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btntransact
            // 
            this.btntransact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntransact.Dock = System.Windows.Forms.DockStyle.Top;
            this.btntransact.FlatAppearance.BorderSize = 0;
            this.btntransact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntransact.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntransact.ForeColor = System.Drawing.Color.White;
            this.btntransact.Location = new System.Drawing.Point(0, 157);
            this.btntransact.Name = "btntransact";
            this.btntransact.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btntransact.Size = new System.Drawing.Size(215, 53);
            this.btntransact.TabIndex = 32;
            this.btntransact.Text = "New Transaction";
            this.btntransact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntransact.UseVisualStyleBackColor = true;
            this.btntransact.Click += new System.EventHandler(this.btntransact_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCashier)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnchangepass;
        private System.Windows.Forms.Button btnsales;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsettle;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btntransact;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelTitle;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.Panel slider;
        private System.Windows.Forms.Label labeldisplaytotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labeltimer;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblusername;
        public System.Windows.Forms.Label lbltransno;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox txtqty;
        public System.Windows.Forms.DataGridView dvgCashier;
        public System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn colAdd;
        private System.Windows.Forms.DataGridViewImageColumn colReduce;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        public System.Windows.Forms.Label lblvatable;
        public System.Windows.Forms.Label lblvat;
        public System.Windows.Forms.Label lbldisc;
        public System.Windows.Forms.Label lblsalestotal;
    }
}