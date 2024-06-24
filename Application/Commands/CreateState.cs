using Domain.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class CreateState:IRequest<StateDto>

    {
        public string? Name { get; set; }
        public string? StateCode { get; set; }
        public int CountryId { get; set; }
    }
}
