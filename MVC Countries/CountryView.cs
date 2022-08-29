using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    public class CountryView
    {
        
public CountryView(Country country)
{
    DisplayCountry = country;
}

        public Country DisplayCountry { get; private set; }

        //Public void Display() - This method will print out the Name, Continent, and Colors of the Country DisplayCountry property
        public void Display()
        {
            Console.WriteLine("Name: {0}", DisplayCountry.Name);
            Console.WriteLine("Continent: {0}", DisplayCountry.Continent);
            Console.WriteLine("Colors: {0}", string.Join(", ", DisplayCountry.Colors));
        }

    }
}
