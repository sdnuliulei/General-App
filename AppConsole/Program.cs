using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralApp.Infrastructure.Helper;

namespace AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerHelper.WriteToFile("this is my firstLog","test.txt");
            Console.ReadKey();
        }
    }
}
