using System;
using System.Collections.Generic;
using System.IO;

namespace AssignmentOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruitArray =
            {
                "melon",
                "apple",
                "guava",
                "apricot",
                "banana",
                "grape",
                "avocado" 
            };

            string[] fruitFilter = FilterFruitStartingWithA(fruitArray);

            Console.WriteLine("Fruits that start with the letter 'a'");

            foreach (string item in fruitFilter)

            {
                Console.WriteLine(item);
            }


            Console.ReadKey();

        }

        static string[] FilterFruitStartingWithA(string[] fruit)
        {
            string[] filteredArray= new string[fruit.Length];
            int index= 0;

            foreach (string item in fruit)
            {
                if (item.StartsWith("a", StringComparison.OrdinalIgnoreCase)) filteredArray[index++] = item;
            }

          return filteredArray;

        }
    }

}