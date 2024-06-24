using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class UpdateState:IRequest<int>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? StateCode { get; set; }
        public int CountryId { get; set; }
    }
}
