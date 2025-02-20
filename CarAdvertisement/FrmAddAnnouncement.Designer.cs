namespace CarAdvertisement
{
    partial class FrmAddAnnouncement
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
            txtID = new TextBox();
            txtDescription = new TextBox();
            cmoCarID = new ComboBox();
            cmoLocation = new ComboBox();
            cekStatus = new CheckBox();
            lblDescription = new Label();
            lblLocation = new Label();
            lblStatus = new Label();
            dgvListing = new DataGridView();
            lblCar = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListing).BeginInit();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(89, 11);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(89, 87);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(305, 180);
            txtDescription.TabIndex = 1;
            // 
            // cmoCarID
            // 
            cmoCarID.BackColor = SystemColors.Window;
            cmoCarID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmoCarID.FlatStyle = FlatStyle.Popup;
            cmoCarID.ForeColor = SystemColors.WindowText;
            cmoCarID.FormattingEnabled = true;
            cmoCarID.Location = new Point(89, 49);
            cmoCarID.Name = "cmoCarID";
            cmoCarID.Size = new Size(121, 23);
            cmoCarID.TabIndex = 2;
            // 
            // cmoLocation
            // 
            cmoLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmoLocation.FlatStyle = FlatStyle.Popup;
            cmoLocation.FormattingEnabled = true;
            cmoLocation.Location = new Point(89, 282);
            cmoLocation.Name = "cmoLocation";
            cmoLocation.Size = new Size(121, 23);
            cmoLocation.TabIndex = 3;
            // 
            // cekStatus
            // 
            cekStatus.AutoSize = true;
            cekStatus.Location = new Point(89, 320);
            cekStatus.Name = "cekStatus";
            cekStatus.Size = new Size(15, 14);
            cekStatus.TabIndex = 4;
            cekStatus.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(12, 87);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(56, 15);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Açıklama";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(12, 285);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(46, 15);
            lblLocation.TabIndex = 6;
            lblLocation.Text = "Konum";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 320);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(51, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Durumu";
            // 
            // dgvListing
            // 
            dgvListing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListing.Location = new Point(414, 12);
            dgvListing.Name = "dgvListing";
            dgvListing.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListing.Size = new Size(647, 323);
            dgvListing.TabIndex = 8;
            dgvListing.MouseClick += dgvListing_MouseClick;
            // 
            // lblCar
            // 
            lblCar.AutoSize = true;
            lblCar.Location = new Point(12, 52);
            lblCar.Name = "lblCar";
            lblCar.Size = new Size(31, 15);
            lblCar.TabIndex = 9;
            lblCar.Text = "Araç";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 379);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(93, 379);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(174, 379);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // FrmAddAd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblCar);
            Controls.Add(dgvListing);
            Controls.Add(lblStatus);
            Controls.Add(lblLocation);
            Controls.Add(lblDescription);
            Controls.Add(cekStatus);
            Controls.Add(cmoLocation);
            Controls.Add(cmoCarID);
            Controls.Add(txtDescription);
            Controls.Add(txtID);
            Name = "FrmAddAd";
            Text = "FrmAddAd";
            ((System.ComponentModel.ISupportInitialize)dgvListing).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private TextBox txtDescription;
        private ComboBox cmoCarID;
        private ComboBox cmoLocation;
        private CheckBox cekStatus;
        private Label lblDescription;
        private Label lblLocation;
        private Label lblStatus;
        private DataGridView dgvListing;
        private Label lblCar;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}