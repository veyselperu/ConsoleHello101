using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHello
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            Console.WriteLine($"What\'s your name?");
            name = Console.ReadLine();

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"Hello {name}");
            }
            Console.ReadLine();
        }
    }
}