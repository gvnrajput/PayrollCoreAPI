using DAL.Models;
using BAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class SettingsUserRepository : ISettingsUserRepository
    {
        private readonly PayrollDbContext _context;

        public SettingsUserRepository(PayrollDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SettingsUser>> GetAllUsersAsync()
        {
            return await _context.SettingsUsers.ToListAsync();
        }

        public async Task<SettingsUser> GetUserByIdAsync(int userId)
        {
            return await _context.SettingsUsers
                .Include(u => u.UserGroup) 
                .FirstOrDefaultAsync(u => u.UserId == userId);
        }

        public async Task<SettingsUser> AddUserAsync(SettingsUser user)
        {
            _context.SettingsUsers.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<SettingsUser> UpdateUserAsync(SettingsUser user)
        {
            _context.SettingsUsers.Update(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<bool> DeleteUserAsync(int userId)
        {
            var user = await _context.SettingsUsers.FindAsync(userId);
            if (user == null)
            {
                return false;
            }

            _context.SettingsUsers.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UserExistsAsync(string username)
        {
            return await _context.SettingsUsers.AnyAsync(u => u.UserName == username);
        }
        public bool ValidateUser(string username, string password)
        {
            return _context.SettingsUsers
                .AnyAsync(u => u.UserName == username && u.Password == password)
                .GetAwaiter()
                .GetResult();
        }
    }
}
