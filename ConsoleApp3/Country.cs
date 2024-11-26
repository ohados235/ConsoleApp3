using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Country
    {
        string countryName;
        Game[] games= new Game[43];

        public Country(string country) 
        {
            games[0].SetGN(country);
        for (int i = 1; i < games.Length; i++)
            {
                games[i].SetGN("");
            }
        }


        public bool C(string country)
        {
            for (int i = 0; i < games.Length; i++)
            {
                if(games[i].GetGN() == country)
                {
                    return true;
                }
               
            }
            return false;
        }
    }
}
