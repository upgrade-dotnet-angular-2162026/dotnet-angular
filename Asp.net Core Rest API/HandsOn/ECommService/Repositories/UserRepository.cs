using ECommService.Entities;

namespace ECommService.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task Register(User user)
        {
            throw new NotImplementedException();
        }

        public Task Update(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> Validate(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
