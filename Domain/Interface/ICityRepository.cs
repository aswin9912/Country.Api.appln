using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface ICityRepository
    {
        Task<City> CreateAsync(City city);
        Task<int> UpdateAsync(int id,City city);
        Task<int> DeleteAsync(int id);
    }
}
