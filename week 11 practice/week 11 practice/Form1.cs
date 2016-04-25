using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week_11_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {   //FOR HIDING FORM
            //this.Hide();
            //WHEN USER CLICKS OK BUTTON THEN MESSAGE BOX WILL SHOW "THIS IS BTNOK"
            //MessageBox.Show("This is btnok");
            //Form1 obj = new Form1();
            //obj.Show();
            //CHECKBOX
            //MessageBox.Show(checkBox1.Checked.ToString());
            //PANEL
            //panel1.Show();
            //RADIO BUTTON
            //if (radioButton1.Checked==true)
            //{
            //    MessageBox.Show("female");

            //}
            //else
            //{
            //    MessageBox.Show("Male");
            //}
            //DATE TIME PICKER
            //DateTime dt = dateTimePicker1.Value;
            //LIST BOX
            //int[] arr = { 1, 2, 3, 4, 5 };
            
            //listBox1.DataSource = arr;
            //listBox1.Show();
            //COMBO BOX
            //comboBox1.DataSource = arr;
            //comboBox1.Show();

            

           


            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog obj = new OpenFileDialog();
            if(obj.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                Image img = Image.FromFile(obj.FileName);
                pictureBox1.Image = img;
            }
        }
    }
}
