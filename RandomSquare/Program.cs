using System;
using System.Collections.Generic;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var randomList = new List<int>();

            for (int i = 0; i <= 19; i++)
            {
                randomList.Add(random.Next(1, 50));
            }
            var outputList = new List<int>();
            foreach (var item in randomList)
            {
                var squared = item * item;
                outputList.Add(squared);
            }
            outputList.RemoveAll((i) => i % 2 != 0);
            foreach (var item in outputList)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
