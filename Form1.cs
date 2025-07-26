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

            // Setup exit PictureBox (pbExit)
            pbExit.Click += (s, ev) => Application.Exit();
            pbExit.Cursor = Cursors.Hand;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(storageManager);
            registerForm.Show();
            this.Hide();
        }
    }
}
