using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vinylApp.Repositories;
using vinylApp.Model;

namespace vinylFront
{
    public partial class RegisterForm : Form
    {
        private StorageManager storageManager;

        public RegisterForm(StorageManager sm)
        {
            InitializeComponent();
            storageManager = sm;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = chkIsAdmin.Checked ? "Admin" : "Customer";

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblMessage.Text = "Username and password cannot be empty.";
                return;
            }

            if (username.Length >= 100 || password.Length >= 100)
            {
                lblMessage.Text = "Username and password must be less than 100 characters.";
                return;
            }

            if (storageManager.UsernameExists(username))
            {
                lblMessage.Text = "Username already taken. Try another.";
                return;
            }

            User newUser = new User(0, username, password, role);
            int newId = storageManager.InsertUser(newUser);

            MessageBox.Show($"User registered successfully! ID: {newId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // or redirect back to login
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Go back to main menu
        }
    }
}