using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Imaging;
using System.Runtime.InteropServices;


namespace OCR
{
    public partial class Form1 : Form
    {

        String text;
        Boolean bHaveMouse;
        Point ptOriginal = new Point();
        //Point ptLast = new Point();
        Rectangle rectCropArea;
        Image srcImage = null;
        Bitmap oldimg= null;

        int imgNo = 0;
        //
        Image[] imgList = new Image[20];
        public Form1()
        {
            //testTessa = new TesseractEngine("tessdata", "eng", EngineMode.TesseractAndCube);
           // testTessa = new TesseractEngine("tessdata", "eng", EngineMode.TesseractOnly);
            InitializeComponent();
            bHaveMouse = false;
        }

        
        private void SrcPicBox_Paint(object sender, PaintEventArgs e)
        {
            Pen drawLine = new Pen(Color.Black);
            drawLine.DashStyle = DashStyle.Dash;
            e.Graphics.DrawRectangle(drawLine, rectCropArea);
        }

       

        private void SrcPicBox_MouseDown(object sender, MouseEventArgs e)
        {
            
            bHaveMouse = true;

            
            ptOriginal.X = e.X;
            ptOriginal.Y = e.Y;

            
            lbCordinates.Text = "Coordinates  :  " + e.X.ToString() + ", " + e.Y.ToString();

            

            
        }

        private void SrcPicBox_MouseUp(object sender, MouseEventArgs e)
        {
            
            bHaveMouse = false;

            
           
                Point ptCurrent = new Point(e.X, e.Y);

               
                lbCordinates.Text = "Coordinates  :  " + ptOriginal.X.ToString() + ", " +
                    ptOriginal.Y.ToString() + " And " + e.X.ToString() + ", " + e.Y.ToString();

            


        }

        private void SrcPicBox_MouseMove(object sender, MouseEventArgs e)
        {
            Point ptCurrent = new Point(e.X, e.Y);

           
            if (bHaveMouse) 
            {
               
               
                {
                   
                    lbCordinates.Text = "Coordinates  :  " + ptOriginal.X.ToString() + ", " +
                        ptOriginal.Y.ToString() + " And " + e.X.ToString() + ", " + e.Y.ToString();
                }






                if (e.X > ptOriginal.X && e.Y > ptOriginal.Y)
                {
                    rectCropArea.Width = e.X - ptOriginal.X;


                    rectCropArea.Height = e.Y - ptOriginal.Y;
                }
                else if (e.X < ptOriginal.X && e.Y > ptOriginal.Y)
                {
                    rectCropArea.Width = ptOriginal.X - e.X;
                    rectCropArea.Height = e.Y - ptOriginal.Y;
                    rectCropArea.X = e.X;
                    rectCropArea.Y = ptOriginal.Y;
                }
                else if (e.X > ptOriginal.X && e.Y < ptOriginal.Y)
                {
                    rectCropArea.Width = e.X - ptOriginal.X;
                    rectCropArea.Height = ptOriginal.Y - e.Y;

                    rectCropArea.X = ptOriginal.X;
                    rectCropArea.Y = e.Y;
                }
                else
                {
                    rectCropArea.Width = ptOriginal.X - e.X;


                    rectCropArea.Height = ptOriginal.Y - e.Y;
                    rectCropArea.X = e.X;
                    rectCropArea.Y = e.Y;
                }
                SrcPicBox.Refresh();
            }
        }



       


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = null;
                FileDialog fd = new OpenFileDialog();
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    path = System.IO.Path.GetFullPath(fd.FileName);
                    Bitmap newimg = new Bitmap(path);
                    SrcPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    SrcPicBox.Image = (Image)newimg;
                }
                textBox1.Text = path;
            }

            catch (System.ArgumentException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               
                
                Bitmap sourceBitmap = new Bitmap(SrcPicBox.Image, SrcPicBox.Width, SrcPicBox.Height);
                Graphics g = TargetPicBox.CreateGraphics();

          
                Rectangle rectangleCropArea = new Rectangle(0, 0, TargetPicBox.Width, TargetPicBox.Height);
                Bitmap destBitmap = new Bitmap(TargetPicBox.Width, TargetPicBox.Height);
                Graphics gg = Graphics.FromImage(destBitmap);
                gg.DrawImage(sourceBitmap, rectangleCropArea, rectCropArea, GraphicsUnit.Pixel);
               
                TargetPicBox.Image=destBitmap;
                oldimg = destBitmap;
                
                g.DrawImage(sourceBitmap, rectangleCropArea ,rectCropArea, GraphicsUnit.Pixel);
           
                imgList[imgNo] = TargetPicBox.Image;
                ++imgNo;

               
                sourceBitmap.Dispose();
                gg.Dispose();
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }
  
        }

        private void btnShowSegments_Click(object sender, EventArgs e)
        {
            if (imgNo==0)
            {
                MessageBox.Show("Form is not divided into segments, please crop first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Form2 fm = new Form2(imgList);
                fm.ShowDialog();
            }
        }


        private void lbCordinates_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
          
        }
            




        }
    }
