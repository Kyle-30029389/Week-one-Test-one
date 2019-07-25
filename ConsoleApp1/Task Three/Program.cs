using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number one");
            int one = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter number two");
            int two = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter decimal one");
            double DecOne = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter decimal two");
            double DecTwo = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter String one");
            string StrOne = Console.ReadLine();

            Console.WriteLine("Please enter String two");
            string StrTwo = Console.ReadLine();

            Console.WriteLine($"Number One: {one}\nNumber Two: {two}\nDecimal One: {DecOne}\nDecimal Two: {DecTwo}\nString One: {StrOne}\nString Two: {StrTwo}");
            Console.ReadLine();
        }
    }
}
