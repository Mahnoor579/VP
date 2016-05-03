namespace OCR
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SrcPicBox = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TargetPicBox = new System.Windows.Forms.PictureBox();
            this.chkCropCordinates = new System.Windows.Forms.CheckBox();
            this.lbCordinates = new System.Windows.Forms.Label();
            this.tbCordinates = new System.Windows.Forms.TextBox();
            this.btnShowSegments = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SrcPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Image";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(408, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SrcPicBox
            // 
            this.SrcPicBox.Location = new System.Drawing.Point(93, 46);
            this.SrcPicBox.Name = "SrcPicBox";
            this.SrcPicBox.Size = new System.Drawing.Size(294, 289);
            this.SrcPicBox.TabIndex = 3;
            this.SrcPicBox.TabStop = false;
            this.SrcPicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.SrcPicBox_Paint);
            this.SrcPicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SrcPicBox_MouseDown);
            this.SrcPicBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SrcPicBox_MouseMove);
            this.SrcPicBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SrcPicBox_MouseUp);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(338, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Crop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TargetPicBox
            // 
            this.TargetPicBox.Location = new System.Drawing.Point(564, 46);
            this.TargetPicBox.Name = "TargetPicBox";
            this.TargetPicBox.Size = new System.Drawing.Size(550, 49);
            this.TargetPicBox.TabIndex = 8;
            this.TargetPicBox.TabStop = false;
            // 
            // chkCropCordinates
            // 
            this.chkCropCordinates.AutoSize = true;
            this.chkCropCordinates.Location = new System.Drawing.Point(93, 381);
            this.chkCropCordinates.Name = "chkCropCordinates";
            this.chkCropCordinates.Size = new System.Drawing.Size(202, 17);
            this.chkCropCordinates.TabIndex = 10;
            this.chkCropCordinates.Text = "Crop using coordinates ( x1,y1,x2,y2 )";
            this.chkCropCordinates.UseVisualStyleBackColor = true;
            this.chkCropCordinates.CheckedChanged += new System.EventHandler(this.chkCropCordinates_CheckedChanged_1);
            // 
            // lbCordinates
            // 
            this.lbCordinates.AutoSize = true;
            this.lbCordinates.Location = new System.Drawing.Point(90, 354);
            this.lbCordinates.Name = "lbCordinates";
            this.lbCordinates.Size = new System.Drawing.Size(66, 13);
            this.lbCordinates.TabIndex = 9;
            this.lbCordinates.Text = "Coordinates:";
            // 
            // tbCordinates
            // 
            this.tbCordinates.Location = new System.Drawing.Point(93, 414);
            this.tbCordinates.Name = "tbCordinates";
            this.tbCordinates.Size = new System.Drawing.Size(140, 20);
            this.tbCordinates.TabIndex = 11;
            this.tbCordinates.Visible = false;
            // 
            // btnShowSegments
            // 
            this.btnShowSegments.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSegments.Location = new System.Drawing.Point(564, 366);
            this.btnShowSegments.Name = "btnShowSegments";
            this.btnShowSegments.Size = new System.Drawing.Size(111, 32);
            this.btnShowSegments.TabIndex = 7;
            this.btnShowSegments.Text = "Show Segments";
            this.btnShowSegments.UseVisualStyleBackColor = true;
            this.btnShowSegments.Click += new System.EventHandler(this.btnShowSegments_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1246, 578);
            this.Controls.Add(this.tbCordinates);
            this.Controls.Add(this.chkCropCordinates);
            this.Controls.Add(this.lbCordinates);
            this.Controls.Add(this.TargetPicBox);
            this.Controls.Add(this.btnShowSegments);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SrcPicBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SrcPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox SrcPicBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox TargetPicBox;
        private System.Windows.Forms.CheckBox chkCropCordinates;
        private System.Windows.Forms.Label lbCordinates;
        private System.Windows.Forms.TextBox tbCordinates;
        private System.Windows.Forms.Button btnShowSegments;
    }
}

