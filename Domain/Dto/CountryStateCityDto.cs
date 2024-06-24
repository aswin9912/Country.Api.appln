using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto
{
    public class CountryStateCityDto
    {
        public int CountryId { get; set; }
        public string? CountryName {  get; set; }
        public string? CountryCode { get; set; }
        public string? StateName { get; set; }
        public string? StateCode { get; set; }
        public string? CityName {  get; set; }
        public string? CityCode { get; set; }
       
    }
}
