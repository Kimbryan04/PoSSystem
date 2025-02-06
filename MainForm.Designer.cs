namespace WindowsFormsApp2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.SubpanelSetting = new System.Windows.Forms.Panel();
            this.btnstore = new System.Windows.Forms.Button();
            this.btnuser = new System.Windows.Forms.Button();
            this.btnsettings = new System.Windows.Forms.Button();
            this.SubpanelRecord = new System.Windows.Forms.Panel();
            this.btnposrecord = new System.Windows.Forms.Button();
            this.btnsaleshistory = new System.Windows.Forms.Button();
            this.btnrecord = new System.Windows.Forms.Button();
            this.btnsupplier = new System.Windows.Forms.Button();
            this.SubpanelInstock = new System.Windows.Forms.Panel();
            this.btnstockadj = new System.Windows.Forms.Button();
            this.btnstockentry = new System.Windows.Forms.Button();
            this.btninstock = new System.Windows.Forms.Button();
            this.SubPanelProduct = new System.Windows.Forms.Panel();
            this.btnbrand = new System.Windows.Forms.Button();
            this.btncategory = new System.Windows.Forms.Button();
            this.btnproductlist = new System.Windows.Forms.Button();
            this.btnproduct = new System.Windows.Forms.Button();
            this.btndashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SubpanelSetting.SuspendLayout();
            this.SubpanelRecord.SuspendLayout();
            this.SubpanelInstock.SuspendLayout();
            this.SubPanelProduct.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.SubpanelSetting);
            this.panel1.Controls.Add(this.btnsettings);
            this.panel1.Controls.Add(this.SubpanelRecord);
            this.panel1.Controls.Add(this.btnrecord);
            this.panel1.Controls.Add(this.btnsupplier);
            this.panel1.Controls.Add(this.SubpanelInstock);
            this.panel1.Controls.Add(this.btninstock);
            this.panel1.Controls.Add(this.SubPanelProduct);
            this.panel1.Controls.Add(this.btnproduct);
            this.panel1.Controls.Add(this.btndashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 661);
            this.panel1.TabIndex = 0;
            // 
            // btnlogout
            // 
            this.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Location = new System.Drawing.Point(0, 934);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnlogout.Size = new System.Drawing.Size(197, 53);
            this.btnlogout.TabIndex = 31;
            this.btnlogout.Text = "Logout";
            this.btnlogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // SubpanelSetting
            // 
            this.SubpanelSetting.Controls.Add(this.btnstore);
            this.SubpanelSetting.Controls.Add(this.btnuser);
            this.SubpanelSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubpanelSetting.Location = new System.Drawing.Point(0, 828);
            this.SubpanelSetting.Name = "SubpanelSetting";
            this.SubpanelSetting.Size = new System.Drawing.Size(197, 106);
            this.SubpanelSetting.TabIndex = 29;
            // 
            // btnstore
            // 
            this.btnstore.BackColor = System.Drawing.Color.DarkCyan;
            this.btnstore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnstore.FlatAppearance.BorderSize = 0;
            this.btnstore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstore.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstore.ForeColor = System.Drawing.Color.White;
            this.btnstore.Location = new System.Drawing.Point(0, 53);
            this.btnstore.Name = "btnstore";
            this.btnstore.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnstore.Size = new System.Drawing.Size(197, 53);
            this.btnstore.TabIndex = 31;
            this.btnstore.Text = "Store";
            this.btnstore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstore.UseVisualStyleBackColor = false;
            this.btnstore.Click += new System.EventHandler(this.btnstore_Click);
            // 
            // btnuser
            // 
            this.btnuser.BackColor = System.Drawing.Color.DarkCyan;
            this.btnuser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnuser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnuser.FlatAppearance.BorderSize = 0;
            this.btnuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuser.ForeColor = System.Drawing.Color.White;
            this.btnuser.Location = new System.Drawing.Point(0, 0);
            this.btnuser.Name = "btnuser";
            this.btnuser.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnuser.Size = new System.Drawing.Size(197, 53);
            this.btnuser.TabIndex = 30;
            this.btnuser.Text = "User";
            this.btnuser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnuser.UseVisualStyleBackColor = false;
            this.btnuser.Click += new System.EventHandler(this.btnuser_Click);
            // 
            // btnsettings
            // 
            this.btnsettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsettings.FlatAppearance.BorderSize = 0;
            this.btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsettings.ForeColor = System.Drawing.Color.White;
            this.btnsettings.Location = new System.Drawing.Point(0, 775);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnsettings.Size = new System.Drawing.Size(197, 53);
            this.btnsettings.TabIndex = 28;
            this.btnsettings.Text = "Setting";
            this.btnsettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsettings.UseVisualStyleBackColor = true;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // SubpanelRecord
            // 
            this.SubpanelRecord.Controls.Add(this.btnposrecord);
            this.SubpanelRecord.Controls.Add(this.btnsaleshistory);
            this.SubpanelRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubpanelRecord.Location = new System.Drawing.Point(0, 669);
            this.SubpanelRecord.Name = "SubpanelRecord";
            this.SubpanelRecord.Size = new System.Drawing.Size(197, 106);
            this.SubpanelRecord.TabIndex = 27;
            // 
            // btnposrecord
            // 
            this.btnposrecord.BackColor = System.Drawing.Color.DarkCyan;
            this.btnposrecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnposrecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnposrecord.FlatAppearance.BorderSize = 0;
            this.btnposrecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnposrecord.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnposrecord.ForeColor = System.Drawing.Color.White;
            this.btnposrecord.Location = new System.Drawing.Point(0, 53);
            this.btnposrecord.Name = "btnposrecord";
            this.btnposrecord.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnposrecord.Size = new System.Drawing.Size(197, 53);
            this.btnposrecord.TabIndex = 28;
            this.btnposrecord.Text = "POS Record";
            this.btnposrecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnposrecord.UseVisualStyleBackColor = false;
            this.btnposrecord.Click += new System.EventHandler(this.btnposrecord_Click);
            // 
            // btnsaleshistory
            // 
            this.btnsaleshistory.BackColor = System.Drawing.Color.DarkCyan;
            this.btnsaleshistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsaleshistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsaleshistory.FlatAppearance.BorderSize = 0;
            this.btnsaleshistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaleshistory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaleshistory.ForeColor = System.Drawing.Color.White;
            this.btnsaleshistory.Location = new System.Drawing.Point(0, 0);
            this.btnsaleshistory.Name = "btnsaleshistory";
            this.btnsaleshistory.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnsaleshistory.Size = new System.Drawing.Size(197, 53);
            this.btnsaleshistory.TabIndex = 27;
            this.btnsaleshistory.Text = "Sales History";
            this.btnsaleshistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsaleshistory.UseVisualStyleBackColor = false;
            this.btnsaleshistory.Click += new System.EventHandler(this.btnsaleshistory_Click);
            // 
            // btnrecord
            // 
            this.btnrecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnrecord.FlatAppearance.BorderSize = 0;
            this.btnrecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrecord.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecord.ForeColor = System.Drawing.Color.White;
            this.btnrecord.Location = new System.Drawing.Point(0, 616);
            this.btnrecord.Name = "btnrecord";
            this.btnrecord.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnrecord.Size = new System.Drawing.Size(197, 53);
            this.btnrecord.TabIndex = 26;
            this.btnrecord.Text = "Record";
            this.btnrecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrecord.UseVisualStyleBackColor = true;
            this.btnrecord.Click += new System.EventHandler(this.btnrecord_Click);
            // 
            // btnsupplier
            // 
            this.btnsupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsupplier.FlatAppearance.BorderSize = 0;
            this.btnsupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupplier.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupplier.ForeColor = System.Drawing.Color.White;
            this.btnsupplier.Location = new System.Drawing.Point(0, 563);
            this.btnsupplier.Name = "btnsupplier";
            this.btnsupplier.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnsupplier.Size = new System.Drawing.Size(197, 53);
            this.btnsupplier.TabIndex = 25;
            this.btnsupplier.Text = "Supplier";
            this.btnsupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsupplier.UseVisualStyleBackColor = true;
            this.btnsupplier.Click += new System.EventHandler(this.btnsupplier_Click);
            // 
            // SubpanelInstock
            // 
            this.SubpanelInstock.Controls.Add(this.btnstockadj);
            this.SubpanelInstock.Controls.Add(this.btnstockentry);
            this.SubpanelInstock.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubpanelInstock.Location = new System.Drawing.Point(0, 457);
            this.SubpanelInstock.Name = "SubpanelInstock";
            this.SubpanelInstock.Size = new System.Drawing.Size(197, 106);
            this.SubpanelInstock.TabIndex = 23;
            // 
            // btnstockadj
            // 
            this.btnstockadj.BackColor = System.Drawing.Color.DarkCyan;
            this.btnstockadj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstockadj.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnstockadj.FlatAppearance.BorderSize = 0;
            this.btnstockadj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstockadj.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstockadj.ForeColor = System.Drawing.Color.White;
            this.btnstockadj.Location = new System.Drawing.Point(0, 53);
            this.btnstockadj.Name = "btnstockadj";
            this.btnstockadj.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnstockadj.Size = new System.Drawing.Size(197, 53);
            this.btnstockadj.TabIndex = 24;
            this.btnstockadj.Text = "Stock Adjustment";
            this.btnstockadj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstockadj.UseVisualStyleBackColor = false;
            this.btnstockadj.Click += new System.EventHandler(this.btnstockadj_Click);
            // 
            // btnstockentry
            // 
            this.btnstockentry.BackColor = System.Drawing.Color.DarkCyan;
            this.btnstockentry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstockentry.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnstockentry.FlatAppearance.BorderSize = 0;
            this.btnstockentry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstockentry.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstockentry.ForeColor = System.Drawing.Color.White;
            this.btnstockentry.Location = new System.Drawing.Point(0, 0);
            this.btnstockentry.Name = "btnstockentry";
            this.btnstockentry.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnstockentry.Size = new System.Drawing.Size(197, 53);
            this.btnstockentry.TabIndex = 23;
            this.btnstockentry.Text = "Stock Entry";
            this.btnstockentry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstockentry.UseVisualStyleBackColor = false;
            this.btnstockentry.Click += new System.EventHandler(this.btnstockentry_Click);
            // 
            // btninstock
            // 
            this.btninstock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninstock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btninstock.FlatAppearance.BorderSize = 0;
            this.btninstock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninstock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninstock.ForeColor = System.Drawing.Color.White;
            this.btninstock.Location = new System.Drawing.Point(0, 404);
            this.btninstock.Name = "btninstock";
            this.btninstock.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btninstock.Size = new System.Drawing.Size(197, 53);
            this.btninstock.TabIndex = 22;
            this.btninstock.Text = "In stock";
            this.btninstock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninstock.UseVisualStyleBackColor = true;
            this.btninstock.Click += new System.EventHandler(this.btninstock_Click);
            // 
            // SubPanelProduct
            // 
            this.SubPanelProduct.Controls.Add(this.btnbrand);
            this.SubPanelProduct.Controls.Add(this.btncategory);
            this.SubPanelProduct.Controls.Add(this.btnproductlist);
            this.SubPanelProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubPanelProduct.Location = new System.Drawing.Point(0, 270);
            this.SubPanelProduct.Name = "SubPanelProduct";
            this.SubPanelProduct.Size = new System.Drawing.Size(197, 134);
            this.SubPanelProduct.TabIndex = 18;
            // 
            // btnbrand
            // 
            this.btnbrand.BackColor = System.Drawing.Color.DarkCyan;
            this.btnbrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnbrand.FlatAppearance.BorderSize = 0;
            this.btnbrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbrand.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrand.ForeColor = System.Drawing.Color.White;
            this.btnbrand.Location = new System.Drawing.Point(0, 94);
            this.btnbrand.Name = "btnbrand";
            this.btnbrand.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnbrand.Size = new System.Drawing.Size(197, 40);
            this.btnbrand.TabIndex = 22;
            this.btnbrand.Text = "Brand";
            this.btnbrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbrand.UseVisualStyleBackColor = false;
            this.btnbrand.Click += new System.EventHandler(this.btnbrand_Click);
            // 
            // btncategory
            // 
            this.btncategory.BackColor = System.Drawing.Color.DarkCyan;
            this.btncategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncategory.FlatAppearance.BorderSize = 0;
            this.btncategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncategory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategory.ForeColor = System.Drawing.Color.White;
            this.btncategory.Location = new System.Drawing.Point(0, 41);
            this.btncategory.Name = "btncategory";
            this.btncategory.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btncategory.Size = new System.Drawing.Size(197, 53);
            this.btncategory.TabIndex = 21;
            this.btncategory.Text = "Category";
            this.btncategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncategory.UseVisualStyleBackColor = false;
            this.btncategory.Click += new System.EventHandler(this.btncategory_Click);
            // 
            // btnproductlist
            // 
            this.btnproductlist.BackColor = System.Drawing.Color.DarkCyan;
            this.btnproductlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnproductlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnproductlist.FlatAppearance.BorderSize = 0;
            this.btnproductlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproductlist.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproductlist.ForeColor = System.Drawing.Color.White;
            this.btnproductlist.Location = new System.Drawing.Point(0, 0);
            this.btnproductlist.Name = "btnproductlist";
            this.btnproductlist.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnproductlist.Size = new System.Drawing.Size(197, 41);
            this.btnproductlist.TabIndex = 20;
            this.btnproductlist.Text = "Product List";
            this.btnproductlist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproductlist.UseVisualStyleBackColor = false;
            this.btnproductlist.Click += new System.EventHandler(this.btnproductlist_Click);
            // 
            // btnproduct
            // 
            this.btnproduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnproduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnproduct.FlatAppearance.BorderSize = 0;
            this.btnproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproduct.ForeColor = System.Drawing.Color.White;
            this.btnproduct.Location = new System.Drawing.Point(0, 217);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnproduct.Size = new System.Drawing.Size(197, 53);
            this.btnproduct.TabIndex = 2;
            this.btnproduct.Text = "Product";
            this.btnproduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproduct.UseVisualStyleBackColor = true;
            this.btnproduct.Click += new System.EventHandler(this.btnproduct_Click);
            // 
            // btndashboard
            // 
            this.btndashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndashboard.FlatAppearance.BorderSize = 0;
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ForeColor = System.Drawing.Color.White;
            this.btndashboard.Location = new System.Drawing.Point(0, 164);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btndashboard.Size = new System.Drawing.Size(197, 53);
            this.btndashboard.TabIndex = 0;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblusername);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 164);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ln";
            this.label4.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Administrator";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.White;
            this.lblusername.Location = new System.Drawing.Point(39, 102);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(83, 20);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "Username";
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
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lbltitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(214, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(970, 73);
            this.panelTitle.TabIndex = 1;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(300, 23);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(143, 25);
            this.lbltitle.TabIndex = 2;
            this.lbltitle.Text = "Title | Name";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(214, 73);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(970, 588);
            this.panelMain.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of Sale";
            this.panel1.ResumeLayout(false);
            this.SubpanelSetting.ResumeLayout(false);
            this.SubpanelRecord.ResumeLayout(false);
            this.SubpanelInstock.ResumeLayout(false);
            this.SubPanelProduct.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel SubPanelProduct;
        private System.Windows.Forms.Button btnbrand;
        private System.Windows.Forms.Button btncategory;
        private System.Windows.Forms.Button btnproductlist;
        private System.Windows.Forms.Panel SubpanelRecord;
        private System.Windows.Forms.Button btnrecord;
        private System.Windows.Forms.Button btnsupplier;
        private System.Windows.Forms.Panel SubpanelInstock;
        private System.Windows.Forms.Button btnstockadj;
        private System.Windows.Forms.Button btnstockentry;
        private System.Windows.Forms.Button btninstock;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Panel SubpanelSetting;
        private System.Windows.Forms.Button btnstore;
        private System.Windows.Forms.Button btnuser;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Button btnposrecord;
        private System.Windows.Forms.Button btnsaleshistory;
        private System.Windows.Forms.Panel panelMain;
        public System.Windows.Forms.Label lblusername;
        public System.Windows.Forms.Label lbltitle;
    }
}

