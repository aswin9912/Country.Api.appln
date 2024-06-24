using AutoMapper;
using Domain.Entities;
using Domain.Interface;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class CountryRepository : ICountryRepository
    {
        private readonly CountryDb db;
        

        public CountryRepository(CountryDb db)
        {
            this.db = db;
            
        }
        public async Task<Country> CreateAsync(Country country)
        {
            await db.Countries.AddAsync(country);
            await db.SaveChangesAsync();
            return country;
        }

        public async Task<int> DeleteAsync(int id)
        {
           return await db.Countries.Where(l=>l.Id==id).ExecuteDeleteAsync();

        }

        public async Task<int> UpdateAsync(int id, Country country)
        {
            return await db.Countries.Where(l=>l.Id==id).ExecuteUpdateAsync(setters=>setters
            .SetProperty(m=>m.Name, country.Name)
            .SetProperty(m=>m.CountryCode,country.CountryCode)
            );
        }
    }
}
