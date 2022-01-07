using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsOnStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Input String: ");
            string input = Console.ReadLine();

            //Hands On 1
            //CountOfEachCharacter obj1 = new CountOfEachCharacter();
            //obj1.Count(input);

            //Hands On 2
            //ReverseAString obj2 = new ReverseAString();
            //Console.WriteLine("After Reversing: "+obj2.Reverse(input));

            //Hands On 3
            ReverseWordsInString obj3 = new ReverseWordsInString();
            obj3.ReverseWords(input);
            Console.ReadKey();
        }
    }
}
