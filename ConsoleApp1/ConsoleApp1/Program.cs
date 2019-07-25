using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("What is your last name");
            string LastName = Console.ReadLine();

            Console.WriteLine("Your name is " + FirstName + " " + LastName);
            Console.WriteLine("Your name is {0} {1}", FirstName, LastName);
            Console.WriteLine($"Your name is {FirstName} {LastName}");
            Console.ReadLine();



        }
    }
}
