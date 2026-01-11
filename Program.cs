using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStruct
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var elmer = new Person()
            {
                FirstName = "Elmer",
                LastName = "Abrea",
                Nickname = "Ako lang malakas",
                MyMoney = 10
            };

            Console.WriteLine($@"{elmer.FullName}
                                 Nickname:{elmer.Nickname} {elmer.MyMoney}");
        }
    }
}