using System;
using System.Collections.Generic;

namespace _05._CitiesbyContinentandCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var continents = new Dictionary<string, Dictionary<string, List<string>>>();
            for(int i = 0; i < lines; i++)
            {
                string[] cmd = Console.ReadLine().Split();
                string continent = cmd[0];
                string country = cmd[1];
                string city = cmd[2];
                if (!continents.ContainsKey(continent))
{
                    continents.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country,new List<string>());
                }
                continents[continent][country].Add(city);
            }
            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {String.Join(", ",country.Value)}");
                }
            }
        }
    }
}
