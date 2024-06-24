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
    public class UpdateStateHandler : IRequestHandler<UpdateState, int>
    {
        private readonly IStateRepository stateRepository;

        public UpdateStateHandler(IStateRepository stateRepository)
        {
            this.stateRepository = stateRepository;
        }
        public async Task<int> Handle(UpdateState request, CancellationToken cancellationToken)
        {
            var newState=new State { Name = request.Name ,StateCode=request.StateCode,CountryId=request.CountryId};
            var statenew = await stateRepository.UpdateAsync(request.Id,newState);
            return statenew;
        }
    }
}
