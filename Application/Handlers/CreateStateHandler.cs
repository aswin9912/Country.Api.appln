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
    public class CreateStateHandler : IRequestHandler<CreateState, StateDto>
    {
        private readonly IStateRepository stateRepository;
        private readonly IMapper mapper;

        public CreateStateHandler(IStateRepository stateRepository,IMapper mapper)
        {
            this.stateRepository = stateRepository;
            this.mapper = mapper;
        }
        public async Task<StateDto> Handle(CreateState request, CancellationToken cancellationToken)
        {
           var newstate= new State { Name = request.Name ,StateCode=request.StateCode,CountryId=request.CountryId};
            var statenew=await stateRepository.CreateAsync(newstate);
            return mapper.Map<StateDto>(newstate);
        }
    }
}
