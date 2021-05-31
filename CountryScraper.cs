using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WebScraper
{
    public class CountryScraper
    {
        private const string BaseUrl = "https://unece.org/trade/cefact/unlocode-code-list-country-and-territory";

        public IEnumerable<CountryModel> GetCountries()
        {
            var web = new HtmlWeb();
            var document = web.Load(BaseUrl);

            var tableRows = document.QuerySelectorAll("table tr").Skip(1);

            foreach (var tableRow in tableRows)
            {
                var tds = tableRow.QuerySelectorAll("td");

                var code = tds[0].InnerText;
                var name = tds[1].InnerText;

                var href = tds[1].QuerySelector("a").Attributes["href"].Value;

                yield return new CountryModel(code, name, href);
            }
        }
    }
}
