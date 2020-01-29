using System;
using System.Collections.Generic;

namespace Chapter4Practice
{
    public class Program
    {
        public static void Main()
        {
            List<string> planetList = new List<string>()
            {
                "Mercury", "Mars"
            };


            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 4);

            planetList.Remove("Pluto");

            Console.WriteLine("Original Planet List");
            foreach (string i in planetList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Rocky Planet List");
            foreach (string i in rockyPlanets)
            {
                Console.WriteLine(i);
            }

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

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(i);
            }
        
        }


    }
}
