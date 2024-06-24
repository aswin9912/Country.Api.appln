using Domain.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class CreateCountry:IRequest<CountryDto>

    {
        public string? Name { get; set; }
        public string? CountryCode { get; set; }
    }
}
