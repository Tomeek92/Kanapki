using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanapki
{
    class MenuItem
    {


        public Random randomizer = new Random();

        public string[] Proteins = { "Wołowina", "Salami", "Indyk", "Szynka", "Kurczak", "Tuńczyk" };
        public string[] Condiments = {"musztarda żółta","musztarda brązowa","musztarda miodowa","majonez",
    "przyprawy","sos francuski"};
        public string[] Breads = { "ryżowe", "białe", "pszenne", "pumpernikiel", "bułka" };
        public string Description = " ";
        public string Price;

        public void Generate()
        {
            string randomProtein = Proteins[randomizer.Next(Proteins.Length)];
            string randomCndiments = Condiments[randomizer.Next(Condiments.Length)];
            string randomBreads = Breads[randomizer.Next(Breads.Length)];
            Description = randomProtein + " " + "i" + " " + randomCndiments + " " + "Pieczywo" + " "+ randomBreads;

            decimal bucks = randomizer.Next(1, 5);
            decimal cents = randomizer.Next(1, 98);
            decimal price = bucks + (cents * .01M);
            Price = price.ToString("c");
        }

    }
}

