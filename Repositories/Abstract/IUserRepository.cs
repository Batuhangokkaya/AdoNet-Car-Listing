using Entities.Models;

namespace Repositories.Abstract
{
    public interface IUserRepository
    {
        void AddUser(User entity);
        void UpdateUser(User entity);
        void DeleteUser(int id);
        User GetByIdUser(int id);
        List<User> GetAllUsers();
    }
}