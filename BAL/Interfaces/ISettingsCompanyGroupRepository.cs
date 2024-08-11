using DAL.Models;
namespace BAL.Interfaces
{
    public interface ISettingsCompanyGroupRepository
    {
        Task<IEnumerable<SettingsCompanyGroup>> GetAllAsync();
        Task<SettingsCompanyGroup> GetByIdAsync(int id);
        Task AddAsync(SettingsCompanyGroup entity);
        Task UpdateAsync(SettingsCompanyGroup entity);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(string companyName); // Add this method
    }
}
