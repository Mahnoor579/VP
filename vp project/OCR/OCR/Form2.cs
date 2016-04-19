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
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e, Bitmap bmpInput)
        {
            
            Bitmap temp;
            Color c;
            float sum = 0;
            for(int i=0; i<bmpInput.Width;i++)
            {
                for(int j=0; j<bmpInput.Height;j++)
                {
                    c = bmpInput.GetPixel(i, j);
                    byte gray = (byte)(.333 * c.R + .333 * c.G + .333 * c.B);
                    bmpInput.SetPixel(i, j, Color.FromArgb(gray, gray, gray));

                }
            }
            temp = bmpInput;
            for(int i=0; i<=bmpInput.Width-3;i++)
            {
                for(int j=0; j<bmpInput.Height-3; j++)
                {
                    for(int x=i; x<=i+2;x++)
                    {
                        for(int y=j; y<=j+2;y++)
                        {
                            c = bmpInput.GetPixel(x, y);
                            sum = sum + c.R;


                        }
                        int color = (int)Math.Round(sum / 9, 10);
                        temp.SetPixel(i + 1, j + 1, Color.FromArgb(color, color, color));
                        sum = 0;

                    }
                    bmpInput = temp;






                }
            }

        }
    }
}
