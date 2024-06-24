using Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.IQueries
{
    public interface IState
    {
        IList<StateDto> GetAllStates();
        StateDto GetState(int id);
    }
}
