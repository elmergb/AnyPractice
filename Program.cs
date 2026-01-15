using System;

public static class Hello
{
   
    public static string Upper(this string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return s;
        }

        return char.ToUpper(s[0]) + s.Substring(s[1]);
    }

}
public class Program
{
    public static void Main(String[] args)
    {
        int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        List<string> students = ["elmer", "heather", "savanah" ];

        var num = String.Join(",", number); 

        foreach (var student in students)
        {
            Console.WriteLine($@"Name: {student.Upper}");
        }

        Console.WriteLine(num);
        foreach (var r in num)
        {
            Console.Write(r);
        }
        //string songLyrics = "You say goodbye, and I say hello";
        //Console.WriteLine(songLyrics.Contains("goodbye"));
        //Console.WriteLine(songLyrics.Contains("greetings"));
        string sayHello = "Hello World!";
        Console.WriteLine(sayHello);
        sayHello = sayHello.Replace("World!", "Greetings");
        Console.WriteLine(sayHello);
        Console.WriteLine($"{number[2]}");
        Console.WriteLine("----------");
        string songLyrics = "You say goodbye, and I say hello";
        Console.WriteLine(songLyrics.StartsWith("You"));
        Console.WriteLine(songLyrics.StartsWith("goodbye"));

        Console.WriteLine(songLyrics.EndsWith("hello"));
        Console.WriteLine(songLyrics.EndsWith("goodbye"));

        if (songLyrics.StartsWith("Y"))
        {
            Console.WriteLine("Yes");
        } else
        {
            Console.WriteLine("hINDI E");
        }
    }


}