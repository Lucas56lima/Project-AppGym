using Domain.Entities;

namespace Domain.Interface
{
    public interface IUserRepository   
    {
        Task<User> GetUserByIdAsync(int id);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task <User>PostUserAsync(User user);
        Task<User> GetByEmailAsync(string email);
    }
}