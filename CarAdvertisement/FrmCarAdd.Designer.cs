namespace CarAdvertisement
{
    partial class FrmCarEdit
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
            lblBrand = new Label();
            lblModel = new Label();
            lblYear = new Label();
            lblPrice = new Label();
            txtYear = new TextBox();
            txtPrice = new TextBox();
            cmoBrand = new ComboBox();
            cmoModel = new ComboBox();
            btnAddCar = new Button();
            label1 = new Label();
            lblTransmission = new Label();
            cmoTransmission = new ComboBox();
            txtMileage = new TextBox();
            lblMileage = new Label();
            txtColor = new TextBox();
            lblColor = new Label();
            cmoFuelType = new ComboBox();
            dgvListingCars = new DataGridView();
            btnUpdateCar = new Button();
            btnDelete = new Button();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvListingCars).BeginInit();
            SuspendLayout();
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(10, 54);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(40, 15);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "Marka";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(10, 92);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(41, 15);
            lblModel.TabIndex = 1;
            lblModel.Text = "Model";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(10, 132);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(20, 15);
            lblYear.TabIndex = 2;
            lblYear.Text = "Yıl";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(10, 172);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(32, 15);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Fiyat";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(81, 129);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(85, 23);
            txtYear.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(81, 169);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(85, 23);
            txtPrice.TabIndex = 4;
            // 
            // cmoBrand
            // 
            cmoBrand.FormattingEnabled = true;
            cmoBrand.Location = new Point(81, 51);
            cmoBrand.Name = "cmoBrand";
            cmoBrand.Size = new Size(108, 23);
            cmoBrand.TabIndex = 1;
            // 
            // cmoModel
            // 
            cmoModel.FormattingEnabled = true;
            cmoModel.Location = new Point(81, 89);
            cmoModel.Name = "cmoModel";
            cmoModel.Size = new Size(108, 23);
            cmoModel.TabIndex = 2;
            // 
            // btnAddCar
            // 
            btnAddCar.Location = new Point(10, 369);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(75, 23);
            btnAddCar.TabIndex = 9;
            btnAddCar.Text = "Ekle";
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 210);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 12;
            label1.Text = "Yakıt Tipi";
            // 
            // lblTransmission
            // 
            lblTransmission.AutoSize = true;
            lblTransmission.Location = new Point(10, 248);
            lblTransmission.Name = "lblTransmission";
            lblTransmission.Size = new Size(59, 15);
            lblTransmission.TabIndex = 14;
            lblTransmission.Text = "Vites Türü";
            // 
            // cmoTransmission
            // 
            cmoTransmission.FormattingEnabled = true;
            cmoTransmission.Location = new Point(81, 245);
            cmoTransmission.Name = "cmoTransmission";
            cmoTransmission.Size = new Size(108, 23);
            cmoTransmission.TabIndex = 6;
            // 
            // txtMileage
            // 
            txtMileage.Location = new Point(81, 283);
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new Size(85, 23);
            txtMileage.TabIndex = 7;
            // 
            // lblMileage
            // 
            lblMileage.AutoSize = true;
            lblMileage.Location = new Point(10, 286);
            lblMileage.Name = "lblMileage";
            lblMileage.Size = new Size(58, 15);
            lblMileage.TabIndex = 16;
            lblMileage.Text = "Kilometre";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(81, 321);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(85, 23);
            txtColor.TabIndex = 8;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(10, 324);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(33, 15);
            lblColor.TabIndex = 18;
            lblColor.Text = "Renk";
            // 
            // cmoFuelType
            // 
            cmoFuelType.FormattingEnabled = true;
            cmoFuelType.Location = new Point(81, 207);
            cmoFuelType.Name = "cmoFuelType";
            cmoFuelType.Size = new Size(108, 23);
            cmoFuelType.TabIndex = 5;
            // 
            // dgvListingCars
            // 
            dgvListingCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListingCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListingCars.Location = new Point(207, 12);
            dgvListingCars.Name = "dgvListingCars";
            dgvListingCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListingCars.Size = new Size(804, 332);
            dgvListingCars.TabIndex = 24;
            dgvListingCars.MouseClick += dgvListingCars_MouseClick;
            // 
            // btnUpdateCar
            // 
            btnUpdateCar.Location = new Point(91, 370);
            btnUpdateCar.Name = "btnUpdateCar";
            btnUpdateCar.Size = new Size(75, 23);
            btnUpdateCar.TabIndex = 25;
            btnUpdateCar.Text = "Güncelle";
            btnUpdateCar.UseVisualStyleBackColor = true;
            btnUpdateCar.Click += btnUpdateCar_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(172, 370);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(81, 12);
            txtID.Name = "txtID";
            txtID.Size = new Size(85, 23);
            txtID.TabIndex = 28;
            // 
            // FrmCarAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 435);
            Controls.Add(txtID);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdateCar);
            Controls.Add(dgvListingCars);
            Controls.Add(cmoFuelType);
            Controls.Add(txtColor);
            Controls.Add(lblColor);
            Controls.Add(txtMileage);
            Controls.Add(lblMileage);
            Controls.Add(cmoTransmission);
            Controls.Add(lblTransmission);
            Controls.Add(label1);
            Controls.Add(btnAddCar);
            Controls.Add(cmoModel);
            Controls.Add(cmoBrand);
            Controls.Add(txtPrice);
            Controls.Add(txtYear);
            Controls.Add(lblPrice);
            Controls.Add(lblYear);
            Controls.Add(lblModel);
            Controls.Add(lblBrand);
            Name = "FrmCarAdd";
            Text = "Yeni Araç Ekle";
            ((System.ComponentModel.ISupportInitialize)dgvListingCars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBrand;
        private Label lblModel;
        private Label lblYear;
        private Label lblPrice;
        private TextBox txtYear;
        private TextBox txtPrice;
        private ComboBox cmoBrand;
        private ComboBox cmoModel;
        private Button btnAddCar;
        private Label label1;
        private Label lblTransmission;
        private ComboBox cmoTransmission;
        private TextBox txtMileage;
        private Label lblMileage;
        private TextBox txtColor;
        private Label lblColor;
        private ComboBox cmoFuelType;
        private DataGridView dgvListingCars;
        private Button btnUpdateCar;
        private Button btnDelete;
        private TextBox txtID;
    }
}