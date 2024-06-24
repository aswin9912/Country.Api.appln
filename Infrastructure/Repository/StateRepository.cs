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
    public class StateRepository : IStateRepository
    {
        private readonly CountryDb db;

        public StateRepository(CountryDb db)
        {
            this.db = db;
        }
        public async Task<State> CreateAsync(State state)
        {
            await db.States.AddAsync(state);
            await db.SaveChangesAsync();
            return state;
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await db.States.Where(l => l.Id == id).ExecuteDeleteAsync();

        }

        public async Task<int> UpdateAsync(int id, State state)
        {
            return await db.States.Where(l => l.Id == id).ExecuteUpdateAsync(setters => setters
            .SetProperty(m => m.Name, state.Name)
            .SetProperty(m=>m.StateCode,state.StateCode)
            .SetProperty(m=>m.CountryId,state.CountryId));
        }
    }
}
