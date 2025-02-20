namespace CarAdvertisement
{
    partial class FrmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUser = new Label();
            lblPassword = new Label();
            lblMail = new Label();
            lblPhone = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            txtMail = new TextBox();
            txtPhone = new TextBox();
            btnBackToLogin = new Button();
            btnRegister = new Button();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblFirstName = new Label();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(45, 102);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(73, 15);
            lblUser.TabIndex = 0;
            lblUser.Text = "Kullanıcı Adı";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(45, 136);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(30, 15);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Şifre";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(45, 171);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(47, 15);
            lblMail.TabIndex = 2;
            lblMail.Text = "E-Posta";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(45, 208);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(45, 15);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Telefon";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(146, 99);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(100, 23);
            txtUser.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(146, 133);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(146, 168);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(100, 23);
            txtMail.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(146, 205);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 6;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.Location = new Point(45, 276);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(120, 23);
            btnBackToLogin.TabIndex = 8;
            btnBackToLogin.Text = "Giriş Ekranına Dön";
            btnBackToLogin.UseVisualStyleBackColor = true;
            btnBackToLogin.Click += btnBackToLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(171, 276);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(146, 23);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(45, 64);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(48, 15);
            lblLastName.TabIndex = 10;
            lblLastName.Text = "Soyisim";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(146, 61);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(45, 26);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(29, 15);
            lblFirstName.TabIndex = 12;
            lblFirstName.Text = "İsim";
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(293, 322);
            Controls.Add(txtLastName);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(btnRegister);
            Controls.Add(btnBackToLogin);
            Controls.Add(txtPhone);
            Controls.Add(txtMail);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(lblPhone);
            Controls.Add(lblMail);
            Controls.Add(lblPassword);
            Controls.Add(lblUser);
            Name = "FrmRegister";
            Text = "Kayıt Ol";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label lblPassword;
        private Label lblMail;
        private Label lblPhone;
        private TextBox txtUser;
        private TextBox txtPassword;
        private TextBox txtMail;
        private TextBox txtPhone;
        private Button btnBackToLogin;
        private Button btnRegister;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblFirstName;
    }
}