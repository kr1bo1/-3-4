using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Практика_3__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 func = new Class1();

            func.Job("CHPK");
            Console.WriteLine($"\r");
            func.salary(1000, 30);
            Console.WriteLine($"\r\nin 10 years you will be: {func.Age(18)}");
            Console.WriteLine($"\r\nyour balance: {func.Balance(12278.299, 1500)}");
            Console.WriteLine($"\r");
            Console.WriteLine(func.GetGreeting("Kristina"));
        }
    }
}
