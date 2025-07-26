namespace vinylFront
{
    partial class RegisterForm
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
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            chkIsAdmin = new CheckBox();
            btnRegister = new Button();
            lblMessage = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 80);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(260, 77);
            txtUsername.Size = new Size(120, 23);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 120);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(260, 117);
            txtPassword.Size = new Size(120, 23);
            // 
            // chkIsAdmin
            // 
            chkIsAdmin.AutoSize = true;
            chkIsAdmin.Location = new Point(260, 150);
            chkIsAdmin.Text = "Make Admin";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(200, 190);
            btnRegister.Size = new Size(75, 25);
            btnRegister.Text = "Register";
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(300, 190);
            btnBack.Size = new Size(75, 25);
            btnBack.Text = "Back";
            btnBack.Click += btnBack_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(200, 230);
            lblMessage.Size = new Size(0, 15);
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 300);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(chkIsAdmin);
            Controls.Add(btnRegister);
            Controls.Add(btnBack);
            Controls.Add(lblMessage);
            Name = "RegisterForm";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private CheckBox chkIsAdmin;
        private Button btnRegister;
        private Button btnBack;
        private Label lblMessage;
    }
}
