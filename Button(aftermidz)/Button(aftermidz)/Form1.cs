using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_aftermidz_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Location = new Point(50, 70);
            btn.Width = 120;
            btn.Height = 30;
            btn.Text = "PRESS";
            this.Controls.Add(btn);
            btn.Visible = true;
        }
    }
}
