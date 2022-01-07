using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first name: ");
            string fname = Console.ReadLine();

            Console.Write("Enter last name: ");
            string lname = Console.ReadLine();

            Console.Write("Enter email id: ");
            string email = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("FIRST NAME IS: "+fname);
            Console.WriteLine("LAST NAME IS: "+lname);
            Console.WriteLine("EMAIL ID IS: "+email);


            Console.ReadKey();
        }
    }
}
