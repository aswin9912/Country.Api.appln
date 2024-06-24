using Application.Commands;
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
    public class UpdateCityHandler : IRequestHandler<UpdateCity, int>
    {
        private readonly ICityRepository cityRepository;

        public UpdateCityHandler(ICityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }
        public async Task<int> Handle(UpdateCity request, CancellationToken cancellationToken)
        {
            var newcity=new City { Name = request.Name,CityCode = request.CityCode ,StateId=request.StateId};
            var citynew=await cityRepository.UpdateAsync(request.Id, newcity);
            return citynew;
        }
    }
}
