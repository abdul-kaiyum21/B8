using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "";
            string Contact = "";
            string Address = "";
            int Age;

            Console.WriteLine("What is your Name ?");
            Name = Console.ReadLine();
            Console.WriteLine("How old are you ? ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's your Mobile No ?");
            Contact = Console.ReadLine();
            Console.WriteLine("Enter your Address ?");
            Address = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("I am : " + Name);
            Console.WriteLine("I am   : " + Age);
            Console.WriteLine("My contact number is: " + Contact);
            Console.WriteLine("and\nMy Address is: " + Address);

            Console.ReadLine();








        }
    }
}
