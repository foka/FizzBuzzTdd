using System;
using System.Collections.Generic;
using System.Linq;

namespace FuzzBazzApp
{
    class FizzBuzzBootstrapper
    {
        static void Main()
        {
            var fizzBuzzItems = GetFizzBuzzItems();
            var fizzBuzzText = string.Join(' ', fizzBuzzItems);
            Console.Write(fizzBuzzText);
        }

        private static IEnumerable<string> GetFizzBuzzItems()
        {
            return Enumerable.Range(1, 100)
                .Select(i =>
                {
                    if (i % 15 == 0) return "FizzBuzz";
                    if (i % 3 == 0) return "Fizz";
                    if (i % 5 == 0) return "Buzz";

                    return i.ToString();
                });
        }
    }
}
