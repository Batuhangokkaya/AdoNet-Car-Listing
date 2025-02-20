using Entities.Models;
using Repositories.Abstract;
using System.Data.SqlClient;

namespace Repositories.Concrete
{
    public class UserRepository : IUserRepository
    {
        public void AddUser(User entity)
        {
            using (var db = new RepositoryContext())
            {
                db.GetConnection();
                string query = "INSERT INTO Users (FirstName, LastName, UserName, PasswordHash, Email, Phone, Role, CreatedAt) VALUES (@firstName, @lastName, @userName, @password, @email, @phone, @role, @createdAt)";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@firstName", entity.FirstName);
                cmd.Parameters.AddWithValue("@lastName", entity.LastName);
                cmd.Parameters.AddWithValue("@userName", entity.UserName);
                cmd.Parameters.AddWithValue("@password", entity.PasswordHash);
                cmd.Parameters.AddWithValue("@email", entity.EMail);
                cmd.Parameters.AddWithValue("@phone", entity.Phone);
                cmd.Parameters.AddWithValue("@role", entity.Role);
                cmd.Parameters.AddWithValue("@createdAt", DateTime.Now);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateUser(User entity)
        {
            using (var db = new RepositoryContext())
            {
                db.GetConnection();
                string query   = "UPDATE Users SET FirstName = @firstName, LastName = @lastName, UserName = @userName, PasswordHash = @password, Email = @email, Phone = @phone, Role = @role, CreatedAt = @createdAt WHERE UserID = @userID";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@userID", entity.UserID);
                cmd.Parameters.AddWithValue("@firstName", entity.FirstName);
                cmd.Parameters.AddWithValue("@lastName", entity.LastName);
                cmd.Parameters.AddWithValue("@userName", entity.UserName);
                cmd.Parameters.AddWithValue("@password", entity.PasswordHash);
                cmd.Parameters.AddWithValue("@email", entity.EMail);
                cmd.Parameters.AddWithValue("@phone", entity.Phone);
                cmd.Parameters.AddWithValue("@role", entity.Role);
                cmd.Parameters.AddWithValue("@createdAt", DateTime.Now);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteUser(int id)
        {
            using (var db = new RepositoryContext())
            {
                string query   = "DELETE FROM Users WHERE UserID = @userID";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@userID", id);

                cmd.ExecuteNonQuery();
            }
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            using (var db = new RepositoryContext())
            {
                string query         = "SELECT * FROM Users";
                SqlCommand cmd       = new SqlCommand(query, db.GetConnection());
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    User user = new User
                    {
                        UserID       = (int)reader["UserID"],
                        FirstName    = reader["FirstName"].ToString(),
                        LastName     = reader["LastName"].ToString(),
                        UserName     = reader["UserName"].ToString(),
                        PasswordHash = reader["PasswordHash"].ToString(),
                        EMail        = reader["Email"].ToString(),
                        Phone        = reader["Phone"].ToString(),
                        Role         = reader["Role"].ToString(),
                        CreatedAt    = reader["CreatedAt"].ToString()
                    };
                    users.Add(user);
                }
            }
            return users;
        }

        public User GetByIdUser(int id)
        {
            using (var db = new RepositoryContext())
            {
                string query   = "SELECT * FROM Users WHERE UserID = @userID";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@userID", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new User
                    {
                        UserID       = (int)reader["UserID"],
                        UserName     = reader["UserName"].ToString(),
                        PasswordHash = reader["Password"].ToString(),
                        EMail        = reader["Email"].ToString(),
                        Phone        = reader["Phone"].ToString(),
                        Role         = reader["Role"].ToString(),
                        CreatedAt    = reader["CreatedAt"].ToString()
                    };
                }
            return null;
            }
        }

        public User GetByRole(int id)
        {
            using (var db = new RepositoryContext())
            {
                string query = "SELECT * FROM Users WHERE UserID = @userID";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@userID", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new User
                    {
                        UserID = (int)reader["UserID"],
                        Role = reader["Role"].ToString(),
                    };
                }
                return null;
            }
        }

        public User UserLogin(string userName, string password)
        {
            using (var db = new RepositoryContext())
            {
                string query   = "SELECT * FROM Users WHERE Username = @username AND PasswordHash = @password";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@username", userName);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        UserID       = Convert.ToInt32(reader["UserID"]),
                        UserName     = reader["UserName"].ToString(),
                        PasswordHash = reader["PasswordHash"].ToString()
                    };
                }
                return null;
            }
        }

        public List<Role> GetAllRoles()
        {
            List<Role> roles = new List<Role>();

            using (var db = new RepositoryContext())
            {
                string query = "SELECT * FROM Roles";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Role role = new Role
                    {
                        ID       = (int)reader["ID"],
                        RoleName = reader["RoleName"].ToString()
                    };
                    roles.Add(role);
                }
                return roles;
            }
        }
    }
}