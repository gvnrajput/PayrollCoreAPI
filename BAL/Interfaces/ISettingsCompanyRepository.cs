using DAL.Models;

namespace BAL.Interfaces
{
    public interface ISettingsCompanyRepository
    {
        Task<IEnumerable<SettingsCompany>> GetAllAsync();
        Task<SettingsCompany> GetByIdAsync(int id);
        Task AddAsync(SettingsCompany settingsCompany);
        Task UpdateAsync(SettingsCompany settingsCompany);
        Task DeleteAsync(int id);    
        Task<bool> ExistsAsync(string companyName);
    }
}
