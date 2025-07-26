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

namespace vinylFront
{
    public partial class MainMenuForm : Form
    {
        private StorageManager storageManager;

        public MainMenuForm(StorageManager manager)
        {
            InitializeComponent();
            storageManager = manager;
        }

        private void btnViewGenres_Click(object sender, EventArgs e)
        {
            GenreForm genreForm = new GenreForm(storageManager);
            genreForm.Show();
        }

        private void btnViewRecords_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not yet implemented.");
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not yet implemented.");
        }

        private void btnViewArtists_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not yet implemented.");
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not yet implemented.");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart(); // restarts to Form1
        }
    }
}