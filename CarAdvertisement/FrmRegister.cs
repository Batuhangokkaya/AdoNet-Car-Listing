using Entities.Models;
using Repositories.Concrete;

namespace CarAdvertisement
{
    public partial class FrmRegister : Form
    {
        UserRepository _userRepository;
        public FrmRegister()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName  = txtLastName.Text.Trim();
            string userName  = txtUser.Text.Trim();
            string password  = txtPassword.Text.Trim();
            string email     = txtMail.Text.Trim();
            string phone     = txtPhone.Text.Trim();

            if (userName == "" || password == "" || email == "")
            {
                MessageBox.Show("Lütfen tüm zorunlu alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User user = new User
            {
                FirstName    = firstName,
                LastName     = lastName,
                UserName     = userName,
                PasswordHash = password,
                EMail        = email,
                Phone        = phone,
                Role         = "User"
            };
            _userRepository.AddUser(user);

            if (user != null)
            {
                MessageBox.Show("Kayıt işlemi başarıyla tamamlanmıştır.");
                this.Close();
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}