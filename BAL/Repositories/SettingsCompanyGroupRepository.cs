﻿using BAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BAL.Repositories
{
    public class SettingsCompanyGroupRepository : ISettingsCompanyGroupRepository
    {
        private readonly PayrollDbContext _context;

        public SettingsCompanyGroupRepository(PayrollDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SettingsCompanyGroup>> GetAllAsync()
        {
            return await _context.SettingsCompanyGroups.ToListAsync();
        }

        public async Task<SettingsCompanyGroup> GetByIdAsync(int id)
        {
            return await _context.SettingsCompanyGroups.FindAsync(id);
        }

        public async Task AddAsync(SettingsCompanyGroup entity)
        {
            _context.SettingsCompanyGroups.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(SettingsCompanyGroup entity)
        {
            _context.SettingsCompanyGroups.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.SettingsCompanyGroups.FindAsync(id);
            if (entity != null)
            {
                _context.SettingsCompanyGroups.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<bool> ExistsAsync(string companyGroupName)
        {
            return await _context.SettingsCompanyGroups.AnyAsync(c => c.CompanyGroupName== companyGroupName && c.CompanyGroupActive == true);
        }
    }
}
