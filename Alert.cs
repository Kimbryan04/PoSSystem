﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Alert : Form
    {
        private Random random;
        private int tempIndex;
        MainForm mainForm;
        public Alert(MainForm main)
        {
            InitializeComponent();
            random = new Random();
            Color color = SelectThemeColor();
            panel1.BackColor = color;
            mainForm = main;
        }

        public enum enmAction
        {
            wait,
            start,
            close
        }

        private Alert.enmAction action;
        private int x, y;

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 15000;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if(this.x<this.Location.X)
                    {
                        this.Left--;

                    }
                    else
                    {
                        if(this.Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if(base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;   
            }
        }

        public void ShowAlert(string msg)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Alert frm = (Alert)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    // Position the alert in the right-middle of the screen
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 15; // Right side with some padding
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i; // Centered vertically
                    this.Location = new Point(this.x, this.y);
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            this.MessageText.Text = msg;

            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            timer1.Start();

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            StockIn stock = new StockIn();
            mainForm.OpenChildForm(stock);
            ProductStockIn stockIn = new ProductStockIn(stock);
            stock.ProductForSupplier(lblid.Text);
            stockIn.addStockIn(lblid.Text);

        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);  
            }
            tempIndex = index;
            string color =  ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
    }
}
