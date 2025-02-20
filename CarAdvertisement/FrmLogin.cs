using Entities.Models;
using Repositories;
using Repositories.Concrete;

namespace CarAdvertisement
{
    public partial class FrmLogin : Form
    {
        RepositoryContext _repositoryContext;
        UserRepository _userRepository;

        public FrmLogin()
        {
            InitializeComponent();
            _repositoryContext = new RepositoryContext();
            _userRepository    = new UserRepository();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            string password = txtPassword.Text;

            User user = _userRepository.UserLogin(userName, password);

            if (user != null)
            {
                this.Hide();
                FrmMain registerForm = new FrmMain(user);
                
                registerForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Hatalý kullanýcý adý veya þifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegister registerForm = new FrmRegister();
            registerForm.ShowDialog();
            this.Show();
        }
    }
}