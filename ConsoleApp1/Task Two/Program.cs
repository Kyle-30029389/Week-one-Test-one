using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your Age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your Address?");
            string address = Console.ReadLine();

            Console.WriteLine("What is your Email ?");
            string email = Console.ReadLine();

            Console.WriteLine("Please enter a 4 digit number");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}\nAge: {age}\nAdress: {address}\nEmail : {email}\nNumber: {number}");
            Console.ReadLine();
        }
    }
}
