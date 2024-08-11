using Microsoft.EntityFrameworkCore;
using DAL.Models;
using BAL.Interfaces;

namespace BAL.Repositories
{
    public class SettingsCompanyRepository : ISettingsCompanyRepository
    {
        private readonly PayrollDbContext _context;

        public SettingsCompanyRepository(PayrollDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SettingsCompany>> GetAllAsync()
        {
            return await _context.SettingsCompanies.ToListAsync();
        }

        public async Task<SettingsCompany> GetByIdAsync(int id)
        {
            return await _context.SettingsCompanies.FindAsync(id);
        }

        public async Task AddAsync(SettingsCompany settingsCompany)
        {
            _context.SettingsCompanies.Add(settingsCompany);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(SettingsCompany settingsCompany)
        {
            _context.Entry(settingsCompany).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var settingsCompany = await _context.SettingsCompanies.FindAsync(id);
            if (settingsCompany != null)
            {
                _context.SettingsCompanies.Remove(settingsCompany);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<bool> ExistsAsync(string companyName)
        {
            return await _context.SettingsCompanies
                                 .AnyAsync(c => c.CompanyName == companyName && c.CompanyActive == true);
        }
    }
}
