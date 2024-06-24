using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IStateRepository
    {
        Task<State> CreateAsync(State state);
        Task<int> UpdateAsync(int id,State state);
        Task<int> DeleteAsync(int id);
    }
}
