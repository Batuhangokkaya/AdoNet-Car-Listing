using Entities.Models;
using Repositories.Concrete;

namespace CarAdvertisement
{
    public partial class FrmAddAnnouncement : Form
    {
        private readonly AnnouncementRepository _announcementRepository;
        private readonly User _currentUser;

        public event Action? IlanEklendi;
        public FrmAddAnnouncement(User currentUser)
        {
            InitializeComponent();
            _announcementRepository = new AnnouncementRepository();

            _currentUser = currentUser;
            LoadCarsList();
            LoadLocationslist();
            LoadAnnouncements();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Announcement listing = new Announcement
            {
                CarID       = Convert.ToInt32(cmoCarID.Text),
                UserID      = _currentUser.UserID,
                Description = txtDescription.Text,
                Location    = cmoLocation.Text,
                Status      = cekStatus.Checked ? "Active" : "Passive"
            };
            _announcementRepository.AddAd(listing);

            LoadAnnouncements();
            IlanEklendi?.Invoke();
            MessageBox.Show("İlan başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Announcement listing = new Announcement
            {
                AnnouncementID = Convert.ToInt32(txtID.Text),
                CarID          = Convert.ToInt32(cmoCarID.Text),
                Description    = txtDescription.Text,
                Location       = cmoLocation.Text,
                Status         = cekStatus.Checked ? "Active" : "Passive"
            };
            _announcementRepository.UpdateAd(listing);

            LoadAnnouncements();
            IlanEklendi?.Invoke();
            MessageBox.Show("İlan başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            _announcementRepository.DeleteAd(id);

            LoadAnnouncements();
            IlanEklendi?.Invoke();
            MessageBox.Show("İlan başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LoadCarsList()
        {
            var car = _announcementRepository.GetAllCars();
            cmoCarID.DisplayMember = "CarID";
            cmoCarID.ValueMember   = "CarID";
            cmoCarID.DataSource    = car;
        }

        public void LoadLocationslist()
        {
            var location = _announcementRepository.GetAllLocations();
            cmoLocation.DisplayMember = "LocationName";
            cmoLocation.ValueMember   = "ID";
            cmoLocation.DataSource    = location;
        }

        public void LoadAnnouncements()
        {
            dgvListing.DataSource = _announcementRepository.GetAllAnnouncements(_currentUser.UserID);
            dgvListing.Columns["UserID"].Visible = false;
        }

        private void dgvListing_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow row       = dgvListing.SelectedRows[0];
            Announcement announcement = (Announcement)row.DataBoundItem;

            txtID.Text          = announcement.AnnouncementID.ToString();
            cmoCarID.Text       = announcement.CarID.ToString();
            txtDescription.Text = announcement.Description;
            cmoLocation.Text    = announcement.Location;
            cekStatus.Checked   = announcement.Status == "Active";
        }
    }
}