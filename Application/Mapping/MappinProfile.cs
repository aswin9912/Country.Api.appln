using AutoMapper;
using Domain.Dto;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping
{
    public class MappinProfile:Profile
    {
        public MappinProfile()
        {
            CreateMap<Country,CountryDto>().ReverseMap();
            CreateMap<State,StateDto>().ReverseMap();
            CreateMap<City,CityDto>().ReverseMap();
            
        }
    }
}
