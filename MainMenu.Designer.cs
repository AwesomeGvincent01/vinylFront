namespace vinylFront
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnViewGenres = new Button();
            btnViewRecords = new Button();
            btnViewCustomers = new Button();
            btnViewArtists = new Button();
            btnViewOrders = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnViewGenres
            // 
            btnViewGenres.Location = new Point(50, 30);
            btnViewGenres.Size = new Size(200, 30);
            btnViewGenres.Text = "View Genres";
            btnViewGenres.Click += btnViewGenres_Click;
            // 
            // btnViewRecords
            // 
            btnViewRecords.Location = new Point(50, 70);
            btnViewRecords.Size = new Size(200, 30);
            btnViewRecords.Text = "View Records";
            btnViewRecords.Click += btnViewRecords_Click;
            // 
            // btnViewCustomers
            // 
            btnViewCustomers.Location = new Point(50, 110);
            btnViewCustomers.Size = new Size(200, 30);
            btnViewCustomers.Text = "View Customers";
            btnViewCustomers.Click += btnViewCustomers_Click;
            // 
            // btnViewArtists
            // 
            btnViewArtists.Location = new Point(50, 150);
            btnViewArtists.Size = new Size(200, 30);
            btnViewArtists.Text = "View Artists";
            btnViewArtists.Click += btnViewArtists_Click;
            // 
            // btnViewOrders
            // 
            btnViewOrders.Location = new Point(50, 190);
            btnViewOrders.Size = new Size(200, 30);
            btnViewOrders.Text = "View Orders";
            btnViewOrders.Click += btnViewOrders_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(50, 230);
            btnLogout.Size = new Size(200, 30);
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 300);
            Controls.Add(btnViewGenres);
            Controls.Add(btnViewRecords);
            Controls.Add(btnViewCustomers);
            Controls.Add(btnViewArtists);
            Controls.Add(btnViewOrders);
            Controls.Add(btnLogout);
            Name = "MainMenuForm";
            Text = "Main Menu";
            ResumeLayout(false);
        }

        private Button btnViewGenres;
        private Button btnViewRecords;
        private Button btnViewCustomers;
        private Button btnViewArtists;
        private Button btnViewOrders;
        private Button btnLogout;
    }
}
