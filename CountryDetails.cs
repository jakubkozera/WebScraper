using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraper
{
    public class CountryDetails
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public List<CityModel> Cities { get; set; }
    }
}
