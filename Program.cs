using System;
using System.Diagnostics.Metrics;
using System.Linq;

namespace LinqLamda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var countries = new[] {"Philippines", "USA", "Japan", "Singapore" };

            var linqResult = from country in countries where country.Contains("P")  select country;
            foreach (string country in linqResult)
            {
                Console.WriteLine(country);
            } 

        }
    }
}
