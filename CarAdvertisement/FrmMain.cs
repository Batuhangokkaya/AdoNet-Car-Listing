using Entities.Models;
using Repositories.Concrete;

namespace CarAdvertisement
{
    public partial class FrmMain : Form
    {
        private readonly User _currentUser;
        private readonly CarRepository _carRepository;
        private readonly AnnouncementRepository _announcementRepository;
        private readonly UserRepository _userRepository;

        public FrmMain(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            _carRepository = new CarRepository();
            _announcementRepository = new AnnouncementRepository();
            _userRepository = new UserRepository();

            lblUsername.Text = "Hoş Geldin, " + _currentUser.UserName; // Kullanıcı adını göster
            LoadAnnouncements();

            SetButtonVisibility();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            FrmCarEdit frmCarAdd = new FrmCarEdit();
            frmCarAdd.Show();
        }

        private void btnAddAd_Click(object sender, EventArgs e)
        {
            /*FrmAddAd frmAddAd = new FrmAddAd(_currentUser);
            frmAddAd.ShowDialog();*/

            var ilanEkleForm = new FrmAddAnnouncement(_currentUser);
            ilanEkleForm.IlanEklendi += LoadAnnouncements; // Event'i bağla
            ilanEkleForm.ShowDialog();
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            if (dgvAds.SelectedRows.Count > 0)
            {
                int carId = Convert.ToInt32(dgvAds.SelectedRows[0].Cells["Id"].Value);

                // Kullanıcıya emin olup olmadığını sor
                DialogResult result = MessageBox.Show(
                    "Bu ilanı silmek istediğinize emin misiniz?",
                    "İlan Silme",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    CarRepository carRepo = new CarRepository();
                    carRepo.Delete(carId);
                    MessageBox.Show("İlan başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir ilan seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            int carId = Convert.ToInt32(dgvAds.SelectedRows[0].Cells["AnnouncementID"].Value);
            FrmCarDetails detailsForm = new FrmCarDetails(carId);
            detailsForm.ShowDialog();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            FrmUserManagement frmUserManagement = new FrmUserManagement();
            frmUserManagement.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoadAnnouncements()
        {
            dgvAds.DataSource = _announcementRepository.GetAllAdAndCar();
        }
        private void llblPriceFilterASC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvAds.DataSource = _announcementRepository.GetAllAdAndCar().OrderBy(x => x.Price).ToList();
        }

        private void llblPriceFilterDESC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvAds.DataSource = _announcementRepository.GetAllAdAndCar().OrderByDescending(x => x.Price).ToList();
        }

        private void SetButtonVisibility()
        {
            if (_userRepository.GetByRole(_currentUser.UserID).Role == "Admin")
            {
                btnUserManagement.Visible = true;
            }
            else
            {
                btnUserManagement.Visible = false;
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit(); // Uygulamayı tamamen kapat
            }
        }
    }
}