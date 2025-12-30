// See https://aka.ms/new-console-template for more information
using practiceConsole;

class StudentService
{
    public string getStudentInfo(string name, int age)
    {
       return $"Name: {name}\n Age: {age}";
    }

    public string getStudentStatus(int status)
    {
        return status >= 18 ? "Adult" : "Minor";
    }

    public double studentGrades(double prelim, double midterm, double final)
    {
      return (prelim + midterm + final) /3;
    }

    public string studentAverage(double average)
    {
        return average >= 75 ? "Passed" : "Failed";
    }
    static void Main(string[] args)
    {
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

        string age = "33";
        
        if (int.TryParse(age, out int result))
        {
            Console.WriteLine($"Your age is {age}");
        }
        else
        {
            Console.WriteLine($"you can't tryparse this value {age}");
        }


        #endregion  


    }
}