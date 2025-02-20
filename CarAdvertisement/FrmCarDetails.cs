using Entities.Models;
using Repositories.Concrete;

namespace CarAdvertisement
{
    public partial class FrmCarDetails : Form
    {
        private readonly AnnouncementRepository _announcementRepository;
        private int carId;

        public FrmCarDetails(int selectedCarId)
        {
            InitializeComponent();
            _announcementRepository = new AnnouncementRepository();

            carId = selectedCarId;
            LoadCarDetails();
        }

        private void LoadCarDetails()
        {
            CarWithAnnouncement carWithListings = _announcementRepository.GetByIdAdAndCar(carId);

            if (carWithListings != null)
            {
                txtListingID.Text    = carWithListings.AnnouncementID.ToString();
                txtFirstName.Text    = carWithListings.FirstName;
                txtLastName.Text     = carWithListings.LastName;
                txtPhone.Text        = carWithListings.Phone;
                txtBrandName.Text    = carWithListings.BrandName;
                txtModelName.Text    = carWithListings.ModelName;
                txtYear.Text         = carWithListings.Year.ToString();
                txtPrice.Text        = carWithListings.Price.ToString();
                txtFuelType.Text     = carWithListings.FuelType;
                txtTransmission.Text = carWithListings.FuelType;
                txtMileage.Text      = carWithListings.FuelType;
                txtColor.Text        = carWithListings.Color;
                txtDescription.Text  = carWithListings.Description;
                txtLocation.Text     = carWithListings.Location;
                txtDateAt.Text       = carWithListings.AnnouncementAt.ToString();
                cekStatus.Text       = carWithListings.Status;
            }
        }
    }
}