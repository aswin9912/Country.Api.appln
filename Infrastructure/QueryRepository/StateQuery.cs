using AutoMapper;
using Domain.Dto;
using Domain.Interface.IQueries;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.QueryRepository
{
    public class StateQuery : IState
    {
        private readonly CountryDb db;
        private readonly IMapper mapper;

        public StateQuery(CountryDb db,IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public IList<StateDto> GetAllStates()
        {
            var statelist=db.States.ToList();
            return mapper.Map<IList<StateDto>>(statelist);
        }

        public StateDto GetState(int id)
        {
            var statebyid=db.States.FirstOrDefault(x => x.Id == id);
            return mapper.Map<StateDto>(statebyid);
        }
    }
}
