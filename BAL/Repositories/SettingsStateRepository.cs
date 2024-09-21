using DAL.Models;
using BAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using DAL.CustomModels;

namespace BAL.Repositories
{
    public class SettingsStateRepository : ISettingsStateRepository
    {
        private readonly PayrollDbContext _context;

        public SettingsStateRepository(PayrollDbContext context)
        {
            _context = context;
        }

        public IQueryable<SettingsState> GetAll()
        {
            return _context.SettingsStates;
        }

        public async Task<SettingsState?> GetByIdAsync(int id)
        {
            return await _context.SettingsStates.FindAsync(id);
        }

        public async Task AddAsync(SettingsState state)
        {
            _context.SettingsStates.Add(state);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(SettingsState state)
        {
            _context.Entry(state).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var state = await _context.SettingsStates.FindAsync(id);
            if (state != null)
            {
                _context.SettingsStates.Remove(state);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<SettingsStateWithCountry>> GetAllStatesWithCountryAsync()
        {
            return await (from state in _context.SettingsStates
                          join country in _context.SettingsCountries
                          on state.CountryId equals country.CountryId
                          select new SettingsStateWithCountry
                          {
                              StateId = state.StateId,
                              StateName = state.StateName,
                              StateActive = state.StateActive,
                              CountryName = country.CountryName
                          }).ToListAsync();
        }
    }
}
