using Application.Commands;
using Domain.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handlers
{
    public class DeleteCountryHandler : IRequestHandler<DeleteCountry, int>
    {
        private readonly ICountryRepository countryRepository;

        public DeleteCountryHandler(ICountryRepository countryRepository)
        {
            this.countryRepository = countryRepository;
        }
        public async Task<int> Handle(DeleteCountry request, CancellationToken cancellationToken)
        {
            return await countryRepository.DeleteAsync(request.Id);
        }
    }
}
