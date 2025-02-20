namespace CarAdvertisement
{
    partial class FrmUserManagement
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
            dgvUsers = new DataGridView();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            cmoRole = new ComboBox();
            lblFirstName = new Label();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtUserID = new TextBox();
            btnUpdateUser = new Button();
            btnAddUser = new Button();
            btnDeleteUser = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(12, 12);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(776, 412);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellMouseClick += dgvUsers_CellMouseClick;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(12, 446);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(118, 446);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(224, 446);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(330, 446);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // cmoRole
            // 
            cmoRole.Location = new Point(648, 446);
            cmoRole.Name = "cmoRole";
            cmoRole.Size = new Size(121, 23);
            cmoRole.TabIndex = 5;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(12, 428);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(22, 15);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "Ad";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(436, 446);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(542, 446);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 8;
            // 
            // txtUserID
            // 
            txtUserID.Enabled = false;
            txtUserID.Location = new Point(12, 484);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(36, 23);
            txtUserID.TabIndex = 9;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Location = new Point(527, 484);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(118, 23);
            btnUpdateUser.TabIndex = 10;
            btnUpdateUser.Text = "Kullanıcı Güncelle";
            btnUpdateUser.UseVisualStyleBackColor = true;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(403, 484);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(118, 23);
            btnAddUser.TabIndex = 11;
            btnAddUser.Text = "Kullanıcı Ekle";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(651, 484);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(118, 23);
            btnDeleteUser.TabIndex = 12;
            btnDeleteUser.Text = "Kullanıcı Sil";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 428);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 13;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 428);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 14;
            label3.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 428);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 15;
            label4.Text = "Şifre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(436, 428);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 16;
            label5.Text = "E-Mail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(542, 427);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 17;
            label6.Text = "Telefon";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(648, 428);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 18;
            label7.Text = "Rol";
            // 
            // FrmUserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnAddUser);
            Controls.Add(btnUpdateUser);
            Controls.Add(txtUserID);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(lblFirstName);
            Controls.Add(cmoRole);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(dgvUsers);
            Name = "FrmUserManagement";
            Text = "FrmUserManagement";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsers;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private ComboBox cmoRole;
        private Label lblFirstName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtUserID;
        private Button btnUpdateUser;
        private Button btnAddUser;
        private Button btnDeleteUser;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}