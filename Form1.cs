using System;
using System.Drawing;
using System.Windows.Forms;
using vinylApp.Repositories;

namespace vinylFront
{
    public partial class Form1 : Form
    {
        private StorageManager storageManager;

        // Image fields for hover effects
        private Image loginHover;
        private Image registerHover;
        private Image exitHover;
        private Image exitNormal;

        // Panel for pbExit
        private Panel panelExit;

        public Form1()
        {
            InitializeComponent();

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\vgkel\\source\\repos\\vinylFront\\bin\\Debug\\net9.0-windows\\vinylVault.mdf;Integrated Security=True;Connect Timeout=30";
            storageManager = new StorageManager(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load hover images
            loginHover = Image.FromFile("login_hover.png");
            registerHover = Image.FromFile("register_hover.png");
            exitHover = Image.FromFile("exit_hover.png");
            exitNormal = pbExit.Image;

            // Setup login PictureBox (pbLogin1)
            pbLogin1.MouseEnter += (s, ev) => pbLogin1.Image = loginHover;
            pbLogin1.MouseLeave += (s, ev) => pbLogin1.Image = Image.FromFile("login_normal.png");
            pbLogin1.Click += btnLogin_Click;
            pbLogin1.Cursor = Cursors.Hand;

            // Setup register PictureBox (pbRegister1)
            pbRegister1.MouseEnter += (s, ev) => pbRegister1.Image = registerHover;
            pbRegister1.MouseLeave += (s, ev) => pbRegister1.Image = Image.FromFile("register_normal.png");
            pbRegister1.Click += btnRegister_Click;
            pbRegister1.Cursor = Cursors.Hand;

            // ========================
            // Setup smaller hitbox for pbExit
            // ========================

            // Create the panel wrapper
            panelExit = new Panel();
            panelExit.Size = pbExit.Size;
            panelExit.Location = pbExit.Location;
            panelExit.BackColor = Color.Transparent;
            panelExit.Controls.Add(pbExit);
            this.Controls.Add(panelExit);

            // Adjust pbExit inside the panel (shrink it slightly)
            pbExit.Size = new Size(pbExit.Width - 10, pbExit.Height - 10);
            pbExit.Location = new Point(5, 5); // center inside panel

            // Setup hover/click
            pbExit.MouseEnter += (s, ev) => pbExit.Image = exitHover;
            pbExit.MouseLeave += (s, ev) => pbExit.Image = exitNormal;
            pbExit.Click += (s, ev) => Application.Exit();
            pbExit.Cursor = Cursors.Hand;

            // Remove original pbExit from form-level Controls
            this.Controls.Remove(pbExit);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(storageManager);
            loginForm.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(storageManager);
            registerForm.Show();
            this.Hide();
        }

        private void pbLogin1_Click(object sender, EventArgs e)
        {

        }
    }
}

