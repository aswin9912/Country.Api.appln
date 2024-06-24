using Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.IQueries
{
    public interface ICity
    {
        IList<CityDto>GetAllCities();
        CityDto GetCityById(int id);
    }
}
