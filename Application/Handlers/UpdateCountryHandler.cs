using Application.Commands;
using AutoMapper;
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
    public class UpdateCountryHandler : IRequestHandler<UpdateCountry, int>
    {
        private readonly ICountryRepository countryRepository;
        

        public UpdateCountryHandler(ICountryRepository countryRepository)
        {
            this.countryRepository = countryRepository;
        }
        public async Task<int> Handle(UpdateCountry request, CancellationToken cancellationToken)
        {
            var updatecountry=new Country { Name = request.Name ,CountryCode=request.CountryCode};
            var newcountry=await countryRepository.UpdateAsync(request.Id,updatecountry);
            return newcountry;

        }
    }
}
