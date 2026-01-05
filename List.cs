using System;

namespace SimpleSystem
{

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
    }

    class Countries
    {
        public string CountiresName { get; set; }
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

            var countries = new[] {"Philippines", "USA", "Japan", "Singapore" };
            
            IEnumerable<string> nameCount = countries;
            IList<Countries> country = new List<Countries>();
            IList<Student> students = new List<Student>();
            Boolean isRunning = true;   

            Console.WriteLine("===========Book your flight============");
            Console.WriteLine("1. Show all Country");
            Console.WriteLine("2. Show all student their flight");
            Console.WriteLine("3. Add Student flight");
            Console.WriteLine("4. Exit");
            Console.Write("Select: ");
            int select = Convert.ToInt32(Console.ReadLine());

            switch (select)
            {
                case 1:
                    //int count = 1;

                    //foreach (string country in countries)
                    //{
                    //    Console.WriteLine($"{count} : {country}");
                    //    count++;
                    //}

                    for (int i = 0; i < countries.Length; i++)
                    {
                        Console.WriteLine($"{i + 1} : {countries[i]}" );
                    }
                    break;
                case 2:

                    break;

            }
        }
    }
}