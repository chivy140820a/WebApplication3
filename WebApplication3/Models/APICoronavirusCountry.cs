using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class APICoronavirusCountry
    {
       
        public string Country { get; set; }
        public int Cases { get; set; }
        public int TodayCases { get; set; }
        public int Deaths { get; set; }
        public int TodayDeaths { get; set; }
        public int Recovered { get; set; }
        public int TodayRecovered { get; set; }
        public int Active { get; set; }
        public int Population { get; set; }
        public string Continent { get; set; }
        public int Tests { get; set; }
        public APICoronavirusCountryInfo CountryInfo { get; set; }

    }
}
