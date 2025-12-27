using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceConsole
{
   class InfoStudent
    {
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value < 0)
                  Console.WriteLine("Age cannot be negative");
                    _age = value;
               
             
            }

            
        }
    
    }
}
