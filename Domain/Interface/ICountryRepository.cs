using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface ICountryRepository
    {
        Task<Country>CreateAsync(Country country);
        Task<int>  UpdateAsync(int id,Country country);
        Task<int> DeleteAsync(int id);

    }
}
