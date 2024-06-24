using AutoMapper;
using Domain.Dto;
using Domain.Interface.IQueries;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.QueryRepository
{
    public class CityQuery : ICity
    {
        private readonly CountryDb db;
        private readonly IMapper mapper;

        public CityQuery(CountryDb db,IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public IList<CityDto> GetAllCities()
        {
            var citylist=db.Cities.ToList();
            return mapper.Map<IList<CityDto>>(citylist);
        }

        public CityDto GetCityById(int id)
        {
            var citybyid=db.Cities.FirstOrDefault(x => x.Id == id);
            return mapper.Map<CityDto>(citybyid);
        }
    }
}
