// See https://aka.ms/new-console-template for more information
using practiceConsole;
using System;
using practiceConsole.Entity;

class StudentService
{
    #region -- Methods
    //public string getStudentInfo(string name, int age)
    //{
    //    return $"Name: {name}\n Age: {age}";
    //}

    //public string getStudentStatus(int status)
    //{
    //    return status >= 18 ? "Adult" : "Minor";
    //}

    //public double studentGrades(double prelim, double midterm, double final)
    //{
    //    return (prelim + midterm + final) / 3;
    //}

    //public string studentAverage(double average)
    //{
    //    return average >= 75 ? "Passed" : "Failed";
    //}
    #endregion
    static void Main(string[] args)
    {
        #region --practice area
        //StudentService student1 = new StudentService();
        //StudentService student2 = new StudentService();

        //string name1 = student1.getStudentInfo("Elmer", 19);
        //string checkers = student1.getStudentStatus(19);
        //double grades1 = student1.studentGrades(90, 98, 94);
        //string average1 = student1.studentAverage(grades1); 
        //Console.WriteLine($"{name1}\n {checkers} \n {grades1} {average1}");

        //InfoStudent stud = new InfoStudent();

        //stud.Age = -2;
        //int myAge = stud.Age;

        //Console.WriteLine(myAge);
        #endregion

        #region -- practice
        //object letter = 21;
        //if (letter is string s) Console.WriteLine($"The letter is {s}");
        //else Console.WriteLine("Not a string");
        #endregion
        #region -- parse
        //string num1 = "200";
        //int num2 = Convert.ToInt32(num1);
        ////var num2 = int.Parse(num1);
        //int result = num2 + 300;
        //Console.WriteLine($"the result is: {result} ");

        //string age = "eea";

        //if (int.TryParse(age, out int result))
        //{
        //    Console.WriteLine($"Your age is {result}");
        //}
        //else
        //{
        //    Console.WriteLine($"you can't try parse this value {age}");
        //}


        #endregion
        #region --readline 
        //Console.Write("Enter your name: ");
        //string name = Console.ReadLine();

        //Console.Write("Enter your age: ");
        //int age = Convert.ToInt32(Console.ReadLine());

        //if (age <= 0)
        //{
        //    Console.WriteLine($"Invalid. age must be higher than 0 ");

        //} 
        //    else if (name == "")
        //{
        //    Console.WriteLine("Please enter your name");
        //}
        //else
        //{
        //    Console.WriteLine($"Welcome {name}, your age is {age}");

        //}


        //Console.Write("Enter your name: ");
        //string name = Console.ReadLine();

        //Console.Write("Enter your age: ");
        //string age = Console.ReadLine();

        //if (int.TryParse(age, out int ageParse ) ){
        //    Console.WriteLine($"Welcome {name}, your age is {ageParse}");

        //} else
        //{
        //    Console.WriteLine($"Your age cannot parse");
        //}
        #endregion

        bool isRunning = true;

        while (isRunning == true) {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            var entity = new Student();
            entity.DisplayInfo();
            entity.addNum(num1, num2);
            Console.WriteLine($"The sum is: {entity.addNum(num1, num2)}");
            //isRunning = false;
        }
    }
}