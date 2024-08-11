using BAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Repositories
{
    public class SettingsLocationRepository : ISettingsLocationRepository
    {
        private readonly PayrollDbContext _context;

        public SettingsLocationRepository(PayrollDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SettingsLocation>> GetAllAsync()
        {
            return await _context.SettingsLocations.ToListAsync();
        }

        public async Task<SettingsLocation> GetByIdAsync(int id)
        {
            return await _context.SettingsLocations.FindAsync(id);
        }

        public async Task AddAsync(SettingsLocation entity)
        {
            _context.SettingsLocations.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(SettingsLocation entity)
        {
            _context.SettingsLocations.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.SettingsLocations.FindAsync(id);
            if (entity != null)
            {
                _context.SettingsLocations.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<bool> ExistsAsync(string locationName)
        {
            return await _context.SettingsLocations.AnyAsync(c => c.LocationName == locationName && c.LocationActive == true);
        }
    }
}