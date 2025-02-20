using Entities.Models;
using Repositories.Concrete;

namespace CarAdvertisement
{
    public partial class FrmCarEdit : Form
    {
        private CarRepository _carRepository;

        public FrmCarEdit()
        {
            InitializeComponent();
            _carRepository = new CarRepository();

            cmoBrandLoad();
            cmoModelLoad();
            cmoFuelTypeLoad();
            cmoTransmissionLoad();
            ListngCars();
        }
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan gelen veriyi al
            string brand        = cmoBrand.Text.Trim();
            string model        = cmoModel.Text.Trim();
            int year            = int.Parse(txtYear.Text.Trim());
            decimal price       = decimal.Parse(txtPrice.Text);
            string fuelType     = cmoFuelType.Text.Trim();
            string transmission = cmoTransmission.Text.Trim();
            int Mileage         = int.Parse(txtMileage.Text.Trim());
            string color        = txtColor.Text.Trim();

            // Yeni Araba Nesnesi
            Car newCar = new Car
            {
                BrandName    = brand,
                ModelName    = model,
                Year         = year,
                Price        = price,
                FuelType     = fuelType,
                Transmission = transmission,
                Mileage      = Mileage,
                Color        = color
            };

            // Veritabanına Kaydet
            _carRepository.Add(newCar);

            ListngCars();
            MessageBox.Show("Araç başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan gelen veriyi al
            int id              = int.Parse(txtID.Text);
            string brand        = cmoBrand.Text.Trim();
            string model        = cmoModel.Text.Trim();
            int year            = int.Parse(txtYear.Text.Trim());
            decimal price       = decimal.Parse(txtPrice.Text);
            string fuelType     = cmoFuelType.Text.Trim();
            string transmission = cmoTransmission.Text.Trim();
            int Mileage         = int.Parse(txtMileage.Text.Trim());
            string color        = txtColor.Text.Trim();

            // Yeni Araba Nesnesi
            Car newCar = new Car
            {
                CarID        = id,
                BrandName    = brand,
                ModelName    = model,
                Year         = year,
                Price        = price,
                FuelType     = fuelType,
                Transmission = transmission,
                Mileage      = Mileage,
                Color        = color
            };

            // Veritabanına Kaydet
            _carRepository.Update(newCar);

            ListngCars();
            MessageBox.Show("Araç başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan gelen veriyi al
            int id = int.Parse(txtID.Text);

            // Veritabanına Kaydet
            _carRepository.Delete(id);

            ListngCars();
            MessageBox.Show("Araç başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void cmoBrandLoad()
        {
            var brands = _carRepository.GetAllBrands();
            cmoBrand.DisplayMember = "BrandName";
            cmoBrand.ValueMember   = "BrandID";
            cmoBrand.DataSource    = brands;
        }

        public void cmoModelLoad()
        {
            var models = _carRepository.GetAllModels();
            cmoModel.DisplayMember = "ModelName";
            cmoModel.ValueMember   = "ModelID";
            cmoModel.DataSource    = models;
        }

        public void cmoFuelTypeLoad()
        {
            var models = _carRepository.GetAllFuelTypes();
            cmoFuelType.DisplayMember = "Fuel";
            cmoFuelType.ValueMember   = "ID";
            cmoFuelType.DataSource    = models;
        }

        public void cmoTransmissionLoad()
        {
            var Transmission = _carRepository.GetAllTransmissions();
            cmoTransmission.DisplayMember = "TransmissionName";
            cmoTransmission.ValueMember   = "ID";
            cmoTransmission.DataSource    = Transmission;
        }

        public void ListngCars()
        {
            dgvListingCars.DataSource = _carRepository.GetAllCars();
        }

        private void dgvListingCars_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow row = dgvListingCars.SelectedRows[0];
            Car car = (Car)row.DataBoundItem;

            txtID.Text           = car.CarID.ToString();
            cmoBrand.Text        = car.BrandName;
            cmoModel.Text        = car.ModelName;
            txtYear.Text         = car.Year.ToString();
            txtPrice.Text        = car.Price.ToString();
            cmoFuelType.Text     = car.FuelType;
            cmoTransmission.Text = car.Transmission;
            txtMileage.Text      = car.Mileage.ToString();
            txtColor.Text        = car.Color;
        }
    }
}