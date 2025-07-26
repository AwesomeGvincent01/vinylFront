using System;
using System.Windows.Forms;
using vinylApp.Repositories;
using vinylApp.Model;

namespace vinylFront
{
    public partial class LoginForm : Form
    {
        private StorageManager storageManager;

        public LoginForm()
        {
            InitializeComponent();

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\vgkel\\Downloads\\VincentKellett_SQLProj 2 1\\VincentKellett_SQLProj 2\\VincentKellett_SQLProj\\vinylDBTrue\\vinylDBTrue.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=True";
            storageManager = new StorageManager(connectionString);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblMessage.Text = "Please enter both username and password.";
                return;
            }

            User user = storageManager.GetUserByUsernameAndPassword(username, password);

            if (user != null)
            {
                lblMessage.Text = $"Login successful! Welcome, {user.Username} ({user.Role})";


                MessageBox.Show($"Welcome {user.Username}, you are logged in as {user.Role}");

                MainMenuForm menuForm = new MainMenuForm(storageManager);
                menuForm.Show();
                this.Hide();


            }
            else
            {
                lblMessage.Text = "Login failed. Invalid credentials.";
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
