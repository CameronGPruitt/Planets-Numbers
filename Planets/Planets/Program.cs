using System;
using System.Collections.Generic;
using System.Linq;

namespace Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Planets

            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            //Step 1
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            Console.WriteLine("Planet List");
            planetList.ForEach(planet => Console.WriteLine(planet));

            //Step 2
            List<string> planetList2 = new List<string>() { "Neptune", "Pluto" };

            //Step 3
            List<string> allPlanets = new List<string>();
            allPlanets = planetList.Concat(planetList2).ToList();
            Console.WriteLine("Title - allPlanets list after we added them");
            allPlanets.ForEach(item => Console.WriteLine(item));

            //Second Way
            Console.WriteLine("Another way to add them together");
            planetList.AddRange(planetList2);
            planetList.ForEach(thing => Console.WriteLine(thing));

            //Step 4
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Insert(6, "Uranus");
            Console.WriteLine("After adding earth and Venus");
            planetList.ForEach(thing => Console.WriteLine(thing));

            //Step 5
            Console.WriteLine("Rocky Planets");
            List<string> rockyPlanets = planetList.GetRange(0, 4);
            rockyPlanets.ForEach(p => Console.WriteLine(p));


            //Random Numbers

            Random random = new Random();

            List<int> numbers = new List<int>
            {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };

            foreach(int x in numbers)
            {
                Console.WriteLine(x + " is the random number generated");
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers.Contains(i))
                {
                    Console.WriteLine($"{i} is in the list");
                }
                else
                {
                    Console.WriteLine($"{i} is not in the list");
                }
            }
        }
    }
}
