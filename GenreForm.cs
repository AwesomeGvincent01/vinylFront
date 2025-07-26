using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vinylApp.Model;
using vinylApp.Repositories;

namespace vinylFront
{
    public partial class GenreForm : Form
    {
        private StorageManager storageManager;

        public GenreForm(StorageManager manager)
        {
            InitializeComponent();
            storageManager = manager;
        }

        private void GenreForm_Load(object sender, EventArgs e)
        {
            List<Genre> genres = storageManager.GetAllGenres();

            if (genres.Count == 0)
            {
                MessageBox.Show("No genres found.");
                return;
            }

            dataGridView1.DataSource = genres;
        }
    }
}