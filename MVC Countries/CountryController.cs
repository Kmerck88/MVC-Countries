using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    public class CountryController
    {
        public List<Country> CountryDb = new List<Country>();
        public CountryController()
        {
            CountryDb.Add(new Country("USA", "North America", new List<string> { "Red", "White", "Blue" }));
            CountryDb.Add(new Country("Canada", "North America", new List<string> { "Red", "White", "Red" }));
            CountryDb.Add(new Country("Mexico", "North America", new List<string> { "Green", "White", "Red" }));
            CountryDb.Add(new Country("Argentina", "South America", new List<string> { "blue", "White", "Blue" }));
            CountryDb.Add(new Country("Spain", "Europe", new List<string> { "Yellow", "Red", "Yellow" }));

        }

        private static void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }
        //        public void WelcomeAction() - This will take no parameter and pass CountryDb into the CountryListView class. Then, it will print “Hello, welcome to the country app.Please select a country from the following list:” Then it will call Display() on the CountryListView.
        public void WelcomeAction()
        {
            CountryListView clv = new CountryListView(CountryDb);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
            clv.Display();
        }
        //Next allow the user to select a country by index.Upon getting the country out of CountryDb, pass that country along to the CountryAction() method. After that’s done, ask if the user would like to learn about another country.
        public void SelectCountryAction(int index)
        {
            CountryAction(CountryDb[index]);
        }
        //CountryAction() method.After that’s done, ask if the user would like to learn about another country.
        public void LearnAboutAnotherCountryAction()
        {
            Console.WriteLine("Would you like to learn about another country? (y/n)");
            string input = Console.ReadLine();
            if (input == "y")
            {
                WelcomeAction();
            }
            else
            {
                Console.WriteLine("Thank you for using the country app!");
            }
        }





    }
}
