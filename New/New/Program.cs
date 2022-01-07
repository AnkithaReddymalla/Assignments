using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace New
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("enter the third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            int result = num1 * num2 * num3;
            Console.WriteLine("multiply {0} with {1} and {2} we will get output as {3}",num1,num2,num3,result);
            Console.ReadKey();





        }
    }
}

