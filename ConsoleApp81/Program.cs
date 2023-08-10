using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp81
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("enter a number:");

            int num1 = int.Parse(Console.ReadLine());

            Console.Write("enter anothernumber");

            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(num1 / num2);

            Console.ReadLine();
        }
    }
}
