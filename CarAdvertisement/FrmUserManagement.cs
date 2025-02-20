using Entities.Models;
using Repositories.Concrete;

namespace CarAdvertisement
{
    public partial class FrmUserManagement : Form
    {
        private readonly UserRepository _userRepository;
        public FrmUserManagement()
        {
            InitializeComponent();
            _userRepository = new UserRepository();

            LoadUserList();
            LoadRoles();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName  = txtLastName.Text;
            string username  = txtUserName.Text;
            string password  = txtPassword.Text;
            string email     = txtEmail.Text;
            string phone     = txtPhone.Text;
            string role      = cmoRole.Text;

            User user = new User
            {
                FirstName    = firstName,
                LastName     = lastName,
                UserName     = username,
                PasswordHash = password,
                EMail        = email,
                Phone        = phone,
                Role         = role,
            };

            _userRepository.AddUser(user);
            LoadUserList();
            MessageBox.Show("Kullanıcı başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            int userID       = Convert.ToInt32(txtUserID.Text);
            string firstName = txtFirstName.Text;
            string lastName  = txtLastName.Text;
            string username  = txtUserName.Text;
            string password  = txtPassword.Text;
            string email     = txtEmail.Text;
            string phone     = txtPhone.Text;
            string role      = cmoRole.Text;

            User user = new User
            {
                UserID       = userID,
                FirstName    = firstName,
                LastName     = lastName,
                UserName     = username,
                PasswordHash = password,
                EMail        = email,
                Phone        = phone,
                Role         = role,
            };

            _userRepository.UpdateUser(user);

            LoadUserList();
            MessageBox.Show("Kullanıcı başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(txtUserID.Text);
            _userRepository.DeleteUser(userID);

            LoadUserList();
            MessageBox.Show("Kullanıcı başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadUserList()
        {
            dgvUsers.DataSource = _userRepository.GetAllUsers();
        }

        private void LoadRoles()
        {
            var role = _userRepository.GetAllRoles();
            cmoRole.DisplayMember = "RoleName";
            cmoRole.ValueMember   = "ID";
            cmoRole.DataSource    = role;
        }

        private void dgvUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgvUsers.SelectedRows[0];
            User user = (User)row.DataBoundItem;

            txtUserID.Text    = user.UserID.ToString();
            txtFirstName.Text = user.FirstName.ToString();
            txtLastName.Text  = user.LastName.ToString();
            txtUserName.Text  = user.UserName.ToString();
            txtPassword.Text  = user.PasswordHash.ToString();
            txtEmail.Text     = user.EMail.ToString();
            txtPhone.Text     = user.Phone.ToString();
            cmoRole.Text      = user.Role.ToString();
        }
    }
}