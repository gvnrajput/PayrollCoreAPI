using DAL.Models;

namespace BAL.Interfaces
{
    public interface ISettingsLocationRepository
    {
        Task<IEnumerable<SettingsLocation>> GetAllAsync();
        Task<SettingsLocation> GetByIdAsync(int id);
        Task AddAsync(SettingsLocation entity);
        Task UpdateAsync(SettingsLocation entity);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(string locationName);
    }
}
