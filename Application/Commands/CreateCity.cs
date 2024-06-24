using Domain.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class CreateCity:IRequest<CityDto>
    {
        public string? Name { get; set; }
        public string? CityCode { get; set; }
        public int StateId { get; set; }
    }
}
