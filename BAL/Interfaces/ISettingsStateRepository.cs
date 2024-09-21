using DAL.CustomModels;
using DAL.Models;

namespace BAL.Interfaces
{
    public interface ISettingsStateRepository
    {
        IQueryable<SettingsState> GetAll();
        Task<SettingsState?> GetByIdAsync(int id);
        Task AddAsync(SettingsState state);
        Task UpdateAsync(SettingsState state);
        Task DeleteAsync(int id);
        Task<IEnumerable<SettingsStateWithCountry>> GetAllStatesWithCountryAsync();
    }
}
