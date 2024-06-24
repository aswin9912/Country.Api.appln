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
    public class CityRepository : ICityRepository
    {
        private readonly CountryDb db;

        public CityRepository(CountryDb db)
        {
            this.db = db;
        }
        public async Task<City> CreateAsync(City city)
        {
            await db.Cities.AddAsync(city);
            await db.SaveChangesAsync();
            return city;

        }

        public async Task<int> DeleteAsync(int id)
        {
            return await db.Cities.Where(l=>l.Id==id).ExecuteDeleteAsync();
        }

        public async Task<int> UpdateAsync(int id, City city)
        {
            return await db.Cities.Where(l=>l.Id==id).ExecuteUpdateAsync(setters=>setters
            .SetProperty(m=>m.Name, city.Name)
            .SetProperty(m=>m.CityCode,city.CityCode)
            .SetProperty(m=>m.StateId,city.StateId));
        }
    }
}
