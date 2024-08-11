using DAL.Models;

namespace BAL.Interfaces
{
    public interface ISettingsCountryRepository
    {
        Task<IEnumerable<SettingsCountry>> GetAllAsync();
        Task<SettingsCountry> GetByIdAsync(int id);
        Task AddAsync(SettingsCountry entity);
        Task UpdateAsync(SettingsCountry entity);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(string countryName);
    }
}
