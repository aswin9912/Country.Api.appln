﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto
{
    public class CityDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? CityCode { get; set; }
        public int StateId { get; set; }
    }
}
