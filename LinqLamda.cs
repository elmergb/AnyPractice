using System;
using System.Diagnostics.Metrics;
using System.Linq;

namespace LinqLamda
{
    internal class Program
    {
        class Item
        {
            public int item { get; set; }
            public string price { get; set; }
        }
        static void Main(string[] args)
        {
            #region practice Linq
            //    var countries = new[] {"Philippines", "USA", "Japan", "Singapore" };
            //    var expense = new [] { 100, 200, 300, 400, 500, 600 };

            //    var linqResult = from country in countries where country.Contains("P")  select country;
            //    foreach (string country in linqResult)
            //    {
            //        Console.WriteLine(country);
            //    } 

            //    var lingExpense = from exp in expense where exp >= 500 select  exp;
            //    int count = 0;
            //    foreach (var exp in lingExpense)
            //    {
            //      count++;
            //      Console.WriteLine(count + "." + exp);
            //    }

            #endregion

            ICollection<Item> item = new List<Item>();

            Console.WriteLine("=========Sele");
        }
    }
}
