using ECommService.Database;
using ECommService.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommService.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ECommDbContext _context;

        public UserRepository(ECommDbContext context)
        {
            _context = context;
        }

        public async Task Register(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task Update(User updateUser)
        {
            var existingUser= await _context.Users.FindAsync(updateUser.UserId);
            //updated only Email and Mobile and rest are same as it is
            existingUser.Email=updateUser.Email;
            existingUser.Mobile=updateUser.Mobile;
            await _context.SaveChangesAsync();
        }

        public async Task<User> Validate(string email, string password)
        {
            User ?user= await _context.Users.SingleOrDefaultAsync(u=>u.Email==email &&  u.Password==password);
            return user;
        }
    }
}
