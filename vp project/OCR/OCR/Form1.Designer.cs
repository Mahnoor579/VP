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
            this.lbCordinates = new System.Windows.Forms.Label();
            this.btnShowSegments = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SrcPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetPicBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Image";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Location = new System.Drawing.Point(115, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(440, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SrcPicBox
            // 
            this.SrcPicBox.Location = new System.Drawing.Point(15, 86);
            this.SrcPicBox.Name = "SrcPicBox";
            this.SrcPicBox.Size = new System.Drawing.Size(500, 454);
            this.SrcPicBox.TabIndex = 3;
            this.SrcPicBox.TabStop = false;
            this.SrcPicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.SrcPicBox_Paint);
            this.SrcPicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SrcPicBox_MouseDown);
            this.SrcPicBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SrcPicBox_MouseMove);
            this.SrcPicBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SrcPicBox_MouseUp);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(440, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Crop";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TargetPicBox
            // 
            this.TargetPicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TargetPicBox.Location = new System.Drawing.Point(26, 24);
            this.TargetPicBox.Name = "TargetPicBox";
            this.TargetPicBox.Size = new System.Drawing.Size(550, 49);
            this.TargetPicBox.TabIndex = 8;
            this.TargetPicBox.TabStop = false;
            // 
            // lbCordinates
            // 
            this.lbCordinates.AutoSize = true;
            this.lbCordinates.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCordinates.Location = new System.Drawing.Point(7, 61);
            this.lbCordinates.Name = "lbCordinates";
            this.lbCordinates.Size = new System.Drawing.Size(86, 16);
            this.lbCordinates.TabIndex = 9;
            this.lbCordinates.Text = "Coordinates:";
            this.lbCordinates.Click += new System.EventHandler(this.lbCordinates_Click);
            // 
            // btnShowSegments
            // 
            this.btnShowSegments.BackColor = System.Drawing.Color.Gainsboro;
            this.btnShowSegments.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSegments.Location = new System.Drawing.Point(942, 323);
            this.btnShowSegments.Name = "btnShowSegments";
            this.btnShowSegments.Size = new System.Drawing.Size(155, 32);
            this.btnShowSegments.TabIndex = 7;
            this.btnShowSegments.Text = "Show Segments";
            this.btnShowSegments.UseVisualStyleBackColor = false;
            this.btnShowSegments.Click += new System.EventHandler(this.btnShowSegments_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.TargetPicBox);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(521, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(942, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 45);
            this.button3.TabIndex = 11;
            this.button3.Text = "character level segmentation";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1137, 578);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbCordinates);
            this.Controls.Add(this.btnShowSegments);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SrcPicBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SrcPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetPicBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Label lbCordinates;
        private System.Windows.Forms.Button btnShowSegments;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
    }
}

