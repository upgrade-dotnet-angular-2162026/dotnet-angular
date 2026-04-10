using ECommService.Entities;

namespace ECommService.Repositories
{
    public interface IUserRepository
    {
        Task Register(User user);
        Task<User> Validate(string email,string password);
        Task Update(User user);
    }
}
