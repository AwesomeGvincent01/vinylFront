using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib; // Windows Media Player reference
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

        // Sound players
        private WindowsMediaPlayer hoverPlayer;
        private WindowsMediaPlayer clickPlayer;

        // Panel for pbExit
        private Panel panelExit;

        public Form1()
        {
            InitializeComponent();

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\vgkel\\Downloads\\VK_PROJECT (2)\\VK_PROJECT\\vinylVault\\vinylApp (1)\\vinylVault.mdf\";Integrated Security=True;Connect Timeout=30";
            storageManager = new StorageManager(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load hover images
            loginHover = Image.FromFile("login_hover.png");
            registerHover = Image.FromFile("register_hover.png");
            exitHover = Image.FromFile("exit_hover.png");
            exitNormal = pbExit.Image;
            pbExit.BringToFront();

            // Initialize sound players
            hoverPlayer = new WindowsMediaPlayer();
            hoverPlayer.URL = "hover.mp3";
            hoverPlayer.settings.volume = 100;
            hoverPlayer.settings.setMode("loop", false);

            clickPlayer = new WindowsMediaPlayer();
            clickPlayer.URL = "select.mp3";
            clickPlayer.settings.volume = 100;
            clickPlayer.settings.setMode("loop", false);

            // Setup pbLogin1
            pbLogin1.MouseEnter += (s, ev) =>
            {
                pbLogin1.Image = loginHover;
                hoverPlayer.controls.stop(); hoverPlayer.controls.play();
            };
            pbLogin1.MouseLeave += (s, ev) => pbLogin1.Image = Image.FromFile("login_normal.png");
            pbLogin1.Click += (s, ev) =>
            {
                clickPlayer.controls.stop(); clickPlayer.controls.play();
                btnLogin_Click(s, ev);
            };
            pbLogin1.Cursor = Cursors.Hand;

            // Setup pbRegister1
            pbRegister1.MouseEnter += (s, ev) =>
            {
                pbRegister1.Image = registerHover;
                hoverPlayer.controls.stop(); hoverPlayer.controls.play();
            };
            pbRegister1.MouseLeave += (s, ev) => pbRegister1.Image = Image.FromFile("register_normal.png");
            pbRegister1.Click += (s, ev) =>
            {
                clickPlayer.controls.stop(); clickPlayer.controls.play();
                btnRegister_Click(s, ev);
            };
            pbRegister1.Cursor = Cursors.Hand;

            // Setup smaller hitbox for pbExit
            panelExit = new Panel();
            panelExit.Size = pbExit.Size;
            panelExit.Location = pbExit.Location;
            panelExit.BackColor = Color.Transparent;
            panelExit.Controls.Add(pbExit);
            this.Controls.Add(panelExit);

            pbExit.Size = new Size(pbExit.Width - 10, pbExit.Height - 10);
            pbExit.Location = new Point(5, 5);
            pbExit.MouseEnter += (s, ev) =>
            {
                pbExit.Image = exitHover;
                hoverPlayer.controls.stop(); hoverPlayer.controls.play();
            };
            pbExit.MouseLeave += (s, ev) => pbExit.Image = exitNormal;
            pbExit.Click += (s, ev) =>
            {
                clickPlayer.controls.stop(); clickPlayer.controls.play();
                Application.Exit();
            };
            pbExit.Cursor = Cursors.Hand;

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
            // not used
        }
    }
}


