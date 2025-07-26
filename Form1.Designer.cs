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
            pbLogin1 = new PictureBox();
            pbRegister1 = new PictureBox();
            pbExit = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRegister1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pbLogin1
            // 
            pbLogin1.Image = (Image)resources.GetObject("pbLogin1.Image");
            pbLogin1.Location = new Point(34, 26);
            pbLogin1.Name = "pbLogin1";
            pbLogin1.Size = new Size(226, 148);
            pbLogin1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogin1.TabIndex = 3;
            pbLogin1.TabStop = false;
            // 
            // pbRegister1
            // 
            pbRegister1.Image = (Image)resources.GetObject("pbRegister1.Image");
            pbRegister1.Location = new Point(34, 223);
            pbRegister1.Name = "pbRegister1";
            pbRegister1.Size = new Size(230, 153);
            pbRegister1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRegister1.TabIndex = 4;
            pbRegister1.TabStop = false;
            // 
            // pbExit
            // 
            pbExit.Image = (Image)resources.GetObject("pbExit.Image");
            pbExit.Location = new Point(661, 344);
            pbExit.Name = "pbExit";
            pbExit.Size = new Size(96, 94);
            pbExit.SizeMode = PictureBoxSizeMode.StretchImage;
            pbExit.TabIndex = 5;
            pbExit.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(355, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 265);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(pbExit);
            Controls.Add(pbRegister1);
            Controls.Add(pbLogin1);
            Name = "Form1";
            Text = "Welcome";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRegister1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogin1;
        private PictureBox pbRegister1;
        private PictureBox pbExit;
        private PictureBox pictureBox1;
    }
}
