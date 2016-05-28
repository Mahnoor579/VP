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
    public partial class Form2 : Form
    {
        Image[] imgList;
        public Form2(Image[] imagesList)
        {
            InitializeComponent();
            imgList = imagesList;
        }

        public PictureBox plotpicturebox(int xAxis, int yAxis, int no)
        {
            //create picture box
            PictureBox pb = new PictureBox();
            pb.Location = new System.Drawing.Point(xAxis, yAxis);
            pb.Name = "pictureBox" + no;
            pb.Size = new System.Drawing.Size(550, 49);
            pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            return pb;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            #region [Static Crop and picture boxes ]
            int cropsize = 54;
            int xAxis = 40, yAxis = -8;
            for (int i = 0; i < imgList.Length; i++)
            {
                //   Bitmap bmp= (Bitmap)pictureBox1.Image;
                //   Bitmap smallBmp = CropBitmap(bmp,0,cropsize,550,47);
                PictureBox myImg = plotpicturebox(xAxis, yAxis + 55, i);
                this.Controls.Add(myImg);
                myImg.Image = imgList[i];
                cropsize += 48;
                yAxis += 55;
                //...................................................................
            #endregion
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {





        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            fm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}


