using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCR
{
    public partial class Form1 : Form
    {
        Boolean bHaveMouse;
        Point ptOriginal = new Point();
        Point ptLast = new Point();
        Rectangle rectCropArea;
        Image srcImage = null;
        int imgNo = 0;
        //
        Image[] imgList = new Image[5];
        public Form1()
        {
            InitializeComponent();
            bHaveMouse = false;
        }

        private void chkCropCordinates_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCropCordinates.Checked)
            {
                tbCordinates.Visible = true;
            }
            else
            {
                tbCordinates.Visible = false;
            }
        }

        private void SrcPicBox_Paint(object sender, PaintEventArgs e)
        {
            Pen drawLine = new Pen(Color.Black);
            drawLine.DashStyle = DashStyle.Dash;
            e.Graphics.DrawRectangle(drawLine, rectCropArea);
        }

        private void tbCordinates_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Following allows only numbers and comma for givng expected input
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar!='.')
                {
                    e.Handled = true;
                }

            }
           

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            //Only allow comma as separator for specifying co-ordinates
            if (e.KeyChar == ',')
            {
                e.Handled = false;
            }

        }

        private void SrcPicBox_MouseDown(object sender, MouseEventArgs e)
        {
            // Make a note that we "have the mouse".
            bHaveMouse = true;

            // Store the "starting point" for this rubber-band rectangle.
            ptOriginal.X = e.X;
            ptOriginal.Y = e.Y;

            // Special value lets us know that no previous
            // rectangle needs to be erased.

            // Display coordinates
            lbCordinates.Text = "Coordinates  :  " + e.X.ToString() + ", " + e.Y.ToString();

            ptLast.X = -1;
            ptLast.Y = -1;

            rectCropArea = new Rectangle(new Point(e.X, e.Y), new Size());
        }

        private void SrcPicBox_MouseUp(object sender, MouseEventArgs e)
        {
            // Set internal flag to know we no longer "have the mouse".
            bHaveMouse = false;

            // If we have drawn previously, draw again in that spot
            // to remove the lines.
            if (ptLast.X != -1)
            {
                Point ptCurrent = new Point(e.X, e.Y);

                // Display coordinates
                lbCordinates.Text = "Coordinates  :  " + ptOriginal.X.ToString() + ", " +
                    ptOriginal.Y.ToString() + " And " + e.X.ToString() + ", " + e.Y.ToString();

            }

            // Set flags to know that there is no "previous" line to reverse.
            ptLast.X = -1;
            ptLast.Y = -1;
            ptOriginal.X = -1;
            ptOriginal.Y = -1;

        }

        private void SrcPicBox_MouseMove(object sender, MouseEventArgs e)
        {
            Point ptCurrent = new Point(e.X, e.Y);

            // If we "have the mouse", then we draw our lines.
            if (bHaveMouse)
            {
                // If we have drawn previously, draw again in
                // that spot to remove the lines.
                if (ptLast.X != -1)
                {
                    // Display Coordinates
                    lbCordinates.Text = "Coordinates  :  " + ptOriginal.X.ToString() + ", " +
                        ptOriginal.Y.ToString() + " And " + e.X.ToString() + ", " + e.Y.ToString();
                }

                // Update last point.
                ptLast = ptCurrent;

                // Draw new lines.

                // e.X - rectCropArea.X;
                // normal
                if (e.X > ptOriginal.X && e.Y > ptOriginal.Y)
                {
                    rectCropArea.Width = e.X - ptOriginal.X;

                    // e.Y - rectCropArea.Height;
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

                    // e.Y - rectCropArea.Height;
                    rectCropArea.Height = ptOriginal.Y - e.Y;
                    rectCropArea.X = e.X;
                    rectCropArea.Y = e.Y;
                }
                SrcPicBox.Refresh();
            }
        }



        public Bitmap CropBitmap(Bitmap bitmap, Rectangle rect)
        {
           // Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);
            Bitmap cropped = bitmap.Clone(rect, bitmap.PixelFormat);
            return cropped;
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

        //public PictureBox plotpicturebox (int xAxis, int yAxis, int no)
        //{
        //    //create picture box
        //    PictureBox pb= new PictureBox();
        //    pb.Location=new System.Drawing.Point(xAxis, yAxis);
        //    pb.Name="pictureBox"+no;
        //    pb.Size=new System.Drawing.Size(550,49);
        //    pb.SizeMode=System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        //    return pb;



        //}


        private void button2_Click(object sender, EventArgs e)
        {
            TargetPicBox.Refresh();
            //Prepare a new Bitmap on which the cropped image will be drawn
            Bitmap sourceBitmap = new Bitmap(SrcPicBox.Image, SrcPicBox.Width, SrcPicBox.Height);
            Graphics g = TargetPicBox.CreateGraphics();

            #region [by providing co-ordinates]
            //Checks if the co-rdinates check-box is checked. If yes, then Selection is based on co-rdinates mentioned in the textbox
            if (chkCropCordinates.Checked)
            {
                //logic to retreive co-rdinates from comma-separated string values
                lbCordinates.Text = "";
                string[] cordinates = tbCordinates.Text.ToString().Split(',');
                int cord0, cord1, cord2, cord3;

                try
                {
                    cord0 = Convert.ToInt32(cordinates[0]);
                    cord1 = Convert.ToInt32(cordinates[1]);
                    cord2 = Convert.ToInt32(cordinates[2]);
                    cord3 = Convert.ToInt32(cordinates[3]);
                }
                catch (Exception ex)
                {
                    lbCordinates.Text = ex.Message;
                    return;
                }

                //Various combinations of selection rectangle being dragged in different directions

                if ((cord0 < cord2 && cord1 < cord3))
                {
                    rectCropArea = new Rectangle(cord0, cord1, cord2 - cord0, cord3 - cord1);
                    
                }
                else if (cord2 < cord0 && cord3 > cord1)
                {
                    rectCropArea = new Rectangle(cord2, cord1, cord0 - cord2, cord3 - cord1);
                    
                }
                else if (cord2 > cord0 && cord3 < cord1)
                {
                    rectCropArea = new Rectangle(cord0, cord3, cord2 - cord0, cord1 - cord3);
                   
                }
                else
                {
                    rectCropArea = new Rectangle(cord2, cord3, cord0 - cord2, cord1 - cord3);
                    
                }
            }
            #endregion

            Rectangle rectangleCropArea = new Rectangle(0, 0, TargetPicBox.Width, TargetPicBox.Height);
            Bitmap destBitmap = new Bitmap(TargetPicBox.Width, TargetPicBox.Height);
            Graphics gg = Graphics.FromImage(destBitmap);
            gg.DrawImage(sourceBitmap, rectangleCropArea, rectCropArea, GraphicsUnit.Pixel);
               
            TargetPicBox.Image=destBitmap;

            //Draw the image on the Graphics object with the new dimesions
            g.DrawImage(sourceBitmap, rectangleCropArea ,rectCropArea, GraphicsUnit.Pixel);
           
            imgList[imgNo] = TargetPicBox.Image;
            ++imgNo;
            //Good practice to dispose the System.Drawing objects when not in use.
            sourceBitmap.Dispose();
            gg.Dispose();
            #region [Static Crop and picture boxes ]
            //int cropsize = 54;
            //int xAxis=384, yAxis=-8;
            //for (int i=0; i<7; i++)
            //{
            //    Bitmap bmp= (Bitmap)pictureBox1.Image;
            //    Bitmap smallBmp = CropBitmap(bmp,0,cropsize,550,47);
            //    PictureBox myImg= plotpicturebox(xAxis, yAxis+55,i);
            //    this.Controls.Add(myImg);
            //    myImg.Image=smallBmp;
            //    cropsize += 48;
            //    yAxis +=55;
            //...................................................................
            #endregion
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

        private void chkCropCordinates_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkCropCordinates.Checked)
            {
                tbCordinates.Visible = true;
            }
            else
            {
                tbCordinates.Visible = false;
            }
        }
            //private void Form1_Load(object sender, EventArgs e)
            //{

            //}




        }
    }
