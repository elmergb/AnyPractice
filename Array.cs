using System;

namespace pracArrayEnum
{
    internal class Program
    {
        static void Main(string[] args) {
            #region --one dimensional array
            //Console.WriteLine("Hello, World");
            Console.WriteLine("Origilnal: ");
            string[] names = {"Elmer", "Heather","Ymir" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            names[1] = "Savanah";
            foreach (string name in names)
            {
                Console.WriteLine("Modified: " + name);
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Using for loop: " + names[i] );
            }
            #endregion

            #region --multi dimensional array
            //var cells = new int[3][]
            //{
            //   new [] {1,2,3 },
            //   new[] { 4,5,6},
            //   new [] {7,8,9 }
            //};

            //for (int row = 0; row < cells.Length; row++)
            //{
            //    Console.WriteLine("Row: " + row);

            //    foreach (var i in cells[row])
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region IEnumerable, Collection and List
            Console.WriteLine("===========IEnumerable===========");
            var city = new[] {"Quezon City", "Bulacan", "Manila", "Cavite"};

            IEnumerable<string> enumrableCity = city;

            foreach (string i in city)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(city[0]);
            Console.WriteLine("===========Collection===========");
            ICollection<string> colCountries = new List<string>(city);
            colCountries.Add("Laguna");
            colCountries.Remove("Manila");
            colCountries.Remove(city[0]);

            foreach (string i in colCountries)
            {
                Console.WriteLine(i); 
            }

            Console.WriteLine("===========List===========");


            #endregion
        }
    }
}