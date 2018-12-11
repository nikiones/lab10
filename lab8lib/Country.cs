using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab8lib
{
    public class Country
    {
        public string Name { get; set; }
        public string Towns { get; set; }
        public int Population { get; set; }
        public int Square { get; set; }
        public bool HasSea { get; set; }

        public Country()
        {

        }
        public Country(string name, string towns, int population, int square, bool hasSea)
        {
            Name = name;
            Towns = towns;
            Population = population;
            Square = square;
            HasSea = hasSea;
        }
    }
   
}
