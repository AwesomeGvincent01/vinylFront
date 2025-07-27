namespace vinylFront
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pbRegister1 = new PictureBox();
            pbExit = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pbLogin1 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbRegister1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pbRegister1
            // 
            pbRegister1.Image = (Image)resources.GetObject("pbRegister1.Image");
            pbRegister1.Location = new Point(24, 206);
            pbRegister1.Name = "pbRegister1";
            pbRegister1.Size = new Size(257, 150);
            pbRegister1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRegister1.TabIndex = 4;
            pbRegister1.TabStop = false;
            // 
            // pbExit
            // 
            pbExit.Image = (Image)resources.GetObject("pbExit.Image");
            pbExit.Location = new Point(692, 344);
            pbExit.Name = "pbExit";
            pbExit.Size = new Size(96, 94);
            pbExit.SizeMode = PictureBoxSizeMode.StretchImage;
            pbExit.TabIndex = 5;
            pbExit.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(329, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 265);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(354, 397);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pbLogin1
            // 
            pbLogin1.Image = (Image)resources.GetObject("pbLogin1.Image");
            pbLogin1.Location = new Point(34, 55);
            pbLogin1.Name = "pbLogin1";
            pbLogin1.Size = new Size(247, 130);
            pbLogin1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogin1.TabIndex = 8;
            pbLogin1.TabStop = false;
            pbLogin1.Click += pbLogin1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(279, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(521, 124);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pbLogin1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pbExit);
            Controls.Add(pbRegister1);
            Name = "Form1";
            Text = "Welcome";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbRegister1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbRegister1;
        private PictureBox pbExit;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pbLogin1;
        private PictureBox pictureBox3;
        // pbLogin2 is fully removed
    }
}
