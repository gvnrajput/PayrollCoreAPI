using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BAL.Interfaces;
using DAL.Models;

namespace BAL.Repositories
{
    public class SettingsCountryRepository : ISettingsCountryRepository
    {
        private readonly PayrollDbContext _context;

        public SettingsCountryRepository(PayrollDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SettingsCountry>> GetAllAsync()
        {
            return await _context.SettingsCountries.ToListAsync();
        }

        public async Task<SettingsCountry> GetByIdAsync(int id)
        {
            return await _context.SettingsCountries.FindAsync(id);
        }

        public async Task AddAsync(SettingsCountry entity)
        {
            _context.SettingsCountries.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(SettingsCountry entity)
        {
            _context.SettingsCountries.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.SettingsCountries.FindAsync(id);
            if (entity != null)
            {
                _context.SettingsCountries.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistsAsync(string countryName)
        {
            return await _context.SettingsCountries.AnyAsync(c => c.CountryName == countryName && c.CountryActive == true);
        }
    }
}
