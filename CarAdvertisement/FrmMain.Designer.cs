namespace CarAdvertisement
{
    partial class FrmMain
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
            pnlMenu = new Panel();
            btnUserManagement = new Button();
            lblUsername = new Label();
            btnAddCar = new Button();
            btnDetails = new Button();
            btnAddAd = new Button();
            btnLogout = new Button();
            dgvAds = new DataGridView();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAds).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(btnUserManagement);
            pnlMenu.Controls.Add(lblUsername);
            pnlMenu.Controls.Add(btnAddCar);
            pnlMenu.Controls.Add(btnDetails);
            pnlMenu.Controls.Add(btnAddAd);
            pnlMenu.Controls.Add(btnLogout);
            pnlMenu.Location = new Point(12, 12);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(122, 426);
            pnlMenu.TabIndex = 0;
            // 
            // btnUserManagement
            // 
            btnUserManagement.Location = new Point(3, 338);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(116, 23);
            btnUserManagement.TabIndex = 8;
            btnUserManagement.Text = "Kullanıcı Yönetimi";
            btnUserManagement.UseVisualStyleBackColor = true;
            btnUserManagement.Visible = false;
            btnUserManagement.Click += btnUserManagement_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(3, 373);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(0, 15);
            lblUsername.TabIndex = 1;
            // 
            // btnAddCar
            // 
            btnAddCar.Location = new Point(3, 4);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(116, 23);
            btnAddCar.TabIndex = 2;
            btnAddCar.Text = "Araç Ekle";
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(3, 62);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(116, 23);
            btnDetails.TabIndex = 7;
            btnDetails.Text = "Detaylar";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnAddAd
            // 
            btnAddAd.Location = new Point(3, 33);
            btnAddAd.Name = "btnAddAd";
            btnAddAd.Size = new Size(116, 23);
            btnAddAd.TabIndex = 3;
            btnAddAd.Text = "İlan Ekle";
            btnAddAd.UseVisualStyleBackColor = true;
            btnAddAd.Click += btnAddAd_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(3, 400);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(116, 23);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Çıkış Yap";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // dgvAds
            // 
            dgvAds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAds.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAds.Location = new Point(137, 12);
            dgvAds.Name = "dgvAds";
            dgvAds.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAds.Size = new Size(1318, 423);
            dgvAds.TabIndex = 6;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1467, 450);
            Controls.Add(dgvAds);
            Controls.Add(pnlMenu);
            Name = "FrmMain";
            Text = "Ana Sayfa - Araba İlanları";
            FormClosing += FrmMain_FormClosing;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAds).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Label lblUsername;
        private Button btnAddCar;
        private Button btnAddAd;
        private Button btnLogout;
        private DataGridView dgvAds;
        private Button btnDetails;
        private Button btnUserManagement;
    }
}