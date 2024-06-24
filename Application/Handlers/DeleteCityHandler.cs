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
    public class DeleteCityHandler : IRequestHandler<DeleteCity, int>
    {
        private readonly ICityRepository cityRepository;

        public DeleteCityHandler(ICityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }
        public async Task<int> Handle(DeleteCity request, CancellationToken cancellationToken)
        {
            return await cityRepository.DeleteAsync(request.Id);
        }
    }
}
