using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CustomException :Exception
    {
        public CustomException(string message) : base (message)
        {
            Console.WriteLine("Changes");
            Console.WriteLine("2nd line added");
        }
    }
}
