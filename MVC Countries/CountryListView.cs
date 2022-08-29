using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
namespace MVC_Countries
{
public class CountryListView
    {
        public CountryListView(List<Country> countries)
        {
            Countries = countries;
        }
        public List<Country> Countries { get; private set; }
        public void Display()
        {
            foreach (var country in Countries)
            {
                Console.WriteLine("Name: {0}", country.Name);
                Console.WriteLine("Continent: {0}", country.Continent);
                Console.WriteLine("Colors: {0}", string.Join(", ", country.Colors));
            }
        }


    }
}
