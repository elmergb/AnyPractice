using System;

namespace SimpleSystem
{

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }

    
    class StudentCrud
    {
        static void Main(string[] args)
        {
            #region simple List practice 
            //Boolean isRunning = true;
            //List<Student> students = new List<Student>();
            //while (isRunning) { 
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //    if (name.ToLower() == "1")
            //    {
            //        foreach (var student in students)
            //        {
            //            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
            //        }
            //    }
            //Console.Write("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //students.Add(new Student
            //{
            //    Name = name,
            //    Age = age
            //});


            //}
            #endregion

            var countries = new[] { "Philippines", "USA", "Japan", "Singapore" };


            IEnumerable<string> nameCount = countries;
            IList<Countries> country = new List<Countries>();
            IList<Student> students = new List<Student>();
            Boolean isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("===========Book your flight============");
                Console.WriteLine("1. Add Country");
                Console.WriteLine("2. Show all student their flight");
                Console.WriteLine("3. Add Student flight");
                Console.WriteLine("4. Show all country");
                Console.WriteLine("5. Exit");
                Console.Write("Select: ");
                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        Console.WriteLine("===========Add Country============");

                        Console.Write("Enter name country: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter name price: ");
                        decimal price = Convert.ToDecimal(Console.ReadLine());

                        country.Add(new Countries
                        {
                            CountiresName = name,
                            price = price
                        });

                        break;
                    case 2:
                        Console.WriteLine("===========Prices============");
                        int count = 1;

                        foreach (Countries i in country)
                        {
                            count++;
                            Console.WriteLine($"{count}.{i.CountiresName} \nPrice:{i.price}");
                        }
                        break;
                        //for (int i = 0; i < country.Count; i++)
                        //{
                        //    Console.WriteLine($"{i + 1} : {country[i]}");
                        //}

                        //break;

                }
            }
        }
    }
}