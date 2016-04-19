using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }
        private void button1_Click(object sender, EventArgs e)
        {
            string imagename;
            try
            {
                FileDialog fd = new OpenFileDialog();
                //specify directory
                fd.InitialDirectory = @":D\";
                fd.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif";
                if (fd.ShowDialog()==DialogResult.OK)
                {
                    imagename = fd.FileName;
                    Bitmap newimg = new Bitmap(imagename);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = (Image)newimg;
                }

                fd = null;
            }

            catch(System.ArgumentException ex)
            {
                imagename = " ";
                MessageBox.Show(ex.Message.ToString());

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string filename = "";
            string path = "";
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                filename = System.IO.Path.GetFileName(ofd.FileName);
                path = System.IO.Path.GetDirectoryName(ofd.FileName);
            }

            MessageBox.Show(filename, "Filename");
            MessageBox.Show(path, "Directory");
        }
    }
}
