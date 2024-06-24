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
    public class CreateCityHandler : IRequestHandler<CreateCity, CityDto>
    {
        private readonly ICityRepository cityRepository;
        private readonly IMapper mapper;

        public CreateCityHandler(ICityRepository cityRepository,IMapper mapper)
        {
            this.cityRepository = cityRepository;
            this.mapper = mapper;
        }
        public async Task<CityDto> Handle(CreateCity request, CancellationToken cancellationToken)
        {
            var newcity=new City { Name = request.Name ,CityCode=request.CityCode,StateId=request.StateId};
            var citynew=await cityRepository.CreateAsync(newcity);
            return mapper.Map<CityDto>(citynew);
        }
    }
}
