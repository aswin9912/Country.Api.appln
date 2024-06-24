using Domain.Dto;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.IQueries
{
    public interface ICountry
    {
        IList<CountryDto> GetCountryList();
        CountryDto GetCountryById(int id);
        IList<CountryStateCityDto> GetCountryStateCity();

    }
}
