using Application.Commands;
using AutoMapper;
using Domain.Dto;
using Domain.Entities;
using Domain.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handlers
{
    public class CreateCountryHandler : IRequestHandler<CreateCountry, CountryDto>
    {
        private readonly ICountryRepository countryRepository;
        private readonly IMapper mapper;

        public CreateCountryHandler(ICountryRepository countryRepository,IMapper mapper)
        {
            this.countryRepository = countryRepository;
            this.mapper = mapper;
        }
        public async Task<CountryDto> Handle(CreateCountry request, CancellationToken cancellationToken)
        {
            var newcountry=new Country { Name = request.Name ,CountryCode=request.CountryCode};
            var countrynew=await countryRepository.CreateAsync(newcountry);
            return mapper.Map<CountryDto>(countrynew);
        }
    }
}
