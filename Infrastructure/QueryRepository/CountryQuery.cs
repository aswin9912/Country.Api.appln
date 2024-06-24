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
    public class CountryQuery : ICountry
    {
        private readonly CountryDb db;
        private readonly IMapper mapper;

        public CountryQuery(CountryDb db,IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public CountryDto GetCountryById(int id)
        {
            var countrybyid=db.Countries.FirstOrDefault(c => c.Id == id);
            return mapper.Map<CountryDto>(countrybyid);
        }

        public IList<CountryDto> GetCountryList()
        {
            var countylist=db.Countries.ToList();
            
            return mapper.Map<IList<CountryDto>>(countylist);
        }

        IList<CountryStateCityDto> ICountry.GetCountryStateCity()
        {
            var countylist = db.Countries.ToList();
            var statelist = db.States.ToList();
            var citylist=db.Cities.ToList();
            var CS = from c in countylist
                     join s in statelist on c.Id equals s.CountryId
                     join city in citylist on s.Id equals city.StateId
                     select new CountryStateCityDto
                     {
                         CountryId = c.Id,
                         CountryName = c.Name,
                         CountryCode = c.CountryCode,
                         StateName = s.Name,
                         StateCode =s.StateCode,
                         CityName=city.Name,
                         CityCode=city.CityCode
                         
                     };
            return mapper.Map<IList<CountryStateCityDto>>(CS);
        }

       
    }
}
