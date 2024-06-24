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
    public class DeleteStateHandler : IRequestHandler<DeleteState, int>
    {
        private readonly IStateRepository stateRepository;

        public DeleteStateHandler(IStateRepository stateRepository)
        {
            this.stateRepository = stateRepository;
        }
        public async Task<int> Handle(DeleteState request, CancellationToken cancellationToken)
        {
            return await stateRepository.DeleteAsync(request.Id);
        }
    }
}
