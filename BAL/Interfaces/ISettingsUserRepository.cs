using DAL.Models;

namespace BAL.Interfaces
{
    public interface ISettingsUserRepository
    {
        Task<IEnumerable<SettingsUser>> GetAllUsersAsync();
        Task<SettingsUser> GetUserByIdAsync(int userId);
        Task<SettingsUser> AddUserAsync(SettingsUser user);
        Task<SettingsUser> UpdateUserAsync(SettingsUser user);
        Task<bool> DeleteUserAsync(int userId);
        Task<bool> UserExistsAsync(string username);
        bool ValidateUser(string username, string password);
    }
}
